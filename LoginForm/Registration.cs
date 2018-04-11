using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginFormTable);

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginFormTable.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.loginFormTable.Table);

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = @"Data Source=THANATOS\SQLEXPRESS01;Initial Catalog=LoginDatabase;Integrated Security=True";                       
            try
            {
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    if (connection.State == ConnectionState.Closed) // Checking connection status, if closed then open.
                    {
                        connection.Open();
                        this.Hide();
                    }
                    String query = "INSERT INTO dbo.[Table] (FirstName,LastName,Username,Password,Email,PhoneNum) VALUES (@FirstName,@LastName,@Username,@Password,@Email,@PhoneNum)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {                       

                        cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text
                        cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text
                        cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text
                        cmd.Parameters.AddWithValue("@PhoneNum", phoneNumTextBox.Text); // Syntax @"TableColumnName", TextBoxToGrabInfoFrom.Text

                        int result = cmd.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Error inserting data into Database!"); // If error, display message.
                    }
                }
            }
            catch (Exception ex)
            {
                string v = ex.Message;
                throw ex;
            }

        }

        private void phoneNumLabel_Click(object sender, EventArgs e)
        {

        }
    }
}