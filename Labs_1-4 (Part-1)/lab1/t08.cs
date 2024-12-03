// using System;
// using System.Globalization;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть похибку: ");
//     double eps = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//     Console.Write("Введіть кількість членів ряду: ");
//     int maxTerms = int.Parse(Console.ReadLine());

//     long n;
//     double dbln;
//     double sum = 0;
//     double term;
//     long k2 = 1;
//     short k1 = 1;

//     for (n = 0; n < maxTerms; n++, k2 *= 2, k1 = (short)-k1)
//     {
//       dbln = n;
//       term = k1 * (dbln + 1) / ((dbln + 2) / (dbln + 3));
//       if (Math.Abs(term) >= eps)
//         sum += term;
//       else
//       {
//         Console.WriteLine("Досягнута задана похибка.");
//         break;
//       }
//     }

//     Console.WriteLine("Повна сума ряду = {0:F7}", sum);
//   }
// }
