namespace LoginForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reMeCheckBox = new System.Windows.Forms.CheckBox();
            this.Register_Link_Label = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.MotdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 20);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // reMeCheckBox
            // 
            this.reMeCheckBox.AutoSize = true;
            this.reMeCheckBox.Location = new System.Drawing.Point(28, 133);
            this.reMeCheckBox.Name = "reMeCheckBox";
            this.reMeCheckBox.Size = new System.Drawing.Size(101, 17);
            this.reMeCheckBox.TabIndex = 6;
            this.reMeCheckBox.Text = "Remember Me?";
            this.reMeCheckBox.UseVisualStyleBackColor = true;
            this.reMeCheckBox.CheckedChanged += new System.EventHandler(this.reMeCheckBox_CheckedChanged);
            // 
            // Register_Link_Label
            // 
            this.Register_Link_Label.AutoSize = true;
            this.Register_Link_Label.Location = new System.Drawing.Point(25, 173);
            this.Register_Link_Label.Name = "Register_Link_Label";
            this.Register_Link_Label.Size = new System.Drawing.Size(49, 13);
            this.Register_Link_Label.TabIndex = 7;
            this.Register_Link_Label.TabStop = true;
            this.Register_Link_Label.Text = "Register!";
            this.Register_Link_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Link_Label_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoginButton.Location = new System.Drawing.Point(175, 128);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(70, 24);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MotdButton
            // 
            this.MotdButton.Image = ((System.Drawing.Image)(resources.GetObject("MotdButton.Image")));
            this.MotdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MotdButton.Location = new System.Drawing.Point(263, 167);
            this.MotdButton.Name = "MotdButton";
            this.MotdButton.Size = new System.Drawing.Size(62, 24);
            this.MotdButton.TabIndex = 9;
            this.MotdButton.Text = "MOTD";
            this.MotdButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MotdButton.UseVisualStyleBackColor = true;
            this.MotdButton.Click += new System.EventHandler(this.MotdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 195);
            this.Controls.Add(this.MotdButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Register_Link_Label);
            this.Controls.Add(this.reMeCheckBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox reMeCheckBox;
        private System.Windows.Forms.LinkLabel Register_Link_Label;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button MotdButton;
    }
}

