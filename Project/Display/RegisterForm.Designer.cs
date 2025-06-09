namespace Display
{
    partial class RegisterForm
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
            lblRegister = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbPasswordAgain = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRegister.Location = new Point(91, 61);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(82, 28);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUsername.Location = new Point(91, 110);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter a username";
            tbUsername.Size = new Size(281, 30);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(91, 212);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter a password";
            tbPassword.Size = new Size(281, 30);
            tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbEmail.Location = new Point(91, 160);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter a valid email address";
            tbEmail.Size = new Size(281, 30);
            tbEmail.TabIndex = 3;
            // 
            // tbPasswordAgain
            // 
            tbPasswordAgain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPasswordAgain.Location = new Point(91, 266);
            tbPasswordAgain.Name = "tbPasswordAgain";
            tbPasswordAgain.PlaceholderText = "Enter your password again";
            tbPasswordAgain.Size = new Size(281, 30);
            tbPasswordAgain.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(91, 317);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 36);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Save";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(tbPasswordAgain);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbPasswordAgain;
        private Button btnRegister;
    }
}