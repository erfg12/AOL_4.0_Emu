﻿namespace aol.Forms
{
    partial class KeywordForm
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
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            closeBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            miniBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            goBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new System.Drawing.Point(3, 1);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(433, 21);
            panel1.TabIndex = 3;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(1, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new System.Drawing.Point(410, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
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
            maxBtn.Location = new System.Drawing.Point(388, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
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
            miniBtn.Location = new System.Drawing.Point(367, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(24, 2);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(53, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Keyword";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(53, 58);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(287, 15);
            label1.TabIndex = 4;
            label1.Text = "Type an AOL Keyword in the input box, then click Go.";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(57, 80);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(267, 23);
            textBox1.TabIndex = 5;
            // 
            // goBtn
            // 
            goBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            goBtn.Location = new System.Drawing.Point(329, 80);
            goBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            goBtn.Name = "goBtn";
            goBtn.Size = new System.Drawing.Size(43, 23);
            goBtn.TabIndex = 6;
            goBtn.Text = "Go";
            goBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label2.Location = new System.Drawing.Point(56, 106);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 13);
            label2.TabIndex = 7;
            label2.Text = "Keyword List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label3.Location = new System.Drawing.Point(143, 106);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 13);
            label3.TabIndex = 8;
            label3.Text = "AOL Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label4.Location = new System.Drawing.Point(227, 106);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 13);
            label4.TabIndex = 9;
            label4.Text = "Help";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(133, 106);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(10, 15);
            label5.TabIndex = 10;
            label5.Text = "|";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(217, 106);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(10, 15);
            label6.TabIndex = 11;
            label6.Text = "|";
            // 
            // KeywordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 251, 240);
            ClientSize = new System.Drawing.Size(437, 161);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(goBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(215, 220);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "KeywordForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Keyword";
            LocationChanged += KeywordForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}