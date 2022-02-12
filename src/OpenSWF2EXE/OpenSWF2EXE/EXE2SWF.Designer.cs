namespace OpenSWF2EXE
{
    partial class EXE2SWF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXE2SWF));
            this.Title = new System.Windows.Forms.Label();
            this.ExeFilePath = new System.Windows.Forms.Label();
            this.ExeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SelectExeFile = new System.Windows.Forms.Button();
            this.openFolder = new System.Windows.Forms.CheckBox();
            this.resultImage = new System.Windows.Forms.PictureBox();
            this.resultText = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputFolderPath = new System.Windows.Forms.Label();
            this.OutputFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectOutputFolder = new System.Windows.Forms.Button();
            this.ConsoleText = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(0, 29);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(782, 63);
            this.Title.TabIndex = 7;
            this.Title.Text = "Open EXE to SWF converter";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExeFilePath
            // 
            this.ExeFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExeFilePath.Location = new System.Drawing.Point(197, 115);
            this.ExeFilePath.Margin = new System.Windows.Forms.Padding(0);
            this.ExeFilePath.Name = "ExeFilePath";
            this.ExeFilePath.Size = new System.Drawing.Size(149, 46);
            this.ExeFilePath.TabIndex = 11;
            this.ExeFilePath.Text = "exe file path:";
            this.ExeFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExeFilePathTextBox
            // 
            this.ExeFilePathTextBox.Location = new System.Drawing.Point(358, 125);
            this.ExeFilePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ExeFilePathTextBox.Name = "ExeFilePathTextBox";
            this.ExeFilePathTextBox.Size = new System.Drawing.Size(404, 27);
            this.ExeFilePathTextBox.TabIndex = 10;
            // 
            // SelectExeFile
            // 
            this.SelectExeFile.Location = new System.Drawing.Point(14, 115);
            this.SelectExeFile.Margin = new System.Windows.Forms.Padding(0);
            this.SelectExeFile.Name = "SelectExeFile";
            this.SelectExeFile.Size = new System.Drawing.Size(183, 46);
            this.SelectExeFile.TabIndex = 9;
            this.SelectExeFile.Text = "Select Exe File";
            this.SelectExeFile.UseVisualStyleBackColor = true;
            this.SelectExeFile.Click += new System.EventHandler(this.SelectExeFile_Click);
            // 
            // openFolder
            // 
            this.openFolder.Checked = true;
            this.openFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openFolder.Location = new System.Drawing.Point(147, 394);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(126, 24);
            this.openFolder.TabIndex = 20;
            this.openFolder.Text = "Open Folder";
            this.openFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFolder.UseVisualStyleBackColor = true;
            // 
            // resultImage
            // 
            this.resultImage.Location = new System.Drawing.Point(661, 373);
            this.resultImage.Name = "resultImage";
            this.resultImage.Size = new System.Drawing.Size(48, 48);
            this.resultImage.TabIndex = 19;
            this.resultImage.TabStop = false;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultText.Location = new System.Drawing.Point(500, 394);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(155, 27);
            this.resultText.TabIndex = 18;
            this.resultText.Text = "Convert Result:";
            this.resultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Coral;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(279, 368);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(215, 69);
            this.ConvertButton.TabIndex = 17;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OutputFolderPath
            // 
            this.OutputFolderPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderPath.Location = new System.Drawing.Point(197, 183);
            this.OutputFolderPath.Margin = new System.Windows.Forms.Padding(0);
            this.OutputFolderPath.Name = "OutputFolderPath";
            this.OutputFolderPath.Size = new System.Drawing.Size(149, 46);
            this.OutputFolderPath.TabIndex = 23;
            this.OutputFolderPath.Text = "output folder path:";
            this.OutputFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputFolderPathTextBox
            // 
            this.OutputFolderPathTextBox.Location = new System.Drawing.Point(358, 193);
            this.OutputFolderPathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.OutputFolderPathTextBox.Name = "OutputFolderPathTextBox";
            this.OutputFolderPathTextBox.Size = new System.Drawing.Size(404, 27);
            this.OutputFolderPathTextBox.TabIndex = 22;
            // 
            // SelectOutputFolder
            // 
            this.SelectOutputFolder.Location = new System.Drawing.Point(14, 183);
            this.SelectOutputFolder.Margin = new System.Windows.Forms.Padding(0);
            this.SelectOutputFolder.Name = "SelectOutputFolder";
            this.SelectOutputFolder.Size = new System.Drawing.Size(183, 46);
            this.SelectOutputFolder.TabIndex = 21;
            this.SelectOutputFolder.Text = "Select Output Folder";
            this.SelectOutputFolder.UseVisualStyleBackColor = true;
            this.SelectOutputFolder.Click += new System.EventHandler(this.SelectOutputFolder_Click);
            // 
            // ConsoleText
            // 
            this.ConsoleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsoleText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleText.Location = new System.Drawing.Point(12, 454);
            this.ConsoleText.Margin = new System.Windows.Forms.Padding(0);
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.Size = new System.Drawing.Size(126, 31);
            this.ConsoleText.TabIndex = 25;
            this.ConsoleText.Text = "Console:";
            this.ConsoleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // console
            // 
            this.console.AcceptsTab = true;
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console.Location = new System.Drawing.Point(12, 488);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(748, 143);
            this.console.TabIndex = 24;
            // 
            // EXE2SWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 643);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.console);
            this.Controls.Add(this.OutputFolderPath);
            this.Controls.Add(this.OutputFolderPathTextBox);
            this.Controls.Add(this.SelectOutputFolder);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.resultImage);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ExeFilePath);
            this.Controls.Add(this.ExeFilePathTextBox);
            this.Controls.Add(this.SelectExeFile);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXE2SWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXE2SWF";
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label ExeFilePath;
        private TextBox ExeFilePathTextBox;
        private Button SelectExeFile;
        private CheckBox openFolder;
        private PictureBox resultImage;
        private Label resultText;
        private Button ConvertButton;
        private Label OutputFolderPath;
        private TextBox OutputFolderPathTextBox;
        private Button SelectOutputFolder;
        private Label ConsoleText;
        private TextBox console;
    }
}