// using System;

// class Program
// {
//   static void Main()
//   {
//     long n;
//     double dbln;
//     double sum = 0;
//     double term;
//     const double eps = 0.000001;
//     long k2 = 1;
//     short k1 = 1;

//     for (n = 0; ; n++, k2 *= 2, k1 = (short)-k1)
//     {
//       dbln = n;
//       term = k1 * (dbln + 1) / ((dbln + 2) / (dbln + 3));
//       if (Math.Abs(term) >= eps)
//         sum += term;
//       else
//         break;

//       if (n == 9)
//       {
//         Console.WriteLine("Сума 10-ти членів ряду = {0:F7}", sum);
//         break;
//       }
//     }

//     Console.WriteLine("Повна сума ряду = {0:F7}", sum);
//   }
// }
