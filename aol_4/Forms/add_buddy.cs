using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class add_buddy : Form
    {
        public add_buddy()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (RestAPI.addBuddy(nameTextBox.Text))
                MessageBox.Show("Buddy Added!");
            else
                MessageBox.Show("Error: Buddy not added.");
            Close();
        }
    }
}
