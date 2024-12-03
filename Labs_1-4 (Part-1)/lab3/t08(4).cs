// using System;
// using System.IO;
// class Program
// {
//   static string ReplaceDotsWithThreeDots(string input)
//   {
//     return input.Replace(".", "...");
//   }

//   static void Main()
//   {
//     string input;
//     string filePath = "output.bin";

//     if (File.Exists(filePath))
//     {
//       File.Delete(filePath);
//     }

//     using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//     {
//       while (true)
//       {
//         Console.Write("Введіть рядок > ");
//         input = Console.ReadLine();

//         if (input == "***") break;

//         string result = ReplaceDotsWithThreeDots(input);

//         writer.Write(result);

//         Console.WriteLine($"Результат: {result}\n");
//       }
//     }

//     Console.WriteLine("Вміст двійкового файлу:");
//     using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//     {
//       try
//       {
//         while (reader.BaseStream.Position != reader.BaseStream.Length)
//         {
//           string line = reader.ReadString();
//           Console.WriteLine(line);
//         }
//       }
//       catch (EndOfStreamException)
//       {
//       }
//     }
//   }
// }
