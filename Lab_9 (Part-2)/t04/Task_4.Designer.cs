using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_4
{
    partial class Task_4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxUkraine;
        private System.Windows.Forms.PictureBox pictureBoxJapan;
        private System.Windows.Forms.Timer timer;

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
            components = new System.ComponentModel.Container();
            pictureBoxUkraine = new PictureBox();
            pictureBoxJapan = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUkraine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJapan).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxUkraine
            // 
            pictureBoxUkraine.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxUkraine.Location = new Point(638, 350);
            pictureBoxUkraine.Name = "pictureBoxUkraine";
            pictureBoxUkraine.Size = new Size(150, 100);
            pictureBoxUkraine.TabIndex = 0;
            pictureBoxUkraine.TabStop = false;
            pictureBoxUkraine.Paint += PictureBoxUkraine_Paint;
            // 
            // pictureBoxJapan
            // 
            pictureBoxJapan.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxJapan.Location = new Point(457, 350);
            pictureBoxJapan.Name = "pictureBoxJapan";
            pictureBoxJapan.Size = new Size(150, 100);
            pictureBoxJapan.TabIndex = 1;
            pictureBoxJapan.TabStop = false;
            pictureBoxJapan.Paint += PictureBoxJapan_Paint;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // Form4
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBoxJapan);
            Controls.Add(pictureBoxUkraine);
            Name = "Form4";
            Text = "Task_4";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUkraine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJapan).EndInit();
            ResumeLayout(false);
        }
    }
}
