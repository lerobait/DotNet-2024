// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public class CityDetailsForm : Form
// {
//     private PictureBox pictureBox;
//     private Label lblCityDescription;

//     public CityDetailsForm(string city)
//     {
//         pictureBox = new PictureBox
//         {
//             Location = new System.Drawing.Point(20, 20),
//             Size = new System.Drawing.Size(300, 200),
//             SizeMode = PictureBoxSizeMode.StretchImage
//         };

//         lblCityDescription = new Label
//         {
//             Location = new System.Drawing.Point(20, 230),
//             Size = new System.Drawing.Size(300, 100)
//         };

//         switch (city)
//         {
//             case "Київ":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Kyiv.jpg");
//                 lblCityDescription.Text = "Київ — столиця України, великий культурний, політичний та економічний центр.";
//                 break;
//             case "Львів":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Lviv.jpg");
//                 lblCityDescription.Text = "Львів — одне з найбільших міст на заході України, відоме своєю історією та архітектурою.";
//                 break;
//             case "Одеса":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Odessa.jpg");
//                 lblCityDescription.Text = "Одеса — місто на південь України, відоме своїм портом і пляжами.";
//                 break;
//             case "Харків":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Kharkiv.jpg");
//                 lblCityDescription.Text = "Харків — важливий науковий та промисловий центр на сході України.";
//                 break;
//             case "Дніпро":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Dnipro.jpg");
//                 lblCityDescription.Text = "Дніпро — одне з найбільших міст у центральній частині України, відоме своєю історією.";
//                 break;
//             case "Чернівці":
//                 pictureBox.Image = Image.FromFile("Resources/Ukraine/Chernyvci.jpg");
//                 lblCityDescription.Text = "Чернівці — місто на заході України, що має багатий культурний спадок.";
//                 break;
//             default:
//                 pictureBox.Image = null;
//                 lblCityDescription.Text = "Опис недоступний.";
//                 break;
//         }

//         Controls.Add(pictureBox);
//         Controls.Add(lblCityDescription);

//         this.Text = $"Деталі міста {city}";
//         this.Size = new System.Drawing.Size(350, 400);
//     }
// }
// }