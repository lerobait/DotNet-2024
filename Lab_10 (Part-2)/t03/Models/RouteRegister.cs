// Models/RouteRegister.cs
using System;
using Task_3.Models;

namespace Task_3.Models
{
    public class RouteRegister
    {
        public int RouteRegisterID { get; set; }
        public int TransportID { get; set; }
        public int RouteID { get; set; }
        public string Direction { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }

        // Для зв'язку з Transport та Route
        public Transport Transport { get; set; }
        public Route Route { get; set; }

        // Метод для формуляру
        public string ToForm()
        {
            return $"ID: {RouteRegisterID}\n" +
                   $"Транспорт: {Transport.Type}\n" +
                   $"Маршрут: {Route.StartPoint} - {Route.EndPoint}\n" +
                   $"Напрямок: {Direction}\n" +
                   $"Відправлення: {DepartureTime}\n" +
                   $"Прибуття: {ArrivalTime}";
        }
    }
}
