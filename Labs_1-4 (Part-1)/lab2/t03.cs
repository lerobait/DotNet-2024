// using System;

// class Program
// {
//   static void Main()
//   {
//     Console.Write("Введіть розмір масиву: ");
//     int arraySize = int.Parse(Console.ReadLine());

//     int[] Ar = new int[arraySize];
//     int minPositive = int.MaxValue;

//     Random random = new Random();
//     for (int i = 0; i < arraySize; i++)
//     {
//       Ar[i] = random.Next(-100, 101);

//       if (Ar[i] > 0 && Ar[i] < minPositive)
//       {
//         minPositive = Ar[i];
//       }
//     }

//     Console.WriteLine("\nПочатковий масив:");
//     for (int i = 0; i < arraySize; i++)
//     {
//       if (Ar[i] > 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Green;
//       }
//       else if (Ar[i] < 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Red;
//       }
//       else
//       {
//         Console.ResetColor();
//       }

//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.ResetColor();
//     Console.WriteLine("\n");

//     for (int i = 0; i < arraySize; i++)
//     {
//       if (Ar[i] < 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine($"Заміна елемента {Ar[i]} на {minPositive}");
//         Ar[i] = minPositive;
//       }
//     }

//     Console.WriteLine("\nМасив-результат:");
//     for (int i = 0; i < arraySize; i++)
//     {
//       if (Ar[i] == minPositive)
//       {
//         Console.ForegroundColor = ConsoleColor.Yellow;
//       }
//       else if (Ar[i] > 0)
//       {
//         Console.ForegroundColor = ConsoleColor.Green;
//       }

//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.ResetColor();
//     Console.WriteLine();
//   }
// }
