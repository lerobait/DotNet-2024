// using System;
// class Program
// {
//   static void Main()
//   {
//     for (int n = 0; n < 5; n++)
//     {
//       Console.WriteLine("|   x   |      y     |");
//       Console.WriteLine("|-------|------------|");

//       for (double x = 0; x < 4; x += 0.25)
//       {
//         double y;
//         if (x < 1)
//           y = 1;
//         else if (x < 3)
//           y = 1 - Math.Sqrt(1 - (x - 2) * (x - 2));
//         else
//           y = 1;

//         Console.Write("| {0,5:0.00} | {1,10:0.0000000} |", x + n * 4, y);

//         int h = (int)((y + 1) * 10);
//         if (y - 1 - h * 0.1 > 0.5) h++;

//         for (int i = 0; i < h; i++) Console.Write(" ");
//         Console.WriteLine("*");
//       }

//       Console.WriteLine("Натисніть клавішу Enter...");
//       Console.ReadLine();
//     }
//   }
// }
