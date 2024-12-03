// using System;
// using System.Text;

// class Program
// {
//   static void Main()
//   {
//     Console.OutputEncoding = Encoding.UTF8;
//     Console.InputEncoding = Encoding.UTF8;

//     string name1, name2, name3;
//     char group1, group2, group3;
//     string habitat1, habitat2, habitat3;
//     int population1, population2, population3;

//     Console.Write("1. Введіть назву антилопи > ");
//     name1 = Console.ReadLine();
//     Console.Write("   Введіть групу (A, B, H) > ");
//     group1 = char.Parse(Console.ReadLine());
//     Console.Write("   Введіть житло (Азія, Африка) > ");
//     habitat1 = Console.ReadLine();
//     Console.Write("   Введіть чисельність популяції > ");
//     population1 = int.Parse(Console.ReadLine());

//     Console.Write("2. Введіть назву антилопи > ");
//     name2 = Console.ReadLine();
//     Console.Write("   Введіть групу (A, B, H) > ");
//     group2 = char.Parse(Console.ReadLine());
//     Console.Write("   Введіть житло (Азія, Африка) > ");
//     habitat2 = Console.ReadLine();
//     Console.Write("   Введіть чисельність популяції > ");
//     population2 = int.Parse(Console.ReadLine());

//     Console.Write("3. Введіть назву антилопи > ");
//     name3 = Console.ReadLine();
//     Console.Write("   Введіть групу (A, B, H) > ");
//     group3 = char.Parse(Console.ReadLine());
//     Console.Write("   Введіть житло (Азія, Африка) > ");
//     habitat3 = Console.ReadLine();
//     Console.Write("   Введіть чисельність популяції > ");
//     population3 = int.Parse(Console.ReadLine());

//     Console.ForegroundColor = ConsoleColor.Cyan;

//     Console.WriteLine("┌────────────────────────────────────────────────┐");
//     Console.WriteLine("│ Деякі види антилоп                             │");
//     Console.WriteLine("├──────────────┬───────┬───────────┬─────────────┤");
//     Console.WriteLine("│   Назва      │ Група │   Житло   │ Чисельність │");
//     Console.WriteLine("│              │       │           │ популяції   │");
//     Console.WriteLine("├──────────────┼───────┼───────────┼─────────────┤");

//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($"│ {name1,-12} │ {group1,-5} │ {habitat1,-9} │ {population1,11} │");
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine($"│ {name2,-12} │ {group2,-5} │ {habitat2,-9} │ {population2,11} │");
//     Console.ForegroundColor = ConsoleColor.Magenta;
//     Console.WriteLine($"│ {name3,-12} │ {group3,-5} │ {habitat3,-9} │ {population3,11} │");

//     Console.ForegroundColor = ConsoleColor.Cyan;
//     Console.WriteLine("├──────────────┴───────┴───────────┴─────────────┤");
//     Console.WriteLine("│ Примітка: A – справжні антилопи;               │");
//     Console.WriteLine("│   B – коров'ячі антилопи; H – кінські антилопи │");
//     Console.WriteLine("└────────────────────────────────────────────────┘");

//     Console.ResetColor();
//   }
// }
