namespace Patient_UI
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pwdtxtbox = new System.Windows.Forms.TextBox();
            this.signintxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(342, 237);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(91, 32);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(267, 116);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(92, 22);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxtbox.Location = new System.Drawing.Point(373, 118);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(140, 24);
            this.idtxtbox.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(267, 178);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(89, 22);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(389, 296);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(257, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password / Reset Password";
            // 
            // pwdtxtbox
            // 
            this.pwdtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxtbox.Location = new System.Drawing.Point(373, 180);
            this.pwdtxtbox.Name = "pwdtxtbox";
            this.pwdtxtbox.PasswordChar = '*';
            this.pwdtxtbox.Size = new System.Drawing.Size(140, 24);
            this.pwdtxtbox.TabIndex = 6;
            // 
            // signintxt
            // 
            this.signintxt.AutoSize = true;
            this.signintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signintxt.Location = new System.Drawing.Point(339, 55);
            this.signintxt.Name = "signintxt";
            this.signintxt.Size = new System.Drawing.Size(80, 25);
            this.signintxt.TabIndex = 7;
            this.signintxt.Text = "Sign In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.signintxt);
            this.Controls.Add(this.pwdtxtbox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.idtxtbox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginbtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox pwdtxtbox;
        private System.Windows.Forms.Label signintxt;
    }
}