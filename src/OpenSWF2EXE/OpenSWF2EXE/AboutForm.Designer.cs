namespace OpenSWF2EXE
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            AuthorText = new Label();
            EmailText = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            GithubText = new Label();
            githubLink = new LinkLabel();
            ArtistText = new Label();
            textBox3 = new TextBox();
            TestText = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AuthorText
            // 
            AuthorText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorText.Location = new Point(5, 119);
            AuthorText.Margin = new Padding(0);
            AuthorText.Name = "AuthorText";
            AuthorText.Size = new Size(98, 33);
            AuthorText.TabIndex = 0;
            AuthorText.Text = "Author:";
            AuthorText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailText.Location = new Point(5, 194);
            EmailText.Margin = new Padding(0);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(98, 25);
            EmailText.TabIndex = 2;
            EmailText.Text = "Email:";
            EmailText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FLASH_TO_EXE_3;
            pictureBox1.Location = new Point(198, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 71);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(103, 191);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(312, 33);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Text = "zmcj20plusplus@gmail.com";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(103, 119);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(161, 33);
            textBox2.TabIndex = 7;
            textBox2.TabStop = false;
            textBox2.Text = "zmcj21";
            // 
            // label1
            // 
            label1.Location = new Point(168, 82);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 8;
            label1.Text = "ver:x.y.z";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GithubText
            // 
            GithubText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GithubText.Location = new Point(6, 387);
            GithubText.Name = "GithubText";
            GithubText.Size = new Size(97, 25);
            GithubText.TabIndex = 9;
            GithubText.Text = "Github:";
            GithubText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // githubLink
            // 
            githubLink.AutoSize = true;
            githubLink.Location = new Point(103, 392);
            githubLink.Margin = new Padding(0);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(317, 20);
            githubLink.TabIndex = 11;
            githubLink.TabStop = true;
            githubLink.Text = "https://github.com/zmcj21/OpenSWF2EXE";
            githubLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ArtistText
            // 
            ArtistText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ArtistText.Location = new Point(9, 158);
            ArtistText.Margin = new Padding(0);
            ArtistText.Name = "ArtistText";
            ArtistText.Size = new Size(94, 25);
            ArtistText.TabIndex = 12;
            ArtistText.Text = "Artist:";
            ArtistText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(103, 155);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(161, 33);
            textBox3.TabIndex = 13;
            textBox3.Text = "ChiefBYW";
            // 
            // TestText
            // 
            TestText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TestText.Location = new Point(41, 239);
            TestText.Margin = new Padding(0);
            TestText.Name = "TestText";
            TestText.Size = new Size(361, 33);
            TestText.TabIndex = 14;
            TestText.Text = "List of testers:";
            TestText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(41, 275);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(361, 100);
            textBox4.TabIndex = 15;
            textBox4.Text = "zmcj21\r\nChiefBYW\r\n李小王\r\n24个豌豆\r\nprimetime43";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 433);
            Controls.Add(textBox4);
            Controls.Add(TestText);
            Controls.Add(textBox3);
            Controls.Add(ArtistText);
            Controls.Add(githubLink);
            Controls.Add(GithubText);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(EmailText);
            Controls.Add(AuthorText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AuthorText;
        private Label EmailText;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label GithubText;
        private LinkLabel githubLink;
        private Label ArtistText;
        private TextBox textBox3;
        private Label TestText;
        private TextBox textBox4;
    }
}