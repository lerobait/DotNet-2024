// using System;

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
//     string input;

//     while (true)
//     {
//       Console.Write("Введіть рядок > ");
//       input = Console.ReadLine();

//       if (input == "***") break;

//       Console.Write("Введіть позицію та довжину підрядка (pos len) > ");
//       string[] parameters = Console.ReadLine().Split();
//       int pos = int.Parse(parameters[0]);
//       int len = int.Parse(parameters[1]);

//       string substring = ExtractSubstring(input, pos, len);
//       Console.WriteLine($"Підрядок: >>{substring}<<\n");
//     }
//   }
// }
