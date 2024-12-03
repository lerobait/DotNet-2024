namespace Lab__12
{
    partial class MessageReceiveForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label inboxLabel;
        private System.Windows.Forms.ListBox messagesListBox;

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
            this.inboxLabel = new System.Windows.Forms.Label();
            this.messagesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // inboxLabel
            this.inboxLabel.AutoSize = true;
            this.inboxLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.inboxLabel.Location = new System.Drawing.Point(150, 20);
            this.inboxLabel.Name = "inboxLabel";
            this.inboxLabel.Size = new System.Drawing.Size(115, 51);
            this.inboxLabel.Text = "Inbox";

            // messagesListBox
            this.messagesListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.messagesListBox.FormattingEnabled = true;
            this.messagesListBox.ItemHeight = 21;
            this.messagesListBox.Location = new System.Drawing.Point(30, 90);
            this.messagesListBox.Name = "messagesListBox";
            this.messagesListBox.Size = new System.Drawing.Size(350, 298);
            this.messagesListBox.DoubleClick += new System.EventHandler(this.MessagesListBox_DoubleClick);

            // MessageReceiveForm
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.inboxLabel);
            this.Controls.Add(this.messagesListBox);
            this.Name = "MessageReceiveForm";
            this.Text = "Inbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
