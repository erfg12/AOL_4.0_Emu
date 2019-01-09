using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol
{
    public partial class dial_up : Form
    {
        public dial_up()
        {
            InitializeComponent();
            this.TopLevel = true;
            this.Focus();
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    statusLabel.Text = "Step 1: Looking for AOL via TCP/IP...";
                    break;
                case 1:
                    pictureBox1.Visible = Visible;
                    statusLabel.Text = "Step 2: Connecting using TCP/IP ...";
                    break;
                case 2:
                    pictureBox2.Visible = Visible;
                    statusLabel.Text = "Step 3: Checking password ...";
                    break;
                case 3:
                    pictureBox3.Visible = Visible;
                    break;
                case 4:
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.Stream = Properties.Resources.Welcome;
                    player.Play();
                    this.Close();
                    break;
                default:
                    break;
            }
            i++;
        }
    }
}
