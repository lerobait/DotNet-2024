// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// class Program
// {
//   static int CountOddLengthWords(string input)
//   {
//     string[] words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
//     return words.Count(word => word.Length % 2 != 0);
//   }

//   static Dictionary<char, int> GetLetterFrequency(string input)
//   {
//     Dictionary<char, int> frequency = new Dictionary<char, int>();

//     foreach (char c in input)
//     {
//       if (char.IsLetter(c))
//       {
//         char lowerChar = char.ToLower(c);
//         if (frequency.ContainsKey(lowerChar))
//         {
//           frequency[lowerChar]++;
//         }
//         else
//         {
//           frequency[lowerChar] = 1;
//         }
//       }
//     }

//     return frequency;
//   }

//   static string RemoveTextInParentheses(string input)
//   {
//     return Regex.Replace(input, @"\([^)]*\)", "");
//   }

//   static void Main()
//   {
//     string input;

//     Console.Write("Введіть текстовий рядок: ");
//     input = Console.ReadLine();

//     int oddLengthWordCount = CountOddLengthWords(input);
//     Console.WriteLine($"Кількість слів з непарною довжиною: {oddLengthWordCount}");

//     Dictionary<char, int> letterFrequency = GetLetterFrequency(input);
//     Console.WriteLine("Частота входження літер:");
//     foreach (var pair in letterFrequency)
//     {
//       Console.WriteLine($"'{pair.Key}': {pair.Value}");
//     }

//     string resultWithoutParentheses = RemoveTextInParentheses(input);
//     Console.WriteLine($"Текст без тексту в дужках: {resultWithoutParentheses}");
//   }
// }
