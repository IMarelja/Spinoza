namespace Display
{
    partial class LoginForm
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
            btnLogIn = new Button();
            lblTitle = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lblRegister = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogIn.Location = new Point(359, 248);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 35);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(359, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(94, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Spinosa";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUsername.Location = new Point(270, 144);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(268, 31);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(270, 190);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(268, 31);
            tbPassword.TabIndex = 3;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRegister.ForeColor = SystemColors.HotTrack;
            lblRegister.Location = new Point(252, 338);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(191, 23);
            lblRegister.TabIndex = 4;
            lblRegister.Text = "Don't have an account?";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(449, 334);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 33);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(lblRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblTitle);
            Controls.Add(btnLogIn);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Label lblTitle;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblRegister;
        private Button btnRegister;
    }
}