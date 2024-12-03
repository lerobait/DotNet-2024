using System; 
using System.Collections.Generic; 
using MySql.Data.MySqlClient; 
using Task_7.Models;

namespace Task_7
{
    public class Database
    {
        // Підключення
        private string connectionString = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;database=CityTransportDB;";

        // Transport Methods

        public List<Transport> GetTransports()
        {
            List<Transport> transports = new List<Transport>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Transport;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Створити команду
                MySqlDataReader reader = cmd.ExecuteReader(); // Виконати читання
                while (reader.Read())
                {
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

        public decimal GetAverageFare()
        {
            decimal averageFare = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT AVG(Fare) FROM Transport;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                var result = cmd.ExecuteScalar(); 
                if (result != DBNull.Value)
                    averageFare = Convert.ToDecimal(result); // Обробка результату
            }
            return averageFare; // Повернути середнє значення
        }

        public Transport GetTransportWithMaxFare()
        {
            Transport transport = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Transport WHERE Fare = (SELECT MAX(Fare) FROM Transport);";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.Read())
                {
                    transport = new Transport
                    {
                        TransportID = reader.GetInt32("TransportID"),
                        Type = reader.GetString("Type"), 
                        Fare = reader.GetDecimal("Fare"),
                        Units = reader.GetInt32("Units"), 
                        Profitability = reader.GetDecimal("Profitability") 
                    };
                }
            }
            return transport; // Повернути транспорт
        }

        public Transport GetTransportWithMinFare()
        {
            Transport transport = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Transport WHERE Fare = (SELECT MIN(Fare) FROM Transport);";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.Read())
                {
                    transport = new Transport
                    {
                        TransportID = reader.GetInt32("TransportID"), 
                        Type = reader.GetString("Type"), 
                        Fare = reader.GetDecimal("Fare"), 
                        Units = reader.GetInt32("Units"), 
                        Profitability = reader.GetDecimal("Profitability") 
                    };
                }
            }
            return transport; // Повернути транспорт
        }

        // Route Methods

        public List<Route> GetRoutes()
        {
            List<Route> routes = new List<Route>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Route;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Створити команду
                MySqlDataReader reader = cmd.ExecuteReader(); // Виконати читання
                while (reader.Read())
                {
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

        public decimal GetAverageRouteLength()
        {
            decimal averageLength = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT AVG(Length) FROM Route;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                var result = cmd.ExecuteScalar(); 
                if (result != DBNull.Value)
                    averageLength = Convert.ToDecimal(result); // Обробка результату
            }
            return averageLength; // Повернути середню довжину
        }

        public Route GetRouteWithMaxLength()
        {
            Route route = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Route WHERE Length = (SELECT MAX(Length) FROM Route);";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.Read())
                {
                    route = new Route
                    {
                        RouteID = reader.GetInt32("RouteID"),
                        StartPoint = reader.GetString("StartPoint"), 
                        EndPoint = reader.GetString("EndPoint"), 
                        Stops = reader.GetInt32("Stops"), 
                        Length = reader.GetDecimal("Length"), 
                        TravelTime = reader.GetInt32("TravelTime") 
                    };
                }
            }
            return route; // Повернути маршрут
        }

        public Route GetRouteWithMinLength()
        {
            Route route = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT * FROM Route WHERE Length = (SELECT MIN(Length) FROM Route);";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.Read())
                {
                    route = new Route
                    {
                        RouteID = reader.GetInt32("RouteID"), 
                        StartPoint = reader.GetString("StartPoint"), 
                        EndPoint = reader.GetString("EndPoint"), 
                        Stops = reader.GetInt32("Stops"), 
                        Length = reader.GetDecimal("Length"), 
                        TravelTime = reader.GetInt32("TravelTime")
                    };
                }
            }
            return route; // Повернути маршрут
        }

        // RouteRegister Methods

        public List<RouteRegister> GetRouteRegisters()
        {
            List<RouteRegister> routeRegisters = new List<RouteRegister>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити з'єднання
                string query = "SELECT * FROM RouteRegister;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Створити команду
                MySqlDataReader reader = cmd.ExecuteReader(); // Виконати читання
                while (reader.Read())
                {
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
            return routeRegisters; 
        }

        public int GetTotalTrips()
        {
            int totalTrips = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT COUNT(*) FROM RouteRegister;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                totalTrips = Convert.ToInt32(cmd.ExecuteScalar()); 
            }
            return totalTrips; // Повернути загальну кількість поїздок
        }

        public TimeSpan GetEarliestDepartureTime()
        {
            TimeSpan earliestTime = TimeSpan.Zero;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT MIN(DepartureTime) FROM RouteRegister;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                var result = cmd.ExecuteScalar(); 
                if (result != DBNull.Value)
                    earliestTime = (TimeSpan)result; 
            }
            return earliestTime; // Повернути найраніший час відправлення
        }

        public TimeSpan GetLatestArrivalTime()
        {
            TimeSpan latestTime = TimeSpan.Zero;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT MAX(ArrivalTime) FROM RouteRegister;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                var result = cmd.ExecuteScalar(); 
                if (result != DBNull.Value)
                    latestTime = (TimeSpan)result; // Обробка результату
            }
            return latestTime; // Повернути найпізніший час прибуття
        }
    }
}
