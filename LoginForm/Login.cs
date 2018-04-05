using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace LoginForm
{
    public static class Interaction
    {

    }
    public partial class Login : Form
    {

        private object path;

        private void Login_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(string.Concat(path, "\\EasyLogin\\")))
            {
                Directory.CreateDirectory(string.Concat(path, "\\EasyLogin\\"));
                path = (string.Concat(path, "\\EasyLogin\\"));
            }

            
        }

        private void check()
        {
            WebRequest request = WebRequest.Create("http://synex.pw/program/version.txt");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string output = reader.ReadToEnd();
            if (!output.Contains(Application.ProductVersion))
            {
                MessageBox.Show("Update found.", "Can't Proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start("http://synex.pw/program/program.zip");
                this.Close();

            }

           
        {
            InitializeComponent();
        }
        
        void Register_Link_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.google.com");
            Process.Start(sInfo);
        }

        void reMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        void LoginButton_Click(object sender, EventArgs e)
        {

        }

        void MotdButton_Click(object sender, EventArgs e)
        {
            // On Clicking MOTD Button In Login Form 
            // MOTD Form Will Open Up
            {
                MOTD Form2 = new MOTD();
                Form2.ShowDialog(); // Opens Up The MOTD Form
            }
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Object path;
    }
    }
}
