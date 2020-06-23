namespace aol.Forms
{
    partial class mailbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailbox));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newListView = new System.Windows.Forms.ListView();
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oldListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sentListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.keepBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mailboxAdBanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailboxAdBanner)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 345);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage1.Controls.Add(this.newListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Mail";
            // 
            // newListView
            // 
            this.newListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subject});
            this.newListView.FullRowSelect = true;
            this.newListView.GridLines = true;
            this.newListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.newListView.HideSelection = false;
            this.newListView.Location = new System.Drawing.Point(9, 6);
            this.newListView.MultiSelect = false;
            this.newListView.Name = "newListView";
            this.newListView.Size = new System.Drawing.Size(659, 306);
            this.newListView.TabIndex = 0;
            this.newListView.UseCompatibleStateImageBehavior = false;
            this.newListView.View = System.Windows.Forms.View.Details;
            this.newListView.DoubleClick += new System.EventHandler(this.newListview_DoubleClick);
            // 
            // subject
            // 
            this.subject.Text = "subject";
            this.subject.Width = 650;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage2.Controls.Add(this.oldListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Old Mail";
            // 
            // oldListView
            // 
            this.oldListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.oldListView.FullRowSelect = true;
            this.oldListView.GridLines = true;
            this.oldListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.oldListView.HideSelection = false;
            this.oldListView.Location = new System.Drawing.Point(9, 6);
            this.oldListView.MultiSelect = false;
            this.oldListView.Name = "oldListView";
            this.oldListView.Size = new System.Drawing.Size(659, 306);
            this.oldListView.TabIndex = 1;
            this.oldListView.UseCompatibleStateImageBehavior = false;
            this.oldListView.View = System.Windows.Forms.View.Details;
            this.oldListView.DoubleClick += new System.EventHandler(this.oldListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "subject";
            this.columnHeader1.Width = 650;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage3.Controls.Add(this.sentListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sent Mail";
            // 
            // sentListView
            // 
            this.sentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.sentListView.FullRowSelect = true;
            this.sentListView.GridLines = true;
            this.sentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.sentListView.HideSelection = false;
            this.sentListView.Location = new System.Drawing.Point(9, 6);
            this.sentListView.MultiSelect = false;
            this.sentListView.Name = "sentListView";
            this.sentListView.Size = new System.Drawing.Size(659, 306);
            this.sentListView.TabIndex = 1;
            this.sentListView.UseCompatibleStateImageBehavior = false;
            this.sentListView.View = System.Windows.Forms.View.Details;
            this.sentListView.DoubleClick += new System.EventHandler(this.sentListView_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "subject";
            this.columnHeader2.Width = 650;
            // 
            // readBtn
            // 
            this.readBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.readBtn.Location = new System.Drawing.Point(12, 435);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(57, 23);
            this.readBtn.TabIndex = 4;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // statusBtn
            // 
            this.statusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.statusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.statusBtn.Location = new System.Drawing.Point(75, 435);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(55, 23);
            this.statusBtn.TabIndex = 5;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = false;
            // 
            // keepBtn
            // 
            this.keepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.keepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keepBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.keepBtn.Location = new System.Drawing.Point(216, 435);
            this.keepBtn.Name = "keepBtn";
            this.keepBtn.Size = new System.Drawing.Size(95, 23);
            this.keepBtn.TabIndex = 6;
            this.keepBtn.Text = "Keep As New";
            this.keepBtn.UseVisualStyleBackColor = false;
            this.keepBtn.Click += new System.EventHandler(this.keepBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(317, 435);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(637, 435);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(55, 23);
            this.helpBtn.TabIndex = 8;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "REMINDER: AOL Staff will never ask for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "your password or billing information.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // mailboxAdBanner
            // 
            this.mailboxAdBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mailboxAdBanner.Image = ((System.Drawing.Image)(resources.GetObject("mailboxAdBanner.Image")));
            this.mailboxAdBanner.Location = new System.Drawing.Point(449, 31);
            this.mailboxAdBanner.Name = "mailboxAdBanner";
            this.mailboxAdBanner.Size = new System.Drawing.Size(243, 61);
            this.mailboxAdBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mailboxAdBanner.TabIndex = 9;
            this.mailboxAdBanner.TabStop = false;
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
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 18);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(23, 2);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(114, 13);
            this.mainTitle.TabIndex = 8;
            this.mainTitle.Text = "Name\'s Online Mailbox";
            this.mainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(649, 1);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(18, 16);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(667, 1);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(18, 16);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::aol.Properties.Resources.close_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(687, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(18, 16);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mailbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(708, 468);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailboxAdBanner);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.keepBtn);
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 120);
            this.Name = "mailbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mailbox";
            this.Load += new System.EventHandler(this.mailbox_Load);
            this.Shown += new System.EventHandler(this.mailbox_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailboxAdBanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.Button keepBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.PictureBox mailboxAdBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ListView newListView;
        private System.Windows.Forms.ColumnHeader subject;
        public System.Windows.Forms.ListView oldListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView sentListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}