using System.Diagnostics;

namespace OpenSWF2EXE
{
    public partial class AboutForm : Form
    {
        #region LocaleSetting

        private string AuthorTextCN = "作者:";
        private string AuthorTextEN = "Author:";

        private string EmailTextCN = "邮箱:";
        private string EmailTextEN = "Email:";

        private string GithubTextCN = "Github:";
        private string GithubTextEN = "Github:";

        #endregion

        public AboutForm()
        {
            InitializeComponent();
            if (MainWindow.humanLanguage == HumanLanguage.Chinese)
            {
                AuthorText.Text = AuthorTextCN;
                EmailText.Text = EmailTextCN;
                GithubText.Text = GithubTextCN;
            }
            else if (MainWindow.humanLanguage == HumanLanguage.English)
            {
                AuthorText.Text = AuthorTextEN;
                EmailText.Text = EmailTextEN;
                GithubText.Text = GithubTextEN;
            }
        }

        //ref:https://stackoverflow.com/questions/502199/how-to-open-a-web-page-from-my-application
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = githubLink.Text, UseShellExecute = true });
        }
    }
}