using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace CityTransportApp
{
    // Класи Transport, Route та RouteRegister
    public class Transport
    {
        public int TransportID { get; set; }
        public string Type { get; set; }
        public decimal Fare { get; set; }
        public int Units { get; set; }
        public decimal Profitability { get; set; }
    }

    public class Route
    {
        public int RouteID { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int Stops { get; set; }
        public decimal Length { get; set; }
        public int TravelTime { get; set; }
    }

    public class RouteRegister
    {
        public int RouteRegisterID { get; set; }
        public int TransportID { get; set; }
        public int RouteID { get; set; }
        public string Direction { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }

        // Властивості для зв'язку з іншими класами
        public Transport Transport { get; set; }
        public Route Route { get; set; }
    }

    class Program
    {
        // Рядок підключення до бази даних
        static string connStr = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;database=CityTransportDB;";

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("uk-UA");

            try
            {
                // Створюємо списки для зберігання даних
                List<Transport> transports = new List<Transport>();
                List<Route> routes = new List<Route>();
                List<RouteRegister> routeRegisters = new List<RouteRegister>();

                // Підключення до бази даних
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Завантаження даних з таблиці Transport
                    string selectTransport = "SELECT * FROM Transport;";
                    MySqlCommand cmd = new MySqlCommand(selectTransport, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Transport transport = new Transport()
                        {
                            TransportID = Convert.ToInt32(reader["TransportID"]),
                            Type = reader["Type"].ToString(),
                            Fare = Convert.ToDecimal(reader["Fare"]),
                            Units = Convert.ToInt32(reader["Units"]),
                            Profitability = Convert.ToDecimal(reader["Profitability"])
                        };
                        transports.Add(transport);
                    }
                    reader.Close();

                    // Завантаження даних з таблиці Route
                    string selectRoute = "SELECT * FROM Route;";
                    cmd.CommandText = selectRoute;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Route route = new Route()
                        {
                            RouteID = Convert.ToInt32(reader["RouteID"]),
                            StartPoint = reader["StartPoint"].ToString(),
                            EndPoint = reader["EndPoint"].ToString(),
                            Stops = Convert.ToInt32(reader["Stops"]),
                            Length = Convert.ToDecimal(reader["Length"]),
                            TravelTime = Convert.ToInt32(reader["TravelTime"])
                        };
                        routes.Add(route);
                    }
                    reader.Close();

                    // Завантаження даних з таблиці RouteRegister
                    string selectRouteRegister = "SELECT * FROM RouteRegister;";
                    cmd.CommandText = selectRouteRegister;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RouteRegister rr = new RouteRegister()
                        {
                            RouteRegisterID = Convert.ToInt32(reader["RouteRegisterID"]),
                            TransportID = Convert.ToInt32(reader["TransportID"]),
                            RouteID = Convert.ToInt32(reader["RouteID"]),
                            Direction = reader["Direction"].ToString(),
                            DepartureTime = (TimeSpan)reader["DepartureTime"],
                            ArrivalTime = (TimeSpan)reader["ArrivalTime"]
                        };
                        routeRegisters.Add(rr);
                    }
                    reader.Close();

                    // Встановлення зв'язків між об'єктами
                    foreach (var rr in routeRegisters)
                    {
                        rr.Transport = transports.Find(t => t.TransportID == rr.TransportID);
                        rr.Route = routes.Find(r => r.RouteID == rr.RouteID);
                    }

                    conn.Close();
                }


                // Виведення таблиці Transport
                Console.WriteLine("Таблиця Transport:");
                PrintTransportTable(transports);

                // Виведення таблиці Route
                Console.WriteLine("\nТаблиця Route:");
                PrintRouteTable(routes);

                // Виведення таблиці RouteRegister
                Console.WriteLine("\nТаблиця RouteRegister:");
                PrintRouteRegisterTable(routeRegisters);

                // Головний цикл програми
                while (true)
                {
                    // Запит ID маршруту
                    Console.WriteLine("\nВведіть ID маршруту для відображення транспортів (або 'exit' для виходу):");
                    string inputRouteId = Console.ReadLine();

                    if (inputRouteId.Trim().ToLower() == "exit")
                        break;

                    if (!int.TryParse(inputRouteId, out int routeId))
                    {
                        Console.WriteLine("Неправильний формат ID маршруту. Спробуйте ще раз.");
                        continue;
                    }

                    var transportsOnRoute = routeRegisters.FindAll(rr => rr.RouteID == routeId);

                    if (transportsOnRoute.Count == 0)
                    {
                        Console.WriteLine($"Немає транспортів на маршруті з ID {routeId}.");
                    }
                    else
                    {
                        Console.WriteLine($"\nТранспорти на маршруті ID {routeId}:");
                        PrintRouteRegisterTable(transportsOnRoute);
                    }

                    // Запит типу транспорту
                    Console.WriteLine("\nВведіть тип транспорту для відображення маршрутів (або 'exit' для виходу):");
                    string transportType = Console.ReadLine();

                    if (transportType.Trim().ToLower() == "exit")
                        break;

                    var routesWithTransport = routeRegisters.FindAll(rr => rr.Transport.Type.Equals(transportType, StringComparison.OrdinalIgnoreCase));

                    if (routesWithTransport.Count == 0)
                    {
                        Console.WriteLine($"Немає маршрутів з транспортом '{transportType}'.");
                    }
                    else
                    {
                        Console.WriteLine($"\nМаршрути з транспортом '{transportType}':");
                        PrintRouteRegisterTable(routesWithTransport);
                    }
                }

                Console.WriteLine("\nПрограма завершена. Натисніть будь-яку клавішу для виходу.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
                Console.WriteLine("Деталі помилки: " + ex.StackTrace);
                Console.WriteLine("\nНатисніть будь-яку клавішу для виходу.");
                Console.ReadKey();
            }
        }

        // Вивід таблиці Transport (динам. шир.)
        static void PrintTransportTable(List<Transport> transports)
        {
            // Макс. довжини для кожної колонки
            int idWidth = Math.Max("ID".Length, transports.Max(t => t.TransportID.ToString().Length)) + 2;
            int typeWidth = Math.Max("Тип".Length, transports.Max(t => t.Type.Length)) + 2;
            int fareWidth = Math.Max("Вартість".Length, transports.Max(t => t.Fare.ToString("C").Length)) + 2;
            int unitsWidth = Math.Max("Одиниці".Length, transports.Max(t => t.Units.ToString().Length)) + 2;
            int profitWidth = Math.Max("Рентабельність".Length, transports.Max(t => (t.Profitability / 100).ToString("P").Length)) + 2;

            string separator = new string('-', idWidth + typeWidth + fareWidth + unitsWidth + profitWidth + 13);

            // Формат для рядків
            string rowFormat = $"| {{0,-{idWidth}}} | " +
                               $"{{1,-{typeWidth}}} | " +
                               $"{{2,-{fareWidth}}} | " +
                               $"{{3,-{unitsWidth}}} | " +
                               $"{{4,-{profitWidth}}} |";


            Console.WriteLine(separator);
            Console.WriteLine(rowFormat, "ID", "Тип", "Вартість", "Одиниці", "Рентабельність");
            Console.WriteLine(separator);
            foreach (var t in transports)
            {
                Console.WriteLine(
                    rowFormat,
                    t.TransportID,
                    t.Type,
                    t.Fare.ToString("C"),
                    t.Units,
                    (t.Profitability / 100).ToString("P")
                );
            }
            Console.WriteLine(separator);
        }

        // Вивід таблиці Route (динам. шир.)
        static void PrintRouteTable(List<Route> routes)
        {
            // Макс. довжини для кожної колонки
            int idWidth = Math.Max("ID".Length, routes.Max(r => r.RouteID.ToString().Length)) + 2;
            int startWidth = Math.Max("Початок".Length, routes.Max(r => r.StartPoint.Length)) + 2;
            int endWidth = Math.Max("Кінець".Length, routes.Max(r => r.EndPoint.Length)) + 2;
            int stopsWidth = Math.Max("Зупинки".Length, routes.Max(r => r.Stops.ToString().Length)) + 2;
            int lengthWidth = Math.Max("Довжина".Length, routes.Max(r => r.Length.ToString().Length + 4)) + 2; // +4 для " км"
            int timeWidth = Math.Max("Час у дорозі".Length, routes.Max(r => r.TravelTime.ToString().Length + 4)) + 2; // +4 для " хв"

            string separator = new string('-', idWidth + startWidth + endWidth + stopsWidth + lengthWidth + timeWidth + 19);

            // Формат для рядків
            string rowFormat = $"| {{0,-{idWidth}}} | " +
                               $"{{1,-{startWidth}}} | " +
                               $"{{2,-{endWidth}}} | " +
                               $"{{3,-{stopsWidth}}} | " +
                               $"{{4,-{lengthWidth}}} | " +
                               $"{{5,-{timeWidth}}} |";

            Console.WriteLine(separator);
            Console.WriteLine(rowFormat, "ID", "Початок", "Кінець", "Зупинки", "Довжина", "Час у дорозі");
            Console.WriteLine(separator);

            foreach (var r in routes)
            {
                Console.WriteLine(
                    rowFormat,
                    r.RouteID,
                    r.StartPoint,
                    r.EndPoint,
                    r.Stops,
                    r.Length + " км",
                    r.TravelTime + " хв"
                );
            }
            Console.WriteLine(separator);
        }

        // Вивід таблиці RouteRegister (динам. шир.)
        static void PrintRouteRegisterTable(List<RouteRegister> routeRegisters)
        {
            // Макс. довжини для кожної колонки
            int idWidth = Math.Max("ID".Length, routeRegisters.Max(rr => rr.RouteRegisterID.ToString().Length)) + 2;
            int transportWidth = Math.Max("Транспорт".Length, routeRegisters.Max(rr => rr.Transport.Type.Length)) + 2;
            int startWidth = Math.Max("Початок".Length, routeRegisters.Max(rr => rr.Route.StartPoint.Length)) + 2;
            int endWidth = Math.Max("Кінець".Length, routeRegisters.Max(rr => rr.Route.EndPoint.Length)) + 2;
            int directionWidth = Math.Max("Напрямок".Length, routeRegisters.Max(rr => rr.Direction.Length)) + 2;
            int departWidth = Math.Max("Відправлення".Length, routeRegisters.Max(rr => rr.DepartureTime.ToString(@"hh\:mm").Length)) + 2;
            int arrivalWidth = Math.Max("Прибуття".Length, routeRegisters.Max(rr => rr.ArrivalTime.ToString(@"hh\:mm").Length)) + 2;

            string separator = new string('-', idWidth + transportWidth + startWidth + endWidth + directionWidth + departWidth + arrivalWidth + 19);

            // Формат для рядків
            string rowFormat = $"| {{0,-{idWidth}}} | " +
                               $"{{1,-{transportWidth}}} | " +
                               $"{{2,-{startWidth}}} | " +
                               $"{{3,-{endWidth}}} | " +
                               $"{{4,-{directionWidth}}} | " +
                               $"{{5,-{departWidth}}} | " +
                               $"{{6,-{arrivalWidth}}} |";

            Console.WriteLine(separator);
            Console.WriteLine(rowFormat, "ID", "Транспорт", "Початок", "Кінець", "Напрямок", "Відправлення", "Прибуття");
            Console.WriteLine(separator);

            foreach (var rr in routeRegisters)
            {
                Console.WriteLine(
                    rowFormat,
                    rr.RouteRegisterID,
                    rr.Transport.Type,
                    rr.Route.StartPoint,
                    rr.Route.EndPoint,
                    rr.Direction,
                    rr.DepartureTime.ToString(@"hh\:mm"),
                    rr.ArrivalTime.ToString(@"hh\:mm")
                );
            }
            Console.WriteLine(separator);
        }
    }
}
