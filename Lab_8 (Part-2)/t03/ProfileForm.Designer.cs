namespace Lab__12
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailTitleLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneTitleLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Button editEmailButton;
        private System.Windows.Forms.Button editPhoneButton;
        private System.Windows.Forms.Button editPasswordButton;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button receiveMessageButton;

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
            welcomeLabel = new Label();
            nameLabel = new Label();
            emailTitleLabel = new Label();
            emailLabel = new Label();
            phoneTitleLabel = new Label();
            phoneLabel = new Label();
            logoutButton = new Button();
            editNameButton = new Button();
            editEmailButton = new Button();
            editPhoneButton = new Button();
            editPasswordButton = new Button();
            sendMessageButton = new Button();
            receiveMessageButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            welcomeLabel.Location = new Point(30, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(244, 62);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome,";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            nameLabel.Location = new Point(220, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 62);
            nameLabel.TabIndex = 1;
            // 
            // emailTitleLabel
            // 
            emailTitleLabel.AutoSize = true;
            emailTitleLabel.Font = new Font("Segoe UI", 14F);
            emailTitleLabel.Location = new Point(30, 90);
            emailTitleLabel.Name = "emailTitleLabel";
            emailTitleLabel.Size = new Size(76, 32);
            emailTitleLabel.TabIndex = 2;
            emailTitleLabel.Text = "Email:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14F);
            emailLabel.Location = new Point(100, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 32);
            emailLabel.TabIndex = 3;
            // 
            // phoneTitleLabel
            // 
            phoneTitleLabel.AutoSize = true;
            phoneTitleLabel.Font = new Font("Segoe UI", 14F);
            phoneTitleLabel.Location = new Point(30, 130);
            phoneTitleLabel.Name = "phoneTitleLabel";
            phoneTitleLabel.Size = new Size(87, 32);
            phoneTitleLabel.TabIndex = 4;
            phoneTitleLabel.Text = "Phone:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 14F);
            phoneLabel.Location = new Point(100, 130);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(0, 32);
            phoneLabel.TabIndex = 5;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 10F);
            logoutButton.Location = new Point(30, 370);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(80, 30);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // editNameButton
            // 
            editNameButton.Font = new Font("Segoe UI", 10F);
            editNameButton.Location = new Point(30, 180);
            editNameButton.Name = "editNameButton";
            editNameButton.Size = new Size(120, 30);
            editNameButton.TabIndex = 7;
            editNameButton.Text = "Edit Username";
            editNameButton.UseVisualStyleBackColor = true;
            editNameButton.Click += EditNameButton_Click;
            // 
            // editEmailButton
            // 
            editEmailButton.Font = new Font("Segoe UI", 10F);
            editEmailButton.Location = new Point(160, 180);
            editEmailButton.Name = "editEmailButton";
            editEmailButton.Size = new Size(100, 30);
            editEmailButton.TabIndex = 8;
            editEmailButton.Text = "Edit Email";
            editEmailButton.UseVisualStyleBackColor = true;
            editEmailButton.Click += EditEmailButton_Click;
            // 
            // editPhoneButton
            // 
            editPhoneButton.Font = new Font("Segoe UI", 10F);
            editPhoneButton.Location = new Point(270, 180);
            editPhoneButton.Name = "editPhoneButton";
            editPhoneButton.Size = new Size(100, 30);
            editPhoneButton.TabIndex = 9;
            editPhoneButton.Text = "Edit Phone";
            editPhoneButton.UseVisualStyleBackColor = true;
            editPhoneButton.Click += EditPhoneButton_Click;
            // 
            // editPasswordButton
            // 
            editPasswordButton.Font = new Font("Segoe UI", 10F);
            editPasswordButton.Location = new Point(117, 216);
            editPasswordButton.Name = "editPasswordButton";
            editPasswordButton.Size = new Size(196, 30);
            editPasswordButton.TabIndex = 10;
            editPasswordButton.Text = "Edit Password";
            editPasswordButton.UseVisualStyleBackColor = true;
            editPasswordButton.Click += EditPasswordButton_Click;
            // 
            // sendMessageButton
            // 
            sendMessageButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sendMessageButton.Location = new Point(30, 270);
            sendMessageButton.Name = "sendMessageButton";
            sendMessageButton.Size = new Size(340, 40);
            sendMessageButton.TabIndex = 11;
            sendMessageButton.Text = "Send Message";
            sendMessageButton.UseVisualStyleBackColor = false;
            sendMessageButton.Click += SendMessageButton_Click;
            // 
            // receiveMessageButton
            // 
            receiveMessageButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            receiveMessageButton.Location = new Point(30, 320);
            receiveMessageButton.Name = "receiveMessageButton";
            receiveMessageButton.Size = new Size(340, 40);
            receiveMessageButton.TabIndex = 12;
            receiveMessageButton.Text = "Inbox";
            receiveMessageButton.UseVisualStyleBackColor = true;
            receiveMessageButton.Click += ReceiveMessageButton_Click;
            // 
            // ProfileForm
            // 
            ClientSize = new Size(500, 450);
            Controls.Add(welcomeLabel);
            Controls.Add(nameLabel);
            Controls.Add(emailTitleLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneTitleLabel);
            Controls.Add(phoneLabel);
            Controls.Add(logoutButton);
            Controls.Add(editNameButton);
            Controls.Add(editEmailButton);
            Controls.Add(editPhoneButton);
            Controls.Add(editPasswordButton);
            Controls.Add(sendMessageButton);
            Controls.Add(receiveMessageButton);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
