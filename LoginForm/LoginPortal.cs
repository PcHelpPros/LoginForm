using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginPortal : Form
    {
        public LoginPortal()
        {
            InitializeComponent();
        }
                
        private void reMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
              using (SqlConnection con = new SqlConnection(@"Data Source=THANATOS\SQLEXPRESS01;Initial Catalog=LoginDatabase;Integrated Security=True"))
                // making connection
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserAlias WHERE UserName='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", con);
                        DataTable dt = new DataTable(); //this is creating a virtual table  
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            this.Hide(); // Hide The Login Form Once Login Is Successful.
                             
                        }
                        else
                            MessageBox.Show("Invalid username or password");

                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                    }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            new UserRegistration().Show(); // Displays The Registration Form
        }
    }
}
