// using System;

// class Program
// {
//   static int[] Ar = new int[50];

//   static void Main()
//   {
//     int i;
//     int minPositive = int.MaxValue;

//     Random random = new Random();
//     for (i = 0; i < 50; i++)
//     {
//       Ar[i] = random.Next(-100, 101);
//       if (Ar[i] > 0 && Ar[i] < minPositive)
//       {
//         minPositive = Ar[i];
//       }
//     }

//     Console.WriteLine("Початковий масив:");
//     for (i = 0; i < 50; i++)
//     {
//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.WriteLine("\n");

//     for (i = 0; i < 50; i++)
//     {
//       if (Ar[i] < 0)
//       {
//         Ar[i] = minPositive;
//       }
//     }

//     Console.WriteLine("Масив-результат:");
//     for (i = 0; i < 50; i++)
//     {
//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.WriteLine();
//   }
// }
