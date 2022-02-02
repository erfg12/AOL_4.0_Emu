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
            this.messagesBox = new System.Windows.Forms.RichTextBox();
            this.myMessageBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOrSoundFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smileyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmiliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frowningCtrl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winkingCtrl3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pStickingouttongueCtrl4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.oSurprisedCtrl5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kissingCtrl6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oYellingCtrl7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coolCtrl8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moneymouthCtrlShift1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footinmouthCtrlShift2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embarrassedCtrlShift3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oInnocentCtrlShift4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.undecidedCtrlShift5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryingCtrlShift6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xLipsaresealedCtrlShift7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLaughingCtrlShift8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesBox
            // 
            this.messagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesBox.Location = new System.Drawing.Point(11, 96);
            this.messagesBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.ReadOnly = true;
            this.messagesBox.Size = new System.Drawing.Size(954, 375);
            this.messagesBox.TabIndex = 4;
            this.messagesBox.Text = "";
            // 
            // myMessageBox
            // 
            this.myMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myMessageBox.Location = new System.Drawing.Point(11, 487);
            this.myMessageBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.myMessageBox.Name = "myMessageBox";
            this.myMessageBox.Size = new System.Drawing.Size(954, 106);
            this.myMessageBox.TabIndex = 5;
            this.myMessageBox.Text = "";
            this.myMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myMessageBox_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendBtn.Location = new System.Drawing.Point(864, 608);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(104, 98);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(4, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 42);
            this.panel2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.peopleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(290, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageOrSoundFileToolStripMenuItem,
            this.recordSoundToolStripMenuItem,
            this.hyperlinkToolStripMenuItem,
            this.smileyToolStripMenuItem,
            this.textFromFileToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // imageOrSoundFileToolStripMenuItem
            // 
            this.imageOrSoundFileToolStripMenuItem.Name = "imageOrSoundFileToolStripMenuItem";
            this.imageOrSoundFileToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.imageOrSoundFileToolStripMenuItem.Text = "Image or Sound File...";
            // 
            // recordSoundToolStripMenuItem
            // 
            this.recordSoundToolStripMenuItem.Name = "recordSoundToolStripMenuItem";
            this.recordSoundToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.recordSoundToolStripMenuItem.Text = "Record Sound...";
            // 
            // hyperlinkToolStripMenuItem
            // 
            this.hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem";
            this.hyperlinkToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.hyperlinkToolStripMenuItem.Text = "Hyperlink...";
            // 
            // smileyToolStripMenuItem
            // 
            this.smileyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmiliesToolStripMenuItem,
            this.frowningCtrl2ToolStripMenuItem,
            this.winkingCtrl3ToolStripMenuItem,
            this.pStickingouttongueCtrl4ToolStripMenuItem,
            this.toolStripSeparator1,
            this.oSurprisedCtrl5ToolStripMenuItem,
            this.kissingCtrl6ToolStripMenuItem,
            this.oYellingCtrl7ToolStripMenuItem,
            this.coolCtrl8ToolStripMenuItem,
            this.toolStripSeparator2,
            this.moneymouthCtrlShift1ToolStripMenuItem,
            this.footinmouthCtrlShift2ToolStripMenuItem,
            this.embarrassedCtrlShift3ToolStripMenuItem,
            this.oInnocentCtrlShift4ToolStripMenuItem,
            this.toolStripSeparator3,
            this.undecidedCtrlShift5ToolStripMenuItem,
            this.cryingCtrlShift6ToolStripMenuItem,
            this.xLipsaresealedCtrlShift7ToolStripMenuItem,
            this.dLaughingCtrlShift8ToolStripMenuItem});
            this.smileyToolStripMenuItem.Name = "smileyToolStripMenuItem";
            this.smileyToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.smileyToolStripMenuItem.Text = "Smiley";
            // 
            // SmiliesToolStripMenuItem
            // 
            this.SmiliesToolStripMenuItem.Image = global::aol.Properties.Resources.Smiling;
            this.SmiliesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SmiliesToolStripMenuItem.Name = "SmiliesToolStripMenuItem";
            this.SmiliesToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.SmiliesToolStripMenuItem.Text = ":-)          Smiling                             Ctrl+1";
            this.SmiliesToolStripMenuItem.Click += new System.EventHandler(this.SmiliesToolStripMenuItem_Click);
            // 
            // frowningCtrl2ToolStripMenuItem
            // 
            this.frowningCtrl2ToolStripMenuItem.Image = global::aol.Properties.Resources.Frowning;
            this.frowningCtrl2ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frowningCtrl2ToolStripMenuItem.Name = "frowningCtrl2ToolStripMenuItem";
            this.frowningCtrl2ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.frowningCtrl2ToolStripMenuItem.Text = ":-(          Frowning                          Ctrl+2";
            this.frowningCtrl2ToolStripMenuItem.Click += new System.EventHandler(this.frowningCtrl2ToolStripMenuItem_Click);
            // 
            // winkingCtrl3ToolStripMenuItem
            // 
            this.winkingCtrl3ToolStripMenuItem.Image = global::aol.Properties.Resources.Winking;
            this.winkingCtrl3ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.winkingCtrl3ToolStripMenuItem.Name = "winkingCtrl3ToolStripMenuItem";
            this.winkingCtrl3ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.winkingCtrl3ToolStripMenuItem.Text = ";-)          Winking                            Ctrl+3";
            this.winkingCtrl3ToolStripMenuItem.Click += new System.EventHandler(this.winkingCtrl3ToolStripMenuItem_Click);
            // 
            // pStickingouttongueCtrl4ToolStripMenuItem
            // 
            this.pStickingouttongueCtrl4ToolStripMenuItem.Image = global::aol.Properties.Resources.Sticking_out_tongue;
            this.pStickingouttongueCtrl4ToolStripMenuItem.Name = "pStickingouttongueCtrl4ToolStripMenuItem";
            this.pStickingouttongueCtrl4ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.pStickingouttongueCtrl4ToolStripMenuItem.Text = ":-P         Sticking-out-tongue       Ctrl+4";
            this.pStickingouttongueCtrl4ToolStripMenuItem.Click += new System.EventHandler(this.pStickingouttongueCtrl4ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(495, 6);
            // 
            // oSurprisedCtrl5ToolStripMenuItem
            // 
            this.oSurprisedCtrl5ToolStripMenuItem.Image = global::aol.Properties.Resources.Surprised;
            this.oSurprisedCtrl5ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oSurprisedCtrl5ToolStripMenuItem.Name = "oSurprisedCtrl5ToolStripMenuItem";
            this.oSurprisedCtrl5ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.oSurprisedCtrl5ToolStripMenuItem.Text = "=-O       Surprised                          Ctrl+5";
            this.oSurprisedCtrl5ToolStripMenuItem.Click += new System.EventHandler(this.oSurprisedCtrl5ToolStripMenuItem_Click);
            // 
            // kissingCtrl6ToolStripMenuItem
            // 
            this.kissingCtrl6ToolStripMenuItem.Image = global::aol.Properties.Resources.Kissing;
            this.kissingCtrl6ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kissingCtrl6ToolStripMenuItem.Name = "kissingCtrl6ToolStripMenuItem";
            this.kissingCtrl6ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.kissingCtrl6ToolStripMenuItem.Text = ":-*          Kissing                              Ctrl+6";
            this.kissingCtrl6ToolStripMenuItem.Click += new System.EventHandler(this.kissingCtrl6ToolStripMenuItem_Click);
            // 
            // oYellingCtrl7ToolStripMenuItem
            // 
            this.oYellingCtrl7ToolStripMenuItem.Image = global::aol.Properties.Resources.Yelling;
            this.oYellingCtrl7ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oYellingCtrl7ToolStripMenuItem.Name = "oYellingCtrl7ToolStripMenuItem";
            this.oYellingCtrl7ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.oYellingCtrl7ToolStripMenuItem.Text = ">:o        Yelling                               Ctrl+7";
            this.oYellingCtrl7ToolStripMenuItem.Click += new System.EventHandler(this.oYellingCtrl7ToolStripMenuItem_Click);
            // 
            // coolCtrl8ToolStripMenuItem
            // 
            this.coolCtrl8ToolStripMenuItem.Image = global::aol.Properties.Resources.Cool;
            this.coolCtrl8ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coolCtrl8ToolStripMenuItem.Name = "coolCtrl8ToolStripMenuItem";
            this.coolCtrl8ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.coolCtrl8ToolStripMenuItem.Text = "8-)         Cool                                  Ctrl+8";
            this.coolCtrl8ToolStripMenuItem.Click += new System.EventHandler(this.coolCtrl8ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(495, 6);
            // 
            // moneymouthCtrlShift1ToolStripMenuItem
            // 
            this.moneymouthCtrlShift1ToolStripMenuItem.Image = global::aol.Properties.Resources.Money_mouth;
            this.moneymouthCtrlShift1ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneymouthCtrlShift1ToolStripMenuItem.Name = "moneymouthCtrlShift1ToolStripMenuItem";
            this.moneymouthCtrlShift1ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.moneymouthCtrlShift1ToolStripMenuItem.Text = ":-$         Money-mouth                 Ctrl+Shift+1";
            this.moneymouthCtrlShift1ToolStripMenuItem.Click += new System.EventHandler(this.moneymouthCtrlShift1ToolStripMenuItem_Click);
            // 
            // footinmouthCtrlShift2ToolStripMenuItem
            // 
            this.footinmouthCtrlShift2ToolStripMenuItem.Image = global::aol.Properties.Resources.Foot_in_mouth;
            this.footinmouthCtrlShift2ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.footinmouthCtrlShift2ToolStripMenuItem.Name = "footinmouthCtrlShift2ToolStripMenuItem";
            this.footinmouthCtrlShift2ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.footinmouthCtrlShift2ToolStripMenuItem.Text = ":-!          Foot-in-mouth                Ctrl+Shift+2";
            this.footinmouthCtrlShift2ToolStripMenuItem.Click += new System.EventHandler(this.footinmouthCtrlShift2ToolStripMenuItem_Click);
            // 
            // embarrassedCtrlShift3ToolStripMenuItem
            // 
            this.embarrassedCtrlShift3ToolStripMenuItem.Image = global::aol.Properties.Resources.Embarrassed;
            this.embarrassedCtrlShift3ToolStripMenuItem.Name = "embarrassedCtrlShift3ToolStripMenuItem";
            this.embarrassedCtrlShift3ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.embarrassedCtrlShift3ToolStripMenuItem.Text = ":-[          Embarrassed                    Ctrl+Shift+3";
            this.embarrassedCtrlShift3ToolStripMenuItem.Click += new System.EventHandler(this.embarrassedCtrlShift3ToolStripMenuItem_Click);
            // 
            // oInnocentCtrlShift4ToolStripMenuItem
            // 
            this.oInnocentCtrlShift4ToolStripMenuItem.Image = global::aol.Properties.Resources.Innocent;
            this.oInnocentCtrlShift4ToolStripMenuItem.Name = "oInnocentCtrlShift4ToolStripMenuItem";
            this.oInnocentCtrlShift4ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.oInnocentCtrlShift4ToolStripMenuItem.Text = "O:-)       Innocent                           Ctrl+Shift+4";
            this.oInnocentCtrlShift4ToolStripMenuItem.Click += new System.EventHandler(this.oInnocentCtrlShift4ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(495, 6);
            // 
            // undecidedCtrlShift5ToolStripMenuItem
            // 
            this.undecidedCtrlShift5ToolStripMenuItem.Image = global::aol.Properties.Resources.Undecided;
            this.undecidedCtrlShift5ToolStripMenuItem.Name = "undecidedCtrlShift5ToolStripMenuItem";
            this.undecidedCtrlShift5ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.undecidedCtrlShift5ToolStripMenuItem.Text = ":-\\          Undecided                        Ctrl+Shift+5";
            this.undecidedCtrlShift5ToolStripMenuItem.Click += new System.EventHandler(this.undecidedCtrlShift5ToolStripMenuItem_Click);
            // 
            // cryingCtrlShift6ToolStripMenuItem
            // 
            this.cryingCtrlShift6ToolStripMenuItem.Image = global::aol.Properties.Resources.Crying;
            this.cryingCtrlShift6ToolStripMenuItem.Name = "cryingCtrlShift6ToolStripMenuItem";
            this.cryingCtrlShift6ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.cryingCtrlShift6ToolStripMenuItem.Text = ":\'(           Crying                               Ctrl+Shift+6";
            this.cryingCtrlShift6ToolStripMenuItem.Click += new System.EventHandler(this.cryingCtrlShift6ToolStripMenuItem_Click);
            // 
            // xLipsaresealedCtrlShift7ToolStripMenuItem
            // 
            this.xLipsaresealedCtrlShift7ToolStripMenuItem.Image = global::aol.Properties.Resources.Lips_are_sealed;
            this.xLipsaresealedCtrlShift7ToolStripMenuItem.Name = "xLipsaresealedCtrlShift7ToolStripMenuItem";
            this.xLipsaresealedCtrlShift7ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.xLipsaresealedCtrlShift7ToolStripMenuItem.Text = ":-X         Lips-are-sealed                Ctrl+Shift+7";
            this.xLipsaresealedCtrlShift7ToolStripMenuItem.Click += new System.EventHandler(this.xLipsaresealedCtrlShift7ToolStripMenuItem_Click);
            // 
            // dLaughingCtrlShift8ToolStripMenuItem
            // 
            this.dLaughingCtrlShift8ToolStripMenuItem.Image = global::aol.Properties.Resources.Laughing;
            this.dLaughingCtrlShift8ToolStripMenuItem.Name = "dLaughingCtrlShift8ToolStripMenuItem";
            this.dLaughingCtrlShift8ToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.dLaughingCtrlShift8ToolStripMenuItem.Text = ":-D         Laughing                          Ctrl+Shift+8";
            this.dLaughingCtrlShift8ToolStripMenuItem.Click += new System.EventHandler(this.dLaughingCtrlShift8ToolStripMenuItem_Click);
            // 
            // textFromFileToolStripMenuItem
            // 
            this.textFromFileToolStripMenuItem.Name = "textFromFileToolStripMenuItem";
            this.textFromFileToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.textFromFileToolStripMenuItem.Text = "Text from File...";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mainTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 35);
            this.panel1.TabIndex = 3;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(44, 6);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(148, 25);
            this.mainTitle.TabIndex = 12;
            this.mainTitle.Text = "Instant Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(6, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 25);
            this.titleLabel.TabIndex = 3;
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(865, 2);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(33, 31);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(898, 2);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(33, 31);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::aol.Properties.Resources.close_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(935, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(33, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // instant_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.myMessageBox);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 120);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "instant_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "instant_message";
            this.Load += new System.EventHandler(this.instant_message_Load);
            this.Shown += new System.EventHandler(this.instant_message_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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