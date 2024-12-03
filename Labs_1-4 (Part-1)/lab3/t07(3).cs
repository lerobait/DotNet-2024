// using System;
// using System.IO;
// class Program
// {
//   static int CountLetterO(string input)
//   {
//     int count = 0;

//     foreach (char c in input)
//     {
//       if (c == 'o' || c == 'O')
//       {
//         count++;
//       }
//     }

//     return count;
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

//           int oCount = CountLetterO(line);
//           writer.WriteLine($"Кількість букв 'o' у рядку: \"{line}\" = {oCount}");
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
