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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailboxForm));
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            newListView = new System.Windows.Forms.ListView();
            subject = new System.Windows.Forms.ColumnHeader();
            tabPage2 = new System.Windows.Forms.TabPage();
            oldListView = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            tabPage3 = new System.Windows.Forms.TabPage();
            sentListView = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            readBtn = new System.Windows.Forms.Button();
            statusBtn = new System.Windows.Forms.Button();
            keepBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            helpBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            mailboxAdBanner = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailboxAdBanner).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(14, 97);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(798, 398);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            tabPage1.Controls.Add(newListView);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPage1.Size = new System.Drawing.Size(790, 370);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Mail";
            // 
            // newListView
            // 
            newListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            newListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { subject });
            newListView.FullRowSelect = true;
            newListView.GridLines = true;
            newListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            newListView.Location = new System.Drawing.Point(10, 7);
            newListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            newListView.MultiSelect = false;
            newListView.Name = "newListView";
            newListView.Size = new System.Drawing.Size(768, 353);
            newListView.TabIndex = 0;
            newListView.UseCompatibleStateImageBehavior = false;
            newListView.View = System.Windows.Forms.View.Details;
            newListView.DoubleClick += newListview_DoubleClick;
            // 
            // subject
            // 
            subject.Text = "subject";
            subject.Width = 650;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            tabPage2.Controls.Add(oldListView);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPage2.Size = new System.Drawing.Size(790, 370);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Old Mail";
            // 
            // oldListView
            // 
            oldListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            oldListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            oldListView.FullRowSelect = true;
            oldListView.GridLines = true;
            oldListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            oldListView.Location = new System.Drawing.Point(10, 7);
            oldListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            oldListView.MultiSelect = false;
            oldListView.Name = "oldListView";
            oldListView.Size = new System.Drawing.Size(768, 353);
            oldListView.TabIndex = 1;
            oldListView.UseCompatibleStateImageBehavior = false;
            oldListView.View = System.Windows.Forms.View.Details;
            oldListView.DoubleClick += oldListView_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "subject";
            columnHeader1.Width = 650;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            tabPage3.Controls.Add(sentListView);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(790, 370);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sent Mail";
            // 
            // sentListView
            // 
            sentListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            sentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader2 });
            sentListView.FullRowSelect = true;
            sentListView.GridLines = true;
            sentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            sentListView.Location = new System.Drawing.Point(10, 7);
            sentListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sentListView.MultiSelect = false;
            sentListView.Name = "sentListView";
            sentListView.Size = new System.Drawing.Size(768, 353);
            sentListView.TabIndex = 1;
            sentListView.UseCompatibleStateImageBehavior = false;
            sentListView.View = System.Windows.Forms.View.Details;
            sentListView.DoubleClick += sentListView_DoubleClick;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "subject";
            columnHeader2.Width = 650;
            // 
            // readBtn
            // 
            readBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            readBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            readBtn.ForeColor = System.Drawing.SystemColors.Control;
            readBtn.Location = new System.Drawing.Point(14, 502);
            readBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            readBtn.Name = "readBtn";
            readBtn.Size = new System.Drawing.Size(66, 26);
            readBtn.TabIndex = 4;
            readBtn.Text = "Read";
            readBtn.UseVisualStyleBackColor = false;
            readBtn.Click += readBtn_Click;
            // 
            // statusBtn
            // 
            statusBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            statusBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            statusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            statusBtn.ForeColor = System.Drawing.SystemColors.Control;
            statusBtn.Location = new System.Drawing.Point(88, 502);
            statusBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            statusBtn.Name = "statusBtn";
            statusBtn.Size = new System.Drawing.Size(64, 26);
            statusBtn.TabIndex = 5;
            statusBtn.Text = "Status";
            statusBtn.UseVisualStyleBackColor = false;
            // 
            // keepBtn
            // 
            keepBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            keepBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            keepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            keepBtn.ForeColor = System.Drawing.SystemColors.Control;
            keepBtn.Location = new System.Drawing.Point(252, 502);
            keepBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            keepBtn.Name = "keepBtn";
            keepBtn.Size = new System.Drawing.Size(111, 26);
            keepBtn.TabIndex = 6;
            keepBtn.Text = "Keep As New";
            keepBtn.UseVisualStyleBackColor = false;
            keepBtn.Click += keepBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            deleteBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            deleteBtn.Location = new System.Drawing.Point(370, 502);
            deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(64, 26);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            helpBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            helpBtn.Location = new System.Drawing.Point(743, 502);
            helpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(64, 26);
            helpBtn.TabIndex = 8;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(270, 46);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 15);
            label1.TabIndex = 10;
            label1.Text = "REMINDER: AOL Staff will never ask for";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(270, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(203, 15);
            label2.TabIndex = 11;
            label2.Text = "your password or billing information.";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(14, 36);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(214, 41);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // mailboxAdBanner
            // 
            mailboxAdBanner.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            mailboxAdBanner.Image = (System.Drawing.Image)resources.GetObject("mailboxAdBanner.Image");
            mailboxAdBanner.Location = new System.Drawing.Point(524, 36);
            mailboxAdBanner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            mailboxAdBanner.Name = "mailboxAdBanner";
            mailboxAdBanner.Size = new System.Drawing.Size(243, 61);
            mailboxAdBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            mailboxAdBanner.TabIndex = 9;
            mailboxAdBanner.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(822, 21);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(27, 2);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(130, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Name's Online Mailbox";
            mainTitle.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(1, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            miniBtn.Location = new System.Drawing.Point(757, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
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
            maxBtn.Location = new System.Drawing.Point(778, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
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
            closeBtn.Location = new System.Drawing.Point(801, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // MailboxForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 251, 240);
            ClientSize = new System.Drawing.Size(826, 540);
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
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(25, 220);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MailboxForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "mailbox";
            Load += mailbox_Load;
            Shown += mailbox_Shown;
            LocationChanged += MailboxForm_LocationChanged;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailboxAdBanner).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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