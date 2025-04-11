namespace aol.Forms
{
    partial class InstantMessageForm
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
            messagesBox = new RichTextBox();
            myMessageBox = new RichTextBox();
            sendBtn = new Button();
            backgroundWorker1 = new BackgroundWorker();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            imageOrSoundFileToolStripMenuItem = new ToolStripMenuItem();
            recordSoundToolStripMenuItem = new ToolStripMenuItem();
            hyperlinkToolStripMenuItem = new ToolStripMenuItem();
            smileyToolStripMenuItem = new ToolStripMenuItem();
            SmiliesToolStripMenuItem = new ToolStripMenuItem();
            frowningCtrl2ToolStripMenuItem = new ToolStripMenuItem();
            winkingCtrl3ToolStripMenuItem = new ToolStripMenuItem();
            pStickingouttongueCtrl4ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            oSurprisedCtrl5ToolStripMenuItem = new ToolStripMenuItem();
            kissingCtrl6ToolStripMenuItem = new ToolStripMenuItem();
            oYellingCtrl7ToolStripMenuItem = new ToolStripMenuItem();
            coolCtrl8ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            moneymouthCtrlShift1ToolStripMenuItem = new ToolStripMenuItem();
            footinmouthCtrlShift2ToolStripMenuItem = new ToolStripMenuItem();
            embarrassedCtrlShift3ToolStripMenuItem = new ToolStripMenuItem();
            oInnocentCtrlShift4ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            undecidedCtrlShift5ToolStripMenuItem = new ToolStripMenuItem();
            cryingCtrlShift6ToolStripMenuItem = new ToolStripMenuItem();
            xLipsaresealedCtrlShift7ToolStripMenuItem = new ToolStripMenuItem();
            dLaughingCtrlShift8ToolStripMenuItem = new ToolStripMenuItem();
            textFromFileToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            mainTitle = new Label();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // messagesBox
            // 
            messagesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messagesBox.Location = new Point(7, 58);
            messagesBox.Margin = new Padding(4);
            messagesBox.Name = "messagesBox";
            messagesBox.ReadOnly = true;
            messagesBox.Size = new Size(609, 227);
            messagesBox.TabIndex = 4;
            messagesBox.Text = "";
            // 
            // myMessageBox
            // 
            myMessageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myMessageBox.Location = new Point(7, 292);
            myMessageBox.Margin = new Padding(4);
            myMessageBox.Name = "myMessageBox";
            myMessageBox.Size = new Size(609, 66);
            myMessageBox.TabIndex = 5;
            myMessageBox.Text = "";
            myMessageBox.KeyDown += MyMessageBox_KeyDown;
            // 
            // sendBtn
            // 
            sendBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendBtn.BackColor = Color.FromArgb(0, 109, 170);
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.ForeColor = SystemColors.Control;
            sendBtn.Location = new Point(550, 364);
            sendBtn.Margin = new Padding(4);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(66, 58);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "SEND";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += BackgroundWorker_DoWork;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(3, 26);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 26);
            panel2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, insertToolStripMenuItem, peopleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(188, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageOrSoundFileToolStripMenuItem, recordSoundToolStripMenuItem, hyperlinkToolStripMenuItem, smileyToolStripMenuItem, textFromFileToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(48, 20);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // imageOrSoundFileToolStripMenuItem
            // 
            imageOrSoundFileToolStripMenuItem.Name = "imageOrSoundFileToolStripMenuItem";
            imageOrSoundFileToolStripMenuItem.Size = new Size(188, 22);
            imageOrSoundFileToolStripMenuItem.Text = "Image or Sound File...";
            // 
            // recordSoundToolStripMenuItem
            // 
            recordSoundToolStripMenuItem.Name = "recordSoundToolStripMenuItem";
            recordSoundToolStripMenuItem.Size = new Size(188, 22);
            recordSoundToolStripMenuItem.Text = "Record Sound...";
            // 
            // hyperlinkToolStripMenuItem
            // 
            hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem";
            hyperlinkToolStripMenuItem.Size = new Size(188, 22);
            hyperlinkToolStripMenuItem.Text = "Hyperlink...";
            // 
            // smileyToolStripMenuItem
            // 
            smileyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SmiliesToolStripMenuItem, frowningCtrl2ToolStripMenuItem, winkingCtrl3ToolStripMenuItem, pStickingouttongueCtrl4ToolStripMenuItem, toolStripSeparator1, oSurprisedCtrl5ToolStripMenuItem, kissingCtrl6ToolStripMenuItem, oYellingCtrl7ToolStripMenuItem, coolCtrl8ToolStripMenuItem, toolStripSeparator2, moneymouthCtrlShift1ToolStripMenuItem, footinmouthCtrlShift2ToolStripMenuItem, embarrassedCtrlShift3ToolStripMenuItem, oInnocentCtrlShift4ToolStripMenuItem, toolStripSeparator3, undecidedCtrlShift5ToolStripMenuItem, cryingCtrlShift6ToolStripMenuItem, xLipsaresealedCtrlShift7ToolStripMenuItem, dLaughingCtrlShift8ToolStripMenuItem });
            smileyToolStripMenuItem.Name = "smileyToolStripMenuItem";
            smileyToolStripMenuItem.Size = new Size(188, 22);
            smileyToolStripMenuItem.Text = "Smiley";
            // 
            // SmiliesToolStripMenuItem
            // 
            SmiliesToolStripMenuItem.Image = Properties.Resources.Smiling;
            SmiliesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            SmiliesToolStripMenuItem.Name = "SmiliesToolStripMenuItem";
            SmiliesToolStripMenuItem.Size = new Size(311, 22);
            SmiliesToolStripMenuItem.Text = ":-)          Smiling                             Ctrl+1";
            SmiliesToolStripMenuItem.Click += SmiliesToolStripMenuItem_Click;
            // 
            // frowningCtrl2ToolStripMenuItem
            // 
            frowningCtrl2ToolStripMenuItem.Image = Properties.Resources.Frowning;
            frowningCtrl2ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            frowningCtrl2ToolStripMenuItem.Name = "frowningCtrl2ToolStripMenuItem";
            frowningCtrl2ToolStripMenuItem.Size = new Size(311, 22);
            frowningCtrl2ToolStripMenuItem.Text = ":-(          Frowning                          Ctrl+2";
            frowningCtrl2ToolStripMenuItem.Click += FrowningCtrl2ToolStripMenuItem_Click;
            // 
            // winkingCtrl3ToolStripMenuItem
            // 
            winkingCtrl3ToolStripMenuItem.Image = Properties.Resources.Winking;
            winkingCtrl3ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            winkingCtrl3ToolStripMenuItem.Name = "winkingCtrl3ToolStripMenuItem";
            winkingCtrl3ToolStripMenuItem.Size = new Size(311, 22);
            winkingCtrl3ToolStripMenuItem.Text = ";-)          Winking                            Ctrl+3";
            winkingCtrl3ToolStripMenuItem.Click += WinkingCtrl3ToolStripMenuItem_Click;
            // 
            // pStickingouttongueCtrl4ToolStripMenuItem
            // 
            pStickingouttongueCtrl4ToolStripMenuItem.Image = Properties.Resources.Sticking_out_tongue;
            pStickingouttongueCtrl4ToolStripMenuItem.Name = "pStickingouttongueCtrl4ToolStripMenuItem";
            pStickingouttongueCtrl4ToolStripMenuItem.Size = new Size(311, 22);
            pStickingouttongueCtrl4ToolStripMenuItem.Text = ":-P         Sticking-out-tongue       Ctrl+4";
            pStickingouttongueCtrl4ToolStripMenuItem.Click += PStickingouttongueCtrl4ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(308, 6);
            // 
            // oSurprisedCtrl5ToolStripMenuItem
            // 
            oSurprisedCtrl5ToolStripMenuItem.Image = Properties.Resources.Surprised;
            oSurprisedCtrl5ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            oSurprisedCtrl5ToolStripMenuItem.Name = "oSurprisedCtrl5ToolStripMenuItem";
            oSurprisedCtrl5ToolStripMenuItem.Size = new Size(311, 22);
            oSurprisedCtrl5ToolStripMenuItem.Text = "=-O       Surprised                          Ctrl+5";
            oSurprisedCtrl5ToolStripMenuItem.Click += OSurprisedCtrl5ToolStripMenuItem_Click;
            // 
            // kissingCtrl6ToolStripMenuItem
            // 
            kissingCtrl6ToolStripMenuItem.Image = Properties.Resources.Kissing;
            kissingCtrl6ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            kissingCtrl6ToolStripMenuItem.Name = "kissingCtrl6ToolStripMenuItem";
            kissingCtrl6ToolStripMenuItem.Size = new Size(311, 22);
            kissingCtrl6ToolStripMenuItem.Text = ":-*          Kissing                              Ctrl+6";
            kissingCtrl6ToolStripMenuItem.Click += KissingCtrl6ToolStripMenuItem_Click;
            // 
            // oYellingCtrl7ToolStripMenuItem
            // 
            oYellingCtrl7ToolStripMenuItem.Image = Properties.Resources.Yelling;
            oYellingCtrl7ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            oYellingCtrl7ToolStripMenuItem.Name = "oYellingCtrl7ToolStripMenuItem";
            oYellingCtrl7ToolStripMenuItem.Size = new Size(311, 22);
            oYellingCtrl7ToolStripMenuItem.Text = ">:o        Yelling                               Ctrl+7";
            oYellingCtrl7ToolStripMenuItem.Click += OYellingCtrl7ToolStripMenuItem_Click;
            // 
            // coolCtrl8ToolStripMenuItem
            // 
            coolCtrl8ToolStripMenuItem.Image = Properties.Resources.Cool;
            coolCtrl8ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            coolCtrl8ToolStripMenuItem.Name = "coolCtrl8ToolStripMenuItem";
            coolCtrl8ToolStripMenuItem.Size = new Size(311, 22);
            coolCtrl8ToolStripMenuItem.Text = "8-)         Cool                                  Ctrl+8";
            coolCtrl8ToolStripMenuItem.Click += CoolCtrl8ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(308, 6);
            // 
            // moneymouthCtrlShift1ToolStripMenuItem
            // 
            moneymouthCtrlShift1ToolStripMenuItem.Image = Properties.Resources.Money_mouth;
            moneymouthCtrlShift1ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            moneymouthCtrlShift1ToolStripMenuItem.Name = "moneymouthCtrlShift1ToolStripMenuItem";
            moneymouthCtrlShift1ToolStripMenuItem.Size = new Size(311, 22);
            moneymouthCtrlShift1ToolStripMenuItem.Text = ":-$         Money-mouth                 Ctrl+Shift+1";
            moneymouthCtrlShift1ToolStripMenuItem.Click += MoneymouthCtrlShift1ToolStripMenuItem_Click;
            // 
            // footinmouthCtrlShift2ToolStripMenuItem
            // 
            footinmouthCtrlShift2ToolStripMenuItem.Image = Properties.Resources.Foot_in_mouth;
            footinmouthCtrlShift2ToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            footinmouthCtrlShift2ToolStripMenuItem.Name = "footinmouthCtrlShift2ToolStripMenuItem";
            footinmouthCtrlShift2ToolStripMenuItem.Size = new Size(311, 22);
            footinmouthCtrlShift2ToolStripMenuItem.Text = ":-!          Foot-in-mouth                Ctrl+Shift+2";
            footinmouthCtrlShift2ToolStripMenuItem.Click += FootinmouthCtrlShift2ToolStripMenuItem_Click;
            // 
            // embarrassedCtrlShift3ToolStripMenuItem
            // 
            embarrassedCtrlShift3ToolStripMenuItem.Image = Properties.Resources.Embarrassed;
            embarrassedCtrlShift3ToolStripMenuItem.Name = "embarrassedCtrlShift3ToolStripMenuItem";
            embarrassedCtrlShift3ToolStripMenuItem.Size = new Size(311, 22);
            embarrassedCtrlShift3ToolStripMenuItem.Text = ":-[          Embarrassed                    Ctrl+Shift+3";
            embarrassedCtrlShift3ToolStripMenuItem.Click += EmbarrassedCtrlShift3ToolStripMenuItem_Click;
            // 
            // oInnocentCtrlShift4ToolStripMenuItem
            // 
            oInnocentCtrlShift4ToolStripMenuItem.Image = Properties.Resources.Innocent;
            oInnocentCtrlShift4ToolStripMenuItem.Name = "oInnocentCtrlShift4ToolStripMenuItem";
            oInnocentCtrlShift4ToolStripMenuItem.Size = new Size(311, 22);
            oInnocentCtrlShift4ToolStripMenuItem.Text = "O:-)       Innocent                           Ctrl+Shift+4";
            oInnocentCtrlShift4ToolStripMenuItem.Click += OInnocentCtrlShift4ToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(308, 6);
            // 
            // undecidedCtrlShift5ToolStripMenuItem
            // 
            undecidedCtrlShift5ToolStripMenuItem.Image = Properties.Resources.Undecided;
            undecidedCtrlShift5ToolStripMenuItem.Name = "undecidedCtrlShift5ToolStripMenuItem";
            undecidedCtrlShift5ToolStripMenuItem.Size = new Size(311, 22);
            undecidedCtrlShift5ToolStripMenuItem.Text = ":-\\          Undecided                        Ctrl+Shift+5";
            undecidedCtrlShift5ToolStripMenuItem.Click += UndecidedCtrlShift5ToolStripMenuItem_Click;
            // 
            // cryingCtrlShift6ToolStripMenuItem
            // 
            cryingCtrlShift6ToolStripMenuItem.Image = Properties.Resources.Crying;
            cryingCtrlShift6ToolStripMenuItem.Name = "cryingCtrlShift6ToolStripMenuItem";
            cryingCtrlShift6ToolStripMenuItem.Size = new Size(311, 22);
            cryingCtrlShift6ToolStripMenuItem.Text = ":'(           Crying                               Ctrl+Shift+6";
            cryingCtrlShift6ToolStripMenuItem.Click += CryingCtrlShift6ToolStripMenuItem_Click;
            // 
            // xLipsaresealedCtrlShift7ToolStripMenuItem
            // 
            xLipsaresealedCtrlShift7ToolStripMenuItem.Image = Properties.Resources.Lips_are_sealed;
            xLipsaresealedCtrlShift7ToolStripMenuItem.Name = "xLipsaresealedCtrlShift7ToolStripMenuItem";
            xLipsaresealedCtrlShift7ToolStripMenuItem.Size = new Size(311, 22);
            xLipsaresealedCtrlShift7ToolStripMenuItem.Text = ":-X         Lips-are-sealed                Ctrl+Shift+7";
            xLipsaresealedCtrlShift7ToolStripMenuItem.Click += XLipsaresealedCtrlShift7ToolStripMenuItem_Click;
            // 
            // dLaughingCtrlShift8ToolStripMenuItem
            // 
            dLaughingCtrlShift8ToolStripMenuItem.Image = Properties.Resources.Laughing;
            dLaughingCtrlShift8ToolStripMenuItem.Name = "dLaughingCtrlShift8ToolStripMenuItem";
            dLaughingCtrlShift8ToolStripMenuItem.Size = new Size(311, 22);
            dLaughingCtrlShift8ToolStripMenuItem.Text = ":-D         Laughing                          Ctrl+Shift+8";
            dLaughingCtrlShift8ToolStripMenuItem.Click += DLaughingCtrlShift8ToolStripMenuItem_Click;
            // 
            // textFromFileToolStripMenuItem
            // 
            textFromFileToolStripMenuItem.Name = "textFromFileToolStripMenuItem";
            textFromFileToolStripMenuItem.Size = new Size(188, 22);
            textFromFileToolStripMenuItem.Text = "Text from File...";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(55, 20);
            peopleToolStripMenuItem.Text = "People";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 21);
            panel1.TabIndex = 3;
            panel1.DoubleClick += TitleBar_DoubleClick;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(28, 4);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(92, 15);
            mainTitle.TabIndex = 12;
            mainTitle.Text = "Instant Message";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(4, 4);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 15);
            titleLabel.TabIndex = 3;
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
            miniBtn.Location = new Point(550, 2);
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
            maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(571, 2);
            maxBtn.Margin = new Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = RightToLeft.No;
            maxBtn.Size = new Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += MaxBtn_Click;
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
            closeBtn.Location = new Point(595, 2);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // InstantMessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 437);
            Controls.Add(panel2);
            Controls.Add(sendBtn);
            Controls.Add(myMessageBox);
            Controls.Add(messagesBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(5, 120);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "InstantMessageForm";
            StartPosition = FormStartPosition.Manual;
            Text = "instant_message";
            Shown += instant_message_Shown;
            LocationChanged += InstantMessageForm_LocationChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.RichTextBox myMessageBox;
        private System.Windows.Forms.Button sendBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox messagesBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageOrSoundFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hyperlinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smileyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmiliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frowningCtrl2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pStickingouttongueCtrl4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winkingCtrl3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem oSurprisedCtrl5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kissingCtrl6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oYellingCtrl7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coolCtrl8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem moneymouthCtrlShift1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem footinmouthCtrlShift2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embarrassedCtrlShift3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oInnocentCtrlShift4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem undecidedCtrlShift5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryingCtrlShift6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xLipsaresealedCtrlShift7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dLaughingCtrlShift8ToolStripMenuItem;
    }
}