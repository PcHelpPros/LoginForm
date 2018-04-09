namespace LoginForm
{
    partial class UserRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label phone_NumbersLabel;
            this.loginDatabaseDataSet1 = new LoginForm.LoginDatabaseDataSet1();
            this.user_RegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_RegistrationTableAdapter = new LoginForm.LoginDatabaseDataSet1TableAdapters.User_RegistrationTableAdapter();
            this.tableAdapterManager = new LoginForm.LoginDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumbersTextBox = new System.Windows.Forms.TextBox();
            this.register_Button1 = new System.Windows.Forms.Button();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            phone_NumbersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_RegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(31, 46);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 1;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(31, 81);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 3;
            last_NameLabel.Text = "Last Name:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(34, 116);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(36, 151);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Location = new System.Drawing.Point(16, 187);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(76, 13);
            email_AddressLabel.TabIndex = 9;
            email_AddressLabel.Text = "Email Address:";
            email_AddressLabel.Click += new System.EventHandler(this.email_AddressLabel_Click);
            // 
            // phone_NumbersLabel
            // 
            phone_NumbersLabel.AutoSize = true;
            phone_NumbersLabel.Location = new System.Drawing.Point(6, 221);
            phone_NumbersLabel.Name = "phone_NumbersLabel";
            phone_NumbersLabel.Size = new System.Drawing.Size(86, 13);
            phone_NumbersLabel.TabIndex = 11;
            phone_NumbersLabel.Text = "Phone Numbers:";
            // 
            // loginDatabaseDataSet1
            // 
            this.loginDatabaseDataSet1.DataSetName = "LoginDatabaseDataSet1";
            this.loginDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_RegistrationBindingSource
            // 
            this.user_RegistrationBindingSource.DataMember = "User Registration";
            this.user_RegistrationBindingSource.DataSource = this.loginDatabaseDataSet1;
            this.user_RegistrationBindingSource.CurrentChanged += new System.EventHandler(this.user_RegistrationBindingSource_CurrentChanged);
            // 
            // user_RegistrationTableAdapter
            // 
            this.user_RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LoginForm.LoginDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_RegistrationTableAdapter = this.user_RegistrationTableAdapter;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(95, 43);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 2;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(95, 78);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 4;
            this.last_NameTextBox.TextChanged += new System.EventHandler(this.last_NameTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(95, 113);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(95, 148);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(95, 184);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.email_AddressTextBox.TabIndex = 10;
            this.email_AddressTextBox.TextChanged += new System.EventHandler(this.email_AddressTextBox_TextChanged);
            // 
            // phone_NumbersTextBox
            // 
            this.phone_NumbersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_RegistrationBindingSource, "Phone Numbers", true));
            this.phone_NumbersTextBox.Location = new System.Drawing.Point(95, 218);
            this.phone_NumbersTextBox.Name = "phone_NumbersTextBox";
            this.phone_NumbersTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_NumbersTextBox.TabIndex = 12;
            this.phone_NumbersTextBox.TextChanged += new System.EventHandler(this.phone_NumbersTextBox_TextChanged);
            // 
            // register_Button1
            // 
            this.register_Button1.Location = new System.Drawing.Point(95, 251);
            this.register_Button1.Name = "register_Button1";
            this.register_Button1.Size = new System.Drawing.Size(75, 23);
            this.register_Button1.TabIndex = 13;
            this.register_Button1.Text = "Register!";
            this.register_Button1.UseVisualStyleBackColor = true;
            this.register_Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 286);
            this.Controls.Add(this.register_Button1);
            this.Controls.Add(phone_NumbersLabel);
            this.Controls.Add(this.phone_NumbersTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Name = "UserRegistration";
            this.Text = "UserRegistration";
            this.Load += new System.EventHandler(this.UserRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_RegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginDatabaseDataSet1 loginDatabaseDataSet1;
        private System.Windows.Forms.BindingSource user_RegistrationBindingSource;
        private LoginDatabaseDataSet1TableAdapters.User_RegistrationTableAdapter user_RegistrationTableAdapter;
        private LoginDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox phone_NumbersTextBox;
        private System.Windows.Forms.Button register_Button1;
    }
}