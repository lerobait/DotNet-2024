using System; 
using System.Collections.Generic; 
using MySql.Data.MySqlClient; 
using Task_6.Models;

namespace Task_6
{
    public class Database
    {
        // Підключення
        private string connectionString = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;database=CityTransportDB;";

        // Методи Transport
        public List<Transport> GetTransports()
        {
            // Список транспорту
            List<Transport> transports = new List<Transport>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит SQL
                string query = "SELECT * FROM Transport;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Команда
                MySqlDataReader reader = cmd.ExecuteReader(); 

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
                    transports.Add(transport); 
                }
            }
            return transports;
        }

        public void AddTransport(Transport transport)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит вставки
                string query =
                    "INSERT INTO Transport (Type, Fare, Units, Profitability) " +
                    "VALUES (@Type, @Fare, @Units, @Profitability);";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@Type", transport.Type);
                cmd.Parameters.AddWithValue("@Fare", transport.Fare); 
                cmd.Parameters.AddWithValue("@Units", transport.Units); 
                cmd.Parameters.AddWithValue("@Profitability", transport.Profitability); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void UpdateTransport(Transport transport)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит оновлення
                string query =
                    "UPDATE Transport " +
                    "SET Type = @Type, Fare = @Fare, Units = @Units, Profitability = @Profitability " +
                    "WHERE TransportID = @TransportID;";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@TransportID", transport.TransportID); 
                cmd.Parameters.AddWithValue("@Type", transport.Type); 
                cmd.Parameters.AddWithValue("@Fare", transport.Fare);
                cmd.Parameters.AddWithValue("@Units", transport.Units); 
                cmd.Parameters.AddWithValue("@Profitability", transport.Profitability); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void DeleteTransport(int transportID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит видалення
                string query = "DELETE FROM Transport WHERE TransportID = @TransportID;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Команда
                cmd.Parameters.AddWithValue("@TransportID", transportID); // Параметр ID
                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        // Методи Route
        public List<Route> GetRoutes()
        {
            // Список маршрутів
            List<Route> routes = new List<Route>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит SQL
                string query = "SELECT * FROM Route;";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader();

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
                    routes.Add(route); 
                }
            }
            return routes; 
        }

        public void AddRoute(Route route)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит вставки
                string query =
                    "INSERT INTO Route (StartPoint, EndPoint, Stops, Length, TravelTime) " +
                    "VALUES (@StartPoint, @EndPoint, @Stops, @Length, @TravelTime);";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@StartPoint", route.StartPoint);
                cmd.Parameters.AddWithValue("@EndPoint", route.EndPoint); 
                cmd.Parameters.AddWithValue("@Stops", route.Stops); 
                cmd.Parameters.AddWithValue("@Length", route.Length); 
                cmd.Parameters.AddWithValue("@TravelTime", route.TravelTime); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void UpdateRoute(Route route)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                // Запит оновлення
                string query =
                    "UPDATE Route " +
                    "SET StartPoint = @StartPoint, EndPoint = @EndPoint, Stops = @Stops, " +
                    "Length = @Length, TravelTime = @TravelTime " +
                    "WHERE RouteID = @RouteID;";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@RouteID", route.RouteID); 
                cmd.Parameters.AddWithValue("@StartPoint", route.StartPoint); 
                cmd.Parameters.AddWithValue("@EndPoint", route.EndPoint); 
                cmd.Parameters.AddWithValue("@Stops", route.Stops); 
                cmd.Parameters.AddWithValue("@Length", route.Length);
                cmd.Parameters.AddWithValue("@TravelTime", route.TravelTime); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void DeleteRoute(int routeID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                // Запит видалення
                string query = "DELETE FROM Route WHERE RouteID = @RouteID;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Команда
                cmd.Parameters.AddWithValue("@RouteID", routeID); // Параметр ID
                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        // Методи RouteRegister
        public List<RouteRegister> GetRouteRegisters()
        {
            // Список реєстрів
            List<RouteRegister> routeRegisters = new List<RouteRegister>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит SQL
                string query = "SELECT * FROM RouteRegister;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Команда
                MySqlDataReader reader = cmd.ExecuteReader(); // Читання

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
                    routeRegisters.Add(routeRegister); // Додати
                }
            }
            return routeRegisters; 
        }

        public void AddRouteRegister(RouteRegister routeRegister)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 

                // Запит вставки
                string query =
                    "INSERT INTO RouteRegister (TransportID, RouteID, Direction, DepartureTime, ArrivalTime) " +
                    "VALUES (@TransportID, @RouteID, @Direction, @DepartureTime, @ArrivalTime);";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@TransportID", routeRegister.TransportID); 
                cmd.Parameters.AddWithValue("@RouteID", routeRegister.RouteID);
                cmd.Parameters.AddWithValue("@Direction", routeRegister.Direction);
                cmd.Parameters.AddWithValue("@DepartureTime", routeRegister.DepartureTime); 
                cmd.Parameters.AddWithValue("@ArrivalTime", routeRegister.ArrivalTime); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void UpdateRouteRegister(RouteRegister routeRegister)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                // Запит оновлення
                string query =
                    "UPDATE RouteRegister " +
                    "SET TransportID = @TransportID, RouteID = @RouteID, Direction = @Direction, " +
                    "DepartureTime = @DepartureTime, ArrivalTime = @ArrivalTime " +
                    "WHERE RouteRegisterID = @RouteRegisterID;";

                MySqlCommand cmd = new MySqlCommand(query, conn); 
                cmd.Parameters.AddWithValue("@RouteRegisterID", routeRegister.RouteRegisterID); 
                cmd.Parameters.AddWithValue("@TransportID", routeRegister.TransportID);
                cmd.Parameters.AddWithValue("@RouteID", routeRegister.RouteID); 
                cmd.Parameters.AddWithValue("@Direction", routeRegister.Direction); 
                cmd.Parameters.AddWithValue("@DepartureTime", routeRegister.DepartureTime);
                cmd.Parameters.AddWithValue("@ArrivalTime", routeRegister.ArrivalTime); 

                cmd.ExecuteNonQuery(); // Виконати
            }
        }

        public void DeleteRouteRegister(int routeRegisterID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); // Відкрити

                // Запит видалення
                string query = "DELETE FROM RouteRegister WHERE RouteRegisterID = @RouteRegisterID;";
                MySqlCommand cmd = new MySqlCommand(query, conn); // Команда
                cmd.Parameters.AddWithValue("@RouteRegisterID", routeRegisterID); // Параметр ID
                cmd.ExecuteNonQuery(); // Виконати
            }
        }
    }
}
