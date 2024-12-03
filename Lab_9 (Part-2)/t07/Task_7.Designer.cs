namespace Task_7
{
    partial class Task_7
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.RichTextBox textBoxOutput;

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
            graphPanel = new Panel();
            textBoxOutput = new RichTextBox();
            SuspendLayout();
            // 
            // graphPanel
            // 
            graphPanel.Location = new Point(10, 10);
            graphPanel.Margin = new Padding(4, 5, 4, 5);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(750, 400); 
            graphPanel.TabIndex = 0;
            graphPanel.Paint += GraphPanel_Paint;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(10, 420);
            textBoxOutput.Margin = new Padding(4, 5, 4, 5);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(750, 150); 
            textBoxOutput.TabIndex = 1;
            textBoxOutput.Text = "";
            // 
            // Task_7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 600); 
            Controls.Add(textBoxOutput);
            Controls.Add(graphPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form7";
            Text = "Task_7";
            ResumeLayout(false);
        }
    }
}
