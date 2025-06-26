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
            lbMessage = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogIn.Location = new Point(449, 310);
            btnLogIn.Margin = new Padding(4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(118, 44);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(449, 112);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Spinosa";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUsername.Location = new Point(338, 180);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(334, 36);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(338, 238);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(334, 36);
            tbPassword.TabIndex = 3;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRegister.ForeColor = SystemColors.HotTrack;
            lblRegister.Location = new Point(315, 422);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(232, 30);
            lblRegister.TabIndex = 4;
            lblRegister.Text = "Don't have an account?";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(561, 418);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(129, 41);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(338, 375);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(82, 25);
            lbMessage.TabIndex = 6;
            lbMessage.Text = "Message";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbMessage);
            Controls.Add(btnRegister);
            Controls.Add(lblRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblTitle);
            Controls.Add(btnLogIn);
            Margin = new Padding(4);
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
        private Label lbMessage;
    }
}