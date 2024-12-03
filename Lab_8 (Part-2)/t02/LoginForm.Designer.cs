namespace Lab__12
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button registerButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(10, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 51);
            this.titleLabel.Text = "Login";

            // usernameTextBox
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(50, 100);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 22);

            // usernamePanel
            this.usernamePanel.Location = new System.Drawing.Point(50, 122);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(300, 1);

            // passwordTextBox
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(50, 140);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 22);
            this.passwordTextBox.UseSystemPasswordChar = true;

            // passwordPanel
            this.passwordPanel.Location = new System.Drawing.Point(50, 162);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(300, 1);

            // loginButton
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(50, 190);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 40);
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false; // Enable custom backcolor
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);

            // registerButton
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.registerButton.Location = new System.Drawing.Point(50, 240);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(80, 30);
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false; // Enable custom backcolor
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);

            // errorLabel
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.errorLabel.Location = new System.Drawing.Point(50, 290);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 21);
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // LoginForm
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.errorLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
