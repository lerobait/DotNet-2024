namespace Lab__12
{
    partial class EditPhoneForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel phonePanel;
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
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // phoneLabel
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(30, 30);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(131, 32);
            this.phoneLabel.Text = "Edit Phone";

            // phoneTextBox
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(30, 80);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(350, 22);
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // phonePanel
            this.phonePanel.BackColor = System.Drawing.Color.Black;
            this.phonePanel.Location = new System.Drawing.Point(30, 102);
            this.phonePanel.Name = "phonePanel";
            this.phonePanel.Size = new System.Drawing.Size(350, 1);

            // saveButton
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(30, 130);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(350, 40);
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);

            // EditPhoneForm
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phonePanel);
            this.Controls.Add(this.saveButton);
            this.Name = "EditPhoneForm";
            this.Text = "Edit Phone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
