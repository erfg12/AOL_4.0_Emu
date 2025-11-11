namespace Uninstall
{
    partial class UninstallForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uninstallBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // uninstallBtn
            // 
            uninstallBtn.Location = new Point(281, 12);
            uninstallBtn.Name = "uninstallBtn";
            uninstallBtn.Size = new Size(75, 40);
            uninstallBtn.TabIndex = 0;
            uninstallBtn.Text = "Uninstall";
            uninstallBtn.UseVisualStyleBackColor = true;
            uninstallBtn.Click += uninstallBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(263, 40);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Click the Uninstall button to remove AOL 4.0 Emu.";
            // 
            // UninstallForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 64);
            Controls.Add(richTextBox1);
            Controls.Add(uninstallBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UninstallForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AOL 4.0 Emu Uninstaller";
            FormClosing += UninstallForm_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button uninstallBtn;
        private RichTextBox richTextBox1;
    }
}
