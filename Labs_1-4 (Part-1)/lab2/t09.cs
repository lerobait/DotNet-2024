// using System;
// using System.Collections.Generic;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть кількість рядків матриці: ");
//     int rows = int.Parse(Console.ReadLine());

//     Console.Write("Введіть кількість стовпців матриці: ");
//     int cols = int.Parse(Console.ReadLine());

//     int[][] matrix = new int[rows][];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//       matrix[i] = new int[cols];
//       for (int j = 0; j < cols; j++)
//       {
//         matrix[i][j] = rand.Next(1, 100);
//       }
//     }

//     Console.WriteLine("\nЗгенерована матриця:");
//     PrintMatrix(matrix, rows, cols);

//     int? maxDuplicate = FindMaxDuplicate(matrix, rows, cols);

//     if (maxDuplicate.HasValue)
//     {
//       Console.WriteLine($"\nМаксимальне число, яке зустрічається більше одного разу: {maxDuplicate.Value}");
//     }
//     else
//     {
//       Console.WriteLine("\nУ матриці немає чисел, які зустрічаються більше одного разу.");
//     }
//   }

//   static void PrintMatrix(int[][] matrix, int rows, int cols)
//   {
//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         Console.Write("{0,3} ", matrix[l][r]);
//       }
//       Console.WriteLine();
//     }
//   }

//   static int? FindMaxDuplicate(int[][] matrix, int rows, int cols)
//   {
//     Dictionary<int, int> frequency = new Dictionary<int, int>();

//     for (int l = 0; l < rows; l++)
//     {
//       for (int r = 0; r < cols; r++)
//       {
//         if (frequency.ContainsKey(matrix[l][r]))
//         {
//           frequency[matrix[l][r]]++;
//         }
//         else
//         {
//           frequency[matrix[l][r]] = 1;
//         }
//       }
//     }

//     int? maxDuplicate = null;

//     foreach (var pair in frequency)
//     {
//       if (pair.Value > 1)
//       {
//         if (maxDuplicate == null || pair.Key > maxDuplicate)
//         {
//           maxDuplicate = pair.Key;
//         }
//       }
//     }

//     return maxDuplicate;
//   }
// }
