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
            tbPasswordAgain = new TextBox();
            btnRegister = new Button();
            lbMessage = new Label();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRegister.Location = new Point(114, 76);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(99, 32);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUsername.Location = new Point(114, 138);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter a username";
            tbUsername.Size = new Size(350, 35);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(114, 202);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter a password";
            tbPassword.Size = new Size(350, 35);
            tbPassword.TabIndex = 2;
            // 
            // tbPasswordAgain
            // 
            tbPasswordAgain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPasswordAgain.Location = new Point(114, 269);
            tbPasswordAgain.Margin = new Padding(4);
            tbPasswordAgain.Name = "tbPasswordAgain";
            tbPasswordAgain.PlaceholderText = "Enter your password again";
            tbPasswordAgain.Size = new Size(350, 35);
            tbPasswordAgain.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(114, 339);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(129, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(274, 339);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(82, 25);
            lbMessage.TabIndex = 6;
            lbMessage.Text = "Message";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 547);
            Controls.Add(lbMessage);
            Controls.Add(btnRegister);
            Controls.Add(tbPasswordAgain);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lblRegister);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbPasswordAgain;
        private Button btnRegister;
        private Label lbMessage;
    }
}