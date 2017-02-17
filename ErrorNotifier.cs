using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSync {
   public partial class ErrorNotifier : Form {

      public enum drResult { OK, RENAME, CANCEL };
      public static drResult EResult = drResult.OK;
      public static string NewName  { get; set; }

      public ErrorNotifier () {
         InitializeComponent ();
         this.FormClosing += ErrorNotifier_FormClosing;
      }

      void ErrorNotifier_FormClosing (object sender, FormClosingEventArgs e) {
         //EResult = drResult.OK;
      }

      public void SetSourcePath (string path) {
         mLblSrcPath.Text = path;
      }

      public void SetDestPath (string path) {
         mLblDestPath.Text = path;
      }

      public void SetErrorMsg (string msg) {
         mLblError.Text = msg;
      }

      public void SetRenameText( string newName, string ext) {
         NewName = mLblRenameText.Text = (newName + "_" + DateTime.Today.Day + DateTime.Today.Month.ToString("00") + DateTime.Today.Year + ext);
      }

      private void mBtnSkip_Click (object sender, EventArgs e) {
         EResult = drResult.OK;
         this.Close ();
      }

      private void mBtnCancel_Click (object sender, EventArgs e) {
         EResult = drResult.CANCEL;
         this.Close ();
      }

      private void mBtnRename_Click (object sender, EventArgs e) {
         EResult = drResult.RENAME;
         this.Close ();
      }

   }
}
