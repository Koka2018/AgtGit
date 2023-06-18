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
            mFileSystemWatcher = new FileSystemWatcher();
            mChkRun = new CheckBox();
            label1 = new Label();
            mTxtMonDirPath = new TextBox();
            mBtnSelectMonDir = new Button();
            mLstMessage = new ListBox();
            ((System.ComponentModel.ISupportInitialize)mFileSystemWatcher).BeginInit();
            SuspendLayout();
            // 
            // mFileSystemWatcher
            // 
            mFileSystemWatcher.EnableRaisingEvents = true;
            mFileSystemWatcher.IncludeSubdirectories = true;
            mFileSystemWatcher.SynchronizingObject = this;
            mFileSystemWatcher.Changed += mFileSystemWatcher_Changed;
            mFileSystemWatcher.Created += mFileSystemWatcher_Changed;
            mFileSystemWatcher.Deleted += mFileSystemWatcher_Changed;
            mFileSystemWatcher.Renamed += mFileSystemWatcher_Renamed;
            // 
            // mChkRun
            // 
            mChkRun.Appearance = Appearance.Button;
            mChkRun.AutoSize = true;
            mChkRun.Location = new Point(12, 12);
            mChkRun.Name = "mChkRun";
            mChkRun.Size = new Size(86, 40);
            mChkRun.TabIndex = 3;
            mChkRun.Text = "停止中";
            mChkRun.UseVisualStyleBackColor = true;
            mChkRun.CheckedChanged += mChkRun_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 4;
            label1.Text = "対象ディレクトリ";
            // 
            // mTxtMonDirPath
            // 
            mTxtMonDirPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mTxtMonDirPath.Location = new Point(161, 84);
            mTxtMonDirPath.Name = "mTxtMonDirPath";
            mTxtMonDirPath.Size = new Size(627, 35);
            mTxtMonDirPath.TabIndex = 5;
            // 
            // mBtnSelectMonDir
            // 
            mBtnSelectMonDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mBtnSelectMonDir.Location = new Point(657, 125);
            mBtnSelectMonDir.Name = "mBtnSelectMonDir";
            mBtnSelectMonDir.Size = new Size(131, 40);
            mBtnSelectMonDir.TabIndex = 6;
            mBtnSelectMonDir.Text = "・・・";
            mBtnSelectMonDir.UseVisualStyleBackColor = true;
            mBtnSelectMonDir.Click += mBtnSelectMonDir_Click;
            // 
            // mLstMessage
            // 
            mLstMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mLstMessage.FormattingEnabled = true;
            mLstMessage.ItemHeight = 30;
            mLstMessage.Location = new Point(12, 176);
            mLstMessage.Name = "mLstMessage";
            mLstMessage.Size = new Size(776, 244);
            mLstMessage.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mLstMessage);
            Controls.Add(mBtnSelectMonDir);
            Controls.Add(mTxtMonDirPath);
            Controls.Add(label1);
            Controls.Add(mChkRun);
            Name = "MainForm";
            Text = "AgtGit";
            Shown += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)mFileSystemWatcher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher mFileSystemWatcher;
        private CheckBox mChkRun;
        private Button mBtnSelectMonDir;
        private TextBox mTxtMonDirPath;
        private Label label1;
        private ListBox mLstMessage;
    }
}