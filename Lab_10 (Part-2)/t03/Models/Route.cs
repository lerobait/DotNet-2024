// Models/Route.cs
namespace Task_3.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int Stops { get; set; }
        public decimal Length { get; set; }
        public int TravelTime { get; set; }

        // Метод для формуляру
        public string ToForm()
        {
            return $"ID: {RouteID}\n" +
                   $"Початковий пункт: {StartPoint}\n" +
                   $"Кінцевий пункт: {EndPoint}\n" +
                   $"Зупинки: {Stops}\n" +
                   $"Довжина: {Length}\n" +
                   $"Час у дорозі: {TravelTime}";
        }
    }
}
