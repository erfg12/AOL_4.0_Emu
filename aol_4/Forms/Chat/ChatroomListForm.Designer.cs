namespace aol.Forms
{
    partial class ChatroomListForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ChatroomListForm));
            TitleBar = new Panel();
            mainTitle = new Label();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            searchTextBox = new TextBox();
            catListView = new ListView();
            category_column = new ColumnHeader();
            chanListView = new ListView();
            channels = new ColumnHeader();
            pictureBox2 = new PictureBox();
            roomsIn = new Label();
            goChatBtn = new PictureBox();
            searchBtn = new PictureBox();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)goChatBtn).BeginInit();
            ((ISupportInitialize)searchBtn).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSize = true;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(mainTitle);
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(704, 29);
            TitleBar.TabIndex = 2;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(29, 4);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(82, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Chatroom List";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(4, 0);
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
            titleLabel.Size = new Size(0, 25);
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
            miniBtn.Location = new Point(638, 1);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += miniBtn_Click;
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
            maxBtn.Location = new Point(659, 1);
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
            closeBtn.Location = new Point(682, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.Location = new Point(18, 128);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(162, 15);
            searchTextBox.TabIndex = 3;
            // 
            // catListView
            // 
            catListView.BorderStyle = BorderStyle.None;
            catListView.Columns.AddRange(new ColumnHeader[] { category_column });
            catListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            catListView.FullRowSelect = true;
            catListView.HeaderStyle = ColumnHeaderStyle.None;
            catListView.Location = new Point(21, 258);
            catListView.Margin = new Padding(4);
            catListView.MultiSelect = false;
            catListView.Name = "catListView";
            catListView.Size = new Size(164, 200);
            catListView.TabIndex = 7;
            catListView.UseCompatibleStateImageBehavior = false;
            catListView.View = View.Details;
            catListView.SelectedIndexChanged += catListView_SelectedIndexChanged;
            catListView.MouseClick += catListView_MouseClick;
            // 
            // category_column
            // 
            category_column.Text = "categories";
            category_column.Width = 135;
            // 
            // chanListView
            // 
            chanListView.BorderStyle = BorderStyle.None;
            chanListView.Columns.AddRange(new ColumnHeader[] { channels });
            chanListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            chanListView.HeaderStyle = ColumnHeaderStyle.None;
            chanListView.Location = new Point(201, 258);
            chanListView.Margin = new Padding(4);
            chanListView.Name = "chanListView";
            chanListView.Size = new Size(268, 182);
            chanListView.TabIndex = 8;
            chanListView.UseCompatibleStateImageBehavior = false;
            chanListView.View = View.Details;
            chanListView.DoubleClick += chanListView_DoubleClick;
            // 
            // channels
            // 
            channels.Text = "channels";
            channels.Width = 231;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(704, 482);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // roomsIn
            // 
            roomsIn.AutoSize = true;
            roomsIn.BackColor = Color.FromArgb(201, 229, 248);
            roomsIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            roomsIn.ForeColor = Color.DarkSlateGray;
            roomsIn.Location = new Point(312, 238);
            roomsIn.Margin = new Padding(4, 0, 4, 0);
            roomsIn.Name = "roomsIn";
            roomsIn.Size = new Size(13, 15);
            roomsIn.TabIndex = 10;
            roomsIn.Text = "''";
            // 
            // goChatBtn
            // 
            goChatBtn.BackgroundImage = (Image)resources.GetObject("goChatBtn.BackgroundImage");
            goChatBtn.BackgroundImageLayout = ImageLayout.Stretch;
            goChatBtn.Cursor = Cursors.Hand;
            goChatBtn.Location = new Point(192, 450);
            goChatBtn.Margin = new Padding(3, 2, 3, 2);
            goChatBtn.Name = "goChatBtn";
            goChatBtn.Size = new Size(85, 26);
            goChatBtn.TabIndex = 11;
            goChatBtn.TabStop = false;
            goChatBtn.Click += goChatBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = (Image)resources.GetObject("searchBtn.BackgroundImage");
            searchBtn.BackgroundImageLayout = ImageLayout.Stretch;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.Location = new Point(186, 122);
            searchBtn.Margin = new Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(73, 26);
            searchBtn.TabIndex = 12;
            searchBtn.TabStop = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // ChatroomListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 506);
            Controls.Add(searchBtn);
            Controls.Add(goChatBtn);
            Controls.Add(roomsIn);
            Controls.Add(chanListView);
            Controls.Add(catListView);
            Controls.Add(searchTextBox);
            Controls.Add(TitleBar);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(10, 245);
            Margin = new Padding(4);
            Name = "ChatroomListForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Chatroom List";
            Load += chat_list_Load;
            Shown += chat_list_Shown;
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)goChatBtn).EndInit();
            ((ISupportInitialize)searchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView catListView;
        private System.Windows.Forms.ListView chanListView;
        private System.Windows.Forms.ColumnHeader category_column;
        private System.Windows.Forms.ColumnHeader channels;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label roomsIn;
        private System.Windows.Forms.PictureBox goChatBtn;
        private System.Windows.Forms.PictureBox searchBtn;
    }
}