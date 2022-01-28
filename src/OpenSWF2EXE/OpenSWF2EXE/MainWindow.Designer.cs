namespace OpenSWF2EXE
{
    partial class MainWindow
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
            this.SelectFlashPlayer = new System.Windows.Forms.Button();
            this.flashPlayerPathTextBox = new System.Windows.Forms.TextBox();
            this.flashSWFPathTextBox = new System.Windows.Forms.TextBox();
            this.flashPlayerPath = new System.Windows.Forms.Label();
            this.swfFilePath = new System.Windows.Forms.Label();
            this.SelectSWFFile = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectOutputFolder = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.Label();
            this.outputPathTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFlashPlayer
            // 
            this.SelectFlashPlayer.Location = new System.Drawing.Point(12, 102);
            this.SelectFlashPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.SelectFlashPlayer.Name = "SelectFlashPlayer";
            this.SelectFlashPlayer.Size = new System.Drawing.Size(183, 46);
            this.SelectFlashPlayer.TabIndex = 0;
            this.SelectFlashPlayer.Text = "Select Flash Player";
            this.SelectFlashPlayer.UseVisualStyleBackColor = true;
            this.SelectFlashPlayer.Click += new System.EventHandler(this.SelectFlashPlayer_Click);
            // 
            // flashPlayerPathTextBox
            // 
            this.flashPlayerPathTextBox.Location = new System.Drawing.Point(354, 112);
            this.flashPlayerPathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.flashPlayerPathTextBox.Name = "flashPlayerPathTextBox";
            this.flashPlayerPathTextBox.Size = new System.Drawing.Size(406, 27);
            this.flashPlayerPathTextBox.TabIndex = 1;
            this.flashPlayerPathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flashSWFPathTextBox
            // 
            this.flashSWFPathTextBox.Location = new System.Drawing.Point(354, 184);
            this.flashSWFPathTextBox.Name = "flashSWFPathTextBox";
            this.flashSWFPathTextBox.Size = new System.Drawing.Size(406, 27);
            this.flashSWFPathTextBox.TabIndex = 2;
            // 
            // flashPlayerPath
            // 
            this.flashPlayerPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flashPlayerPath.Location = new System.Drawing.Point(195, 102);
            this.flashPlayerPath.Margin = new System.Windows.Forms.Padding(0);
            this.flashPlayerPath.Name = "flashPlayerPath";
            this.flashPlayerPath.Size = new System.Drawing.Size(150, 46);
            this.flashPlayerPath.TabIndex = 3;
            this.flashPlayerPath.Text = "flash player path:";
            this.flashPlayerPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // swfFilePath
            // 
            this.swfFilePath.Location = new System.Drawing.Point(195, 176);
            this.swfFilePath.Name = "swfFilePath";
            this.swfFilePath.Size = new System.Drawing.Size(150, 43);
            this.swfFilePath.TabIndex = 4;
            this.swfFilePath.Text = "flash swf path:";
            this.swfFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectSWFFile
            // 
            this.SelectSWFFile.Location = new System.Drawing.Point(12, 176);
            this.SelectSWFFile.Name = "SelectSWFFile";
            this.SelectSWFFile.Size = new System.Drawing.Size(183, 46);
            this.SelectSWFFile.TabIndex = 5;
            this.SelectSWFFile.Text = "Select SWF File";
            this.SelectSWFFile.UseVisualStyleBackColor = true;
            this.SelectSWFFile.Click += new System.EventHandler(this.SelectSWFFile_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(0, 28);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(782, 63);
            this.Title.TabIndex = 6;
            this.Title.Text = "Open swf file to exe file converter";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "flashPlayerOpenFileDialog";
            // 
            // SelectOutputFolder
            // 
            this.SelectOutputFolder.Location = new System.Drawing.Point(12, 247);
            this.SelectOutputFolder.Name = "SelectOutputFolder";
            this.SelectOutputFolder.Size = new System.Drawing.Size(183, 46);
            this.SelectOutputFolder.TabIndex = 8;
            this.SelectOutputFolder.Text = "Select Output Folder";
            this.SelectOutputFolder.UseVisualStyleBackColor = true;
            this.SelectOutputFolder.Click += new System.EventHandler(this.SelectOutputFolder_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(195, 247);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(150, 46);
            this.outputPath.TabIndex = 9;
            this.outputPath.Text = "output folder path:";
            this.outputPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputPathTextBox
            // 
            this.outputPathTextBox.Location = new System.Drawing.Point(354, 257);
            this.outputPathTextBox.Name = "outputPathTextBox";
            this.outputPathTextBox.Size = new System.Drawing.Size(406, 27);
            this.outputPathTextBox.TabIndex = 10;
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Coral;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(294, 310);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(215, 69);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.outputPathTextBox);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.SelectOutputFolder);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SelectSWFFile);
            this.Controls.Add(this.swfFilePath);
            this.Controls.Add(this.flashPlayerPath);
            this.Controls.Add(this.flashSWFPathTextBox);
            this.Controls.Add(this.flashPlayerPathTextBox);
            this.Controls.Add(this.SelectFlashPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSWF2EXE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectFlashPlayer;
        private TextBox flashPlayerPathTextBox;
        private TextBox flashSWFPathTextBox;
        private Label flashPlayerPath;
        private Label swfFilePath;
        private Button SelectSWFFile;
        private Label Title;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private Button SelectOutputFolder;
        private Label outputPath;
        private TextBox outputPathTextBox;
        private Button ConvertButton;
    }
}