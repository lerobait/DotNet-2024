using System.Collections.Generic; 
using MySql.Data.MySqlClient; 
using Task_3.Models; 

namespace Task_3
{
    public class Database
    {
        // Строка підключення
        private string connectionString = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;database=CityTransportDB;";

        // Отримати транспорти
        public List<Transport> GetTransports()
        {
            // Список транспорту
            List<Transport> transports = new List<Transport>();

            // Відкрити з'єднання
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити
                
                string query = "SELECT * FROM Transport;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати запит
                MySqlDataReader reader = cmd.ExecuteReader();

                // Читати дані
                while (reader.Read())
                {
                    // Створити транспорт
                    Transport transport = new Transport
                    {
                        TransportID = reader.GetInt32("TransportID"),
                        Type = reader.GetString("Type"),
                        Fare = reader.GetDecimal("Fare"),
                        Units = reader.GetInt32("Units"),
                        Profitability = reader.GetDecimal("Profitability")
                    };

                    transports.Add(transport); // Додати транспорт
                }
            }

            return transports; 
        }

        // Отримати маршрути
        public List<Route> GetRoutes()
        {
            // Список маршрутів
            List<Route> routes = new List<Route>();

            // Відкрити з'єднання
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                string query = "SELECT * FROM Route;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати запит
                MySqlDataReader reader = cmd.ExecuteReader();

                // Читати дані
                while (reader.Read())
                {
                    // Створити маршрут
                    Route route = new Route
                    {
                        RouteID = reader.GetInt32("RouteID"),
                        StartPoint = reader.GetString("StartPoint"),
                        EndPoint = reader.GetString("EndPoint"),
                        Stops = reader.GetInt32("Stops"),
                        Length = reader.GetDecimal("Length"),
                        TravelTime = reader.GetInt32("TravelTime")
                    };

                    routes.Add(route); // Додати маршрут
                }
            }

            return routes; 
        }

        // Отримати реєстри маршрутів
        public List<RouteRegister> GetRouteRegisters()
        {
            // Список реєстрів
            List<RouteRegister> routeRegisters = new List<RouteRegister>();

            // Відкрити з'єднання
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                string query = @"SELECT rr.*, t.*, r.* FROM RouteRegister rr
                                 JOIN Transport t ON rr.TransportID = t.TransportID
                                 JOIN Route r ON rr.RouteID = r.RouteID;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати запит
                MySqlDataReader reader = cmd.ExecuteReader();

                // Читати дані
                while (reader.Read())
                {
                    // Створити транспорт
                    Transport transport = new Transport
                    {
                        TransportID = reader.GetInt32("TransportID"),
                        Type = reader.GetString("Type"),
                        Fare = reader.GetDecimal("Fare"),
                        Units = reader.GetInt32("Units"),
                        Profitability = reader.GetDecimal("Profitability")
                    };

                    // Створити маршрут
                    Route route = new Route
                    {
                        RouteID = reader.GetInt32("RouteID"),
                        StartPoint = reader.GetString("StartPoint"),
                        EndPoint = reader.GetString("EndPoint"),
                        Stops = reader.GetInt32("Stops"),
                        Length = reader.GetDecimal("Length"),
                        TravelTime = reader.GetInt32("TravelTime")
                    };

                    // Створити реєстр маршруту
                    RouteRegister routeRegister = new RouteRegister
                    {
                        RouteRegisterID = reader.GetInt32("RouteRegisterID"),
                        TransportID = reader.GetInt32("TransportID"),
                        RouteID = reader.GetInt32("RouteID"),
                        Direction = reader.GetString("Direction"),
                        DepartureTime = reader.GetTimeSpan("DepartureTime"),
                        ArrivalTime = reader.GetTimeSpan("ArrivalTime"),
                        Transport = transport,
                        Route = route
                    };

                    routeRegisters.Add(routeRegister); // Додати реєстр
                }
            }

            return routeRegisters; 
        }
    }
}
