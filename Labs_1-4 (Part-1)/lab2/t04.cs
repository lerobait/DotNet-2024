// using System;
// using System.Collections.Generic;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть розмір масиву: ");
//     int listSize = int.Parse(Console.ReadLine());

//     List<int> numbers = new List<int>();
//     int minPositive = int.MaxValue;

//     Random random = new Random();

//     for (int i = 0; i < listSize; i++)
//     {
//       int randomValue = random.Next(-100, 101);
//       numbers.Add(randomValue);

//       if (randomValue > 0 && randomValue < minPositive)
//       {
//         minPositive = randomValue;
//       }
//     }

//     Console.WriteLine("\nПочатковий масив:");
//     for (int i = 0; i < listSize; i++)
//     {
//       if (numbers[i] > 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Green;
//       }
//       else if (numbers[i] < 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Red;
//       }
//       else
//       {
//         Console.ResetColor();
//       }

//       Console.Write($"{numbers[i],4}  ");
//     }
//     Console.ResetColor();
//     Console.WriteLine("\n");

//     for (int i = 0; i < listSize; i++)
//     {
//       if (numbers[i] < 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine($"Заміна елемента {numbers[i]} на {minPositive}");
//         numbers[i] = minPositive;
//       }
//     }

//     Console.WriteLine("\nСписок-результат:");
//     for (int i = 0; i < listSize; i++)
//     {
//       if (numbers[i] == minPositive)
//       {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//       }
//       else if (numbers[i] > 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Green;
//       }

//       Console.Write($"{numbers[i],4}  ");
//     }
//     Console.ResetColor();
//     Console.WriteLine();
//   }
// }
