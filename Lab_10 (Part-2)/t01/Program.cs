using System;
using MySql.Data.MySqlClient;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Підключення до MySQL сервера
            string connStr = "server=localhost;user=root;password=mnc5UbTRn_nZ+M:;";

            // Створення підключення
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                // Створення бази даних
                string createDbQuery = "CREATE DATABASE IF NOT EXISTS CityTransportDB;";
                MySqlCommand cmd = new MySqlCommand(createDbQuery, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("База даних успішно створена.");

                // Використання нової бази даних
                cmd.CommandText = "USE CityTransportDB;";
                cmd.ExecuteNonQuery();

                // Створення таблиць
                string createTransportTable = @"CREATE TABLE IF NOT EXISTS Transport (
                    TransportID INT AUTO_INCREMENT PRIMARY KEY,
                    Type VARCHAR(50),
                    Fare DECIMAL(5,2),
                    Units INT,
                    Profitability DECIMAL(5,2)
                );";

                string createRouteTable = @"CREATE TABLE IF NOT EXISTS Route (
                    RouteID INT AUTO_INCREMENT PRIMARY KEY,
                    StartPoint VARCHAR(100),
                    EndPoint VARCHAR(100),
                    Stops INT,
                    Length DECIMAL(5,2),
                    TravelTime INT
                );";

                string createRouteRegisterTable = @"CREATE TABLE IF NOT EXISTS RouteRegister (
                    RouteRegisterID INT AUTO_INCREMENT PRIMARY KEY,
                    TransportID INT,
                    RouteID INT,
                    Direction VARCHAR(50),
                    DepartureTime TIME,
                    ArrivalTime TIME,
                    FOREIGN KEY (TransportID) REFERENCES Transport(TransportID),
                    FOREIGN KEY (RouteID) REFERENCES Route(RouteID)
                );";

                cmd.CommandText = createTransportTable;
                cmd.ExecuteNonQuery();

                cmd.CommandText = createRouteTable;
                cmd.ExecuteNonQuery();

                cmd.CommandText = createRouteRegisterTable;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Таблиці успішно створені.");

                // Вставка даних у таблицю Transport
                string insertTransportData = @"INSERT INTO Transport (Type, Fare, Units, Profitability) VALUES
                    ('Автобус', 1.50, 50, 10.5),
                    ('Трамвай', 1.20, 30, 8.0),
                    ('Тролейбус', 1.00, 40, 7.5),
                    ('Метро', 2.00, 100, 15.0),
                    ('Таксі', 10.00, 20, 25.0),
                    ('Маршрутка', 2.50, 25, 12.0),
                    ('Паром', 3.00, 5, 20.0),
                    ('Потяг', 5.00, 10, 18.0),
                    ('Прокат велосипедів', 0.50, 200, 5.0),
                    ('Електросамокат', 0.75, 150, 6.5),
                    ('Канатна дорога', 2.50, 3, 22.0),
                    ('Фунікулер', 2.00, 2, 15.0),
                    ('Монорельс', 2.20, 8, 13.5),
                    ('Експрес в аеропорт', 8.00, 2, 30.0),
                    ('Шатл', 1.80, 15, 9.0),
                    ('Туристичний автобус', 12.00, 4, 40.0),
                    ('Водне таксі', 7.00, 3, 28.0),
                    ('Гелікоптер', 150.00, 1, 50.0),
                    ('Сегвей', 2.00, 10, 5.5),
                    ('Кінний віз', 5.00, 2, 12.5);";

                cmd.CommandText = insertTransportData;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Дані в таблицю Transport успішно вставлені.");

                // Вставка даних у таблицю Route
                string insertRouteData = @"INSERT INTO Route (StartPoint, EndPoint, Stops, Length, TravelTime) VALUES
                    ('Центральний вокзал', 'Міський парк', 5, 10.0, 30),
                    ('Аеропорт', 'Центр міста', 8, 15.5, 45),
                    ('Порт', 'Музейний квартал', 6, 12.0, 35),
                    ('Університет', 'Старе місто', 7, 14.0, 40),
                    ('Стадіон', 'Міська рада', 4, 8.5, 25),
                    ('Зоопарк', 'Океанаріум', 9, 18.0, 50),
                    ('Передмістя', 'Промислова зона', 10, 20.0, 55),
                    ('Пляж', 'Гора', 12, 25.0, 60),
                    ('Східний район', 'Західний район', 15, 30.0, 75),
                    ('Північні ворота', 'Південні ворота', 11, 22.0, 55),
                    ('Кінотеатр', 'Бібліотека', 3, 6.0, 20),
                    ('Лікарня', 'Пожежна станція', 5, 10.0, 30),
                    ('Поліція', 'Суд', 4, 9.0, 25),
                    ('Торговий центр', 'Конференц-центр', 6, 13.0, 35),
                    ('Парк', 'Озеро', 7, 14.5, 40),
                    ('Галерея', 'Ботанічний сад', 5, 11.0, 30),
                    ('Залізничний вокзал', 'Автовокзал', 2, 4.5, 15),
                    ('Оперний театр', 'Театр', 3, 7.0, 20),
                    ('Склад', 'Логістичний центр', 8, 16.0, 45),
                    ('Пам''ятник', 'Оглядовий майданчик', 5, 10.5, 30);";

                cmd.CommandText = insertRouteData;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Дані в таблицю Route успішно вставлені.");

                // Вставка даних у таблицю RouteRegister
                string insertRouteRegisterData = @"INSERT INTO RouteRegister (TransportID, RouteID, Direction, DepartureTime, ArrivalTime) VALUES
                    (1, 1, 'Туди', '08:00:00', '08:30:00'),
                    (2, 2, 'Назад', '09:00:00', '09:45:00'),
                    (3, 3, 'Туди', '07:15:00', '07:50:00'),
                    (4, 4, 'Назад', '10:00:00', '10:40:00'),
                    (5, 5, 'Туди', '12:00:00', '12:25:00'),
                    (6, 6, 'Назад', '13:30:00', '14:20:00'),
                    (7, 7, 'Туди', '14:00:00', '14:55:00'),
                    (8, 8, 'Назад', '16:00:00', '17:00:00'),
                    (9, 9, 'Туди', '17:30:00', '18:45:00'),
                    (10, 10, 'Назад', '19:00:00', '19:55:00'),
                    (11, 11, 'Туди', '20:00:00', '20:20:00'),
                    (12, 12, 'Назад', '21:00:00', '21:30:00'),
                    (13, 13, 'Туди', '06:00:00', '06:25:00'),
                    (14, 14, 'Назад', '07:30:00', '08:05:00'),
                    (15, 15, 'Туди', '09:30:00', '10:10:00'),
                    (16, 16, 'Назад', '11:00:00', '11:30:00'),
                    (17, 17, 'Туди', '12:30:00', '12:45:00'),
                    (18, 18, 'Назад', '13:00:00', '13:20:00'),
                    (19, 19, 'Туди', '15:00:00', '15:45:00'),
                    (20, 20, 'Назад', '16:30:00', '17:00:00');";

                cmd.CommandText = insertRouteRegisterData;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Дані в таблицю RouteRegister успішно вставлені.");

                // Виведення даних з таблиць

                // Виведення таблиці Transport
                cmd.CommandText = "SELECT * FROM Transport;";
                MySqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\nТаблиця Transport:");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"ID: {reader["TransportID"]}, " +
                        $"Тип: {reader["Type"]}, " +
                        $"Вартість: {reader["Fare"]}, " +
                        $"Одиниці: {reader["Units"]}, " +
                        $"Рентабельність: {reader["Profitability"]}"
                    );
                }
                reader.Close();

                // Виведення таблиці Route
                cmd.CommandText = "SELECT * FROM Route;";
                reader = cmd.ExecuteReader();

                Console.WriteLine("\nТаблиця Route:");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"ID: {reader["RouteID"]}, " +
                        $"Початок: {reader["StartPoint"]}, " +
                        $"Кінець: {reader["EndPoint"]}, " +
                        $"Зупинки: {reader["Stops"]}, " +
                        $"Довжина: {reader["Length"]}, " +
                        $"Час у дорозі: {reader["TravelTime"]}"
                    );
                }
                reader.Close();

                // Виведення таблиці RouteRegister
                cmd.CommandText = @"SELECT rr.RouteRegisterID, t.Type, r.StartPoint, r.EndPoint, rr.Direction, rr.DepartureTime, rr.ArrivalTime
                                    FROM RouteRegister rr
                                    JOIN Transport t ON rr.TransportID = t.TransportID
                                    JOIN Route r ON rr.RouteID = r.RouteID;";

                reader = cmd.ExecuteReader();

                Console.WriteLine("\nТаблиця RouteRegister:");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"ID: {reader["RouteRegisterID"]}, " +
                        $"Транспорт: {reader["Type"]}, " +
                        $"Маршрут: {reader["StartPoint"]} - {reader["EndPoint"]}, " +
                        $"Напрямок: {reader["Direction"]}, " +
                        $"Відправлення: {reader["DepartureTime"]}, " +
                        $"Прибуття: {reader["ArrivalTime"]}"
                    );
                }
                reader.Close();

                conn.Close();
                Console.WriteLine("\nВсі дані успішно виведені.");
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
    }
}
