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
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.[Table] WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", con);
                        DataTable dt = new DataTable(); //this is creating a virtual table  
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            this.Hide(); // Hide The Login Form Once Login Is Successful.
                             
                        }
                        else
                            MessageBox.Show("Invalid username or password");

                    }

                catch (Exception ex)
                {
                    string v = ex.Message;
                    throw ex;
                }
                finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

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
            new Registration().Show();
        }
    }
}