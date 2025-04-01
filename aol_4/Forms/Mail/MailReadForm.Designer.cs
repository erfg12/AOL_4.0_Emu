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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailReadForm));
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            mailViewer = new System.Windows.Forms.WebBrowser();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            helpBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            curID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            totalQty = new System.Windows.Forms.Label();
            replyButton = new System.Windows.Forms.PictureBox();
            forwardButton = new System.Windows.Forms.PictureBox();
            replyAllButton = new System.Windows.Forms.PictureBox();
            addressBookButton = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)replyButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)replyAllButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressBookButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(1, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(676, 21);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(4, 2);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(46, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Subject";
            mainTitle.MouseMove += panel1_MouseMove;
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
            miniBtn.Location = new System.Drawing.Point(612, 2);
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
            maxBtn.Location = new System.Drawing.Point(633, 2);
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
            closeBtn.Location = new System.Drawing.Point(655, 2);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // mailViewer
            // 
            mailViewer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mailViewer.Location = new System.Drawing.Point(1, 2);
            mailViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            mailViewer.MinimumSize = new System.Drawing.Size(24, 22);
            mailViewer.Name = "mailViewer";
            mailViewer.Size = new System.Drawing.Size(571, 388);
            mailViewer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(513, 434);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 26);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(393, 434);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 26);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            helpBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            helpBtn.Location = new System.Drawing.Point(601, 435);
            helpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(64, 26);
            helpBtn.TabIndex = 9;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(307, 434);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 26);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // curID
            // 
            curID.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            curID.AutoSize = true;
            curID.Location = new System.Drawing.Point(458, 440);
            curID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            curID.Name = "curID";
            curID.Size = new System.Drawing.Size(13, 15);
            curID.TabIndex = 11;
            curID.Text = "1";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(473, 440);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 12;
            label1.Text = "of";
            // 
            // totalQty
            // 
            totalQty.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            totalQty.AutoSize = true;
            totalQty.Location = new System.Drawing.Point(491, 440);
            totalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalQty.Name = "totalQty";
            totalQty.Size = new System.Drawing.Size(13, 15);
            totalQty.TabIndex = 13;
            totalQty.Text = "1";
            // 
            // replyButton
            // 
            replyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            replyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            replyButton.Image = (System.Drawing.Image)resources.GetObject("replyButton.Image");
            replyButton.Location = new System.Drawing.Point(610, 34);
            replyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            replyButton.Name = "replyButton";
            replyButton.Size = new System.Drawing.Size(48, 45);
            replyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            replyButton.TabIndex = 14;
            replyButton.TabStop = false;
            replyButton.Click += replyButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            forwardButton.Image = (System.Drawing.Image)resources.GetObject("forwardButton.Image");
            forwardButton.Location = new System.Drawing.Point(610, 107);
            forwardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new System.Drawing.Size(48, 45);
            forwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            forwardButton.TabIndex = 15;
            forwardButton.TabStop = false;
            // 
            // replyAllButton
            // 
            replyAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            replyAllButton.Image = (System.Drawing.Image)resources.GetObject("replyAllButton.Image");
            replyAllButton.Location = new System.Drawing.Point(610, 180);
            replyAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            replyAllButton.Name = "replyAllButton";
            replyAllButton.Size = new System.Drawing.Size(48, 45);
            replyAllButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            replyAllButton.TabIndex = 16;
            replyAllButton.TabStop = false;
            // 
            // addressBookButton
            // 
            addressBookButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addressBookButton.Image = (System.Drawing.Image)resources.GetObject("addressBookButton.Image");
            addressBookButton.Location = new System.Drawing.Point(610, 262);
            addressBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            addressBookButton.Name = "addressBookButton";
            addressBookButton.Size = new System.Drawing.Size(48, 45);
            addressBookButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            addressBookButton.TabIndex = 17;
            addressBookButton.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(612, 83);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Reply";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(606, 156);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 15);
            label3.TabIndex = 19;
            label3.Text = "Forward";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(605, 229);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 20;
            label4.Text = "Reply All";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(592, 310);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 15);
            label5.TabIndex = 21;
            label5.Text = "Add Address";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(mailViewer);
            panel2.Location = new System.Drawing.Point(14, 34);
            panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(577, 392);
            panel2.TabIndex = 22;
            // 
            // MailReadForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 253, 241);
            ClientSize = new System.Drawing.Size(679, 474);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(15, 220);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MailReadForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Read Mail";
            Load += read_mail_Load;
            Shown += read_mail_Shown;
            LocationChanged += MailReadForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)replyButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)replyAllButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressBookButton).EndInit();
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