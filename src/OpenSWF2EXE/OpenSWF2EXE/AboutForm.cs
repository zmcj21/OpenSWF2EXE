﻿using System.Diagnostics;

namespace OpenSWF2EXE
{
    public partial class AboutForm : Form
    {
        private string VersionText = "0.2.2";

        #region LocaleSetting

        private string AuthorTextCN = "作者:";
        private string AuthorTextEN = "Author:";

        private string EmailTextCN = "邮箱:";
        private string EmailTextEN = "Email:";

        private string GithubTextCN = "Github:";
        private string GithubTextEN = "Github:";

        private string ArtistTextCN = "艺术家:";
        private string ArtistTextEN = "Artist:";

        private string TestTextCN = "测试人员名单:";
        private string TestTextEN = "List of testers:";

        #endregion

        public AboutForm()
        {
            InitializeComponent();
            label1.Text = VersionText;
            if (MainWindow.humanLanguage == HumanLanguage.Chinese)
            {
                AuthorText.Text = AuthorTextCN;
                EmailText.Text = EmailTextCN;
                GithubText.Text = GithubTextCN;
                ArtistText.Text = ArtistTextCN;
                TestText.Text = TestTextCN;
            }
            else if (MainWindow.humanLanguage == HumanLanguage.English)
            {
                AuthorText.Text = AuthorTextEN;
                EmailText.Text = EmailTextEN;
                GithubText.Text = GithubTextEN;
                ArtistText.Text = ArtistTextEN;
                TestText.Text = TestTextEN;
            }
        }

        //ref:https://stackoverflow.com/questions/502199/how-to-open-a-web-page-from-my-application
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = githubLink.Text, UseShellExecute = true });
        }
    }
}