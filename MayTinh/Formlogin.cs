
namespace MayTinh
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Register = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(136, 106);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(125, 27);
            this.txt_Email.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(136, 180);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(125, 27);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(5, 247);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(112, 29);
            this.bt_Login.TabIndex = 5;
            this.bt_Login.Text = "LOGIN";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Register
            // 
            this.bt_Register.Location = new System.Drawing.Point(152, 247);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(109, 29);
            this.bt_Register.TabIndex = 6;
            this.bt_Register.Text = "REGISTER";
            this.bt_Register.UseVisualStyleBackColor = true;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(424, 247);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(110, 29);
            this.bt_Exit.TabIndex = 7;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_ChangePass
            // 
            this.bt_ChangePass.Location = new System.Drawing.Point(287, 247);
            this.bt_ChangePass.Name = "bt_ChangePass";
            this.bt_ChangePass.Size = new System.Drawing.Size(112, 29);
            this.bt_ChangePass.TabIndex = 8;
            this.bt_ChangePass.Text = "ResetPassword";
            this.bt_ChangePass.UseVisualStyleBackColor = true;
            this.bt_ChangePass.Click += new System.EventHandler(this.bt_ChangePass_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 385);
            this.Controls.Add(this.bt_ChangePass);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Name = "Form2";
            this.Text = "LOGIN FORM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_ChangePass;
    }
}