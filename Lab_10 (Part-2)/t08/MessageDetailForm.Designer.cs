namespace Lab__12
{
    partial class MessageDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.TextBox messageTextBox;

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
            this.detailLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // detailLabel
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.detailLabel.Location = new System.Drawing.Point(100, 20);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(196, 37);
            this.detailLabel.Text = "Message Detail";

            // messageTextBox
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.messageTextBox.Location = new System.Drawing.Point(20, 70);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(360, 300);

            // MessageDetailForm
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.messageTextBox);
            this.Name = "MessageDetailForm";
            this.Text = "Message Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
