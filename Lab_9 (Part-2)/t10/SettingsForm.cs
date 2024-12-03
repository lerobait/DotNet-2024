using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Task_10
{
    public partial class SettingsForm : Form
    {
        public int BallCount { get; private set; }
        public int Diameter { get; private set; }
        public int Speed { get; private set; }
        public List<Color> Colors { get; private set; }

        public SettingsForm(int currentBallCount, int currentDiameter, int currentSpeed, List<Color> currentColors)
        {
            InitializeComponent(); 
            nudBallCount.Value = currentBallCount; 
            nudDiameter.Value = currentDiameter; 
            nudSpeed.Value = currentSpeed; 

            Colors = new List<Color>(currentColors.Distinct()); // Унікальні кольори
            UpdateColorList(); 

            lbColors.DrawMode = DrawMode.OwnerDrawFixed; // Режим малювання списку
            lbColors.DrawItem += lbColors_DrawItem; // Додано обробник подій
        }

        private void UpdateColorList()
        {
            lbColors.Items.Clear(); // Очистка списку
            foreach (var color in Colors) // Додавання кольорів
            {
                lbColors.Items.Add(color);
            }
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog()) // Відкриття діалогу кольору
            {
                if (colorDialog.ShowDialog() == DialogResult.OK) // Перевірка вибору
                {
                    if (!Colors.Contains(colorDialog.Color)) // Унікальність кольору
                    {
                        Colors.Add(colorDialog.Color); // Додавання кольору
                        UpdateColorList(); // Оновлення списку
                        lbColors.Invalidate(); // Перемальовування
                    }
                    else
                    {
                        MessageBox.Show("Цей колір вже додано.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
            }
        }

        private void btnRemoveColor_Click(object sender, EventArgs e)
        {
            if (lbColors.SelectedIndex >= 0) // Перевірка вибору
            {
                Colors.RemoveAt(lbColors.SelectedIndex); // Видалення кольору
                UpdateColorList(); // Оновлення списку
                lbColors.Invalidate(); // Перемальовування
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BallCount = (int)nudBallCount.Value; // Отримання кількості кульок
            Diameter = (int)nudDiameter.Value; // Отримання діаметру
            Speed = (int)nudSpeed.Value; // Отримання швидкості

            if (Colors.Count < BallCount) // Перевірка кількості кольорів
            {
                MessageBox.Show("Кількість кольорів повинна бути не менше кількості кульок.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            DialogResult = DialogResult.OK; // Завершення роботи
            Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Відміна
            Close(); 
        }

        private void lbColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Перевірка індексу

            e.DrawBackground(); // Малювання фону
            Color color = Colors[e.Index]; // Отримання кольору
            using (Brush brush = new SolidBrush(color)) // Кисть для кольору
            {
                e.Graphics.FillRectangle(brush, e.Bounds.Left + 2, e.Bounds.Top + 2, e.Bounds.Height - 4, e.Bounds.Height - 4); // Малювання кольору
            }
            using (Brush textBrush = new SolidBrush(Color.Black)) // Кисть для тексту
            {
                string colorName = color.IsKnownColor ? color.Name : $"#{color.R:X2}{color.G:X2}{color.B:X2}"; // Назва кольору
                e.Graphics.DrawString(colorName, e.Font, textBrush, e.Bounds.Left + e.Bounds.Height + 5, e.Bounds.Top); // Малювання назви
            }
            e.DrawFocusRectangle(); // Малювання фокусу
        }
    }
}
