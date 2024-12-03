// using System;
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
//     string input;
//     while (true)
//     {
//       Console.Write("Введіть рядок > ");
//       input = Console.ReadLine();

//       if (input == "***") break;

//       int oCount = CountLetterO(input);
//       Console.WriteLine($"Кількість букв 'o': {oCount}\n");
//     }
//   }
// }
