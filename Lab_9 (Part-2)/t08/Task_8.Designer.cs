namespace Task_8
{
    partial class Task_8
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений Конструктором Windows Forms

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 400);
            this.Name = "Form8";
            this.Text = "Task_8";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form8_Paint);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
