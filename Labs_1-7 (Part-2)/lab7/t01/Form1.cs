// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void buttonOpenForm4_Click(object sender, EventArgs e)
//         {
//             Form4 form4 = new Form4();
//             form4.ShowDialog(); // Виклик Form4 у модальному режимі
//         }

//         private void toolStripMenuItemForm4_Click(object sender, EventArgs e)
//         {
//             Form4 form4 = new Form4();
//             form4.ShowDialog(); // Виклик Form4 через меню
//         }

//         private void InitializeComponentCustom()
//         {
//             this.buttonOpenForm4 = new System.Windows.Forms.Button();
//             this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//             this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
//             this.toolStripMenuItemForm4 = new System.Windows.Forms.ToolStripMenuItem();
//             this.menuStrip1.SuspendLayout();
//             this.SuspendLayout();
//             // 
//             // buttonOpenForm4
//             // 
//             this.buttonOpenForm4.Location = new System.Drawing.Point(100, 100);
//             this.buttonOpenForm4.Name = "buttonOpenForm4";
//             this.buttonOpenForm4.Size = new System.Drawing.Size(200, 50);
//             this.buttonOpenForm4.TabIndex = 0;
//             this.buttonOpenForm4.Text = "Відкрити Form4";
//             this.buttonOpenForm4.UseVisualStyleBackColor = true;
//             this.buttonOpenForm4.Click += new System.EventHandler(this.buttonOpenForm4_Click);
//             // 
//             // menuStrip1
//             // 
//             this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//             this.toolStripMenuItem1});
//             this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//             this.menuStrip1.Name = "menuStrip1";
//             this.menuStrip1.Size = new System.Drawing.Size(400, 24);
//             this.menuStrip1.TabIndex = 1;
//             this.menuStrip1.Text = "menuStrip1";
//             // 
//             // toolStripMenuItem1
//             // 
//             this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//             this.toolStripMenuItemForm4});
//             this.toolStripMenuItem1.Name = "toolStripMenuItem1";
//             this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
//             this.toolStripMenuItem1.Text = "Форми";
//             // 
//             // toolStripMenuItemForm4
//             // 
//             this.toolStripMenuItemForm4.Name = "toolStripMenuItemForm4";
//             this.toolStripMenuItemForm4.Size = new System.Drawing.Size(180, 22);
//             this.toolStripMenuItemForm4.Text = "Відкрити Form4";
//             this.toolStripMenuItemForm4.Click += new System.EventHandler(this.toolStripMenuItemForm4_Click);
//             // 
//             // Form1
//             // 
//             this.ClientSize = new System.Drawing.Size(400, 300);
//             this.Controls.Add(this.buttonOpenForm4);
//             this.Controls.Add(this.menuStrip1);
//             this.MainMenuStrip = this.menuStrip1;
//             this.Name = "Form1";
//             this.Text = "Form1";
//             this.menuStrip1.ResumeLayout(false);
//             this.menuStrip1.PerformLayout();
//             this.ResumeLayout(false);
//             this.PerformLayout();
//         }

//         private System.Windows.Forms.Button buttonOpenForm4;
//         private System.Windows.Forms.MenuStrip menuStrip1;
//         private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
//         private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForm4;
//     }
// }
