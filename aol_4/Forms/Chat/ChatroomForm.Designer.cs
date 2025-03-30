namespace aol.Forms
{
    partial class ChatroomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatroomForm));
            messageTextBox = new System.Windows.Forms.TextBox();
            chatRoomTextBox = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            usersListView = new System.Windows.Forms.ListView();
            users = new System.Windows.Forms.ColumnHeader();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pplQty = new System.Windows.Forms.Label();
            chatSendBtn = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatSendBtn).BeginInit();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            messageTextBox.Location = new System.Drawing.Point(23, 642);
            messageTextBox.Margin = new System.Windows.Forms.Padding(5);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new System.Drawing.Size(535, 27);
            messageTextBox.TabIndex = 3;
            messageTextBox.KeyDown += messageTextBox_KeyDown;
            // 
            // chatRoomTextBox
            // 
            chatRoomTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chatRoomTextBox.BackColor = System.Drawing.Color.White;
            chatRoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            chatRoomTextBox.Location = new System.Drawing.Point(23, 40);
            chatRoomTextBox.Margin = new System.Windows.Forms.Padding(5);
            chatRoomTextBox.Name = "chatRoomTextBox";
            chatRoomTextBox.ReadOnly = true;
            chatRoomTextBox.Size = new System.Drawing.Size(614, 540);
            chatRoomTextBox.TabIndex = 6;
            chatRoomTextBox.Text = "";
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
            panel1.Margin = new System.Windows.Forms.Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(901, 28);
            panel1.TabIndex = 2;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(29, 3);
            mainTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(75, 20);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Chatroom";
            mainTitle.MouseMove += mainTitle_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(0, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(24, 28);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(5, 5);
            titleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            miniBtn.Location = new System.Drawing.Point(825, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(5);
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
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(849, 1);
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
            closeBtn.Location = new System.Drawing.Point(875, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(24, 25);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // usersListView
            // 
            usersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { users });
            usersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            usersListView.Location = new System.Drawing.Point(652, 159);
            usersListView.Margin = new System.Windows.Forms.Padding(5);
            usersListView.Name = "usersListView";
            usersListView.Size = new System.Drawing.Size(230, 269);
            usersListView.TabIndex = 7;
            usersListView.UseCompatibleStateImageBehavior = false;
            usersListView.View = System.Windows.Forms.View.Details;
            usersListView.DoubleClick += usersListView_DoubleClick;
            // 
            // users
            // 
            users.Text = "users";
            users.Width = 170;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(3, 31);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(901, 659);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            // 
            // pplQty
            // 
            pplQty.AutoSize = true;
            pplQty.BackColor = System.Drawing.Color.FromArgb(209, 229, 243);
            pplQty.Location = new System.Drawing.Point(763, 83);
            pplQty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pplQty.Name = "pplQty";
            pplQty.Size = new System.Drawing.Size(18, 20);
            pplQty.TabIndex = 9;
            pplQty.Text = "#";
            // 
            // chatSendBtn
            // 
            chatSendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            chatSendBtn.Image = (System.Drawing.Image)resources.GetObject("chatSendBtn.Image");
            chatSendBtn.Location = new System.Drawing.Point(568, 639);
            chatSendBtn.Margin = new System.Windows.Forms.Padding(5);
            chatSendBtn.Name = "chatSendBtn";
            chatSendBtn.Size = new System.Drawing.Size(67, 31);
            chatSendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chatSendBtn.TabIndex = 10;
            chatSendBtn.TabStop = false;
            chatSendBtn.Click += ChatSendBtn_Click;
            // 
            // chatroom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(907, 691);
            Controls.Add(chatSendBtn);
            Controls.Add(pplQty);
            Controls.Add(usersListView);
            Controls.Add(chatRoomTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(5, 245);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "chatroom";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "chatroom";
            FormClosing += chatroom_FormClosing;
            Load += chatroom_Load;
            Shown += chatroom_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatSendBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.RichTextBox chatRoomTextBox;
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader users;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label pplQty;
        private System.Windows.Forms.PictureBox chatSendBtn;
    }
}