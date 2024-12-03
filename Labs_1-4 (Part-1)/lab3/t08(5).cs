// using System;
// using System.IO;
// class Program
// {
//   static string CapitalizeFirstLetterOfEachWord(string input)
//   {
//     string[] words = input.Split(' ');

//     for (int i = 0; i < words.Length; i++)
//     {
//       if (words[i].Length > 0)
//       {
//         words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
//       }
//     }

//     return string.Join(" ", words);
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

//         string result = CapitalizeFirstLetterOfEachWord(input);

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
