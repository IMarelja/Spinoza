namespace Display
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
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            lblUsernameError = new Label();
            lblPasswordError = new Label();
            tbPassword = new TextBox();
            btnRegister = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 69);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 220);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(74, 129);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(297, 31);
            tbUsername.TabIndex = 2;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(389, 133);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(183, 25);
            lblUsernameError.TabIndex = 3;
            lblUsernameError.Text = "Please input usename";
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(389, 282);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(317, 25);
            lblPasswordError.TabIndex = 5;
            lblPasswordError.Text = "Password must be at least 8 characters";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(74, 278);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(297, 31);
            tbPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(164, 403);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(194, 65);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.Location = new Point(407, 403);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(194, 65);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 527);
            Controls.Add(btnLogIn);
            Controls.Add(btnRegister);
            Controls.Add(lblPasswordError);
            Controls.Add(tbPassword);
            Controls.Add(lblUsernameError);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private Label lblUsernameError;
        private Label lblPasswordError;
        private TextBox tbPassword;
        private Button btnRegister;
        private Button btnLogIn;
    }
}