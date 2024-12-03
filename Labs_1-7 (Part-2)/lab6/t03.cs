// using System;
// using System.Drawing;
// using System.IO;
// using System.Linq;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private Label label1;
//         private ListBox listBox1;
//         private Button btnFolder;
//         private PictureBox pictureBox1;

//         private string[] imageFiles = Array.Empty<string>();

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Перегляд Ілюстрацій - Автомобілі";
//             this.Size = new Size(800, 600);

//             label1 = new Label
//             {
//                 Text = "Шлях до папки:",
//                 AutoSize = true,
//                 Location = new Point(10, 10)
//             };
//             this.Controls.Add(label1);

//             listBox1 = new ListBox
//             {
//                 Location = new Point(10, 40),
//                 Size = new Size(200, 450)
//             };
//             listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
//             this.Controls.Add(listBox1);

//             btnFolder = new Button
//             {
//                 Text = "Папка",
//                 Location = new Point(10, 500),
//                 Width = 100
//             };
//             btnFolder.Click += new EventHandler(btnFolder_Click);
//             this.Controls.Add(btnFolder);

//             pictureBox1 = new PictureBox
//             {
//                 Location = new Point(220, 10),
//                 Size = new Size(560, 540),
//                 SizeMode = PictureBoxSizeMode.Zoom
//             };
//             this.Controls.Add(pictureBox1);
//         }

//         private void btnFolder_Click(object sender, EventArgs e)
//         {
//             using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
//             {
//                 if (folderDialog.ShowDialog() == DialogResult.OK)
//                 {
//                     label1.Text = $"Шлях до папки: {folderDialog.SelectedPath}";
//                     imageFiles = Directory.GetFiles(folderDialog.SelectedPath, "*.*")
//                                            .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
//                                                           file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
//                                                           file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
//                                            .ToArray();

//                     listBox1.Items.Clear();
//                     foreach (var file in imageFiles)
//                     {
//                         listBox1.Items.Add(Path.GetFileName(file));
//                     }

//                     if (imageFiles.Length == 0)
//                     {
//                         MessageBox.Show("У вибраній папці немає зображень.");
//                     }
//                 }
//             }
//         }

//         private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//         {
//             if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < imageFiles.Length)
//             {
//                 pictureBox1.Image?.Dispose();
//                 pictureBox1.Image = Image.FromFile(imageFiles[listBox1.SelectedIndex]);
//             }
//         }
//     }
// }
