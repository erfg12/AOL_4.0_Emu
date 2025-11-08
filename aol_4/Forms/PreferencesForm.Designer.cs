namespace aol.Forms
{
    partial class PreferencesForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PreferencesForm));
            TitleBar = new Panel();
            pictureBox22 = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            helpBtn = new Button();
            generalBtn = new PictureBox();
            toolbarBtn = new PictureBox();
            wwwBtn = new PictureBox();
            mailBtn = new PictureBox();
            downloadBtn = new PictureBox();
            chatBtn = new PictureBox();
            fontBtn = new PictureBox();
            spellingBtn = new PictureBox();
            FilingCabinetBtn = new PictureBox();
            autoAOLBtn = new PictureBox();
            passwordsBtn = new PictureBox();
            graphicsBtn = new PictureBox();
            marketingBtn = new PictureBox();
            languageBtn = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox22).BeginInit();
            ((ISupportInitialize)generalBtn).BeginInit();
            ((ISupportInitialize)toolbarBtn).BeginInit();
            ((ISupportInitialize)wwwBtn).BeginInit();
            ((ISupportInitialize)mailBtn).BeginInit();
            ((ISupportInitialize)downloadBtn).BeginInit();
            ((ISupportInitialize)chatBtn).BeginInit();
            ((ISupportInitialize)fontBtn).BeginInit();
            ((ISupportInitialize)spellingBtn).BeginInit();
            ((ISupportInitialize)FilingCabinetBtn).BeginInit();
            ((ISupportInitialize)autoAOLBtn).BeginInit();
            ((ISupportInitialize)passwordsBtn).BeginInit();
            ((ISupportInitialize)graphicsBtn).BeginInit();
            ((ISupportInitialize)marketingBtn).BeginInit();
            ((ISupportInitialize)languageBtn).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSize = true;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(pictureBox22);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(515, 25);
            TitleBar.TabIndex = 4;
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = Color.Transparent;
            pictureBox22.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox22.Image = Properties.Resources.aol_icon_4;
            pictureBox22.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox22.Location = new Point(3, 0);
            pictureBox22.Margin = new Padding(4);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(21, 21);
            pictureBox22.TabIndex = 9;
            pictureBox22.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(27, 4);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Preferences";
            // 
            // miniBtn
            // 
            miniBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            miniBtn.BackColor = SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = ImageLayout.Stretch;
            miniBtn.FlatStyle = FlatStyle.Flat;
            miniBtn.Font = new Font("Microsoft Sans Serif", 6F);
            miniBtn.ForeColor = Color.Black;
            miniBtn.Location = new Point(449, 1);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxBtn.BackColor = SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.Enabled = false;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(470, 1);
            maxBtn.Margin = new Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = RightToLeft.No;
            maxBtn.Size = new Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.BackColor = SystemColors.Control;
            closeBtn.BackgroundImage = Properties.Resources.close_btn;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Microsoft Sans Serif", 6F);
            closeBtn.ForeColor = Color.Black;
            closeBtn.Location = new Point(494, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(6, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 5;
            label1.Text = "Preferences";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 251, 240);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.Location = new Point(13, 58);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(494, 54);
            textBox1.TabIndex = 6;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // helpBtn
            // 
            helpBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            helpBtn.BackColor = Color.FromArgb(0, 109, 170);
            helpBtn.Cursor = Cursors.Hand;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            helpBtn.ForeColor = SystemColors.Control;
            helpBtn.Location = new Point(434, 341);
            helpBtn.Margin = new Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(74, 26);
            helpBtn.TabIndex = 7;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // generalBtn
            // 
            generalBtn.BackgroundImage = (Image)resources.GetObject("generalBtn.BackgroundImage");
            generalBtn.BackgroundImageLayout = ImageLayout.Stretch;
            generalBtn.Cursor = Cursors.Hand;
            generalBtn.Location = new Point(29, 119);
            generalBtn.Margin = new Padding(4);
            generalBtn.Name = "generalBtn";
            generalBtn.Size = new Size(52, 51);
            generalBtn.TabIndex = 8;
            generalBtn.TabStop = false;
            generalBtn.Click += GeneralBtn_Click;
            // 
            // toolbarBtn
            // 
            toolbarBtn.BackgroundImage = (Image)resources.GetObject("toolbarBtn.BackgroundImage");
            toolbarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            toolbarBtn.Cursor = Cursors.Hand;
            toolbarBtn.Location = new Point(111, 119);
            toolbarBtn.Margin = new Padding(4);
            toolbarBtn.Name = "toolbarBtn";
            toolbarBtn.Size = new Size(52, 51);
            toolbarBtn.TabIndex = 9;
            toolbarBtn.TabStop = false;
            // 
            // wwwBtn
            // 
            wwwBtn.BackgroundImage = (Image)resources.GetObject("wwwBtn.BackgroundImage");
            wwwBtn.BackgroundImageLayout = ImageLayout.Stretch;
            wwwBtn.Cursor = Cursors.Hand;
            wwwBtn.Location = new Point(274, 119);
            wwwBtn.Margin = new Padding(4);
            wwwBtn.Name = "wwwBtn";
            wwwBtn.Size = new Size(52, 51);
            wwwBtn.TabIndex = 11;
            wwwBtn.TabStop = false;
            // 
            // mailBtn
            // 
            mailBtn.BackgroundImage = (Image)resources.GetObject("mailBtn.BackgroundImage");
            mailBtn.BackgroundImageLayout = ImageLayout.Stretch;
            mailBtn.Cursor = Cursors.Hand;
            mailBtn.Location = new Point(192, 119);
            mailBtn.Margin = new Padding(4);
            mailBtn.Name = "mailBtn";
            mailBtn.Size = new Size(52, 51);
            mailBtn.TabIndex = 10;
            mailBtn.TabStop = false;
            // 
            // downloadBtn
            // 
            downloadBtn.BackgroundImage = (Image)resources.GetObject("downloadBtn.BackgroundImage");
            downloadBtn.BackgroundImageLayout = ImageLayout.Stretch;
            downloadBtn.Cursor = Cursors.Hand;
            downloadBtn.Location = new Point(438, 119);
            downloadBtn.Margin = new Padding(4);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(52, 51);
            downloadBtn.TabIndex = 13;
            downloadBtn.TabStop = false;
            // 
            // chatBtn
            // 
            chatBtn.BackgroundImage = (Image)resources.GetObject("chatBtn.BackgroundImage");
            chatBtn.BackgroundImageLayout = ImageLayout.Stretch;
            chatBtn.Cursor = Cursors.Hand;
            chatBtn.Location = new Point(356, 119);
            chatBtn.Margin = new Padding(4);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(52, 51);
            chatBtn.TabIndex = 12;
            chatBtn.TabStop = false;
            // 
            // fontBtn
            // 
            fontBtn.BackgroundImage = (Image)resources.GetObject("fontBtn.BackgroundImage");
            fontBtn.BackgroundImageLayout = ImageLayout.Stretch;
            fontBtn.Cursor = Cursors.Hand;
            fontBtn.Location = new Point(438, 205);
            fontBtn.Margin = new Padding(4);
            fontBtn.Name = "fontBtn";
            fontBtn.Size = new Size(52, 51);
            fontBtn.TabIndex = 19;
            fontBtn.TabStop = false;
            // 
            // spellingBtn
            // 
            spellingBtn.BackgroundImage = (Image)resources.GetObject("spellingBtn.BackgroundImage");
            spellingBtn.BackgroundImageLayout = ImageLayout.Stretch;
            spellingBtn.Cursor = Cursors.Hand;
            spellingBtn.Location = new Point(356, 205);
            spellingBtn.Margin = new Padding(4);
            spellingBtn.Name = "spellingBtn";
            spellingBtn.Size = new Size(52, 51);
            spellingBtn.TabIndex = 18;
            spellingBtn.TabStop = false;
            // 
            // FilingCabinetBtn
            // 
            FilingCabinetBtn.BackgroundImage = (Image)resources.GetObject("FilingCabinetBtn.BackgroundImage");
            FilingCabinetBtn.BackgroundImageLayout = ImageLayout.Stretch;
            FilingCabinetBtn.Cursor = Cursors.Hand;
            FilingCabinetBtn.Location = new Point(274, 205);
            FilingCabinetBtn.Margin = new Padding(4);
            FilingCabinetBtn.Name = "FilingCabinetBtn";
            FilingCabinetBtn.Size = new Size(52, 51);
            FilingCabinetBtn.TabIndex = 17;
            FilingCabinetBtn.TabStop = false;
            // 
            // autoAOLBtn
            // 
            autoAOLBtn.BackgroundImage = (Image)resources.GetObject("autoAOLBtn.BackgroundImage");
            autoAOLBtn.BackgroundImageLayout = ImageLayout.Stretch;
            autoAOLBtn.Cursor = Cursors.Hand;
            autoAOLBtn.Location = new Point(192, 205);
            autoAOLBtn.Margin = new Padding(4);
            autoAOLBtn.Name = "autoAOLBtn";
            autoAOLBtn.Size = new Size(52, 51);
            autoAOLBtn.TabIndex = 16;
            autoAOLBtn.TabStop = false;
            // 
            // passwordsBtn
            // 
            passwordsBtn.BackgroundImage = (Image)resources.GetObject("passwordsBtn.BackgroundImage");
            passwordsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            passwordsBtn.Cursor = Cursors.Hand;
            passwordsBtn.Location = new Point(111, 205);
            passwordsBtn.Margin = new Padding(4);
            passwordsBtn.Name = "passwordsBtn";
            passwordsBtn.Size = new Size(52, 51);
            passwordsBtn.TabIndex = 15;
            passwordsBtn.TabStop = false;
            // 
            // graphicsBtn
            // 
            graphicsBtn.BackgroundImage = (Image)resources.GetObject("graphicsBtn.BackgroundImage");
            graphicsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            graphicsBtn.Cursor = Cursors.Hand;
            graphicsBtn.Location = new Point(29, 205);
            graphicsBtn.Margin = new Padding(4);
            graphicsBtn.Name = "graphicsBtn";
            graphicsBtn.Size = new Size(52, 51);
            graphicsBtn.TabIndex = 14;
            graphicsBtn.TabStop = false;
            // 
            // marketingBtn
            // 
            marketingBtn.BackgroundImage = (Image)resources.GetObject("marketingBtn.BackgroundImage");
            marketingBtn.BackgroundImageLayout = ImageLayout.Stretch;
            marketingBtn.Cursor = Cursors.Hand;
            marketingBtn.Location = new Point(111, 289);
            marketingBtn.Margin = new Padding(4);
            marketingBtn.Name = "marketingBtn";
            marketingBtn.Size = new Size(52, 51);
            marketingBtn.TabIndex = 21;
            marketingBtn.TabStop = false;
            // 
            // languageBtn
            // 
            languageBtn.BackgroundImage = (Image)resources.GetObject("languageBtn.BackgroundImage");
            languageBtn.BackgroundImageLayout = ImageLayout.Stretch;
            languageBtn.Cursor = Cursors.Hand;
            languageBtn.Location = new Point(29, 289);
            languageBtn.Margin = new Padding(4);
            languageBtn.Name = "languageBtn";
            languageBtn.Size = new Size(52, 51);
            languageBtn.TabIndex = 20;
            languageBtn.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(29, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 22;
            label2.Text = "General";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(111, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 23;
            label3.Text = "Toolbar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(204, 173);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 24;
            label4.Text = "Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(276, 173);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 25;
            label5.Text = "WWW";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(365, 173);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 26;
            label6.Text = "Chat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.Location = new Point(431, 173);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 27;
            label7.Text = "Download";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.Location = new Point(25, 260);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 28;
            label8.Text = "Graphics";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.Location = new Point(104, 260);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 29;
            label9.Text = "Passwords";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label10.Location = new Point(188, 260);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 30;
            label10.Text = "Auto AOL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.Location = new Point(272, 260);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 31;
            label11.Text = "Personal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.Location = new Point(260, 277);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 32;
            label12.Text = "Filing Cabinet";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label13.Location = new Point(356, 260);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 33;
            label13.Text = "Spelling";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label14.Location = new Point(448, 260);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 34;
            label14.Text = "Font";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label15.Location = new Point(24, 343);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 35;
            label15.Text = "Language";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label16.Location = new Point(105, 343);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 36;
            label16.Text = "Marketing";
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(521, 385);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(marketingBtn);
            Controls.Add(languageBtn);
            Controls.Add(fontBtn);
            Controls.Add(spellingBtn);
            Controls.Add(FilingCabinetBtn);
            Controls.Add(autoAOLBtn);
            Controls.Add(passwordsBtn);
            Controls.Add(graphicsBtn);
            Controls.Add(downloadBtn);
            Controls.Add(chatBtn);
            Controls.Add(wwwBtn);
            Controls.Add(mailBtn);
            Controls.Add(toolbarBtn);
            Controls.Add(generalBtn);
            Controls.Add(helpBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 180);
            Margin = new Padding(4);
            Name = "PreferencesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Preferences";
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox22).EndInit();
            ((ISupportInitialize)generalBtn).EndInit();
            ((ISupportInitialize)toolbarBtn).EndInit();
            ((ISupportInitialize)wwwBtn).EndInit();
            ((ISupportInitialize)mailBtn).EndInit();
            ((ISupportInitialize)downloadBtn).EndInit();
            ((ISupportInitialize)chatBtn).EndInit();
            ((ISupportInitialize)fontBtn).EndInit();
            ((ISupportInitialize)spellingBtn).EndInit();
            ((ISupportInitialize)FilingCabinetBtn).EndInit();
            ((ISupportInitialize)autoAOLBtn).EndInit();
            ((ISupportInitialize)passwordsBtn).EndInit();
            ((ISupportInitialize)graphicsBtn).EndInit();
            ((ISupportInitialize)marketingBtn).EndInit();
            ((ISupportInitialize)languageBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.PictureBox generalBtn;
        private System.Windows.Forms.PictureBox toolbarBtn;
        private System.Windows.Forms.PictureBox wwwBtn;
        private System.Windows.Forms.PictureBox mailBtn;
        private System.Windows.Forms.PictureBox downloadBtn;
        private System.Windows.Forms.PictureBox chatBtn;
        private System.Windows.Forms.PictureBox fontBtn;
        private System.Windows.Forms.PictureBox spellingBtn;
        private System.Windows.Forms.PictureBox FilingCabinetBtn;
        private System.Windows.Forms.PictureBox autoAOLBtn;
        private System.Windows.Forms.PictureBox passwordsBtn;
        private System.Windows.Forms.PictureBox graphicsBtn;
        private System.Windows.Forms.PictureBox marketingBtn;
        private System.Windows.Forms.PictureBox languageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}