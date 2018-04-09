using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void user_RegistrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void email_AddressLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = @"Data Source=THANATOS\SQLEXPRESS01;Initial Catalog=LoginDatabase;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cnn.Open();
            cmd.Parameters.AddWithValue("@First_Name", first_NameTextBox.Text);
            cmd.Parameters.AddWithValue("@Last_Name", last_NameTextBox.Text);
            cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
            cmd.Parameters.AddWithValue("@Email_Address", email_AddressTextBox.Text);
            cmd.Parameters.AddWithValue("@Phone_Numbers", passwordTextBox.Text);
            cmd.CommandText = "INSERT into User_Registration VALUES(@First_Name,@Last_Name,@Username,@Password,@Email_Address,@Phone_Numbers)";

            try
            {                
                //cmd.ExecuteNonQuery();
                MessageBox.Show("You Have Been Registered!");                
            }
            finally
            {
                cnn.Close();
            }
        }

        private void user_RegistrationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_NumbersTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
