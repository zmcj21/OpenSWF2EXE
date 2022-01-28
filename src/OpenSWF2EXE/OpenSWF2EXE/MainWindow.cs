namespace OpenSWF2EXE
{
    public enum HumanLanguage
    {
        Chinese = 1,
        English,
    }

    public partial class MainWindow : Form
    {
        private HumanLanguage humanLanguage = HumanLanguage.Chinese;

        //-----locale setting-----

        private string menuFileTextCN = "文件";
        private string menuFileTextEN = "File";

        private string menuCloseTextCN = "关闭";
        private string menuCloseTextEN = "Close";

        private string menuHelpTextCN = "帮助";
        private string menuHelpTextEN = "Help";

        private string menuAboutTextCN = "关于";
        private string menuAboutTextEN = "About";

        private string titleTextCN = "开源SWF到EXE转换器";
        private string titleTextEN = "Open SWF to EXE converter";

        private string selectFlashPlayerButtonTextCN = "选择 Flash Player";
        private string selectFlashPlayerButtonTextEN = "Select Flash Player";

        private string selectSWFFileButtonTextCN = "选择 SWF File";
        private string selectSWFFileButtonTextEN = "Select SWF File";

        private string flashPlayerPathTextCN = "flash player 路径:";
        private string flashPlayerPathTextEN = "flash player path:";

        private string swfFilePathTextCN = "flash swf 路径:";
        private string swfFilePathTextEN = "flash swf path:";

        public MainWindow()
        {
            InitializeComponent();
            InitApplication(this.humanLanguage);
        }

        private void InitApplication(HumanLanguage humanLanguage)
        {
            switch (humanLanguage)
            {
                case HumanLanguage.Chinese:
                    {
                        this.SelectFlashPlayer.Text = selectFlashPlayerButtonTextCN;
                        this.SelectSWFFile.Text = selectSWFFileButtonTextCN;
                        this.flashPlayerPath.Text = flashPlayerPathTextCN;
                        this.swfFilePath.Text = swfFilePathTextCN;

                        this.fileToolStripMenuItem.Text = menuFileTextCN;
                        this.closeToolStripMenuItem.Text = menuCloseTextCN;
                        this.helpToolStripMenuItem.Text = menuHelpTextCN;
                        this.aboutToolStripMenuItem.Text = menuAboutTextCN;
                        this.Title.Text = titleTextCN;

                    }
                    break;
                case HumanLanguage.English:
                    {
                        this.SelectFlashPlayer.Text = selectFlashPlayerButtonTextEN;
                        this.SelectSWFFile.Text = selectSWFFileButtonTextEN;
                        this.flashPlayerPath.Text = flashPlayerPathTextEN;
                        this.swfFilePath.Text = swfFilePathTextEN;

                        this.fileToolStripMenuItem.Text = menuFileTextEN;
                        this.closeToolStripMenuItem.Text = menuCloseTextEN;
                        this.helpToolStripMenuItem.Text = menuHelpTextEN;
                        this.aboutToolStripMenuItem.Text = menuAboutTextEN;
                        this.Title.Text = titleTextEN;

                    }
                    break;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}