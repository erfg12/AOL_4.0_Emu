namespace aol.Forms
{
    partial class chat_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat_list));
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            searchTextBox = new System.Windows.Forms.TextBox();
            catListView = new System.Windows.Forms.ListView();
            category_column = new System.Windows.Forms.ColumnHeader();
            chanListView = new System.Windows.Forms.ListView();
            channels = new System.Windows.Forms.ColumnHeader();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            roomsIn = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(704, 21);
            panel1.TabIndex = 2;
            panel1.MouseDoubleClick += panel1_MouseDoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(29, 4);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(82, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Chatroom List";
            mainTitle.MouseMove += mainTitle_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(4, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(4, 4);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(0, 15);
            titleLabel.TabIndex = 3;
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
            miniBtn.Location = new System.Drawing.Point(638, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4);
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
            maxBtn.Location = new System.Drawing.Point(659, 1);
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
            closeBtn.Location = new System.Drawing.Point(682, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchTextBox.Location = new System.Drawing.Point(14, 127);
            searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(168, 18);
            searchTextBox.TabIndex = 3;
            // 
            // catListView
            // 
            catListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { category_column });
            catListView.FullRowSelect = true;
            catListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            catListView.Location = new System.Drawing.Point(21, 256);
            catListView.Margin = new System.Windows.Forms.Padding(4);
            catListView.MultiSelect = false;
            catListView.Name = "catListView";
            catListView.Size = new System.Drawing.Size(166, 203);
            catListView.TabIndex = 7;
            catListView.UseCompatibleStateImageBehavior = false;
            catListView.View = System.Windows.Forms.View.Details;
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
            chanListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { channels });
            chanListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            chanListView.Location = new System.Drawing.Point(196, 256);
            chanListView.Margin = new System.Windows.Forms.Padding(4);
            chanListView.Name = "chanListView";
            chanListView.Size = new System.Drawing.Size(276, 184);
            chanListView.TabIndex = 8;
            chanListView.UseCompatibleStateImageBehavior = false;
            chanListView.View = System.Windows.Forms.View.Details;
            chanListView.DoubleClick += chanListView_DoubleClick;
            // 
            // channels
            // 
            channels.Text = "channels";
            channels.Width = 231;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(3, 23);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(704, 482);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            // 
            // roomsIn
            // 
            roomsIn.AutoSize = true;
            roomsIn.BackColor = System.Drawing.Color.FromArgb(201, 229, 248);
            roomsIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            roomsIn.Location = new System.Drawing.Point(312, 238);
            roomsIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomsIn.Name = "roomsIn";
            roomsIn.Size = new System.Drawing.Size(13, 15);
            roomsIn.TabIndex = 10;
            roomsIn.Text = "''";
            // 
            // chat_list
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(710, 506);
            Controls.Add(roomsIn);
            Controls.Add(chanListView);
            Controls.Add(catListView);
            Controls.Add(searchTextBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(10, 245);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "chat_list";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "chat_list";
            Load += chat_list_Load;
            Shown += chat_list_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}