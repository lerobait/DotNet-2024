namespace Lab__12
{
    partial class MessageSendForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Panel toPanel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.Panel themePanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;

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
            this.toLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toPanel = new System.Windows.Forms.Panel();
            this.themeLabel = new System.Windows.Forms.Label();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.themePanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // toLabel
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.toLabel.Location = new System.Drawing.Point(30, 20);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(36, 25);
            this.toLabel.Text = "TO:";

            // toTextBox
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toTextBox.Location = new System.Drawing.Point(30, 50);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(350, 22);
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // toPanel
            this.toPanel.BackColor = System.Drawing.Color.Black;
            this.toPanel.Location = new System.Drawing.Point(30, 72);
            this.toPanel.Name = "toPanel";
            this.toPanel.Size = new System.Drawing.Size(350, 1);

            // themeLabel
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.themeLabel.Location = new System.Drawing.Point(30, 90);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(72, 25);
            this.themeLabel.Text = "THEME:";

            // themeTextBox
            this.themeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.themeTextBox.Location = new System.Drawing.Point(30, 120);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(350, 22);
            this.themeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // themePanel
            this.themePanel.BackColor = System.Drawing.Color.Black;
            this.themePanel.Location = new System.Drawing.Point(30, 142);
            this.themePanel.Name = "themePanel";
            this.themePanel.Size = new System.Drawing.Size(350, 1);

            // messageLabel
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.messageLabel.Location = new System.Drawing.Point(30, 160);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(96, 25);
            this.messageLabel.Text = "TEXT:";

            // messageTextBox
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.messageTextBox.Location = new System.Drawing.Point(30, 190);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(350, 150);
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // sendButton
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.sendButton.Location = new System.Drawing.Point(30, 360);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(350, 40);
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);

            // MessageSendForm
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toPanel);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.themePanel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendButton);
            this.Name = "MessageSendForm";
            this.Text = "Send Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
