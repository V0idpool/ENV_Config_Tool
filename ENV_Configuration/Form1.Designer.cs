namespace ENV_Configuration
{
    partial class Form1
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
            nsTabControl1 = new NSTabControl();
            tabPage1 = new TabPage();
            nsGroupBox1 = new NSGroupBox();
            nsLabel5 = new NSLabel();
            mongoDBURL = new NSTextBox();
            nsCheckBox1 = new NSCheckBox();
            nsLabel6 = new NSLabel();
            GptApiKey = new NSTextBox();
            YoutubeAPIKey = new NSTextBox();
            nsLabel4 = new NSLabel();
            YoutubeAppName = new NSTextBox();
            nsLabel3 = new NSLabel();
            DiscordBotToken = new NSTextBox();
            nsLabel2 = new NSLabel();
            nsLabel1 = new NSLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            nsGroupBox6 = new NSGroupBox();
            nsButton1 = new NSButton();
            nsTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            nsGroupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            nsGroupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // nsTabControl1
            // 
            nsTabControl1.Alignment = TabAlignment.Left;
            nsTabControl1.Controls.Add(tabPage1);
            nsTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            nsTabControl1.ItemSize = new Size(28, 115);
            nsTabControl1.Location = new Point(1, -3);
            nsTabControl1.Multiline = true;
            nsTabControl1.Name = "nsTabControl1";
            nsTabControl1.SelectedIndex = 0;
            nsTabControl1.Size = new Size(661, 382);
            nsTabControl1.SizeMode = TabSizeMode.Fixed;
            nsTabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(50, 50, 50);
            tabPage1.Controls.Add(nsGroupBox1);
            tabPage1.Controls.Add(nsGroupBox6);
            tabPage1.Location = new Point(119, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(538, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ENV Main Page";
            // 
            // nsGroupBox1
            // 
            nsGroupBox1.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox1.Controls.Add(nsLabel5);
            nsGroupBox1.Controls.Add(mongoDBURL);
            nsGroupBox1.Controls.Add(nsCheckBox1);
            nsGroupBox1.Controls.Add(nsLabel6);
            nsGroupBox1.Controls.Add(GptApiKey);
            nsGroupBox1.Controls.Add(YoutubeAPIKey);
            nsGroupBox1.Controls.Add(nsLabel4);
            nsGroupBox1.Controls.Add(YoutubeAppName);
            nsGroupBox1.Controls.Add(nsLabel3);
            nsGroupBox1.Controls.Add(DiscordBotToken);
            nsGroupBox1.Controls.Add(nsLabel2);
            nsGroupBox1.Controls.Add(nsLabel1);
            nsGroupBox1.Controls.Add(menuStrip1);
            nsGroupBox1.DrawSeperator = false;
            nsGroupBox1.Location = new Point(0, 0);
            nsGroupBox1.Name = "nsGroupBox1";
            nsGroupBox1.Size = new Size(539, 281);
            nsGroupBox1.SubTitle = "";
            nsGroupBox1.TabIndex = 33;
            nsGroupBox1.Text = "nsGroupBox1";
            nsGroupBox1.Title = "";
            // 
            // nsLabel5
            // 
            nsLabel5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel5.Location = new Point(12, 181);
            nsLabel5.Name = "nsLabel5";
            nsLabel5.Size = new Size(143, 23);
            nsLabel5.TabIndex = 24;
            nsLabel5.Text = "nsLabel5";
            nsLabel5.Value1 = "MongoDBURL:";
            nsLabel5.Value2 = " ";
            // 
            // mongoDBURL
            // 
            mongoDBURL.Location = new Point(161, 181);
            mongoDBURL.MaxLength = 32767;
            mongoDBURL.Multiline = false;
            mongoDBURL.Name = "mongoDBURL";
            mongoDBURL.ReadOnly = false;
            mongoDBURL.Size = new Size(368, 27);
            mongoDBURL.TabIndex = 23;
            mongoDBURL.TextAlign = HorizontalAlignment.Left;
            mongoDBURL.UseSystemPasswordChar = true;
            // 
            // nsCheckBox1
            // 
            nsCheckBox1.Checked = false;
            nsCheckBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nsCheckBox1.Location = new Point(347, 33);
            nsCheckBox1.Name = "nsCheckBox1";
            nsCheckBox1.Size = new Size(182, 23);
            nsCheckBox1.TabIndex = 22;
            nsCheckBox1.Text = "Show Keys/ Sensitive Info";
            nsCheckBox1.CheckedChanged += nsCheckBox1_CheckedChanged;
            // 
            // nsLabel6
            // 
            nsLabel6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel6.Location = new Point(8, 30);
            nsLabel6.Name = "nsLabel6";
            nsLabel6.Size = new Size(129, 23);
            nsLabel6.TabIndex = 21;
            nsLabel6.Text = "nsLabel6";
            nsLabel6.Value1 = "Bot API";
            nsLabel6.Value2 = " Settings";
            // 
            // GptApiKey
            // 
            GptApiKey.Location = new Point(161, 61);
            GptApiKey.MaxLength = 32767;
            GptApiKey.Multiline = false;
            GptApiKey.Name = "GptApiKey";
            GptApiKey.ReadOnly = false;
            GptApiKey.Size = new Size(368, 23);
            GptApiKey.TabIndex = 2;
            GptApiKey.TextAlign = HorizontalAlignment.Left;
            GptApiKey.UseSystemPasswordChar = true;
            // 
            // YoutubeAPIKey
            // 
            YoutubeAPIKey.Location = new Point(161, 90);
            YoutubeAPIKey.MaxLength = 32767;
            YoutubeAPIKey.Multiline = false;
            YoutubeAPIKey.Name = "YoutubeAPIKey";
            YoutubeAPIKey.ReadOnly = false;
            YoutubeAPIKey.Size = new Size(368, 23);
            YoutubeAPIKey.TabIndex = 3;
            YoutubeAPIKey.TextAlign = HorizontalAlignment.Left;
            YoutubeAPIKey.UseSystemPasswordChar = true;
            // 
            // nsLabel4
            // 
            nsLabel4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel4.Location = new Point(12, 148);
            nsLabel4.Name = "nsLabel4";
            nsLabel4.Size = new Size(143, 23);
            nsLabel4.TabIndex = 19;
            nsLabel4.Text = "nsLabel4";
            nsLabel4.Value1 = "Discord Bot Token:";
            nsLabel4.Value2 = " ";
            // 
            // YoutubeAppName
            // 
            YoutubeAppName.Location = new Point(161, 119);
            YoutubeAppName.MaxLength = 32767;
            YoutubeAppName.Multiline = false;
            YoutubeAppName.Name = "YoutubeAppName";
            YoutubeAppName.ReadOnly = false;
            YoutubeAppName.Size = new Size(368, 23);
            YoutubeAppName.TabIndex = 4;
            YoutubeAppName.TextAlign = HorizontalAlignment.Left;
            YoutubeAppName.UseSystemPasswordChar = true;
            // 
            // nsLabel3
            // 
            nsLabel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel3.Location = new Point(12, 119);
            nsLabel3.Name = "nsLabel3";
            nsLabel3.Size = new Size(143, 23);
            nsLabel3.TabIndex = 18;
            nsLabel3.Text = "nsLabel3";
            nsLabel3.Value1 = "Youtube API Name:";
            nsLabel3.Value2 = " ";
            // 
            // DiscordBotToken
            // 
            DiscordBotToken.Location = new Point(161, 148);
            DiscordBotToken.MaxLength = 32767;
            DiscordBotToken.Multiline = false;
            DiscordBotToken.Name = "DiscordBotToken";
            DiscordBotToken.ReadOnly = false;
            DiscordBotToken.Size = new Size(368, 27);
            DiscordBotToken.TabIndex = 5;
            DiscordBotToken.TextAlign = HorizontalAlignment.Left;
            DiscordBotToken.UseSystemPasswordChar = true;
            // 
            // nsLabel2
            // 
            nsLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel2.Location = new Point(12, 90);
            nsLabel2.Name = "nsLabel2";
            nsLabel2.Size = new Size(134, 23);
            nsLabel2.TabIndex = 17;
            nsLabel2.Text = "nsLabel2";
            nsLabel2.Value1 = "Youtube API Key:";
            nsLabel2.Value2 = " ";
            // 
            // nsLabel1
            // 
            nsLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nsLabel1.Location = new Point(12, 61);
            nsLabel1.Name = "nsLabel1";
            nsLabel1.Size = new Size(134, 23);
            nsLabel1.TabIndex = 16;
            nsLabel1.Text = "nsLabel1";
            nsLabel1.Value1 = "ChatGPT API Key:";
            nsLabel1.Value2 = " ";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(539, 24);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load...";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save as...";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // nsGroupBox6
            // 
            nsGroupBox6.BackColor = Color.FromArgb(30, 30, 30);
            nsGroupBox6.Controls.Add(nsButton1);
            nsGroupBox6.DrawSeperator = false;
            nsGroupBox6.Location = new Point(0, 287);
            nsGroupBox6.Name = "nsGroupBox6";
            nsGroupBox6.Size = new Size(538, 85);
            nsGroupBox6.SubTitle = "";
            nsGroupBox6.TabIndex = 38;
            nsGroupBox6.Text = "nsGroupBox6";
            nsGroupBox6.Title = "";
            // 
            // nsButton1
            // 
            nsButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nsButton1.Location = new Point(7, 6);
            nsButton1.Name = "nsButton1";
            nsButton1.Size = new Size(525, 73);
            nsButton1.TabIndex = 0;
            nsButton1.Text = "Save Settings...";
            nsButton1.Click += nsButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(661, 378);
            Controls.Add(nsTabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bot ENV Configuration";
            Load += Form1_Load;
            nsTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            nsGroupBox1.ResumeLayout(false);
            nsGroupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            nsGroupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NSTabControl nsTabControl1;
        private TabPage tabPage1;
        private NSGroupBox nsGroupBox1;
        private NSCheckBox nsCheckBox1;
        private NSLabel nsLabel6;
        private NSLabel nsLabel4;
        private NSLabel nsLabel3;
        private NSLabel nsLabel2;
        private NSLabel nsLabel1;
        private NSGroupBox nsGroupBox6;
        public NSButton nsButton1;
        public NSTextBox GptApiKey;
        public NSTextBox YoutubeAPIKey;
        public NSTextBox YoutubeAppName;
        public NSTextBox DiscordBotToken;
        private NSTextBox nsTextBox8;
        private NSLabel nsLabel5;
        public NSTextBox mongoDBURL;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}
