// using System;
// using System.Globalization;

// class Program
// {
//   static void Main()
//   {
//     double x = 0, y = 0;

//     double a = 12.5, b = 1.3;
//     double c = 14.1, d = 2.7;

//     double t1, t2;
//     double ax;
//     Console.Write("Введіть x і y: ");
//     string input = Console.ReadLine();


//     if (!string.IsNullOrWhiteSpace(input))
//     {
//       string[] values = input.Split(' ');

//       if (values.Length >= 2 &&
//           double.TryParse(values[0], NumberStyles.Any, CultureInfo.InvariantCulture, out x) &&
//           double.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out y))
//       {
//         ax = a * x;
//         t1 = (ax / y) + (b / (y * y)) * Math.Log(b * x + c);

//         ax = Math.Sqrt(c * c - b * b) * Math.Tan(ax);
//         t2 = (1 / (2 * a * b)) * Math.Log((ax + 2) / (ax - 2));

//         Console.WriteLine($"t1 = {t1}");
//         Console.WriteLine($"t2 = {t2}");
//       }
//       else
//       {
//         Console.WriteLine("Помилка введення. Переконайтеся, що ви вводите два номери.");
//       }
//     }
//     else
//     {
//       Console.WriteLine("Помилка введення. Ви не ввели жодних даних.");
//     }
//   }
// }
