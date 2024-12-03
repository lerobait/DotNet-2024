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
//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.WriteLine("\n");

//     for (int i = 0; i < arraySize; i++)
//     {
//       if (Ar[i] < 0)
//       {
//         Ar[i] = minPositive;
//       }
//     }

//     Console.WriteLine("Масив-результат:");
//     for (int i = 0; i < arraySize; i++)
//     {
//       Console.Write($"{Ar[i],4}  ");
//     }
//     Console.WriteLine();
//   }
// }
