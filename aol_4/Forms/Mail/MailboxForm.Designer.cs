namespace aol.Forms
{
    partial class MailboxForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MailboxForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            newListView = new ListView();
            subject = new ColumnHeader();
            tabPage2 = new TabPage();
            oldListView = new ListView();
            columnHeader1 = new ColumnHeader();
            tabPage3 = new TabPage();
            sentListView = new ListView();
            columnHeader2 = new ColumnHeader();
            readBtn = new Button();
            statusBtn = new Button();
            keepBtn = new Button();
            deleteBtn = new Button();
            helpBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            mailboxAdBanner = new PictureBox();
            TitleBar = new Panel();
            mainTitle = new Label();
            pictureBox1 = new PictureBox();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)mailboxAdBanner).BeginInit();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabControl1.Location = new Point(14, 97);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 337);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 109, 170);
            tabPage1.Controls.Add(newListView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(771, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Mail";
            // 
            // newListView
            // 
            newListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newListView.Columns.AddRange(new ColumnHeader[] { subject });
            newListView.FullRowSelect = true;
            newListView.GridLines = true;
            newListView.HeaderStyle = ColumnHeaderStyle.None;
            newListView.Location = new Point(10, 7);
            newListView.Margin = new Padding(4);
            newListView.MultiSelect = false;
            newListView.Name = "newListView";
            newListView.Size = new Size(749, 292);
            newListView.TabIndex = 0;
            newListView.UseCompatibleStateImageBehavior = false;
            newListView.View = View.Details;
            newListView.DoubleClick += NewListview_DoubleClick;
            // 
            // subject
            // 
            subject.Text = "subject";
            subject.Width = 650;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 109, 170);
            tabPage2.Controls.Add(oldListView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(790, 370);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Old Mail";
            // 
            // oldListView
            // 
            oldListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oldListView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            oldListView.FullRowSelect = true;
            oldListView.GridLines = true;
            oldListView.HeaderStyle = ColumnHeaderStyle.None;
            oldListView.Location = new Point(10, 7);
            oldListView.Margin = new Padding(4);
            oldListView.MultiSelect = false;
            oldListView.Name = "oldListView";
            oldListView.Size = new Size(768, 353);
            oldListView.TabIndex = 1;
            oldListView.UseCompatibleStateImageBehavior = false;
            oldListView.View = View.Details;
            oldListView.DoubleClick += OldListView_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "subject";
            columnHeader1.Width = 650;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(0, 109, 170);
            tabPage3.Controls.Add(sentListView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(790, 370);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sent Mail";
            // 
            // sentListView
            // 
            sentListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sentListView.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            sentListView.FullRowSelect = true;
            sentListView.GridLines = true;
            sentListView.HeaderStyle = ColumnHeaderStyle.None;
            sentListView.Location = new Point(10, 7);
            sentListView.Margin = new Padding(4);
            sentListView.MultiSelect = false;
            sentListView.Name = "sentListView";
            sentListView.Size = new Size(768, 353);
            sentListView.TabIndex = 1;
            sentListView.UseCompatibleStateImageBehavior = false;
            sentListView.View = View.Details;
            sentListView.DoubleClick += SentListView_DoubleClick;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "subject";
            columnHeader2.Width = 650;
            // 
            // readBtn
            // 
            readBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            readBtn.BackColor = Color.FromArgb(0, 109, 170);
            readBtn.FlatStyle = FlatStyle.Flat;
            readBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            readBtn.ForeColor = SystemColors.Control;
            readBtn.Location = new Point(14, 441);
            readBtn.Margin = new Padding(4);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(66, 26);
            readBtn.TabIndex = 4;
            readBtn.Text = "Read";
            readBtn.UseVisualStyleBackColor = false;
            readBtn.Click += ReadBtn_Click;
            // 
            // statusBtn
            // 
            statusBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            statusBtn.BackColor = Color.FromArgb(0, 109, 170);
            statusBtn.FlatStyle = FlatStyle.Flat;
            statusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            statusBtn.ForeColor = SystemColors.Control;
            statusBtn.Location = new Point(88, 441);
            statusBtn.Margin = new Padding(4);
            statusBtn.Name = "statusBtn";
            statusBtn.Size = new Size(64, 26);
            statusBtn.TabIndex = 5;
            statusBtn.Text = "Status";
            statusBtn.UseVisualStyleBackColor = false;
            // 
            // keepBtn
            // 
            keepBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            keepBtn.BackColor = Color.FromArgb(0, 109, 170);
            keepBtn.FlatStyle = FlatStyle.Flat;
            keepBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            keepBtn.ForeColor = SystemColors.Control;
            keepBtn.Location = new Point(252, 441);
            keepBtn.Margin = new Padding(4);
            keepBtn.Name = "keepBtn";
            keepBtn.Size = new Size(111, 26);
            keepBtn.TabIndex = 6;
            keepBtn.Text = "Keep As New";
            keepBtn.UseVisualStyleBackColor = false;
            keepBtn.Click += KeepBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteBtn.BackColor = Color.FromArgb(0, 109, 170);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(370, 441);
            deleteBtn.Margin = new Padding(4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(64, 26);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += DeleteBtn_Click;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            helpBtn.BackColor = Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            helpBtn.ForeColor = SystemColors.Control;
            helpBtn.Location = new Point(724, 441);
            helpBtn.Margin = new Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(64, 26);
            helpBtn.TabIndex = 8;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(270, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 10;
            label1.Text = "REMINDER: AOL Staff will never ask for";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(270, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 11;
            label2.Text = "your password or billing information.";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 36);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(214, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // mailboxAdBanner
            // 
            mailboxAdBanner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mailboxAdBanner.Image = (Image)resources.GetObject("mailboxAdBanner.Image");
            mailboxAdBanner.Location = new Point(505, 36);
            mailboxAdBanner.Margin = new Padding(4);
            mailboxAdBanner.Name = "mailboxAdBanner";
            mailboxAdBanner.Size = new Size(243, 61);
            mailboxAdBanner.SizeMode = PictureBoxSizeMode.AutoSize;
            mailboxAdBanner.TabIndex = 9;
            mailboxAdBanner.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(mainTitle);
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(1, 1);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(803, 24);
            TitleBar.TabIndex = 2;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(27, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(130, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Name's Online Mailbox";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            miniBtn.Location = new Point(738, 1);
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
            maxBtn.Location = new Point(759, 1);
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
            closeBtn.Location = new Point(782, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // MailboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(807, 479);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mailboxAdBanner);
            Controls.Add(helpBtn);
            Controls.Add(deleteBtn);
            Controls.Add(keepBtn);
            Controls.Add(statusBtn);
            Controls.Add(readBtn);
            Controls.Add(tabControl1);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(25, 220);
            Margin = new Padding(4);
            MinimumSize = new Size(807, 479);
            Name = "MailboxForm";
            StartPosition = FormStartPosition.Manual;
            Text = "mailbox";
            Shown += Mailbox_Shown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)mailboxAdBanner).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
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