namespace aol.Forms
{
    partial class FavoritesAddForm
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
            TitleBar = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            maxBtn = new Button();
            miniBtn = new Button();
            titleLabel = new Label();
            placeDescBox = new TextBox();
            internetAddrBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(403, 21);
            TitleBar.TabIndex = 3;
            TitleBar.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new Point(382, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
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
            maxBtn.Location = new Point(358, 1);
            maxBtn.Margin = new Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = RightToLeft.No;
            maxBtn.Size = new Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
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
            miniBtn.Location = new Point(337, 1);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(24, 2);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(105, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Add Favorite Place";
            // 
            // placeDescBox
            // 
            placeDescBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            placeDescBox.Location = new Point(14, 55);
            placeDescBox.Margin = new Padding(4);
            placeDescBox.Name = "placeDescBox";
            placeDescBox.Size = new Size(378, 23);
            placeDescBox.TabIndex = 4;
            // 
            // internetAddrBox
            // 
            internetAddrBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            internetAddrBox.Location = new Point(14, 106);
            internetAddrBox.Margin = new Padding(4);
            internetAddrBox.Name = "internetAddrBox";
            internetAddrBox.Size = new Size(378, 23);
            internetAddrBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 6;
            label1.Text = "Enter the Internet Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 7;
            label2.Text = "Enter the Place's Description";
            // 
            // okBtn
            // 
            okBtn.BackColor = Color.FromArgb(0, 109, 170);
            okBtn.Cursor = Cursors.Hand;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.ForeColor = SystemColors.Control;
            okBtn.Location = new Point(133, 141);
            okBtn.Margin = new Padding(4);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(56, 26);
            okBtn.TabIndex = 8;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += OkBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(0, 109, 170);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = SystemColors.Control;
            cancelBtn.Location = new Point(214, 141);
            cancelBtn.Margin = new Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(67, 26);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // FavoritesAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(409, 181);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(internetAddrBox);
            Controls.Add(placeDescBox);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(816, 181);
            MinimumSize = new Size(409, 181);
            Name = "FavoritesAddForm";
            Text = "Add Favorite Place";
            Shown += AddFavorite_Shown;
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox placeDescBox;
        private System.Windows.Forms.TextBox internetAddrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}