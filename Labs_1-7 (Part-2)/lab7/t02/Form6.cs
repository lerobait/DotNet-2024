// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form6 : Form
// {
//     public string PassedInfo { get; set; }
//     public string ReceivedInfo { get; set; }

//     public Form6()
//     {
//         InitializeComponentCustom();
//     }

//     private void Form6_Load(object sender, EventArgs e)
//     {
//         labelPassedInfo.Text = "Передано з Form5: " + PassedInfo;
//         textBoxReceivedInfo.Text = ReceivedInfo;
//     }

//     private void buttonReturnToForm5_Click(object sender, EventArgs e)
//     {
//         ReceivedInfo = textBoxReceivedInfo.Text;
//         this.Close();
//     }

//     private void InitializeComponentCustom()
//     {
//         this.textBoxReceivedInfo = new System.Windows.Forms.TextBox();
//         this.labelPassedInfo = new System.Windows.Forms.Label();
//         this.buttonReturnToForm5 = new System.Windows.Forms.Button();
//         this.SuspendLayout();

//         this.textBoxReceivedInfo.Location = new System.Drawing.Point(50, 100);
//         this.textBoxReceivedInfo.Size = new System.Drawing.Size(200, 20);

//         this.labelPassedInfo.Location = new System.Drawing.Point(50, 50);
//         this.labelPassedInfo.Size = new System.Drawing.Size(300, 20);

//         this.buttonReturnToForm5.Location = new System.Drawing.Point(50, 150);
//         this.buttonReturnToForm5.Size = new System.Drawing.Size(200, 50);
//         this.buttonReturnToForm5.Text = "Повернутися до Form5";
//         this.buttonReturnToForm5.Click += new EventHandler(this.buttonReturnToForm5_Click);

//         this.ClientSize = new System.Drawing.Size(300, 250);
//         this.Controls.Add(this.textBoxReceivedInfo);
//         this.Controls.Add(this.labelPassedInfo);
//         this.Controls.Add(this.buttonReturnToForm5);
//         this.Name = "Form6";
//         this.Text = "Form6";
//         this.Load += new System.EventHandler(this.Form6_Load);
//         this.ResumeLayout(false);
//         this.PerformLayout();
//     }

//     private System.Windows.Forms.TextBox textBoxReceivedInfo;
//     private System.Windows.Forms.Label labelPassedInfo;
//     private System.Windows.Forms.Button buttonReturnToForm5;
// }
// }