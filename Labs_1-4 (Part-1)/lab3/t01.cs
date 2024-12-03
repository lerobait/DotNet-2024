// using System;
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
//     string input;

//     while (true)
//     {
//       Console.Write("Введіть рядок > ");
//       input = Console.ReadLine();

//       if (input == "***") break;

//       int wordCount = CountWords(input);
//       Console.WriteLine($"Кількість слів: {wordCount}\n");
//     }
//   }
// }
