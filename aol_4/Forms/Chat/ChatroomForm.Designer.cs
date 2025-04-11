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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ChatroomForm));
            messageTextBox = new TextBox();
            chatRoomTextBox = new RichTextBox();
            panel1 = new Panel();
            mainTitle = new Label();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            usersListView = new ListView();
            users = new ColumnHeader();
            backgroundWorker1 = new BackgroundWorker();
            BackgroundPictureBox = new PictureBox();
            pplQty = new Label();
            chatSendBtn = new PictureBox();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)BackgroundPictureBox).BeginInit();
            ((ISupportInitialize)chatSendBtn).BeginInit();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.Font = new Font("Microsoft Sans Serif", 14F);
            messageTextBox.Location = new Point(20, 482);
            messageTextBox.Margin = new Padding(4);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(468, 22);
            messageTextBox.TabIndex = 3;
            messageTextBox.KeyDown += MessageTextBox_KeyDown;
            // 
            // chatRoomTextBox
            // 
            chatRoomTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatRoomTextBox.BackColor = Color.White;
            chatRoomTextBox.BorderStyle = BorderStyle.None;
            chatRoomTextBox.Location = new Point(20, 30);
            chatRoomTextBox.Margin = new Padding(4);
            chatRoomTextBox.Name = "chatRoomTextBox";
            chatRoomTextBox.ReadOnly = true;
            chatRoomTextBox.Size = new Size(537, 405);
            chatRoomTextBox.TabIndex = 6;
            chatRoomTextBox.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 21);
            panel1.TabIndex = 2;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(25, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(61, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Chatroom";
            mainTitle.MouseMove += MainTitle_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(4, 4);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 15);
            titleLabel.TabIndex = 3;
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
            miniBtn.Location = new Point(722, 1);
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
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(743, 1);
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
            closeBtn.Location = new Point(766, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // usersListView
            // 
            usersListView.BorderStyle = BorderStyle.None;
            usersListView.Columns.AddRange(new ColumnHeader[] { users });
            usersListView.HeaderStyle = ColumnHeaderStyle.None;
            usersListView.Location = new Point(570, 119);
            usersListView.Margin = new Padding(4);
            usersListView.Name = "usersListView";
            usersListView.Size = new Size(201, 202);
            usersListView.TabIndex = 7;
            usersListView.UseCompatibleStateImageBehavior = false;
            usersListView.View = View.Details;
            usersListView.DoubleClick += UsersListView_DoubleClick;
            // 
            // users
            // 
            users.Text = "users";
            users.Width = 170;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += BackgroundWorker_DoWork;
            // 
            // BackgroundPictureBox
            // 
            BackgroundPictureBox.BackgroundImage = (Image)resources.GetObject("BackgroundPictureBox.BackgroundImage");
            BackgroundPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundPictureBox.Location = new Point(3, 23);
            BackgroundPictureBox.Margin = new Padding(4);
            BackgroundPictureBox.Name = "BackgroundPictureBox";
            BackgroundPictureBox.Size = new Size(788, 494);
            BackgroundPictureBox.TabIndex = 8;
            BackgroundPictureBox.TabStop = false;
            // 
            // pplQty
            // 
            pplQty.AutoSize = true;
            pplQty.BackColor = Color.FromArgb(209, 229, 243);
            pplQty.Location = new Point(668, 62);
            pplQty.Margin = new Padding(4, 0, 4, 0);
            pplQty.Name = "pplQty";
            pplQty.Size = new Size(14, 15);
            pplQty.TabIndex = 9;
            pplQty.Text = "#";
            // 
            // chatSendBtn
            // 
            chatSendBtn.Cursor = Cursors.Hand;
            chatSendBtn.Image = (Image)resources.GetObject("chatSendBtn.Image");
            chatSendBtn.Location = new Point(497, 479);
            chatSendBtn.Margin = new Padding(4);
            chatSendBtn.Name = "chatSendBtn";
            chatSendBtn.Size = new Size(59, 23);
            chatSendBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            chatSendBtn.TabIndex = 10;
            chatSendBtn.TabStop = false;
            chatSendBtn.Click += ChatSendBtn_Click;
            // 
            // ChatroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 518);
            Controls.Add(chatSendBtn);
            Controls.Add(pplQty);
            Controls.Add(usersListView);
            Controls.Add(chatRoomTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(panel1);
            Controls.Add(BackgroundPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(5, 245);
            Margin = new Padding(4);
            Name = "ChatroomForm";
            StartPosition = FormStartPosition.Manual;
            Text = "chatroom";
            FormClosing += Chatroom_FormClosing;
            Shown += Chatroom_Shown;
            LocationChanged += ChatroomForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)BackgroundPictureBox).EndInit();
            ((ISupportInitialize)chatSendBtn).EndInit();
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
        private System.Windows.Forms.PictureBox BackgroundPictureBox;
        private System.Windows.Forms.Label pplQty;
        private System.Windows.Forms.PictureBox chatSendBtn;
    }
}