// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeComponent();
//       InitializePictureBoxes();
//     }

//     private void InitializePictureBoxes()
//     {
//       PictureBox pictureBox1 = new PictureBox
//       {
//         SizeMode = PictureBoxSizeMode.StretchImage,
//         Location = new Point(10, 50),
//         Size = new Size(100, 100)
//       };
//       this.Controls.Add(pictureBox1);

//       PictureBox pictureBox2 = new PictureBox
//       {
//         SizeMode = PictureBoxSizeMode.StretchImage,
//         Location = new Point(120, 50),
//         Size = new Size(100, 100)
//       };
//       this.Controls.Add(pictureBox2);

//       PictureBox pictureBox3 = new PictureBox
//       {
//         SizeMode = PictureBoxSizeMode.StretchImage,
//         Location = new Point(65, 10),
//         Size = new Size(100, 100)
//       };
//       this.Controls.Add(pictureBox3);

//       PictureBox pictureBox4 = new PictureBox
//       {
//         SizeMode = PictureBoxSizeMode.StretchImage,
//         Location = new Point(230, 50),
//         Size = new Size(100, 100)
//       };
//       this.Controls.Add(pictureBox4);

//       PictureBox pictureBox5 = new PictureBox
//       {
//         SizeMode = PictureBoxSizeMode.StretchImage,
//         Location = new Point(230, 160),
//         Size = new Size(100, 100)
//       };
//       this.Controls.Add(pictureBox5);

//       this.Load += (sender, e) =>
//       {
//         pictureBox1.Image = Image.FromFile("image1.jpg");
//         pictureBox2.Image = Image.FromFile("image2.jpg");
//         pictureBox3.Image = Image.FromFile("image3.jpg");
//         pictureBox4.Image = Image.FromFile("image4.jpg");
//         pictureBox5.Image = Image.FromFile("image5.jpg");
//       };
//     }
//   }
// }
