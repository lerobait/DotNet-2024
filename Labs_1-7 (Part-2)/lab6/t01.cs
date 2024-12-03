// using System;
// using System.Drawing;
// using System.IO;
// using System.Linq;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private PictureBox pictureBox1;
//         private Button btnFolder;
//         private Button btnNext;
//         private Button btnPrev;
//         private Panel panel1;

//         private string[] imageFiles = Array.Empty<string>();
//         private int currentIndex = 0;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Слайд-шоу (перегляд фотографій)";
//             this.Size = new Size(800, 600);

//             pictureBox1 = new PictureBox
//             {
//                 Dock = DockStyle.Top,
//                 Height = 500,
//                 SizeMode = PictureBoxSizeMode.Zoom
//             };
//             this.Controls.Add(pictureBox1);

//             panel1 = new Panel
//             {
//                 Dock = DockStyle.Bottom,
//                 Height = 50
//             };
//             this.Controls.Add(panel1);

//             btnFolder = new Button
//             {
//                 Text = "Папка",
//                 Location = new Point(10, 10),
//                 Width = 100
//             };
//             btnFolder.Click += new EventHandler(btnFolder_Click);
//             panel1.Controls.Add(btnFolder);

//             btnPrev = new Button
//             {
//                 Text = "<<",
//                 Location = new Point(200, 10),
//                 Width = 100
//             };
//             btnPrev.Click += new EventHandler(btnPrev_Click);
//             panel1.Controls.Add(btnPrev);

//             btnNext = new Button
//             {
//                 Text = ">>",
//                 Location = new Point(320, 10),
//                 Width = 100
//             };
//             btnNext.Click += new EventHandler(btnNext_Click);
//             panel1.Controls.Add(btnNext);
//         }

//         private void btnFolder_Click(object sender, EventArgs e)
//         {
//             using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
//             {
//                 if (folderDialog.ShowDialog() == DialogResult.OK)
//                 {
//                     imageFiles = Directory.GetFiles(folderDialog.SelectedPath, "*.*")
//                                            .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
//                                                           file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
//                                                           file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
//                                            .ToArray();

//                     if (imageFiles.Length > 0)
//                     {
//                         currentIndex = 0;
//                         ShowImage();
//                     }
//                     else
//                     {
//                         MessageBox.Show("У вибраній папці немає зображень.");
//                     }
//                 }
//             }
//         }

//         private void ShowImage()
//         {
//             if (imageFiles.Length > 0 && currentIndex >= 0 && currentIndex < imageFiles.Length)
//             {
//                 pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]);
//             }
//         }

//         private void btnNext_Click(object sender, EventArgs e)
//         {
//             if (imageFiles != null && imageFiles.Length > 0)
//             {
//                 currentIndex = (currentIndex + 1) % imageFiles.Length;
//                 ShowImage();
//             }
//         }

//         private void btnPrev_Click(object sender, EventArgs e)
//         {
//             if (imageFiles != null && imageFiles.Length > 0)
//             {
//                 currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length;
//                 ShowImage();
//             }
//         }
//     }
// }
