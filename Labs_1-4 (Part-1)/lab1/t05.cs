// using System;
// using System.Globalization;

// class Program
// {
//   static void Main()
//   {
//     double x, y;
//     CultureInfo culture = new CultureInfo("en-US");

//     Console.Write("Введіть координату x > ");
//     x = Convert.ToDouble(Console.ReadLine(), culture);
//     Console.Write("Введіть координату y > ");
//     y = Convert.ToDouble(Console.ReadLine(), culture);

//     Console.WriteLine($"x={x:F3}; y={y:F3}");

//     bool inFirstTriangle = (x >= -1 && x <= 0) && (y >= -1 && y <= 1) && (y >= x + 1);

//     bool inSecondTriangle = (x >= 0 && x <= 1) && (y >= -1 && y <= 0) && (y >= -x);

//     if (inFirstTriangle || inSecondTriangle)
//       Console.WriteLine("Точка потрапляє в задану область");
//     else
//       Console.WriteLine("Точка не потрапляє в задану область");
//   }
// }
