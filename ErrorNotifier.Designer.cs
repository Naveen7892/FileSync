namespace FileSync {
   partial class ErrorNotifier {
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
         this.mLblSrcPath = new System.Windows.Forms.Label();
         this.mLblDestPath = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.mLblError = new System.Windows.Forms.Label();
         this.mBtnSkip = new System.Windows.Forms.Button();
         this.mBtnCancel = new System.Windows.Forms.Button();
         this.mLblRename = new System.Windows.Forms.Label();
         this.mLblRenameText = new System.Windows.Forms.Label();
         this.mBtnRename = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // mLblSrc
         // 
         this.mLblSrc.AutoSize = true;
         this.mLblSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblSrc.Location = new System.Drawing.Point(44, 47);
         this.mLblSrc.Name = "mLblSrc";
         this.mLblSrc.Size = new System.Drawing.Size(68, 20);
         this.mLblSrc.TabIndex = 0;
         this.mLblSrc.Text = "Source: ";
         // 
         // mLblDest
         // 
         this.mLblDest.AutoSize = true;
         this.mLblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblDest.Location = new System.Drawing.Point(14, 81);
         this.mLblDest.Name = "mLblDest";
         this.mLblDest.Size = new System.Drawing.Size(98, 20);
         this.mLblDest.TabIndex = 1;
         this.mLblDest.Text = "Destination: ";
         // 
         // mLblSrcPath
         // 
         this.mLblSrcPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblSrcPath.Location = new System.Drawing.Point(118, 47);
         this.mLblSrcPath.Name = "mLblSrcPath";
         this.mLblSrcPath.Size = new System.Drawing.Size(237, 20);
         this.mLblSrcPath.TabIndex = 2;
         // 
         // mLblDestPath
         // 
         this.mLblDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblDestPath.Location = new System.Drawing.Point(118, 81);
         this.mLblDestPath.Name = "mLblDestPath";
         this.mLblDestPath.Size = new System.Drawing.Size(237, 20);
         this.mLblDestPath.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(60, 113);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(52, 20);
         this.label1.TabIndex = 4;
         this.label1.Text = "Error: ";
         // 
         // mLblError
         // 
         this.mLblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblError.Location = new System.Drawing.Point(118, 113);
         this.mLblError.Name = "mLblError";
         this.mLblError.Size = new System.Drawing.Size(237, 82);
         this.mLblError.TabIndex = 5;
         // 
         // mBtnSkip
         // 
         this.mBtnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnSkip.Location = new System.Drawing.Point(211, 271);
         this.mBtnSkip.Name = "mBtnSkip";
         this.mBtnSkip.Size = new System.Drawing.Size(120, 27);
         this.mBtnSkip.TabIndex = 6;
         this.mBtnSkip.Text = "skip and continue";
         this.mBtnSkip.UseVisualStyleBackColor = true;
         this.mBtnSkip.Click += new System.EventHandler(this.mBtnSkip_Click);
         // 
         // mBtnCancel
         // 
         this.mBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnCancel.Location = new System.Drawing.Point(358, 271);
         this.mBtnCancel.Name = "mBtnCancel";
         this.mBtnCancel.Size = new System.Drawing.Size(110, 27);
         this.mBtnCancel.TabIndex = 7;
         this.mBtnCancel.Text = "cancel copy";
         this.mBtnCancel.UseVisualStyleBackColor = true;
         this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
         // 
         // mLblRename
         // 
         this.mLblRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblRename.Location = new System.Drawing.Point(14, 185);
         this.mLblRename.Name = "mLblRename";
         this.mLblRename.Size = new System.Drawing.Size(98, 43);
         this.mLblRename.TabIndex = 8;
         this.mLblRename.Text = "New name (if rename): ";
         // 
         // mLblRenameText
         // 
         this.mLblRenameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mLblRenameText.Location = new System.Drawing.Point(134, 195);
         this.mLblRenameText.Name = "mLblRenameText";
         this.mLblRenameText.Size = new System.Drawing.Size(237, 20);
         this.mLblRenameText.TabIndex = 9;
         // 
         // mBtnRename
         // 
         this.mBtnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mBtnRename.Location = new System.Drawing.Point(38, 271);
         this.mBtnRename.Name = "mBtnRename";
         this.mBtnRename.Size = new System.Drawing.Size(146, 27);
         this.mBtnRename.TabIndex = 10;
         this.mBtnRename.Text = "rename and continue";
         this.mBtnRename.UseVisualStyleBackColor = true;
         this.mBtnRename.Click += new System.EventHandler(this.mBtnRename_Click);
         // 
         // ErrorNotifier
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(502, 332);
         this.ControlBox = false;
         this.Controls.Add(this.mBtnRename);
         this.Controls.Add(this.mLblRenameText);
         this.Controls.Add(this.mLblRename);
         this.Controls.Add(this.mBtnCancel);
         this.Controls.Add(this.mBtnSkip);
         this.Controls.Add(this.mLblError);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.mLblDestPath);
         this.Controls.Add(this.mLblSrcPath);
         this.Controls.Add(this.mLblDest);
         this.Controls.Add(this.mLblSrc);
         this.Name = "ErrorNotifier";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ErrorNotifier";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label mLblSrc;
      private System.Windows.Forms.Label mLblDest;
      private System.Windows.Forms.Label mLblSrcPath;
      private System.Windows.Forms.Label mLblDestPath;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label mLblError;
      private System.Windows.Forms.Button mBtnSkip;
      private System.Windows.Forms.Button mBtnCancel;
      private System.Windows.Forms.Label mLblRename;
      private System.Windows.Forms.Label mLblRenameText;
      private System.Windows.Forms.Button mBtnRename;
   }
}