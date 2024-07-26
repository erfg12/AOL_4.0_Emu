namespace aol.Forms
{
    partial class instant_message
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
            messagesBox = new System.Windows.Forms.RichTextBox();
            myMessageBox = new System.Windows.Forms.RichTextBox();
            sendBtn = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new System.Windows.Forms.Panel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            imageOrSoundFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            recordSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            smileyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SmiliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            frowningCtrl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            winkingCtrl3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pStickingouttongueCtrl4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            oSurprisedCtrl5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kissingCtrl6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oYellingCtrl7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            coolCtrl8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            moneymouthCtrlShift1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            footinmouthCtrlShift2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            embarrassedCtrlShift3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oInnocentCtrlShift4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            undecidedCtrlShift5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cryingCtrlShift6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            xLipsaresealedCtrlShift7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dLaughingCtrlShift8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            textFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // messagesBox
            // 
            messagesBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messagesBox.Location = new System.Drawing.Point(8, 77);
            messagesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            messagesBox.Name = "messagesBox";
            messagesBox.ReadOnly = true;
            messagesBox.Size = new System.Drawing.Size(695, 301);
            messagesBox.TabIndex = 4;
            messagesBox.Text = "";
            // 
            // myMessageBox
            // 
            myMessageBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            myMessageBox.Location = new System.Drawing.Point(8, 390);
            myMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            myMessageBox.Name = "myMessageBox";
            myMessageBox.Size = new System.Drawing.Size(695, 86);
            myMessageBox.TabIndex = 5;
            myMessageBox.Text = "";
            myMessageBox.KeyDown += myMessageBox_KeyDown;
            // 
            // sendBtn
            // 
            sendBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            sendBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sendBtn.ForeColor = System.Drawing.SystemColors.Control;
            sendBtn.Location = new System.Drawing.Point(628, 486);
            sendBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new System.Drawing.Size(76, 78);
            sendBtn.TabIndex = 6;
            sendBtn.Text = "SEND";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new System.Drawing.Point(3, 34);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(704, 34);
            panel2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, insertToolStripMenuItem, peopleToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(232, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { imageOrSoundFileToolStripMenuItem, recordSoundToolStripMenuItem, hyperlinkToolStripMenuItem, smileyToolStripMenuItem, textFromFileToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // imageOrSoundFileToolStripMenuItem
            // 
            imageOrSoundFileToolStripMenuItem.Name = "imageOrSoundFileToolStripMenuItem";
            imageOrSoundFileToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            imageOrSoundFileToolStripMenuItem.Text = "Image or Sound File...";
            // 
            // recordSoundToolStripMenuItem
            // 
            recordSoundToolStripMenuItem.Name = "recordSoundToolStripMenuItem";
            recordSoundToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            recordSoundToolStripMenuItem.Text = "Record Sound...";
            // 
            // hyperlinkToolStripMenuItem
            // 
            hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem";
            hyperlinkToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            hyperlinkToolStripMenuItem.Text = "Hyperlink...";
            // 
            // smileyToolStripMenuItem
            // 
            smileyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SmiliesToolStripMenuItem, frowningCtrl2ToolStripMenuItem, winkingCtrl3ToolStripMenuItem, pStickingouttongueCtrl4ToolStripMenuItem, toolStripSeparator1, oSurprisedCtrl5ToolStripMenuItem, kissingCtrl6ToolStripMenuItem, oYellingCtrl7ToolStripMenuItem, coolCtrl8ToolStripMenuItem, toolStripSeparator2, moneymouthCtrlShift1ToolStripMenuItem, footinmouthCtrlShift2ToolStripMenuItem, embarrassedCtrlShift3ToolStripMenuItem, oInnocentCtrlShift4ToolStripMenuItem, toolStripSeparator3, undecidedCtrlShift5ToolStripMenuItem, cryingCtrlShift6ToolStripMenuItem, xLipsaresealedCtrlShift7ToolStripMenuItem, dLaughingCtrlShift8ToolStripMenuItem });
            smileyToolStripMenuItem.Name = "smileyToolStripMenuItem";
            smileyToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            smileyToolStripMenuItem.Text = "Smiley";
            // 
            // SmiliesToolStripMenuItem
            // 
            SmiliesToolStripMenuItem.Image = Properties.Resources.Smiling;
            SmiliesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SmiliesToolStripMenuItem.Name = "SmiliesToolStripMenuItem";
            SmiliesToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            SmiliesToolStripMenuItem.Text = ":-)          Smiling                             Ctrl+1";
            SmiliesToolStripMenuItem.Click += SmiliesToolStripMenuItem_Click;
            // 
            // frowningCtrl2ToolStripMenuItem
            // 
            frowningCtrl2ToolStripMenuItem.Image = Properties.Resources.Frowning;
            frowningCtrl2ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            frowningCtrl2ToolStripMenuItem.Name = "frowningCtrl2ToolStripMenuItem";
            frowningCtrl2ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            frowningCtrl2ToolStripMenuItem.Text = ":-(          Frowning                          Ctrl+2";
            frowningCtrl2ToolStripMenuItem.Click += frowningCtrl2ToolStripMenuItem_Click;
            // 
            // winkingCtrl3ToolStripMenuItem
            // 
            winkingCtrl3ToolStripMenuItem.Image = Properties.Resources.Winking;
            winkingCtrl3ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            winkingCtrl3ToolStripMenuItem.Name = "winkingCtrl3ToolStripMenuItem";
            winkingCtrl3ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            winkingCtrl3ToolStripMenuItem.Text = ";-)          Winking                            Ctrl+3";
            winkingCtrl3ToolStripMenuItem.Click += winkingCtrl3ToolStripMenuItem_Click;
            // 
            // pStickingouttongueCtrl4ToolStripMenuItem
            // 
            pStickingouttongueCtrl4ToolStripMenuItem.Image = Properties.Resources.Sticking_out_tongue;
            pStickingouttongueCtrl4ToolStripMenuItem.Name = "pStickingouttongueCtrl4ToolStripMenuItem";
            pStickingouttongueCtrl4ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            pStickingouttongueCtrl4ToolStripMenuItem.Text = ":-P         Sticking-out-tongue       Ctrl+4";
            pStickingouttongueCtrl4ToolStripMenuItem.Click += pStickingouttongueCtrl4ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(393, 6);
            // 
            // oSurprisedCtrl5ToolStripMenuItem
            // 
            oSurprisedCtrl5ToolStripMenuItem.Image = Properties.Resources.Surprised;
            oSurprisedCtrl5ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            oSurprisedCtrl5ToolStripMenuItem.Name = "oSurprisedCtrl5ToolStripMenuItem";
            oSurprisedCtrl5ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            oSurprisedCtrl5ToolStripMenuItem.Text = "=-O       Surprised                          Ctrl+5";
            oSurprisedCtrl5ToolStripMenuItem.Click += oSurprisedCtrl5ToolStripMenuItem_Click;
            // 
            // kissingCtrl6ToolStripMenuItem
            // 
            kissingCtrl6ToolStripMenuItem.Image = Properties.Resources.Kissing;
            kissingCtrl6ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            kissingCtrl6ToolStripMenuItem.Name = "kissingCtrl6ToolStripMenuItem";
            kissingCtrl6ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            kissingCtrl6ToolStripMenuItem.Text = ":-*          Kissing                              Ctrl+6";
            kissingCtrl6ToolStripMenuItem.Click += kissingCtrl6ToolStripMenuItem_Click;
            // 
            // oYellingCtrl7ToolStripMenuItem
            // 
            oYellingCtrl7ToolStripMenuItem.Image = Properties.Resources.Yelling;
            oYellingCtrl7ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            oYellingCtrl7ToolStripMenuItem.Name = "oYellingCtrl7ToolStripMenuItem";
            oYellingCtrl7ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            oYellingCtrl7ToolStripMenuItem.Text = ">:o        Yelling                               Ctrl+7";
            oYellingCtrl7ToolStripMenuItem.Click += oYellingCtrl7ToolStripMenuItem_Click;
            // 
            // coolCtrl8ToolStripMenuItem
            // 
            coolCtrl8ToolStripMenuItem.Image = Properties.Resources.Cool;
            coolCtrl8ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            coolCtrl8ToolStripMenuItem.Name = "coolCtrl8ToolStripMenuItem";
            coolCtrl8ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            coolCtrl8ToolStripMenuItem.Text = "8-)         Cool                                  Ctrl+8";
            coolCtrl8ToolStripMenuItem.Click += coolCtrl8ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(393, 6);
            // 
            // moneymouthCtrlShift1ToolStripMenuItem
            // 
            moneymouthCtrlShift1ToolStripMenuItem.Image = Properties.Resources.Money_mouth;
            moneymouthCtrlShift1ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            moneymouthCtrlShift1ToolStripMenuItem.Name = "moneymouthCtrlShift1ToolStripMenuItem";
            moneymouthCtrlShift1ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            moneymouthCtrlShift1ToolStripMenuItem.Text = ":-$         Money-mouth                 Ctrl+Shift+1";
            moneymouthCtrlShift1ToolStripMenuItem.Click += moneymouthCtrlShift1ToolStripMenuItem_Click;
            // 
            // footinmouthCtrlShift2ToolStripMenuItem
            // 
            footinmouthCtrlShift2ToolStripMenuItem.Image = Properties.Resources.Foot_in_mouth;
            footinmouthCtrlShift2ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            footinmouthCtrlShift2ToolStripMenuItem.Name = "footinmouthCtrlShift2ToolStripMenuItem";
            footinmouthCtrlShift2ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            footinmouthCtrlShift2ToolStripMenuItem.Text = ":-!          Foot-in-mouth                Ctrl+Shift+2";
            footinmouthCtrlShift2ToolStripMenuItem.Click += footinmouthCtrlShift2ToolStripMenuItem_Click;
            // 
            // embarrassedCtrlShift3ToolStripMenuItem
            // 
            embarrassedCtrlShift3ToolStripMenuItem.Image = Properties.Resources.Embarrassed;
            embarrassedCtrlShift3ToolStripMenuItem.Name = "embarrassedCtrlShift3ToolStripMenuItem";
            embarrassedCtrlShift3ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            embarrassedCtrlShift3ToolStripMenuItem.Text = ":-[          Embarrassed                    Ctrl+Shift+3";
            embarrassedCtrlShift3ToolStripMenuItem.Click += embarrassedCtrlShift3ToolStripMenuItem_Click;
            // 
            // oInnocentCtrlShift4ToolStripMenuItem
            // 
            oInnocentCtrlShift4ToolStripMenuItem.Image = Properties.Resources.Innocent;
            oInnocentCtrlShift4ToolStripMenuItem.Name = "oInnocentCtrlShift4ToolStripMenuItem";
            oInnocentCtrlShift4ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            oInnocentCtrlShift4ToolStripMenuItem.Text = "O:-)       Innocent                           Ctrl+Shift+4";
            oInnocentCtrlShift4ToolStripMenuItem.Click += oInnocentCtrlShift4ToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(393, 6);
            // 
            // undecidedCtrlShift5ToolStripMenuItem
            // 
            undecidedCtrlShift5ToolStripMenuItem.Image = Properties.Resources.Undecided;
            undecidedCtrlShift5ToolStripMenuItem.Name = "undecidedCtrlShift5ToolStripMenuItem";
            undecidedCtrlShift5ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            undecidedCtrlShift5ToolStripMenuItem.Text = ":-\\          Undecided                        Ctrl+Shift+5";
            undecidedCtrlShift5ToolStripMenuItem.Click += undecidedCtrlShift5ToolStripMenuItem_Click;
            // 
            // cryingCtrlShift6ToolStripMenuItem
            // 
            cryingCtrlShift6ToolStripMenuItem.Image = Properties.Resources.Crying;
            cryingCtrlShift6ToolStripMenuItem.Name = "cryingCtrlShift6ToolStripMenuItem";
            cryingCtrlShift6ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            cryingCtrlShift6ToolStripMenuItem.Text = ":'(           Crying                               Ctrl+Shift+6";
            cryingCtrlShift6ToolStripMenuItem.Click += cryingCtrlShift6ToolStripMenuItem_Click;
            // 
            // xLipsaresealedCtrlShift7ToolStripMenuItem
            // 
            xLipsaresealedCtrlShift7ToolStripMenuItem.Image = Properties.Resources.Lips_are_sealed;
            xLipsaresealedCtrlShift7ToolStripMenuItem.Name = "xLipsaresealedCtrlShift7ToolStripMenuItem";
            xLipsaresealedCtrlShift7ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            xLipsaresealedCtrlShift7ToolStripMenuItem.Text = ":-X         Lips-are-sealed                Ctrl+Shift+7";
            xLipsaresealedCtrlShift7ToolStripMenuItem.Click += xLipsaresealedCtrlShift7ToolStripMenuItem_Click;
            // 
            // dLaughingCtrlShift8ToolStripMenuItem
            // 
            dLaughingCtrlShift8ToolStripMenuItem.Image = Properties.Resources.Laughing;
            dLaughingCtrlShift8ToolStripMenuItem.Name = "dLaughingCtrlShift8ToolStripMenuItem";
            dLaughingCtrlShift8ToolStripMenuItem.Size = new System.Drawing.Size(396, 26);
            dLaughingCtrlShift8ToolStripMenuItem.Text = ":-D         Laughing                          Ctrl+Shift+8";
            dLaughingCtrlShift8ToolStripMenuItem.Click += dLaughingCtrlShift8ToolStripMenuItem_Click;
            // 
            // textFromFileToolStripMenuItem
            // 
            textFromFileToolStripMenuItem.Name = "textFromFileToolStripMenuItem";
            textFromFileToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            textFromFileToolStripMenuItem.Text = "Text from File...";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            peopleToolStripMenuItem.Text = "People";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(705, 28);
            panel1.TabIndex = 3;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(32, 5);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(115, 20);
            mainTitle.TabIndex = 12;
            mainTitle.Text = "Instant Message";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(3, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 28);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(4, 5);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(0, 20);
            titleLabel.TabIndex = 3;
            // 
            // miniBtn
            // 
            miniBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            miniBtn.BackColor = System.Drawing.SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            miniBtn.ForeColor = System.Drawing.Color.Black;
            miniBtn.Location = new System.Drawing.Point(629, 2);
            miniBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(24, 25);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += miniBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxBtn.BackColor = System.Drawing.SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(653, 2);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(24, 25);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += maxBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeBtn.BackColor = System.Drawing.SystemColors.Control;
            closeBtn.BackgroundImage = Properties.Resources.close_btn;
            closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            closeBtn.ForeColor = System.Drawing.Color.Black;
            closeBtn.Location = new System.Drawing.Point(680, 2);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(24, 25);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // instant_message
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(711, 583);
            Controls.Add(panel2);
            Controls.Add(sendBtn);
            Controls.Add(myMessageBox);
            Controls.Add(messagesBox);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(5, 120);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "instant_message";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "instant_message";
            Load += instant_message_Load;
            Shown += instant_message_Shown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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