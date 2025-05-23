﻿namespace aol.Forms
{
    partial class MsgBoxForm
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
            closeBtn = new Button();
            TitleBar = new Panel();
            titleLabel = new Label();
            richTextBox = new RichTextBox();
            okBtn = new Button();
            TitleBar.SuspendLayout();
            SuspendLayout();
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
            closeBtn.Location = new Point(268, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSize = true;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Location = new Point(2, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(289, 20);
            TitleBar.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(2, 2);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(49, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "MsgBox";
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.BackColor = Color.FromArgb(255, 251, 240);
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Location = new Point(4, 25);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(287, 91);
            richTextBox.TabIndex = 5;
            richTextBox.TabStop = false;
            richTextBox.Text = "";
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.FromArgb(0, 109, 170);
            okBtn.Cursor = Cursors.Hand;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Font = new Font("Arial", 8.25F);
            okBtn.ForeColor = SystemColors.Control;
            okBtn.Location = new Point(213, 119);
            okBtn.Margin = new Padding(4);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(77, 26);
            okBtn.TabIndex = 6;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += OkBtn_Click;
            // 
            // MsgBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(294, 149);
            Controls.Add(okBtn);
            Controls.Add(richTextBox);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(375, 250);
            Name = "MsgBoxForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MsgBoxForm";
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button okBtn;
    }
}