namespace AgtGit
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.mChkRun = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTxtMonDirPath = new System.Windows.Forms.TextBox();
            this.mBtnSelectMonDir = new System.Windows.Forms.Button();
            this.mLstMessage = new System.Windows.Forms.ListBox();
            this.mTxtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mFileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // mFileSystemWatcher
            // 
            this.mFileSystemWatcher.EnableRaisingEvents = true;
            this.mFileSystemWatcher.IncludeSubdirectories = true;
            this.mFileSystemWatcher.SynchronizingObject = this;
            // 
            // mChkRun
            // 
            this.mChkRun.Appearance = System.Windows.Forms.Appearance.Button;
            this.mChkRun.AutoSize = true;
            this.mChkRun.Location = new System.Drawing.Point(8, 8);
            this.mChkRun.Margin = new System.Windows.Forms.Padding(2);
            this.mChkRun.Name = "mChkRun";
            this.mChkRun.Size = new System.Drawing.Size(64, 30);
            this.mChkRun.TabIndex = 3;
            this.mChkRun.Text = "停止中";
            this.mChkRun.UseVisualStyleBackColor = true;
            this.mChkRun.Click += new System.EventHandler(this.mChkRun_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "対象ディレクトリ";
            // 
            // mTxtMonDirPath
            // 
            this.mTxtMonDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtMonDirPath.Location = new System.Drawing.Point(115, 56);
            this.mTxtMonDirPath.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtMonDirPath.Name = "mTxtMonDirPath";
            this.mTxtMonDirPath.Size = new System.Drawing.Size(411, 27);
            this.mTxtMonDirPath.TabIndex = 5;
            // 
            // mBtnSelectMonDir
            // 
            this.mBtnSelectMonDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnSelectMonDir.Location = new System.Drawing.Point(438, 83);
            this.mBtnSelectMonDir.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnSelectMonDir.Name = "mBtnSelectMonDir";
            this.mBtnSelectMonDir.Size = new System.Drawing.Size(87, 27);
            this.mBtnSelectMonDir.TabIndex = 6;
            this.mBtnSelectMonDir.Text = "・・・";
            this.mBtnSelectMonDir.UseVisualStyleBackColor = true;
            this.mBtnSelectMonDir.Click += new System.EventHandler(this.mBtnSelectMonDir_Click);
            // 
            // mLstMessage
            // 
            this.mLstMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLstMessage.FormattingEnabled = true;
            this.mLstMessage.ItemHeight = 20;
            this.mLstMessage.Location = new System.Drawing.Point(8, 117);
            this.mLstMessage.Margin = new System.Windows.Forms.Padding(2);
            this.mLstMessage.Name = "mLstMessage";
            this.mLstMessage.Size = new System.Drawing.Size(519, 164);
            this.mLstMessage.TabIndex = 7;
            // 
            // mTxtAuthor
            // 
            this.mTxtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtAuthor.Location = new System.Drawing.Point(263, 11);
            this.mTxtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtAuthor.Name = "mTxtAuthor";
            this.mTxtAuthor.Size = new System.Drawing.Size(259, 27);
            this.mTxtAuthor.TabIndex = 9;
            this.mTxtAuthor.TextChanged += new System.EventHandler(this.mTxtAuthor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.mTxtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mLstMessage);
            this.Controls.Add(this.mBtnSelectMonDir);
            this.Controls.Add(this.mTxtMonDirPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mChkRun);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "AgtGit";
            ((System.ComponentModel.ISupportInitialize)(this.mFileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher mFileSystemWatcher;
        private CheckBox mChkRun;
        private Button mBtnSelectMonDir;
        private TextBox mTxtMonDirPath;
        private Label label1;
        private ListBox mLstMessage;
        private TextBox mTxtAuthor;
        private Label label2;
    }
}