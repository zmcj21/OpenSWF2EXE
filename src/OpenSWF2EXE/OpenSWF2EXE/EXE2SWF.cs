using System.Diagnostics;

namespace OpenSWF2EXE
{
    public enum EXE2SWF_Result
    {
        OK = 0,
        ExecutableFileInvalid = 1,
    }

    public partial class EXE2SWF : Form
    {
        #region LocaleSetting

        private string TitleCN = "开源EXE到SWF转换器";
        private string TitleEN = "Open EXE to SWF converter";

        private string SelectExeFileCN = "选择Exe文件";
        private string SelectExeFileEN = "Select Exe File";

        private string ExeFilePathCN = "exe文件路径:";
        private string ExeFilePathEN = "exe file path:";

        private string SelectOutputFolderCN = "选择输出文件夹";
        private string SelectOutputFolderEN = "Select Output Folder";

        private string OutputFolderPathCN = "输出文件夹路径:";
        private string OutputFolderPathEN = "output folder path:";

        private string openFolderCN = "打开文件夹";
        private string openFolderEN = "Open Folder";

        private string ConvertButtonCN = "转换";
        private string ConvertButtonEN = "Convert";

        private string resultTextCN = "转换结果:";
        private string resultTextEN = "Convert Result:";

        private string ConsoleTextCN = "控制台:";
        private string ConsoleTextEN = "Console:";

        #endregion

        private void SetLocale(HumanLanguage humanLanguage)
        {
            switch (humanLanguage)
            {
                case HumanLanguage.Chinese:
                    {
                        this.Title.Text = TitleCN;
                        this.SelectExeFile.Text = SelectExeFileCN;
                        this.ExeFilePath.Text = ExeFilePathCN;
                        this.SelectOutputFolder.Text = SelectOutputFolderCN;
                        this.OutputFolderPath.Text = OutputFolderPathCN;

                        this.openFolder.Text = openFolderCN;
                        this.ConvertButton.Text = ConvertButtonCN;
                        this.resultText.Text = resultTextCN;
                        this.ConsoleText.Text = ConsoleTextCN;
                    }
                    break;
                case HumanLanguage.English:
                    {
                        this.Title.Text = TitleEN;
                        this.SelectExeFile.Text = SelectExeFileEN;
                        this.ExeFilePath.Text = ExeFilePathEN;
                        this.SelectOutputFolder.Text = SelectOutputFolderEN;
                        this.OutputFolderPath.Text = OutputFolderPathEN;

                        this.openFolder.Text = openFolderEN;
                        this.ConvertButton.Text = ConvertButtonEN;
                        this.resultText.Text = resultTextEN;
                        this.ConsoleText.Text = ConsoleTextEN;
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
        private EXE2SWF_Result EXE2SWFFunc(string inputEXEPath, string outputFolderPath, out string createdOutputDir)
        {
            createdOutputDir = string.Empty;

            int dashIndex = inputEXEPath.LastIndexOf('\\');
            string inputEXEName = inputEXEPath.Substring(dashIndex + 1, inputEXEPath.LastIndexOf('.') - dashIndex - 1);

            bool inputEXEExecutable = false;

            byte[] checkValueArray = new byte[4];
            byte[] swfLengthArray = new byte[4];
            byte[] data = File.ReadAllBytes(inputEXEPath);

            for (int i = 0; i < 4; i++)
            {
                checkValueArray[i] = data[data.Length - 8 + i];
                swfLengthArray[i] = data[data.Length - 4 + i];
            }

            uint checkValue = BitConverter.ToUInt32(checkValueArray, 0);
            uint swfLength = BitConverter.ToUInt32(swfLengthArray, 0);

            if (checkValue == 0xFA123456)
            {
                inputEXEExecutable = true;
            }
            if (!inputEXEExecutable)
            {
                return EXE2SWF_Result.ExecutableFileInvalid;
            }

            byte[] flashPlayerData = new byte[data.Length - 8 - swfLength];
            byte[] swfData = new byte[swfLength];
            for (int i = 0; i < flashPlayerData.Length; i++)
            {
                flashPlayerData[i] = data[i];
            }
            for (int i = 0; i < swfData.Length; i++)
            {
                swfData[i] = data[i + data.Length - 8 - swfLength];
            }

            DirectoryInfo outputDir = Directory.CreateDirectory(outputFolderPath + "\\" + $"{inputEXEName}_output");
            createdOutputDir = outputDir.FullName;

            FileStream flashPlayerFile = File.Create(outputDir.FullName + "\\FlashPlayer.exe");
            FileStream swfFile = File.Create(outputDir.FullName + $"\\{inputEXEName}.swf");

            flashPlayerFile.Write(flashPlayerData, 0, flashPlayerData.Length);
            swfFile.Write(swfData, 0, swfData.Length);

            flashPlayerFile.Close();
            swfFile.Close();

            return EXE2SWF_Result.OK;
        }

        public EXE2SWF()
        {
            InitializeComponent();
            //set locale:
            SetLocale(MainWindow.humanLanguage);
            //set default output folder:
            OutputFolderPathTextBox.Text = Environment.CurrentDirectory + "\\";
        }

        private void SelectExeFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExeFilePathTextBox.Text = openFileDialog.FileName;
                }
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
                        OutputFolderPathTextBox.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string inputEXEPath = this.ExeFilePathTextBox.Text;
            string outputFolderPath = this.OutputFolderPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(inputEXEPath))
            {
                if (MainWindow.humanLanguage == HumanLanguage.Chinese)
                {
                    ConsoleWriteLine("exe文件路径不能为空！！！");
                }
                else if (MainWindow.humanLanguage == HumanLanguage.English)
                {
                    ConsoleWriteLine("exe file's path can't be empty!!!");
                }
                return;
            }

            if (string.IsNullOrWhiteSpace(outputFolderPath))
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

            EXE2SWF_Result result = EXE2SWFFunc(inputEXEPath, outputFolderPath, out string createdOutputDir);

            switch (result)
            {
                case EXE2SWF_Result.OK:
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
                            Process.Start("explorer.exe", createdOutputDir);
                        }
                        resultImage.Image = Properties.Resources._1;
                    }
                    break;
                case EXE2SWF_Result.ExecutableFileInvalid:
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
            }
        }
    }
}