// using System;

// class Program
// {
//   const int S = 9;
//   static int[,] Ar = new int[S, S];

//   static void Main()
//   {
//     Random rand = new Random();
//     for (int l = 0; l < S; l++)
//     {
//       for (int r = 0; r < S; r++)
//       {
//         Ar[l, r] = rand.Next(1, 100);
//       }
//     }

//     Console.WriteLine("Оригінальна матриця:");
//     PrintMatrix(Ar);

//     int[,] rotatedMatrix = RotateMatrix90Clockwise(Ar);

//     Console.WriteLine("\nМатриця після розгортання на 90 градусів за годинниковою стрілкою:");
//     PrintMatrix(rotatedMatrix);
//   }

//   static void PrintMatrix(int[,] matrix)
//   {
//     for (int l = 0; l < S; l++)
//     {
//       for (int r = 0; r < S; r++)
//       {
//         Console.Write("{0,3} ", matrix[l, r]);
//       }
//       Console.WriteLine();
//     }
//   }

//   static int[,] RotateMatrix90Clockwise(int[,] matrix)
//   {
//     int[,] result = new int[S, S];
//     for (int l = 0; l < S; l++)
//     {
//       for (int r = 0; r < S; r++)
//       {
//         result[r, S - 1 - l] = matrix[l, r];
//       }
//     }
//     return result;
//   }
// }
