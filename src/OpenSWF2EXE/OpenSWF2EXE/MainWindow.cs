namespace OpenSWF2EXE
{
    public enum HumanLanguage
    {
        Chinese = 1,
        English,
    }

    public partial class MainWindow : Form
    {
        //-----logic-----
        private string flashPlayerPathString = string.Empty;
        private string swfFilePathString = string.Empty;
        private string outputPathString = string.Empty;

        //-----locale setting-----
        private HumanLanguage humanLanguage = HumanLanguage.Chinese;

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

        private string selectSWFFileButtonTextCN = "选择 SWF 文件";
        private string selectSWFFileButtonTextEN = "Select SWF File";

        private string selectOutputFolderCN = "选择输出文件夹";
        private string selectOutputFolderEN = "Select Output Folder";

        private string flashPlayerPathTextCN = "flash player 路径:";
        private string flashPlayerPathTextEN = "flash player path:";

        private string swfFilePathTextCN = "flash swf 路径:";
        private string swfFilePathTextEN = "flash swf path:";

        private string outputPathTextCN = "输出文件夹路径:";
        private string outputPathTextEN = "output folder path:";

        public MainWindow()
        {
            InitializeComponent();
            InitApplication(this.humanLanguage);

            //set default output folder:
            outputPathTextBox.Text = Environment.CurrentDirectory + "\\";
            outputPathString = outputPathTextBox.Text;
        }

        private void InitApplication(HumanLanguage humanLanguage)
        {
            switch (humanLanguage)
            {
                case HumanLanguage.Chinese:
                    {
                        this.SelectFlashPlayer.Text = selectFlashPlayerButtonTextCN;
                        this.SelectSWFFile.Text = selectSWFFileButtonTextCN;
                        this.SelectOutputFolder.Text = selectOutputFolderCN;

                        this.flashPlayerPath.Text = flashPlayerPathTextCN;
                        this.swfFilePath.Text = swfFilePathTextCN;
                        this.outputPath.Text = outputPathTextCN;

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
                        this.SelectOutputFolder.Text = selectOutputFolderEN;

                        this.flashPlayerPath.Text = flashPlayerPathTextEN;
                        this.swfFilePath.Text = swfFilePathTextEN;
                        this.outputPath.Text = outputPathTextEN;

                        this.fileToolStripMenuItem.Text = menuFileTextEN;
                        this.closeToolStripMenuItem.Text = menuCloseTextEN;
                        this.helpToolStripMenuItem.Text = menuHelpTextEN;
                        this.aboutToolStripMenuItem.Text = menuAboutTextEN;
                        this.Title.Text = titleTextEN;

                    }
                    break;
            }
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

        //ref:https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
        private void SelectFlashPlayer_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flashPlayerPathString = openFileDialog.FileName;
                flashPlayerPathTextBox.Text = flashPlayerPathString;
            }
        }

        //ref:https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
        private void SelectSWFFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "swf files (*.swf)|*.swf|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                swfFilePathString = openFileDialog.FileName;
                flashSWFPathTextBox.Text = swfFilePathString;
            }
        }

        private void SelectOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        outputPathString = folderBrowserDialog.SelectedPath;
                        outputPathTextBox.Text = outputPathString;
                    }
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            this.flashPlayerPathString = this.flashPlayerPathTextBox.Text;
            this.swfFilePathString = this.flashSWFPathTextBox.Text;
            this.outputPathString = this.outputPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(this.flashPlayerPathString) ||
                string.IsNullOrWhiteSpace(this.swfFilePathString) ||
                string.IsNullOrWhiteSpace(this.outputPathString))
            {
                //fail
                return;
            }

            bool flashPlayerOK = SWF_TO_EXE.CheckFlashPlayer(flashPlayerPathString);
            bool swfFileOK = SWF_TO_EXE.CheckSwfFile(swfFilePathString);
            if (!flashPlayerOK)
            {
                //fail
                return;
            }
            if (!swfFileOK)
            {
                //fail
                return;
            }

            int len = swfFilePathString.LastIndexOf('.');
            string swfFileName = swfFilePathString.Substring(0, len);
            swfFileName = swfFileName + ".exe";

            SWF_TO_EXE.BindSwfAndExe();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}