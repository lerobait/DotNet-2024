using System.Collections.Generic; 
using MySql.Data.MySqlClient; 
using Task_5.Models;

namespace Task_5
{
    public class Database
    {
        // Підключення
        private string connectionString = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;database=CityTransportDB;";

        // Отримати транспорти
        public List<Transport> GetTransports()
        {
            // Список транспорту
            List<Transport> transports = new List<Transport>();

            // Відкрити з'єднання
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                string query = "SELECT * FROM Transport;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати читання
                MySqlDataReader reader = cmd.ExecuteReader();

                // Читати дані
                while (reader.Read())
                {
                    // Створити транспорт
                    Transport transport = new Transport
                    {
                        TransportID = reader.GetInt32("TransportID"), // ID транспорту
                        Type = reader.GetString("Type"), // Тип
                        Fare = reader.GetDecimal("Fare"), // Вартість
                        Units = reader.GetInt32("Units"), // Одиниці
                        Profitability = reader.GetDecimal("Profitability") // Прибутковість
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
                conn.Open(); 

                string query = "SELECT * FROM Route;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати читання
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

                string query = "SELECT * FROM RouteRegister;";

                // Створити команду
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Виконати читання
                MySqlDataReader reader = cmd.ExecuteReader();

                // Читати дані
                while (reader.Read())
                {
                    // Створити реєстр
                    RouteRegister routeRegister = new RouteRegister
                    {
                        RouteRegisterID = reader.GetInt32("RouteRegisterID"), 
                        TransportID = reader.GetInt32("TransportID"), 
                        RouteID = reader.GetInt32("RouteID"), 
                        Direction = reader.GetString("Direction"), 
                        DepartureTime = reader.GetTimeSpan("DepartureTime"), 
                        ArrivalTime = reader.GetTimeSpan("ArrivalTime") 
                    };

                    routeRegisters.Add(routeRegister); // Додати реєстр
                }
            }

            return routeRegisters; // Повернути список
        }
    }
}
