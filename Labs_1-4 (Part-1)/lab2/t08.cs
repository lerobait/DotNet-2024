// using System;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть кількість рядків матриці: ");
//     int rows = int.Parse(Console.ReadLine());

//     Console.Write("Введіть кількість стовпців матриці: ");
//     int cols = int.Parse(Console.ReadLine());

//     int[][] Ar = new int[rows][];
//     for (int i = 0; i < rows; i++)
//     {
//       Ar[i] = new int[cols];
//     }

//     Random rand = new Random();
//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         Ar[l][r] = rand.Next(1, 100);
//       }
//     }

//     Console.WriteLine("\nОригінальна матриця:");
//     PrintMatrix(Ar, rows, cols, ConsoleColor.Green);

//     int[][] rotatedMatrix = RotateMatrix90Clockwise(Ar, rows, cols);

//     Console.WriteLine("\nМатриця після розгортання на 90 градусів за годинниковою стрілкою:");
//     PrintMatrix(rotatedMatrix, cols, rows, ConsoleColor.Blue);
//   }

//   static void PrintMatrix(int[][] matrix, int rows, int cols, ConsoleColor color)
//   {
//     ConsoleColor originalColor = Console.ForegroundColor;
//     Console.ForegroundColor = color;

//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         Console.Write("{0,3} ", matrix[l][r]);
//       }
//       Console.WriteLine();
//     }

//     Console.ForegroundColor = originalColor;
//   }

//   static int[][] RotateMatrix90Clockwise(int[][] matrix, int rows, int cols)
//   {
//     int[][] result = new int[cols][];
//     for (int i = 0; i < cols; i++)
//     {
//       result[i] = new int[rows];
//     }

//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         result[r][rows - 1 - l] = matrix[l][r];
//       }
//     }
//     return result;
//   }
// }
