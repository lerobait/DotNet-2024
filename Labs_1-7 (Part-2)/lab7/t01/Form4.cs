// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form4 : Form
//     {
//         public Form4()
//         {
//             InitializeComponentCustom();
//         }

//         private void buttonOpenForm2_Click(object sender, EventArgs e)
//         {
//             Form2 form2 = new Form2();
//             form2.ShowDialog();
//         }

//         private void buttonOpenForm3_Click(object sender, EventArgs e)
//         {
//             Form3 form3 = new Form3();
//             form3.ShowDialog();
//         }

//         private void buttonOpenForm5_Click(object sender, EventArgs e)
//         {
//             Form5 form5 = new Form5();
//             form5.ShowDialog();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.buttonOpenForm2 = new System.Windows.Forms.Button();
//             this.buttonOpenForm3 = new System.Windows.Forms.Button();
//             this.buttonOpenForm5 = new System.Windows.Forms.Button();
//             this.SuspendLayout();
//             // 
//             // buttonOpenForm2
//             // 
//             this.buttonOpenForm2.Location = new System.Drawing.Point(50, 50);
//             this.buttonOpenForm2.Name = "buttonOpenForm2";
//             this.buttonOpenForm2.Size = new System.Drawing.Size(200, 50);
//             this.buttonOpenForm2.TabIndex = 0;
//             this.buttonOpenForm2.Text = "Відкрити Form2";
//             this.buttonOpenForm2.UseVisualStyleBackColor = true;
//             this.buttonOpenForm2.Click += new System.EventHandler(this.buttonOpenForm2_Click);
//             // 
//             // buttonOpenForm3
//             // 
//             this.buttonOpenForm3.Location = new System.Drawing.Point(50, 120);
//             this.buttonOpenForm3.Name = "buttonOpenForm3";
//             this.buttonOpenForm3.Size = new System.Drawing.Size(200, 50);
//             this.buttonOpenForm3.TabIndex = 1;
//             this.buttonOpenForm3.Text = "Відкрити Form3";
//             this.buttonOpenForm3.UseVisualStyleBackColor = true;
//             this.buttonOpenForm3.Click += new System.EventHandler(this.buttonOpenForm3_Click);
//             // 
//             // buttonOpenForm5
//             // 
//             this.buttonOpenForm5.Location = new System.Drawing.Point(50, 190);
//             this.buttonOpenForm5.Name = "buttonOpenForm5";
//             this.buttonOpenForm5.Size = new System.Drawing.Size(200, 50);
//             this.buttonOpenForm5.TabIndex = 2;
//             this.buttonOpenForm5.Text = "Відкрити Form5";
//             this.buttonOpenForm5.UseVisualStyleBackColor = true;
//             this.buttonOpenForm5.Click += new System.EventHandler(this.buttonOpenForm5_Click);
//             // 
//             // Form4
//             // 
//             this.ClientSize = new System.Drawing.Size(300, 300);
//             this.Controls.Add(this.buttonOpenForm5);
//             this.Controls.Add(this.buttonOpenForm3);
//             this.Controls.Add(this.buttonOpenForm2);
//             this.Name = "Form4";
//             this.Text = "Form4";
//             this.ResumeLayout(false);
//         }

//         private System.Windows.Forms.Button buttonOpenForm2;
//         private System.Windows.Forms.Button buttonOpenForm3;
//         private System.Windows.Forms.Button buttonOpenForm5;
//     }
// }
