// using System;
// using System.IO;

// class Program
// {
//   static string ExtractSubstring(string input, int start, int length)
//   {
//     if (start < 0 || start >= input.Length || length < 0)
//     {
//       return "";
//     }

//     int actualLength = Math.Min(length, input.Length - start);
//     return input.Substring(start, actualLength);
//   }

//   static void Main()
//   {
//     string inputFilePath = "input.txt";
//     string outputFilePath = "output.txt";

//     try
//     {
//       string[] lines = File.ReadAllLines(inputFilePath);
//       using (StreamWriter writer = new StreamWriter(outputFilePath))
//       {
//         foreach (string line in lines)
//         {
//           if (line == "***") break;

//           Console.Write($"Введіть позицію та довжину підрядка для рядка: \"{line}\" (pos len) > ");
//           string[] parameters = Console.ReadLine().Split();

//           if (parameters.Length < 2 || !int.TryParse(parameters[0], out int pos) || !int.TryParse(parameters[1], out int len))
//           {
//             writer.WriteLine("Неправильні параметри. Слід вказати позицію та довжину.");
//             continue;
//           }

//           string substring = ExtractSubstring(line, pos, len);
//           writer.WriteLine($"Підрядок з рядка: \"{line}\" = >>{substring}<<");
//         }
//       }

//       Console.WriteLine("Обробка завершена. Результати записано у файл output.txt.");
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Сталася помилка: {ex.Message}");
//     }
//   }
// }
