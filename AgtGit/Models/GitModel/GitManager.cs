using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;

namespace AgtGit.Models.GitModel
{
    public class GitManager
    {
        #region Property

        public Repository RepositoryInfo { get; protected set; }

        #endregion

        public GitManager(string repositoryPath)
        {
            RepositoryInfo = new Repository(repositoryPath);
        }

        #region Method

        public static GitManager CreateRepository(string repositoryPath)
        {
            Repository.Init(repositoryPath);
            return new GitManager(repositoryPath);
        }

        public void CreateBranch(string branchName)
        {
            RepositoryInfo.CreateBranch(branchName);
        }

        public List<string> GetBranchLists()
        {
            return RepositoryInfo
                .Branches
                .ToList()
                .ConvertAll(b => b.FriendlyName)
                .ToList();
        }

        public void DeleteBranch(string branchName)
        {
            RepositoryInfo.Branches.Remove(branchName);
        }

        public Branch? GetBranch(string branchName)
        {
            var branch = RepositoryInfo
                .Branches
                .FirstOrDefault(b => b.FriendlyName == branchName);
            return branch;
        }

        public List<Commit> GetLogs(string branchName)
        {
            var branch = GetBranch(branchName);
            if (branch == null) { return new List<Commit>(); }
            return branch.Commits.ToList();
        }

        public void AddAllFiles()
        {
            Commands.Stage(RepositoryInfo, "*");
        }

        public void Commit(string msg, string author)
        {
            try
            {
                var sig = new Signature(author, "a@b", DateTimeOffset.Now);
                RepositoryInfo.Commit(msg, sig, sig);
            }
            catch (EmptyCommitException) { }
        }

        public void CheckOut(string branchName, string sha, string checkOutPath)
        {
            var checkOutOption = new CheckoutOptions();
            checkOutOption.CheckoutModifiers = CheckoutModifiers.Force;
            checkOutOption.CheckoutNotifyFlags = CheckoutNotifyFlags.Ignored;
            RepositoryInfo.CheckoutPaths(sha, new[] { checkOutPath }, checkOutOption);
        }

        public void SwitchBranch(string branchName)
        {
            var branch = GetBranch(branchName);
            if (branch == null) { return; }
            Commands.Checkout(RepositoryInfo, branch);
        }

        public static string GitDirPath(string rootPath)
        {
            return Path.Combine(rootPath, ".git");
        }

        public static bool IsGitDir(string path)
        {
            return Directory.Exists(GitDirPath(path));
        }

        #endregion
    }
}
