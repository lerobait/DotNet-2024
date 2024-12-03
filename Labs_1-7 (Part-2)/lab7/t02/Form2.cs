// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form2 : Form
// {
//     public string PassedInfo { get; set; }
//     public string ReceivedInfo { get; set; }

//     public Form2()
//     {
//         InitializeComponentCustom();
//     }

//     private void Form2_Load(object sender, EventArgs e)
//     {
//         labelPassedInfo.Text = "Передано з Form1: " + PassedInfo;
//         textBoxReceivedInfo.Text = ReceivedInfo;
//     }

//     private void buttonReturnToForm1_Click(object sender, EventArgs e)
//     {
//         ReceivedInfo = textBoxReceivedInfo.Text;
//         this.Close();
//     }

//     private void InitializeComponentCustom()
//     {
//         this.textBoxReceivedInfo = new System.Windows.Forms.TextBox();
//         this.labelPassedInfo = new System.Windows.Forms.Label();
//         this.buttonReturnToForm1 = new System.Windows.Forms.Button();
//         this.SuspendLayout();

//         this.textBoxReceivedInfo.Location = new System.Drawing.Point(50, 100);
//         this.textBoxReceivedInfo.Size = new System.Drawing.Size(200, 20);

//         this.labelPassedInfo.Location = new System.Drawing.Point(50, 50);
//         this.labelPassedInfo.Size = new System.Drawing.Size(300, 20);

//         this.buttonReturnToForm1.Location = new System.Drawing.Point(50, 150);
//         this.buttonReturnToForm1.Size = new System.Drawing.Size(200, 50);
//         this.buttonReturnToForm1.Text = "Повернутися до Form1";
//         this.buttonReturnToForm1.Click += new EventHandler(this.buttonReturnToForm1_Click);

//         this.ClientSize = new System.Drawing.Size(300, 250);
//         this.Controls.Add(this.textBoxReceivedInfo);
//         this.Controls.Add(this.labelPassedInfo);
//         this.Controls.Add(this.buttonReturnToForm1);
//         this.Name = "Form2";
//         this.Text = "Form2";
//         this.Load += new System.EventHandler(this.Form2_Load);
//         this.ResumeLayout(false);
//         this.PerformLayout();
//     }

//     private System.Windows.Forms.TextBox textBoxReceivedInfo;
//     private System.Windows.Forms.Label labelPassedInfo;
//     private System.Windows.Forms.Button buttonReturnToForm1;
// }
// }