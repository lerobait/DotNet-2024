namespace Lab__12
{
    partial class EditPasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Panel currentPasswordPanel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Panel newPasswordPanel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Panel confirmPasswordPanel;
        private System.Windows.Forms.Button saveButton;

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
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordPanel = new System.Windows.Forms.Panel();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 32);
            this.titleLabel.Text = "Edit Password";

            // currentPasswordLabel
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordLabel.Location = new System.Drawing.Point(30, 70);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(137, 21);
            this.currentPasswordLabel.Text = "Current Password";

            // currentPasswordTextBox
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordTextBox.Location = new System.Drawing.Point(30, 95);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(350, 22);
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // currentPasswordPanel
            this.currentPasswordPanel.BackColor = System.Drawing.Color.LightGray;
            this.currentPasswordPanel.Location = new System.Drawing.Point(30, 117);
            this.currentPasswordPanel.Name = "currentPasswordPanel";
            this.currentPasswordPanel.Size = new System.Drawing.Size(350, 1);

            // newPasswordLabel
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordLabel.Location = new System.Drawing.Point(30, 130);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(111, 21);
            this.newPasswordLabel.Text = "New Password";

            // newPasswordTextBox
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.Location = new System.Drawing.Point(30, 155);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(350, 22);
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // newPasswordPanel
            this.newPasswordPanel.BackColor = System.Drawing.Color.LightGray;
            this.newPasswordPanel.Location = new System.Drawing.Point(30, 177);
            this.newPasswordPanel.Name = "newPasswordPanel";
            this.newPasswordPanel.Size = new System.Drawing.Size(350, 1);

            // confirmPasswordLabel
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordLabel.Location = new System.Drawing.Point(30, 190);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(137, 21);
            this.confirmPasswordLabel.Text = "Confirm Password";

            // confirmPasswordTextBox
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(30, 215);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(350, 22);
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // confirmPasswordPanel
            this.confirmPasswordPanel.BackColor = System.Drawing.Color.LightGray;
            this.confirmPasswordPanel.Location = new System.Drawing.Point(30, 237);
            this.confirmPasswordPanel.Name = "confirmPasswordPanel";
            this.confirmPasswordPanel.Size = new System.Drawing.Size(350, 1);

            // saveButton
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(30, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(350, 40);
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);

            // EditPasswordForm
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.currentPasswordPanel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordPanel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordPanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditPasswordForm";
            this.Text = "Edit Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
