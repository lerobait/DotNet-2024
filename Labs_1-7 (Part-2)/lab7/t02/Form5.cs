// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form5 : Form
// {
//     public string PassedInfo { get; set; }
//     public string ReceivedInfo { get; set; }

//     public Form5()
//     {
//         InitializeComponentCustom();
//     }

//     private void Form5_Load(object sender, EventArgs e)
//     {
//         labelPassedInfo.Text = "Передано з Form1: " + PassedInfo;
//         textBoxReceivedInfo.Text = ReceivedInfo;
//     }

//     private void buttonOpenForm6_Click(object sender, EventArgs e)
//     {
//         Form6 form6 = new Form6();
//         form6.ShowDialog();
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
//         this.buttonOpenForm6 = new System.Windows.Forms.Button();
//         this.SuspendLayout();

//         this.textBoxReceivedInfo.Location = new System.Drawing.Point(50, 100);
//         this.textBoxReceivedInfo.Size = new System.Drawing.Size(200, 20);

//         this.labelPassedInfo.Location = new System.Drawing.Point(50, 50);
//         this.labelPassedInfo.Size = new System.Drawing.Size(300, 20);

//         this.buttonReturnToForm1.Location = new System.Drawing.Point(50, 150);
//         this.buttonReturnToForm1.Size = new System.Drawing.Size(200, 50);
//         this.buttonReturnToForm1.Text = "Повернутися до Form1";
//         this.buttonReturnToForm1.Click += new EventHandler(this.buttonReturnToForm1_Click);

//         this.buttonOpenForm6.Location = new System.Drawing.Point(100, 200);
//         this.buttonOpenForm6.Name = "buttonOpenForm6";
//         this.buttonOpenForm6.Size = new System.Drawing.Size(200, 50);
//         this.buttonOpenForm6.TabIndex = 0;
//         this.buttonOpenForm6.Text = "Відкрити Form6";
//         this.buttonOpenForm6.Click += new EventHandler(this.buttonOpenForm6_Click);

//         this.ClientSize = new System.Drawing.Size(400, 300);
//         this.Controls.Add(this.textBoxReceivedInfo);
//         this.Controls.Add(this.labelPassedInfo);
//         this.Controls.Add(this.buttonReturnToForm1);
//         this.Controls.Add(this.buttonOpenForm6);
//         this.Name = "Form5";
//         this.Text = "Form5";
//         this.Load += new System.EventHandler(this.Form5_Load);
//         this.ResumeLayout(false);
//         this.PerformLayout();
//     }

//     private System.Windows.Forms.TextBox textBoxReceivedInfo;
//     private System.Windows.Forms.Label labelPassedInfo;
//     private System.Windows.Forms.Button buttonReturnToForm1;
//     private System.Windows.Forms.Button buttonOpenForm6;
// }
// }