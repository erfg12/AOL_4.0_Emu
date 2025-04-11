namespace aol.Forms
{
    partial class MailWriteForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MailWriteForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            mainTitle = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sendToBox = new TextBox();
            copyToBox = new TextBox();
            subjectBox = new TextBox();
            label5 = new Label();
            messageBox = new TextBox();
            helpBtn = new Button();
            attachmentsButton = new Button();
            requestReceiptCheckbox = new CheckBox();
            sendButton = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            sendLaterButton = new PictureBox();
            label8 = new Label();
            addressBookButton = new PictureBox();
            label9 = new Label();
            mailExtrasButton = new PictureBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)sendButton).BeginInit();
            ((ISupportInitialize)sendLaterButton).BeginInit();
            ((ISupportInitialize)addressBookButton).BeginInit();
            ((ISupportInitialize)mailExtrasButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 21);
            panel1.TabIndex = 5;
            panel1.DoubleClick += TitleBar_DoubleClick;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(27, 4);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(61, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Write Mail";
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
            miniBtn.Location = new Point(714, 1);
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
            maxBtn.Location = new Point(735, 1);
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
            closeBtn.Location = new Point(759, 1);
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
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(10, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 6;
            label1.Text = "Send";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(368, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 7;
            label2.Text = "Copy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(24, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 17);
            label3.TabIndex = 8;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(379, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 17);
            label4.TabIndex = 9;
            label4.Text = "To";
            // 
            // sendToBox
            // 
            sendToBox.Location = new Point(57, 31);
            sendToBox.Margin = new Padding(4);
            sendToBox.Multiline = true;
            sendToBox.Name = "sendToBox";
            sendToBox.ScrollBars = ScrollBars.Vertical;
            sendToBox.Size = new Size(285, 107);
            sendToBox.TabIndex = 10;
            // 
            // copyToBox
            // 
            copyToBox.Location = new Point(413, 31);
            copyToBox.Margin = new Padding(4);
            copyToBox.Multiline = true;
            copyToBox.Name = "copyToBox";
            copyToBox.ScrollBars = ScrollBars.Vertical;
            copyToBox.Size = new Size(285, 107);
            copyToBox.TabIndex = 11;
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(81, 145);
            subjectBox.Margin = new Padding(4);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(616, 23);
            subjectBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(13, 145);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 13;
            label5.Text = "Subject";
            // 
            // messageBox
            // 
            messageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageBox.Location = new Point(57, 203);
            messageBox.Margin = new Padding(4);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.ScrollBars = ScrollBars.Vertical;
            messageBox.Size = new Size(641, 205);
            messageBox.TabIndex = 14;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            helpBtn.BackColor = Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.ForeColor = SystemColors.Control;
            helpBtn.Location = new Point(707, 421);
            helpBtn.Margin = new Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(64, 26);
            helpBtn.TabIndex = 15;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // attachmentsButton
            // 
            attachmentsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            attachmentsButton.BackColor = Color.FromArgb(0, 109, 170);
            attachmentsButton.FlatStyle = FlatStyle.Flat;
            attachmentsButton.ForeColor = SystemColors.Control;
            attachmentsButton.Location = new Point(17, 421);
            attachmentsButton.Margin = new Padding(4);
            attachmentsButton.Name = "attachmentsButton";
            attachmentsButton.Size = new Size(94, 26);
            attachmentsButton.TabIndex = 16;
            attachmentsButton.Text = "Attachments";
            attachmentsButton.UseVisualStyleBackColor = false;
            // 
            // requestReceiptCheckbox
            // 
            requestReceiptCheckbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            requestReceiptCheckbox.AutoSize = true;
            requestReceiptCheckbox.Location = new Point(438, 422);
            requestReceiptCheckbox.Margin = new Padding(4);
            requestReceiptCheckbox.Name = "requestReceiptCheckbox";
            requestReceiptCheckbox.Size = new Size(266, 19);
            requestReceiptCheckbox.TabIndex = 17;
            requestReceiptCheckbox.Text = "Request \"Return Receipt\" from AOL members";
            requestReceiptCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sendButton.BackgroundImageLayout = ImageLayout.Stretch;
            sendButton.Cursor = Cursors.Hand;
            sendButton.Image = (Image)resources.GetObject("sendButton.Image");
            sendButton.Location = new Point(717, 32);
            sendButton.Margin = new Padding(4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(48, 45);
            sendButton.SizeMode = PictureBoxSizeMode.StretchImage;
            sendButton.TabIndex = 18;
            sendButton.TabStop = false;
            sendButton.Click += SendButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(706, 79);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 19;
            label6.Text = "Send Now";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(704, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 21;
            label7.Text = "Send Later";
            // 
            // sendLaterButton
            // 
            sendLaterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sendLaterButton.Image = (Image)resources.GetObject("sendLaterButton.Image");
            sendLaterButton.Location = new Point(717, 106);
            sendLaterButton.Margin = new Padding(4);
            sendLaterButton.Name = "sendLaterButton";
            sendLaterButton.Size = new Size(48, 45);
            sendLaterButton.SizeMode = PictureBoxSizeMode.StretchImage;
            sendLaterButton.TabIndex = 20;
            sendLaterButton.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(710, 225);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 23;
            label8.Text = "Address";
            // 
            // addressBookButton
            // 
            addressBookButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressBookButton.Image = (Image)resources.GetObject("addressBookButton.Image");
            addressBookButton.Location = new Point(717, 179);
            addressBookButton.Margin = new Padding(4);
            addressBookButton.Name = "addressBookButton";
            addressBookButton.Size = new Size(48, 45);
            addressBookButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addressBookButton.TabIndex = 22;
            addressBookButton.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(718, 241);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 24;
            label9.Text = "Book";
            // 
            // mailExtrasButton
            // 
            mailExtrasButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mailExtrasButton.Image = (Image)resources.GetObject("mailExtrasButton.Image");
            mailExtrasButton.Location = new Point(715, 264);
            mailExtrasButton.Margin = new Padding(4);
            mailExtrasButton.Name = "mailExtrasButton";
            mailExtrasButton.Size = new Size(48, 45);
            mailExtrasButton.SizeMode = PictureBoxSizeMode.StretchImage;
            mailExtrasButton.TabIndex = 25;
            mailExtrasButton.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(704, 314);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 26;
            label10.Text = "Mail Extras";
            // 
            // MailWriteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 253, 241);
            ClientSize = new Size(785, 461);
            Controls.Add(label10);
            Controls.Add(mailExtrasButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(addressBookButton);
            Controls.Add(label7);
            Controls.Add(sendLaterButton);
            Controls.Add(label6);
            Controls.Add(sendButton);
            Controls.Add(requestReceiptCheckbox);
            Controls.Add(attachmentsButton);
            Controls.Add(helpBtn);
            Controls.Add(messageBox);
            Controls.Add(label5);
            Controls.Add(subjectBox);
            Controls.Add(copyToBox);
            Controls.Add(sendToBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(15, 220);
            Margin = new Padding(4);
            Name = "MailWriteForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Write Mail";
            Shown += WriteMail_Shown;
            LocationChanged += MailWriteForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)sendButton).EndInit();
            ((ISupportInitialize)sendLaterButton).EndInit();
            ((ISupportInitialize)addressBookButton).EndInit();
            ((ISupportInitialize)mailExtrasButton).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendToBox;
        private System.Windows.Forms.TextBox copyToBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button attachmentsButton;
        private System.Windows.Forms.CheckBox requestReceiptCheckbox;
        private System.Windows.Forms.PictureBox sendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox sendLaterButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox addressBookButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox mailExtrasButton;
        private System.Windows.Forms.Label label10;
    }
}