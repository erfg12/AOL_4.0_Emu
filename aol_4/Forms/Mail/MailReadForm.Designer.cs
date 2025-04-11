namespace aol.Forms
{
    partial class MailReadForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MailReadForm));
            panel1 = new Panel();
            mainTitle = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            mailViewer = new WebBrowser();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            helpBtn = new Button();
            button1 = new Button();
            curID = new Label();
            label1 = new Label();
            totalQty = new Label();
            replyButton = new PictureBox();
            forwardButton = new PictureBox();
            replyAllButton = new PictureBox();
            addressBookButton = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)replyButton).BeginInit();
            ((ISupportInitialize)forwardButton).BeginInit();
            ((ISupportInitialize)replyAllButton).BeginInit();
            ((ISupportInitialize)addressBookButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 21);
            panel1.TabIndex = 4;
            panel1.DoubleClick += TitleBar_DoubleClick;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(4, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(46, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Subject";
            mainTitle.MouseMove += TitleBar_MouseMove;
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
            miniBtn.Location = new Point(612, 2);
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
            maxBtn.Location = new Point(633, 2);
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
            closeBtn.Location = new Point(655, 2);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // mailViewer
            // 
            mailViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mailViewer.Location = new Point(1, 2);
            mailViewer.Margin = new Padding(4);
            mailViewer.MinimumSize = new Size(24, 22);
            mailViewer.Name = "mailViewer";
            mailViewer.Size = new Size(571, 388);
            mailViewer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(513, 434);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(393, 434);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            helpBtn.BackColor = Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.ForeColor = SystemColors.Control;
            helpBtn.Location = new Point(601, 435);
            helpBtn.Margin = new Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(64, 26);
            helpBtn.TabIndex = 9;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 109, 170);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(307, 434);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(64, 26);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // curID
            // 
            curID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            curID.AutoSize = true;
            curID.Location = new Point(458, 440);
            curID.Margin = new Padding(4, 0, 4, 0);
            curID.Name = "curID";
            curID.Size = new Size(13, 15);
            curID.TabIndex = 11;
            curID.Text = "1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(473, 440);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 12;
            label1.Text = "of";
            // 
            // totalQty
            // 
            totalQty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalQty.AutoSize = true;
            totalQty.Location = new Point(491, 440);
            totalQty.Margin = new Padding(4, 0, 4, 0);
            totalQty.Name = "totalQty";
            totalQty.Size = new Size(13, 15);
            totalQty.TabIndex = 13;
            totalQty.Text = "1";
            // 
            // replyButton
            // 
            replyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            replyButton.Cursor = Cursors.Hand;
            replyButton.Image = (Image)resources.GetObject("replyButton.Image");
            replyButton.Location = new Point(610, 34);
            replyButton.Margin = new Padding(4);
            replyButton.Name = "replyButton";
            replyButton.Size = new Size(48, 45);
            replyButton.SizeMode = PictureBoxSizeMode.StretchImage;
            replyButton.TabIndex = 14;
            replyButton.TabStop = false;
            replyButton.Click += ReplyBtn_Click;
            // 
            // forwardButton
            // 
            forwardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.Location = new Point(610, 107);
            forwardButton.Margin = new Padding(4);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(48, 45);
            forwardButton.SizeMode = PictureBoxSizeMode.StretchImage;
            forwardButton.TabIndex = 15;
            forwardButton.TabStop = false;
            // 
            // replyAllButton
            // 
            replyAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            replyAllButton.Image = (Image)resources.GetObject("replyAllButton.Image");
            replyAllButton.Location = new Point(610, 180);
            replyAllButton.Margin = new Padding(4);
            replyAllButton.Name = "replyAllButton";
            replyAllButton.Size = new Size(48, 45);
            replyAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
            replyAllButton.TabIndex = 16;
            replyAllButton.TabStop = false;
            // 
            // addressBookButton
            // 
            addressBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressBookButton.Image = (Image)resources.GetObject("addressBookButton.Image");
            addressBookButton.Location = new Point(610, 262);
            addressBookButton.Margin = new Padding(4);
            addressBookButton.Name = "addressBookButton";
            addressBookButton.Size = new Size(48, 45);
            addressBookButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addressBookButton.TabIndex = 17;
            addressBookButton.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(612, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Reply";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(606, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 19;
            label3.Text = "Forward";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(605, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 20;
            label4.Text = "Reply All";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(592, 310);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 21;
            label5.Text = "Add Address";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(mailViewer);
            panel2.Location = new Point(14, 34);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 392);
            panel2.TabIndex = 22;
            // 
            // MailReadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 253, 241);
            ClientSize = new Size(679, 474);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addressBookButton);
            Controls.Add(replyAllButton);
            Controls.Add(forwardButton);
            Controls.Add(replyButton);
            Controls.Add(totalQty);
            Controls.Add(label1);
            Controls.Add(curID);
            Controls.Add(button1);
            Controls.Add(helpBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(15, 220);
            Margin = new Padding(4);
            Name = "MailReadForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Read Mail";
            LocationChanged += MailReadForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)replyButton).EndInit();
            ((ISupportInitialize)forwardButton).EndInit();
            ((ISupportInitialize)replyAllButton).EndInit();
            ((ISupportInitialize)addressBookButton).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label curID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalQty;
        private System.Windows.Forms.PictureBox replyButton;
        private System.Windows.Forms.PictureBox forwardButton;
        private System.Windows.Forms.PictureBox replyAllButton;
        private System.Windows.Forms.PictureBox addressBookButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.WebBrowser mailViewer;
    }
}