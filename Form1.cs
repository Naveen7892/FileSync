using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region References

// http://stackoverflow.com/questions/58744/best-way-to-copy-the-entire-contents-of-a-directory-in-c-sharp

#endregion References

namespace FileSync {
   /// <summary>
   /// File sync - a tool to copy files/folders
   /// </summary>
   public partial class fileSync : Form {

      #region Members

      Dictionary<String, DateTime> mDictOldBackup;
      FolderBrowserDialog mFbd;
      OpenFileDialog mOfd;
      StringBuilder mSbLog;
      ErrorNotifier mErrorForm;
      System.Timers.Timer mTimer;
      
      string sourceOriginal, destOriginal;
      bool isSuccess = false, isOverwritable = false, inProcess = false;
      uint count = 0;
      
      #endregion Members

      #region Constructor

      public fileSync () {
         InitializeComponent ();
         mFbd = new FolderBrowserDialog ();
         mFbd.SelectedPath = @"D:\TestFileSync";
         mSbLog = new StringBuilder ();
         mBtnCompare.Visible = mBtnCompare.Enabled = false;
         mBtnCopyStop.Visible = mLblCopyingText.Visible = mLblCopying.Visible = false;
         this.FormClosing += fileSync_FormClosing;
      }

      #endregion Constructor

      #region Events

      void fileSync_FormClosing (object sender, FormClosingEventArgs e) {
         if (inProcess) {
            e.Cancel = false;
         }
      }

      private void mBtnSrc_Click (object sender, EventArgs e) {
         mFbd.Description = "Choose source folder: ";
         mFbd.ShowNewFolderButton = false;

         DialogResult dlgResult = mFbd.ShowDialog ();
         if (dlgResult == DialogResult.OK) {
            mTxtSrc.Text = mFbd.SelectedPath;
         }
      }

      private void mBtnGenInfo_Click (object sender, EventArgs e) {
         if (string.IsNullOrEmpty (mTxtSrc.Text)) {
            MessageBox.Show ("Provide source path!");
            return;
         }
         sourceOriginal = mTxtSrc.Text;

         //generateInfo (sourceOriginal);
         GenerateInfo (sourceOriginal, "");
         count = 0;
         File.Delete ("oldBackup.csv");
         File.AppendAllText ("oldBackup.csv", mSbLog.ToString ());
         mSbLog.Clear ();
      }

      private void mBtnDest_Click (object sender, EventArgs e) {
         mFbd.Description = "Choose destination folder: ";
         mFbd.ShowNewFolderButton = true;

         DialogResult dlgResult = mFbd.ShowDialog ();
         if (dlgResult == DialogResult.OK) {
            mTxtDest.Text = mFbd.SelectedPath;
         }
      }

      private void mChkCompare_CheckedChanged (object sender, EventArgs e) {
         mBtnCompare.Visible = mBtnCompare.Enabled = mChkCompare.Checked;
      }

      private void mBtnCompare_Click (object sender, EventArgs e) {
         mOfd = new OpenFileDialog ();
         DialogResult fResult = mOfd.ShowDialog ();
         if (fResult == DialogResult.OK) {
            mTxtCompare.Text = mOfd.FileName;
            ConvertLogToDict (mTxtCompare.Text);
         }
      }

      private void mChkReplace_CheckedChanged (object sender, EventArgs e) {
         isOverwritable = mChkReplace.Checked;
      }

      private void mBtnSync_Click (object sender, EventArgs e) {
         if (string.IsNullOrEmpty (mTxtSrc.Text) || string.IsNullOrEmpty (mTxtSrc.Text)) {
            MessageBox.Show ("Please provide source and destination path!");
            return;
         }
         mTimer = new System.Timers.Timer ();
         mTimer.Enabled = true;
         mTimer.Interval = 1000;
         mTimer.Elapsed += t_Tick;
         mTimer.Start ();
         inProcess = true;
         mBtnCopyStop.Visible = mLblCopyingText.Visible = mLblCopying.Visible = true;
         //DisableTools ();

         sourceOriginal = mTxtSrc.Text;
         destOriginal = mTxtDest.Text;
         if (mChkCompare.Checked) {
            CopyModifiedDirectory (sourceOriginal, "");
            File.Delete ("NewBackup.csv");
            File.AppendAllText ("NewBackup.csv", mSbLog.ToString ());
         } else {
            CopyDirectory (mTxtSrc.Text, "");
         }
         mTimer.Dispose ();
         if (isSuccess)
            MessageBox.Show ("Success");
         else
            MessageBox.Show ("Failed");

         //EnableTools ();
         inProcess = false;
      }

      void t_Tick (object sender, EventArgs e) {
         if (mInTimer) return;
         mInTimer = true;
         Invoke (new Action (UpdateLabel));
         mInTimer = false;
      }

      bool mInTimer = false;

      void UpdateLabel () {
         if (mLblCopying.Text.EndsWith (" . . .")) {
            mLblCopying.Text = "Copying";
         } else {
            mLblCopying.Text = mLblCopying.Text + " .";
         }  
      }

      private void mBtnClose_Click (object sender, EventArgs e) {
         Environment.Exit (0);
      }

      #endregion Events

      #region Methods

      private void EnableTools () {
         for (int i = this.Controls.Count - 1; i >= 0; i--) {
            this.Controls[i].Enabled = true;
         }
      }

      private void DisableTools () {
         for (int i = this.Controls.Count - 1; i >= 0; i-- ) {
            if (Controls[i] is Button) {
               this.Controls[i].Enabled = false;
            }
         }
      }

      private void GenerateInfo (string path, string subPath) {
         DirectoryInfo diSource = new DirectoryInfo (Path.Combine (path, subPath));
         if (!String.IsNullOrEmpty (subPath)) {
            mSbLog.Append ((++count) + "," + subPath + "," + diSource.LastWriteTime + Environment.NewLine);
         }

         // Copy each file into the new directory.
         foreach (FileInfo fi in diSource.GetFiles ()) {
            mSbLog.Append ((++count) + "," + Path.Combine (subPath, fi.Name) + "," + fi.LastWriteTime + Environment.NewLine);
         }

         // Copy each subdirectory using recursion.
         foreach (DirectoryInfo diSourceSubDir in diSource.GetDirectories ()) {
            GenerateInfo (path, Path.Combine (subPath, diSourceSubDir.Name));
         }
      }

      private void CopyDirectory (string path, string subPath) {
         // Cancels copy by skipping all remaining items
         if (ErrorNotifier.EResult == ErrorNotifier.drResult.CANCEL) {
            return;
         }

         DirectoryInfo src = new DirectoryInfo (path);
         foreach (DirectoryInfo d in src.GetDirectories ()) {
            CopyDirectory (d.FullName, Path.Combine (subPath, d.Name));
         }

         DirectoryInfo dest = new DirectoryInfo (Path.Combine (destOriginal, subPath));
         if (!Directory.Exists (dest.FullName) && dest.GetDirectories().Count() != 0) {
            Directory.CreateDirectory (dest.FullName);
         }
         foreach (FileInfo f in src.GetFiles ()) {
            string destFile = Path.Combine (dest.FullName, f.Name);
            try {
               // Cancels copy by skipping all remaining items
               if (ErrorNotifier.EResult == ErrorNotifier.drResult.CANCEL) {
                  return;
               }

               if (!File.Exists (destFile)) {
                  //throw new Exception ();
                  mLblCopyingText.Text = f.FullName + "\n to \n" + destFile;
                  File.Copy (f.FullName, destFile, false);
                  File.SetLastWriteTime (destFile, DateTime.Now);
               } else {
                  if (isOverwritable && f.LastWriteTime != File.GetLastAccessTime(destFile)) {
                     //throw new Exception ();
                     mLblCopyingText.Text = f.FullName + "\n to \n" + destFile;
                     File.Copy (f.FullName, destFile, true);
                     File.SetLastWriteTime (destFile, DateTime.Now);
                  }
               }
            } catch (Exception e) {
               mErrorForm = new ErrorNotifier ();
               mErrorForm.SetSourcePath (f.FullName);
               mErrorForm.SetDestPath (destFile);
               mErrorForm.SetErrorMsg (e.StackTrace);
               mErrorForm.SetRenameText (Path.GetFileNameWithoutExtension(f.Name), f.Extension);
               mErrorForm.ShowDialog ();

               if (ErrorNotifier.EResult == ErrorNotifier.drResult.RENAME) {
                  destFile = Path.Combine (dest.FullName, ErrorNotifier.NewName);
                  File.Copy (f.FullName, destFile, true);
                  File.SetLastWriteTime (destFile, DateTime.Now);
               }

               Console.WriteLine ("ERROR: " + e.StackTrace);
               isSuccess = false;
            }
         }
         isSuccess = true;
      }

      private void ConvertLogToDict (string oldPath) {
         if (string.IsNullOrEmpty (mTxtCompare.Text)) {
            MessageBox.Show ("Provide file name to compare!");
            return;
         }

         mDictOldBackup = new Dictionary<string, DateTime> ();

         string[] inputs;
         foreach (string lines in File.ReadAllLines (mTxtCompare.Text)) {
            inputs = lines.Split (',');
            mDictOldBackup.Add (inputs[1], DateTime.Parse (inputs[2]));
         }

      }

      private void CopyModifiedDirectory (string path, string subPath) {
         DirectoryInfo diSource = new DirectoryInfo (Path.Combine (path, subPath));
         if (!String.IsNullOrEmpty (subPath)) {
            //sbLog.Append ((++count) + "," + Path.Combine (sourceOriginal, diSource.Name) + "," + diSource.LastWriteTime + Environment.NewLine);
            String newDir = Path.Combine (destOriginal, subPath);
            Directory.CreateDirectory (newDir);
            Directory.SetCreationTime (newDir, Directory.GetLastWriteTime(diSource.FullName));
            //Directory.SetLastWriteTime(newDir, DateTime.Now);
         }

         foreach (FileInfo f in diSource.GetFiles ()) {
            String destFile = Path.Combine (destOriginal, subPath, f.Name);
            try {
               if (!mDictOldBackup.ContainsKey (Path.Combine (subPath, f.Name))) {
                  //sbLog.Append ((++count) + "," + Path.Combine (fi.FullName) + "," + fi.LastWriteTime +  Environment.NewLine);
                  File.Copy (f.FullName, destFile, false);
                  //File.SetLastWriteTime (newFile, DateTime.Now);
               } else {
                  if (isOverwritable && f.LastWriteTime != File.GetLastAccessTime (destFile)) {
                     File.Copy (f.FullName, destFile, true);
                     //File.SetLastWriteTime (newFile, DateTime.Now);
                  }
               }
            } catch (Exception e) {
               mErrorForm = new ErrorNotifier ();
               mErrorForm.SetSourcePath (f.FullName);
               mErrorForm.SetDestPath (destFile);
               mErrorForm.SetErrorMsg (e.StackTrace);
               mErrorForm.SetRenameText (Path.GetFileNameWithoutExtension (f.Name), f.Extension);
               mErrorForm.ShowDialog ();

               if (ErrorNotifier.EResult == ErrorNotifier.drResult.RENAME) {
                  destFile = Path.Combine (destOriginal, ErrorNotifier.NewName);
                  File.Copy (f.FullName, destFile, true);
                  File.SetLastWriteTime (destFile, DateTime.Now);
               }

               Console.WriteLine ("ERROR: " + e.StackTrace);
               isSuccess = false;
            }
         }

         foreach (DirectoryInfo diSourceSubDir in diSource.GetDirectories ()) {
            CopyModifiedDirectory (path, Path.Combine (subPath, diSourceSubDir.Name));
         }

         isSuccess = true;
      }

      #endregion Methods

      private void mBtnCopyStop_Click (object sender, EventArgs e) {
         ErrorNotifier.EResult = ErrorNotifier.drResult.CANCEL;
      }

      private void backgroundWorker1_DoWork (object sender, DoWorkEventArgs e) {

      }
   }
}
