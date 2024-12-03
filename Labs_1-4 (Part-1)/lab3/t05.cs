// using System;

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

//     while (true)
//     {
//       Console.Write("Введіть рядок > ");
//       input = Console.ReadLine();

//       if (input == "***") break;

//       string result = CapitalizeFirstLetterOfEachWord(input);
//       Console.WriteLine($"Результат: {result}\n");
//     }
//   }
// }
