using System.IO;
using System.Diagnostics;
using AgtGit.Models.GitModel;
using LibGit2Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AgtGit
{
    public partial class MainForm : Form
    {
        private GitManager mRepository;
        private bool mIsWaitForChanged = false;
        private DateTime mLastChangedTime = DateTime.Now;
        private List<WatcherChangeTypes> mChangeTypeList = new List<WatcherChangeTypes>();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
#if TBD
                TestFunc();
                Close();
#else
                //StartMonitor();
#endif
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void mFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.FullPath.StartsWith(GitManager.GitDirPath(mFileSystemWatcher.Path))) { return; }
            await CommitChanges(e.ChangeType);
        }

        private async void mFileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (e.FullPath.StartsWith(GitManager.GitDirPath(mFileSystemWatcher.Path))) { return; }
            await CommitChanges(e.ChangeType);
        }

        private void mChkRun_CheckedChanged(object? sender, EventArgs? e)
        {
            try
            {
                if (mChkRun.Checked == true // 実行中に遷移した場合
                    && IsMonitorEnable() == false) // モニタ実行可否を判定
                {
                    SetMessage("モニタを開始する条件が整っていません。");
                    mChkRun.Checked = false;
                    return;
                }

                SetupGitRepository();

                mChkRun.Text = (mChkRun.Checked) ? "実行中" : "停止中";
                mFileSystemWatcher.EnableRaisingEvents = mChkRun.Checked;
                SetMessage(mChkRun.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mBtnSelectMonDir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dlg = new FolderBrowserDialog())
                {
                    if (dlg.ShowDialog() != DialogResult.OK) { return; }
                    mTxtMonDirPath.Text = dlg.SelectedPath;
                    mFileSystemWatcher.Path = dlg.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Method

        private void TestFunc()
        {
            var dirPath = Path.Combine(".", "Repo");

            // Initialize directory .
            if (Directory.Exists(dirPath)) { Directory.Delete(dirPath, true); }
            Directory.CreateDirectory(dirPath);

            // Create repository .
            var repo = Models.GitModel.GitManager.CreateRepository(dirPath);

            // Commit file to master .
            {
                var filePath = Path.Combine(dirPath, "SampleFile.txt");
                File.WriteAllText(filePath, "abcde");
            }
            repo.AddAllFiles();
            repo.Commit("Add Test", "AgtGit");

            // Create branch
            var branch1 = "Branch1";
            repo.CreateBranch(branch1);

            // Commit file to master .
            {
                var filePath = Path.Combine(dirPath, "SampleFile2.txt");
                File.WriteAllText(filePath, "abcde");
            }
            repo.AddAllFiles();
            repo.Commit("Add Test2", "AgtGit");

            // Switch branch .
            repo.SwitchBranch(branch1);
        }

        private bool IsMonitorEnable()
        {
            var monDirPath = mTxtMonDirPath.Text;
            if (monDirPath.Length == 0
                || Directory.Exists(monDirPath) == false)
            { return false; }
            return true;
        }

        private void SetupGitRepository()
        {
            if (mChkRun.Checked == true)
            {
                if (GitManager.IsGitDir(mTxtMonDirPath.Text) == false)
                {
                    GitManager.CreateRepository(mTxtMonDirPath.Text);
                }
                mRepository = new GitManager(mTxtMonDirPath.Text);
                InitCommit();
            }
        }

        private void InitCommit()
        {
            var time = DateTime.Now;
            var commitMsg = $"[{time.ToLongTimeString()}.{time.Millisecond}] Update";
            mRepository.AddAllFiles();
            mRepository.Commit(commitMsg, "AgtGit");
        }

        private async Task CommitChanges(WatcherChangeTypes changeType)
        {
            mChangeTypeList.Add(changeType);
            mChangeTypeList = mChangeTypeList.Distinct().ToList();

            mLastChangedTime = DateTime.Now;
            if (mIsWaitForChanged) { return; }
            SetMessage("変更検出");

            mIsWaitForChanged = true;
            await Task.Run(() => WaitForChanged());
            mIsWaitForChanged = false;

            var time = DateTime.Now;
            var commitMsg = $"[{time.ToLongTimeString()}.{time.Millisecond}] {string.Join(",", mChangeTypeList)}";
            mChangeTypeList.Clear();
            mRepository.AddAllFiles();
            mRepository.Commit(commitMsg, "AgtGit");
            SetMessage("Commit完了");
        }

        private void WaitForChanged()
        {
            while ((DateTime.Now - mLastChangedTime).TotalSeconds < 5)
            {
                Thread.Sleep(1000);
            }
        }

        public void SetMessage(string msg)
        {
            var time = DateTime.Now;
            var displayMsg = $"[{time.ToLongTimeString()}.{time.Millisecond}] {msg}";
            mLstMessage.Items.Add(displayMsg);
        }

        #endregion
    }
}