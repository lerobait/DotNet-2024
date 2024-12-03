// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form5 : Form
// {
//     public Form5()
//     {
//         InitializeComponentCustom();
//     }

//     private void buttonOpenForm6_Click(object sender, EventArgs e)
//     {
//         Form6 form6 = new Form6();

//         form6.ShowDialog();
//     }

//     private void InitializeComponentCustom()
//     {
//         this.buttonOpenForm6 = new System.Windows.Forms.Button();
//         this.SuspendLayout();

//         this.buttonOpenForm6.Location = new System.Drawing.Point(100, 100);
//         this.buttonOpenForm6.Name = "buttonOpenForm6";
//         this.buttonOpenForm6.Size = new System.Drawing.Size(200, 50);
//         this.buttonOpenForm6.TabIndex = 0;
//         this.buttonOpenForm6.Text = "Відкрити Form6";
//         this.buttonOpenForm6.UseVisualStyleBackColor = true;
//         this.buttonOpenForm6.Click += new System.EventHandler(this.buttonOpenForm6_Click);

//         this.ClientSize = new System.Drawing.Size(400, 300);
//         this.Controls.Add(this.buttonOpenForm6);
//         this.Name = "Form5";
//         this.Text = "Form5";
//         this.ResumeLayout(false);
//         this.PerformLayout();
//     }
//     private System.Windows.Forms.Button buttonOpenForm6;
// }
// }