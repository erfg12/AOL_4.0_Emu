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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTitle = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendToBox = new System.Windows.Forms.TextBox();
            this.copyToBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.attachmentsButton = new System.Windows.Forms.Button();
            this.requestReceiptCheckbox = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sendLaterButton = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressBookButton = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mailExtrasButton = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendLaterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailExtrasButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mainTitle);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 35);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(4, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(42, 6);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(100, 25);
            this.mainTitle.TabIndex = 8;
            this.mainTitle.Text = "Write Mail";
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
            this.miniBtn.Location = new System.Drawing.Point(1122, 2);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(6);
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
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(1155, 2);
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
            this.closeBtn.Location = new System.Drawing.Point(1192, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(33, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(578, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(596, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // sendToBox
            // 
            this.sendToBox.Location = new System.Drawing.Point(90, 52);
            this.sendToBox.Margin = new System.Windows.Forms.Padding(6);
            this.sendToBox.Multiline = true;
            this.sendToBox.Name = "sendToBox";
            this.sendToBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendToBox.Size = new System.Drawing.Size(446, 175);
            this.sendToBox.TabIndex = 10;
            // 
            // copyToBox
            // 
            this.copyToBox.Location = new System.Drawing.Point(649, 52);
            this.copyToBox.Margin = new System.Windows.Forms.Padding(6);
            this.copyToBox.Multiline = true;
            this.copyToBox.Name = "copyToBox";
            this.copyToBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.copyToBox.Size = new System.Drawing.Size(446, 175);
            this.copyToBox.TabIndex = 11;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(128, 242);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(6);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(966, 33);
            this.subjectBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subject";
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Location = new System.Drawing.Point(90, 338);
            this.messageBox.Margin = new System.Windows.Forms.Padding(6);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(1005, 339);
            this.messageBox.TabIndex = 14;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(1111, 702);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(101, 44);
            this.helpBtn.TabIndex = 15;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.attachmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.attachmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachmentsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.attachmentsButton.Location = new System.Drawing.Point(26, 702);
            this.attachmentsButton.Margin = new System.Windows.Forms.Padding(6);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(147, 44);
            this.attachmentsButton.TabIndex = 16;
            this.attachmentsButton.Text = "Attachments";
            this.attachmentsButton.UseVisualStyleBackColor = false;
            // 
            // requestReceiptCheckbox
            // 
            this.requestReceiptCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.requestReceiptCheckbox.AutoSize = true;
            this.requestReceiptCheckbox.Location = new System.Drawing.Point(694, 706);
            this.requestReceiptCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.requestReceiptCheckbox.Name = "requestReceiptCheckbox";
            this.requestReceiptCheckbox.Size = new System.Drawing.Size(412, 29);
            this.requestReceiptCheckbox.TabIndex = 17;
            this.requestReceiptCheckbox.Text = "Request \"Return Receipt\" from AOL members";
            this.requestReceiptCheckbox.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.Location = new System.Drawing.Point(1126, 54);
            this.sendButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 75);
            this.sendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendButton.TabIndex = 18;
            this.sendButton.TabStop = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1109, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Send Now";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1106, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Send Later";
            // 
            // sendLaterButton
            // 
            this.sendLaterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendLaterButton.Image = ((System.Drawing.Image)(resources.GetObject("sendLaterButton.Image")));
            this.sendLaterButton.Location = new System.Drawing.Point(1126, 177);
            this.sendLaterButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendLaterButton.Name = "sendLaterButton";
            this.sendLaterButton.Size = new System.Drawing.Size(75, 75);
            this.sendLaterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendLaterButton.TabIndex = 20;
            this.sendLaterButton.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1116, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Address";
            // 
            // addressBookButton
            // 
            this.addressBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBookButton.Image = ((System.Drawing.Image)(resources.GetObject("addressBookButton.Image")));
            this.addressBookButton.Location = new System.Drawing.Point(1126, 298);
            this.addressBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.addressBookButton.Name = "addressBookButton";
            this.addressBookButton.Size = new System.Drawing.Size(75, 75);
            this.addressBookButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addressBookButton.TabIndex = 22;
            this.addressBookButton.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1128, 402);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Book";
            // 
            // mailExtrasButton
            // 
            this.mailExtrasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mailExtrasButton.Image = ((System.Drawing.Image)(resources.GetObject("mailExtrasButton.Image")));
            this.mailExtrasButton.Location = new System.Drawing.Point(1124, 440);
            this.mailExtrasButton.Margin = new System.Windows.Forms.Padding(6);
            this.mailExtrasButton.Name = "mailExtrasButton";
            this.mailExtrasButton.Size = new System.Drawing.Size(75, 75);
            this.mailExtrasButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mailExtrasButton.TabIndex = 25;
            this.mailExtrasButton.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1106, 523);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mail Extras";
            // 
            // write_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1234, 769);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mailExtrasButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressBookButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sendLaterButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.requestReceiptCheckbox);
            this.Controls.Add(this.attachmentsButton);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.copyToBox);
            this.Controls.Add(this.sendToBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 220);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "write_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Write Mail";
            this.Load += new System.EventHandler(this.write_mail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendLaterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailExtrasButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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