namespace FileSync {
   partial class fileSync {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose (bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose ();
         }
         base.Dispose (disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent () {
         this.mLblSrc = new System.Windows.Forms.Label();
         this.mLblDest = new System.Windows.Forms.Label();
         this.mTxtSrc = new System.Windows.Forms.TextBox();
         this.mTxtDest = new System.Windows.Forms.TextBox();
         this.mBtnSrc = new System.Windows.Forms.Button();
         this.mBtnDest = new System.Windows.Forms.Button();
         this.mChkReplace = new System.Windows.Forms.CheckBox();
         this.mBtnSync = new System.Windows.Forms.Button();
         this.mBtnClose = new System.Windows.Forms.Button();
         this.mBtnGenInfo = new System.Windows.Forms.Button();
         this.mTxtCompare = new System.Windows.Forms.TextBox();
         this.mChkCompare = new System.Windows.Forms.CheckBox();
         this.mBtnCompare = new System.Windows.Forms.Button();
         this.mLblCopying = new System.Windows.Forms.Label();
         this.mLblCopyingText = new System.Windows.Forms.Label();
         this.mBtnCopyStop = new System.Windows.Forms.Button();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.SuspendLayout();
         // 
         // mLblSrc
         // 
         this.mLblSrc.AutoSize = true;
         this.mLblSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblSrc.Location = new System.Drawing.Point(75, 39);
         this.mLblSrc.Name = "mLblSrc";
         this.mLblSrc.Size = new System.Drawing.Size(92, 25);
         this.mLblSrc.TabIndex = 0;
         this.mLblSrc.Text = "Source: ";
         // 
         // mLblDest
         // 
         this.mLblDest.AutoSize = true;
         this.mLblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblDest.Location = new System.Drawing.Point(35, 78);
         this.mLblDest.Name = "mLblDest";
         this.mLblDest.Size = new System.Drawing.Size(132, 25);
         this.mLblDest.TabIndex = 1;
         this.mLblDest.Text = "Destination: ";
         // 
         // mTxtSrc
         // 
         this.mTxtSrc.Enabled = false;
         this.mTxtSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mTxtSrc.Location = new System.Drawing.Point(170, 39);
         this.mTxtSrc.Name = "mTxtSrc";
         this.mTxtSrc.Size = new System.Drawing.Size(399, 26);
         this.mTxtSrc.TabIndex = 2;
         // 
         // mTxtDest
         // 
         this.mTxtDest.Enabled = false;
         this.mTxtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mTxtDest.Location = new System.Drawing.Point(170, 78);
         this.mTxtDest.Name = "mTxtDest";
         this.mTxtDest.Size = new System.Drawing.Size(399, 26);
         this.mTxtDest.TabIndex = 3;
         // 
         // mBtnSrc
         // 
         this.mBtnSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnSrc.Location = new System.Drawing.Point(588, 39);
         this.mBtnSrc.Name = "mBtnSrc";
         this.mBtnSrc.Size = new System.Drawing.Size(36, 26);
         this.mBtnSrc.TabIndex = 4;
         this.mBtnSrc.Text = "...";
         this.mBtnSrc.UseVisualStyleBackColor = true;
         this.mBtnSrc.Click += new System.EventHandler(this.mBtnSrc_Click);
         // 
         // mBtnDest
         // 
         this.mBtnDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnDest.Location = new System.Drawing.Point(588, 78);
         this.mBtnDest.Name = "mBtnDest";
         this.mBtnDest.Size = new System.Drawing.Size(36, 26);
         this.mBtnDest.TabIndex = 5;
         this.mBtnDest.Text = "...";
         this.mBtnDest.UseVisualStyleBackColor = true;
         this.mBtnDest.Click += new System.EventHandler(this.mBtnDest_Click);
         // 
         // mChkReplace
         // 
         this.mChkReplace.AutoSize = true;
         this.mChkReplace.Location = new System.Drawing.Point(170, 181);
         this.mChkReplace.Name = "mChkReplace";
         this.mChkReplace.Size = new System.Drawing.Size(183, 17);
         this.mChkReplace.TabIndex = 6;
         this.mChkReplace.Text = "Overwrite files with newer version";
         this.mChkReplace.UseVisualStyleBackColor = true;
         this.mChkReplace.CheckedChanged += new System.EventHandler(this.mChkReplace_CheckedChanged);
         // 
         // mBtnSync
         // 
         this.mBtnSync.Location = new System.Drawing.Point(205, 305);
         this.mBtnSync.Name = "mBtnSync";
         this.mBtnSync.Size = new System.Drawing.Size(75, 23);
         this.mBtnSync.TabIndex = 7;
         this.mBtnSync.Text = "Sync";
         this.mBtnSync.UseVisualStyleBackColor = true;
         this.mBtnSync.Click += new System.EventHandler(this.mBtnSync_Click);
         // 
         // mBtnClose
         // 
         this.mBtnClose.Location = new System.Drawing.Point(348, 305);
         this.mBtnClose.Name = "mBtnClose";
         this.mBtnClose.Size = new System.Drawing.Size(75, 23);
         this.mBtnClose.TabIndex = 8;
         this.mBtnClose.Text = "Close";
         this.mBtnClose.UseVisualStyleBackColor = true;
         this.mBtnClose.Click += new System.EventHandler(this.mBtnClose_Click);
         // 
         // mBtnGenInfo
         // 
         this.mBtnGenInfo.Location = new System.Drawing.Point(649, 39);
         this.mBtnGenInfo.Name = "mBtnGenInfo";
         this.mBtnGenInfo.Size = new System.Drawing.Size(102, 23);
         this.mBtnGenInfo.TabIndex = 9;
         this.mBtnGenInfo.Text = "Generate File Info";
         this.mBtnGenInfo.UseVisualStyleBackColor = true;
         this.mBtnGenInfo.Click += new System.EventHandler(this.mBtnGenInfo_Click);
         // 
         // mTxtCompare
         // 
         this.mTxtCompare.Enabled = false;
         this.mTxtCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mTxtCompare.Location = new System.Drawing.Point(269, 119);
         this.mTxtCompare.Name = "mTxtCompare";
         this.mTxtCompare.Size = new System.Drawing.Size(300, 26);
         this.mTxtCompare.TabIndex = 10;
         // 
         // mChkCompare
         // 
         this.mChkCompare.AutoSize = true;
         this.mChkCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mChkCompare.Location = new System.Drawing.Point(170, 119);
         this.mChkCompare.Name = "mChkCompare";
         this.mChkCompare.Size = new System.Drawing.Size(93, 24);
         this.mChkCompare.TabIndex = 12;
         this.mChkCompare.Text = "Compare";
         this.mChkCompare.UseVisualStyleBackColor = true;
         this.mChkCompare.CheckedChanged += new System.EventHandler(this.mChkCompare_CheckedChanged);
         // 
         // mBtnCompare
         // 
         this.mBtnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnCompare.Location = new System.Drawing.Point(588, 119);
         this.mBtnCompare.Name = "mBtnCompare";
         this.mBtnCompare.Size = new System.Drawing.Size(36, 26);
         this.mBtnCompare.TabIndex = 13;
         this.mBtnCompare.Text = "...";
         this.mBtnCompare.UseVisualStyleBackColor = true;
         this.mBtnCompare.Click += new System.EventHandler(this.mBtnCompare_Click);
         // 
         // mLblCopying
         // 
         this.mLblCopying.AutoSize = true;
         this.mLblCopying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblCopying.Location = new System.Drawing.Point(167, 218);
         this.mLblCopying.Name = "mLblCopying";
         this.mLblCopying.Size = new System.Drawing.Size(66, 20);
         this.mLblCopying.TabIndex = 14;
         this.mLblCopying.Text = "Copying";
         // 
         // mLblCopyingText
         // 
         this.mLblCopyingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblCopyingText.Location = new System.Drawing.Point(265, 218);
         this.mLblCopyingText.Name = "mLblCopyingText";
         this.mLblCopyingText.Size = new System.Drawing.Size(359, 60);
         this.mLblCopyingText.TabIndex = 15;
         // 
         // mBtnCopyStop
         // 
         this.mBtnCopyStop.Location = new System.Drawing.Point(676, 215);
         this.mBtnCopyStop.Name = "mBtnCopyStop";
         this.mBtnCopyStop.Size = new System.Drawing.Size(75, 23);
         this.mBtnCopyStop.TabIndex = 16;
         this.mBtnCopyStop.Text = "Stop";
         this.mBtnCopyStop.UseVisualStyleBackColor = true;
         this.mBtnCopyStop.Click += new System.EventHandler(this.mBtnCopyStop_Click);
         // 
         // backgroundWorker1
         // 
         this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
         // 
         // fileSync
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(818, 354);
         this.Controls.Add(this.mBtnCopyStop);
         this.Controls.Add(this.mLblCopyingText);
         this.Controls.Add(this.mLblCopying);
         this.Controls.Add(this.mBtnCompare);
         this.Controls.Add(this.mChkCompare);
         this.Controls.Add(this.mTxtCompare);
         this.Controls.Add(this.mBtnGenInfo);
         this.Controls.Add(this.mBtnClose);
         this.Controls.Add(this.mBtnSync);
         this.Controls.Add(this.mChkReplace);
         this.Controls.Add(this.mBtnDest);
         this.Controls.Add(this.mBtnSrc);
         this.Controls.Add(this.mTxtDest);
         this.Controls.Add(this.mTxtSrc);
         this.Controls.Add(this.mLblDest);
         this.Controls.Add(this.mLblSrc);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "fileSync";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "File Sync";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label mLblSrc;
      private System.Windows.Forms.Label mLblDest;
      private System.Windows.Forms.TextBox mTxtSrc;
      private System.Windows.Forms.TextBox mTxtDest;
      private System.Windows.Forms.Button mBtnSrc;
      private System.Windows.Forms.Button mBtnDest;
      private System.Windows.Forms.CheckBox mChkReplace;
      private System.Windows.Forms.Button mBtnSync;
      private System.Windows.Forms.Button mBtnClose;
      private System.Windows.Forms.Button mBtnGenInfo;
      private System.Windows.Forms.TextBox mTxtCompare;
      private System.Windows.Forms.CheckBox mChkCompare;
      private System.Windows.Forms.Button mBtnCompare;
      private System.Windows.Forms.Label mLblCopying;
      private System.Windows.Forms.Label mLblCopyingText;
      private System.Windows.Forms.Button mBtnCopyStop;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
   }
}

