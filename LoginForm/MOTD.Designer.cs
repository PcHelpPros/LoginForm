namespace LoginForm
{
    partial class MOTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOTD));
            this.MotdChangelog = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MotdChangelog
            // 
            this.MotdChangelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotdChangelog.Location = new System.Drawing.Point(13, 13);
            this.MotdChangelog.Name = "MotdChangelog";
            this.MotdChangelog.ReadOnly = true;
            this.MotdChangelog.Size = new System.Drawing.Size(87, 27);
            this.MotdChangelog.TabIndex = 0;
            this.MotdChangelog.Text = "Changelog";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 203);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MOTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MotdChangelog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MOTD";
            this.Text = "MOTD";
            this.Load += new System.EventHandler(this.MOTD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MotdChangelog;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}