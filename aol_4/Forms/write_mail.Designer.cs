namespace aol.Forms
{
    partial class write_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(write_mail));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            mainTitle = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            sendToBox = new System.Windows.Forms.TextBox();
            copyToBox = new System.Windows.Forms.TextBox();
            subjectBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            messageBox = new System.Windows.Forms.TextBox();
            helpBtn = new System.Windows.Forms.Button();
            attachmentsButton = new System.Windows.Forms.Button();
            requestReceiptCheckbox = new System.Windows.Forms.CheckBox();
            sendButton = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            sendLaterButton = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            addressBookButton = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            mailExtrasButton = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendLaterButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressBookButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailExtrasButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(780, 21);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(3, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(27, 4);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(61, 15);
            mainTitle.TabIndex = 8;
            mainTitle.Text = "Write Mail";
            // 
            // miniBtn
            // 
            miniBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            miniBtn.BackColor = System.Drawing.SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            miniBtn.ForeColor = System.Drawing.Color.Black;
            miniBtn.Location = new System.Drawing.Point(714, 1);
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
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(735, 1);
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
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            closeBtn.ForeColor = System.Drawing.Color.Black;
            closeBtn.Location = new System.Drawing.Point(759, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 31);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 17);
            label1.TabIndex = 6;
            label1.Text = "Send";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(368, 31);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 17);
            label2.TabIndex = 7;
            label2.Text = "Copy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(24, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 17);
            label3.TabIndex = 8;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(379, 53);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 17);
            label4.TabIndex = 9;
            label4.Text = "To";
            // 
            // sendToBox
            // 
            sendToBox.Location = new System.Drawing.Point(57, 31);
            sendToBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sendToBox.Multiline = true;
            sendToBox.Name = "sendToBox";
            sendToBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            sendToBox.Size = new System.Drawing.Size(285, 107);
            sendToBox.TabIndex = 10;
            // 
            // copyToBox
            // 
            copyToBox.Location = new System.Drawing.Point(413, 31);
            copyToBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            copyToBox.Multiline = true;
            copyToBox.Name = "copyToBox";
            copyToBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            copyToBox.Size = new System.Drawing.Size(285, 107);
            copyToBox.TabIndex = 11;
            // 
            // subjectBox
            // 
            subjectBox.Location = new System.Drawing.Point(81, 145);
            subjectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new System.Drawing.Size(616, 23);
            subjectBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(13, 145);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 17);
            label5.TabIndex = 13;
            label5.Text = "Subject";
            // 
            // messageBox
            // 
            messageBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageBox.Location = new System.Drawing.Point(57, 203);
            messageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            messageBox.Size = new System.Drawing.Size(641, 205);
            messageBox.TabIndex = 14;
            // 
            // helpBtn
            // 
            helpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            helpBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            helpBtn.Location = new System.Drawing.Point(707, 421);
            helpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(64, 26);
            helpBtn.TabIndex = 15;
            helpBtn.Text = "Help";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // attachmentsButton
            // 
            attachmentsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            attachmentsButton.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            attachmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            attachmentsButton.ForeColor = System.Drawing.SystemColors.Control;
            attachmentsButton.Location = new System.Drawing.Point(17, 421);
            attachmentsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            attachmentsButton.Name = "attachmentsButton";
            attachmentsButton.Size = new System.Drawing.Size(94, 26);
            attachmentsButton.TabIndex = 16;
            attachmentsButton.Text = "Attachments";
            attachmentsButton.UseVisualStyleBackColor = false;
            // 
            // requestReceiptCheckbox
            // 
            requestReceiptCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            requestReceiptCheckbox.AutoSize = true;
            requestReceiptCheckbox.Location = new System.Drawing.Point(438, 422);
            requestReceiptCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            requestReceiptCheckbox.Name = "requestReceiptCheckbox";
            requestReceiptCheckbox.Size = new System.Drawing.Size(266, 19);
            requestReceiptCheckbox.TabIndex = 17;
            requestReceiptCheckbox.Text = "Request \"Return Receipt\" from AOL members";
            requestReceiptCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            sendButton.Image = (System.Drawing.Image)resources.GetObject("sendButton.Image");
            sendButton.Location = new System.Drawing.Point(717, 32);
            sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sendButton.Name = "sendButton";
            sendButton.Size = new System.Drawing.Size(48, 45);
            sendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            sendButton.TabIndex = 18;
            sendButton.TabStop = false;
            sendButton.Click += sendButton_Click;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(706, 79);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 15);
            label6.TabIndex = 19;
            label6.Text = "Send Now";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(704, 152);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(62, 15);
            label7.TabIndex = 21;
            label7.Text = "Send Later";
            // 
            // sendLaterButton
            // 
            sendLaterButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            sendLaterButton.Image = (System.Drawing.Image)resources.GetObject("sendLaterButton.Image");
            sendLaterButton.Location = new System.Drawing.Point(717, 106);
            sendLaterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sendLaterButton.Name = "sendLaterButton";
            sendLaterButton.Size = new System.Drawing.Size(48, 45);
            sendLaterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            sendLaterButton.TabIndex = 20;
            sendLaterButton.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(710, 225);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 15);
            label8.TabIndex = 23;
            label8.Text = "Address";
            // 
            // addressBookButton
            // 
            addressBookButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addressBookButton.Image = (System.Drawing.Image)resources.GetObject("addressBookButton.Image");
            addressBookButton.Location = new System.Drawing.Point(717, 179);
            addressBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            addressBookButton.Name = "addressBookButton";
            addressBookButton.Size = new System.Drawing.Size(48, 45);
            addressBookButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            addressBookButton.TabIndex = 22;
            addressBookButton.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(718, 241);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(34, 15);
            label9.TabIndex = 24;
            label9.Text = "Book";
            // 
            // mailExtrasButton
            // 
            mailExtrasButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            mailExtrasButton.Image = (System.Drawing.Image)resources.GetObject("mailExtrasButton.Image");
            mailExtrasButton.Location = new System.Drawing.Point(715, 264);
            mailExtrasButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            mailExtrasButton.Name = "mailExtrasButton";
            mailExtrasButton.Size = new System.Drawing.Size(48, 45);
            mailExtrasButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            mailExtrasButton.TabIndex = 25;
            mailExtrasButton.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(704, 314);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(64, 15);
            label10.TabIndex = 26;
            label10.Text = "Mail Extras";
            // 
            // write_mail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 253, 241);
            ClientSize = new System.Drawing.Size(785, 461);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(15, 220);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "write_mail";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Write Mail";
            Load += write_mail_Load;
            Shown += write_mail_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendLaterButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressBookButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailExtrasButton).EndInit();
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