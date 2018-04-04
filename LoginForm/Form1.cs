using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_Link_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.google.com");
            Process.Start(sInfo);
        }

        private void reMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void MotdButton_Click(object sender, EventArgs e)
        {
            // On Clicking MOTD Button In Login Form 
            // MOTD Form Will Open Up
            {
                MOTD Form2 = new MOTD();
                Form2.ShowDialog(); // Opens Up The MOTD Form
            }
        }
    }
}
