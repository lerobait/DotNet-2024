// using System;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть кількість рядків матриці: ");
//     int rows = int.Parse(Console.ReadLine());

//     Console.Write("Введіть кількість стовпців матриці: ");
//     int cols = int.Parse(Console.ReadLine());

//     int[,] Ar = new int[rows, cols];

//     Random rand = new Random();
//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         Ar[l, r] = rand.Next(1, 100);
//       }
//     }

//     Console.WriteLine("\nОригінальна матриця:");
//     PrintMatrix(Ar, rows, cols);


//     int[,] rotatedMatrix = RotateMatrix90Clockwise(Ar, rows, cols);

//     Console.WriteLine("\nМатриця після розгортання на 90 градусів за годинниковою стрілкою:");
//     PrintMatrix(rotatedMatrix, cols, rows);
//   }
//   static void PrintMatrix(int[,] matrix, int rows, int cols)
//   {
//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         Console.Write("{0,3} ", matrix[l, r]);
//       }
//       Console.WriteLine();
//     }
//   }
//   static int[,] RotateMatrix90Clockwise(int[,] matrix, int rows, int cols)
//   {
//     int[,] result = new int[cols, rows];
//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         result[r, rows - 1 - l] = matrix[l, r];
//       }
//     }
//     return result;
//   }
// }