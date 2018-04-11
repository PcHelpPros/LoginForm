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
                    SqlConnection cnn = new SqlConnection(connetionString);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;           
                try
            {
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    String query = "INSERT INTO dbo.Table (FirstName,LastName,Username,Password,Email,PhoneNum) VALUES (@FirstName,@LastName,@Username,@Password,@Email,@PhoneNum)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        int result = command.ExecuteNonQuery();
                        cnn.Open();

                        int result = cmd.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
                }
                }
            }
            finally
            {
                cnn.Close();
            }           
            
        }

        private void phoneNumLabel_Click(object sender, EventArgs e)
        {

        }
    }
}