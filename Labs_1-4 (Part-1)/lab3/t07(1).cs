// using System;
// using System.IO;

// class Program
// {
//   static int CountWords(string input)
//   {
//     if (string.IsNullOrWhiteSpace(input))
//     {
//       return 0;
//     }

//     string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
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

//           int wordCount = CountWords(line);
//           writer.WriteLine($"Кількість слів у рядку: \"{line}\" = {wordCount}");
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
