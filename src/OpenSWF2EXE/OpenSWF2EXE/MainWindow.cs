using System.Diagnostics;

namespace OpenSWF2EXE
{
    public enum HumanLanguage
    {
        Chinese = 1,
        English = 2,
    }

    public enum SWF2EXE_Result
    {
        OK = 0,
        FlashPlayerInvalid = 1,
        FlashSWFInvalid = 2,
    }

    public partial class MainWindow : Form
    {
        public static HumanLanguage humanLanguage;

        #region LocaleSetting

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

        private string languageTextCN = "语言";
        private string languageTextEN = "Language";

        private string consoleTextCN = "控制台:";
        private string consoleTextEN = "Console:";

        private string convertTextCN = "转换";
        private string convertTextEN = "Convert";

        private string openFolderTextCN = "打开文件夹";
        private string openFolderTextEN = "Open Folder";

        private string resultTextCN = "转换结果:";
        private string resultTextEN = "Convert Result:";

        private string menuToolTextCN = "工具";
        private string menuToolTextEN = "Tool";

        #endregion

        private void SetLocale(HumanLanguage humanLanguage)
        {
            MainWindow.humanLanguage = humanLanguage;
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
                        this.languageToolStripMenuItem.Text = languageTextCN;
                        this.ConsoleText.Text = consoleTextCN;
                        this.ConvertButton.Text = convertTextCN;
                        this.openFolder.Text = openFolderTextCN;

                        this.resultText.Text = resultTextCN;
                        this.toolToolStripMenuItem.Text = menuToolTextCN;
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
                        this.languageToolStripMenuItem.Text = languageTextEN;
                        this.ConsoleText.Text = consoleTextEN;
                        this.ConvertButton.Text = convertTextEN;
                        this.openFolder.Text = openFolderTextEN;

                        this.resultText.Text = resultTextEN;
                        this.toolToolStripMenuItem.Text = menuToolTextEN;
                    }
                    break;
            }
        }

        private void ConsoleWrite(string msg)
        {
            this.console.Text += msg;
        }

        private void ConsoleWriteLine(string msg)
        {
            this.console.Text += (msg + "\r\n");
        }

        //Reference:http://www.nullsecurity.org/article/extracting_swf_from_flash_projector
        //REF:https://stackoverflow.com/questions/11679113/command-line-extract-from-swf
        private SWF2EXE_Result SWF2EXE(string flashPlayerPath, string flashSWFPath, string outputFilePath)
        {
            bool flashPlayerExecutable = false;
            bool flashSWFExecutable = false;

            //open files:
            FileStream flashPlayerFile = new FileStream(flashPlayerPath, FileMode.Open, FileAccess.Read);
            FileStream flashSWFFile = new FileStream(flashSWFPath, FileMode.Open, FileAccess.Read);
            FileStream outputFile = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write);
            BinaryReader flashPlayerReader = new BinaryReader(flashPlayerFile);
            BinaryReader flashSWFReader = new BinaryReader(flashSWFFile);
            BinaryWriter outputWriter = new BinaryWriter(outputFile);

            byte[] playerSignature = flashPlayerReader.ReadBytes(2);
            if (playerSignature[0] == 'M' && playerSignature[1] == 'Z')
            {
                flashPlayerExecutable = true;
            }
            if (!flashPlayerExecutable)
            {
                return SWF2EXE_Result.FlashPlayerInvalid;
            }

            byte[] flashSignature = flashSWFReader.ReadBytes(3);
            if ((flashSignature[0] == 'F' && flashSignature[1] == 'W' && flashSignature[2] == 'S') ||
                (flashSignature[0] == 'C' && flashSignature[1] == 'W' && flashSignature[2] == 'S') ||
                (flashSignature[0] == 'Z' && flashSignature[1] == 'W' && flashSignature[2] == 'S'))
            {
                flashSWFExecutable = true;
            }
            if (!flashSWFExecutable)
            {
                return SWF2EXE_Result.FlashSWFInvalid;
            }

            //-----combine flashPlayer and flashSWF-----
            flashPlayerReader.BaseStream.Position = 0;
            flashSWFReader.BaseStream.Position = 0;
            //copy flashPlayer:
            for (int i = 0; i < flashPlayerReader.BaseStream.Length; i++)
            {
                outputWriter.Write((byte)flashPlayerReader.BaseStream.ReadByte());
            }
            //copy flashSWF:
            for (int i = 0; i < flashSWFReader.BaseStream.Length; i++)
            {
                outputWriter.Write((byte)flashSWFReader.BaseStream.ReadByte());
            }
            //write 0xFA123456(Flash Projector "check" value):
            outputWriter.Write(0xFA123456);
            //write Size of the original SWF file:
            outputWriter.Write((uint)flashSWFReader.BaseStream.Length);

            //close files:
            flashPlayerReader.Close();
            flashSWFReader.Close();
            outputWriter.Close();
            flashPlayerFile.Close();
            flashSWFFile.Close();
            outputFile.Close();

            return SWF2EXE_Result.OK;
        }

        public MainWindow()
        {
            InitializeComponent();
            //set language:
            HumanLanguage humanLanguage = (HumanLanguage)Config.GetLanguage();
            SetLocale(humanLanguage);
            //set default output folder:
            outputPathTextBox.Text = Environment.CurrentDirectory + "\\";
        }

        //ref:https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
        private void SelectFlashPlayer_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flashPlayerPathTextBox.Text = openFileDialog.FileName;
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
                flashSWFPathTextBox.Text = openFileDialog.FileName;
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
                        outputPathTextBox.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string flashPlayerPath = this.flashPlayerPathTextBox.Text;
            string flashSWFPath = this.flashSWFPathTextBox.Text;
            string outputPath = this.outputPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(flashPlayerPath))
            {
                if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                {
                    ConsoleWriteLine("FlashPlayer路径不能为空！！！");
                }
                else if (MainWindow.humanLanguage == HumanLanguage.English)
                {
                    ConsoleWriteLine("FlashPlayer's path can't be empty!!!");
                }
                return;
            }

            if (string.IsNullOrWhiteSpace(flashSWFPath))
            {
                if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                {
                    ConsoleWriteLine("swf文件路径不能为空！！！");
                }
                else if (MainWindow.humanLanguage == HumanLanguage.English)
                {
                    ConsoleWriteLine("swf file's path can't be empty!!!");
                }
                return;
            }

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                {
                    ConsoleWriteLine("输出路径必须被指定！！！");
                }
                else if (MainWindow.humanLanguage == HumanLanguage.English)
                {
                    ConsoleWriteLine("output folder must be specified!!!");
                }
                return;
            }

            FileInfo fileInfo = new FileInfo(flashSWFPath);
            string outputFilePath = Path.Combine(new string[] { outputPath, $"{fileInfo.Name.Substring(0, fileInfo.Name.LastIndexOf('.'))}.exe" });

            SWF2EXE_Result result = SWF2EXE(flashPlayerPath, flashSWFPath, outputFilePath);

            switch (result)
            {
                case SWF2EXE_Result.OK:
                    {
                        if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                        {
                            ConsoleWriteLine("转换成功。");
                        }
                        else if (MainWindow.humanLanguage == HumanLanguage.English)
                        {
                            ConsoleWriteLine("Work Success.");
                        }
                        if (openFolder.Checked)
                        {
                            Process.Start("explorer.exe", outputPath);
                        }
                        resultImage.Image = Properties.Resources._1;
                    }
                    break;
                case SWF2EXE_Result.FlashPlayerInvalid:
                    {
                        if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                        {
                            ConsoleWriteLine("FlashPlayer无效！！！");
                        }
                        else if (MainWindow.humanLanguage == HumanLanguage.English)
                        {
                            ConsoleWriteLine("FlashPlayer invalid!!!");
                        }
                        resultImage.Image = Properties.Resources._2;
                    }
                    break;
                case SWF2EXE_Result.FlashSWFInvalid:
                    {
                        if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                        {
                            ConsoleWriteLine("Flash文件无效！！！");
                        }
                        else if (MainWindow.humanLanguage == HumanLanguage.English)
                        {
                            ConsoleWriteLine("Flash File invalid!!!");
                        }
                        resultImage.Image = Properties.Resources._2;
                    }
                    break;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.SetLanguage((int)HumanLanguage.Chinese);
            SetLocale(HumanLanguage.Chinese);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.SetLanguage((int)HumanLanguage.English);
            SetLocale(HumanLanguage.English);
        }

        private void eXETOSWFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXE2SWF form = new EXE2SWF();
            form.Show();
        }
    }
}