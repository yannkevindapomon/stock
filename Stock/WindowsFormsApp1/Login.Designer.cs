namespace WindowsFormsApp1
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clearlbl = new System.Windows.Forms.Button();
            this.Loginlbl = new System.Windows.Forms.Button();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.cplbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(147, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "admin";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(147, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(249, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "admin@111";
            // 
            // clearlbl
            // 
            this.clearlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clearlbl.Location = new System.Drawing.Point(146, 178);
            this.clearlbl.Name = "clearlbl";
            this.clearlbl.Size = new System.Drawing.Size(104, 33);
            this.clearlbl.TabIndex = 4;
            this.clearlbl.Text = "Clear";
            this.clearlbl.UseVisualStyleBackColor = true;
            this.clearlbl.Click += new System.EventHandler(this.clearlbl_Click);
            // 
            // Loginlbl
            // 
            this.Loginlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Loginlbl.Location = new System.Drawing.Point(256, 178);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(104, 33);
            this.Loginlbl.TabIndex = 5;
            this.Loginlbl.Text = "Login";
            this.Loginlbl.UseVisualStyleBackColor = true;
            this.Loginlbl.Click += new System.EventHandler(this.Loginlbl_Click);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(40, 69);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(97, 20);
            this.Usernamelbl.TabIndex = 6;
            this.Usernamelbl.Text = "User Name :";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.passwordlbl.Location = new System.Drawing.Point(49, 116);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(87, 20);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password :";
            // 
            // cplbl
            // 
            this.cplbl.AutoSize = true;
            this.cplbl.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cplbl.Location = new System.Drawing.Point(163, 18);
            this.cplbl.Name = "cplbl";
            this.cplbl.Size = new System.Drawing.Size(160, 21);
            this.cplbl.TabIndex = 8;
            this.cplbl.Text = "Company Brand";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.linkLabel1.Location = new System.Drawing.Point(279, 149);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 249);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cplbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.clearlbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button clearlbl;
        private System.Windows.Forms.Button Loginlbl;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label cplbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}