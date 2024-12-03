namespace Lab__12
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameErrorLabel;

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Label emailErrorLabel;

        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel phonePanel;
        private System.Windows.Forms.Label phoneErrorLabel;

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Label passwordErrorLabel;

        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Panel confirmPasswordPanel;
        private System.Windows.Forms.Label confirmPasswordErrorLabel;

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;

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

            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameErrorLabel = new System.Windows.Forms.Label();

            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailErrorLabel = new System.Windows.Forms.Label();

            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.phoneErrorLabel = new System.Windows.Forms.Label();

            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordErrorLabel = new System.Windows.Forms.Label();

            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordErrorLabel = new System.Windows.Forms.Label();

            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(10, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 51);
            this.titleLabel.Text = "Register";

            // nameTextBox
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(35, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Name";
            this.nameTextBox.Size = new System.Drawing.Size(350, 22);

            // namePanel
            this.namePanel.Location = new System.Drawing.Point(35, 122);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(350, 1);

            // nameErrorLabel
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(35, 125);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.Text = "";

            // emailTextBox
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(35, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.Size = new System.Drawing.Size(350, 22);

            // emailPanel
            this.emailPanel.Location = new System.Drawing.Point(35, 162);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(350, 1);

            // emailErrorLabel
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(35, 165);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.emailErrorLabel.Text = "";

            // phoneTextBox
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(35, 180);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PlaceholderText = "Phone";
            this.phoneTextBox.Size = new System.Drawing.Size(350, 22);

            // phonePanel
            this.phonePanel.Location = new System.Drawing.Point(35, 202);
            this.phonePanel.Name = "phonePanel";
            this.phonePanel.Size = new System.Drawing.Size(350, 1);

            // phoneErrorLabel
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(35, 205);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorLabel.Text = "";

            // passwordTextBox
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(35, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(350, 22);
            this.passwordTextBox.UseSystemPasswordChar = true;

            // passwordPanel
            this.passwordPanel.Location = new System.Drawing.Point(35, 242);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(350, 1);

            // passwordErrorLabel
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(35, 245);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordErrorLabel.Text = "";

            // confirmPasswordTextBox
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(35, 260);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(350, 22);
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;

            // confirmPasswordPanel
            this.confirmPasswordPanel.Location = new System.Drawing.Point(35, 282);
            this.confirmPasswordPanel.Name = "confirmPasswordPanel";
            this.confirmPasswordPanel.Size = new System.Drawing.Size(350, 1);

            // confirmPasswordErrorLabel
            this.confirmPasswordErrorLabel.AutoSize = true;
            this.confirmPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordErrorLabel.Location = new System.Drawing.Point(35, 285);
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            this.confirmPasswordErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmPasswordErrorLabel.Text = "";

            // registerButton
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.registerButton.Location = new System.Drawing.Point(35, 310);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(150, 40);
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false; // Allow custom back color
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);

            // loginButton
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(35, 360);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 30);
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false; // Allow custom back color
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);

            // RegisterForm
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.titleLabel);

            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameErrorLabel);

            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.emailErrorLabel);

            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phonePanel);
            this.Controls.Add(this.phoneErrorLabel);

            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordErrorLabel);

            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordPanel);
            this.Controls.Add(this.confirmPasswordErrorLabel);

            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
