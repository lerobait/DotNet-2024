// Models/Transport.cs
namespace Task_3.Models
{
    public class Transport
    {
        public int TransportID { get; set; }
        public string Type { get; set; }
        public decimal Fare { get; set; }
        public int Units { get; set; }
        public decimal Profitability { get; set; }

        // Метод для формуляру
        public string ToForm()
        {
            return $"ID: {TransportID}\n" +
                   $"Тип: {Type}\n" +
                   $"Вартість: {Fare}\n" +
                   $"Одиниці: {Units}\n" +
                   $"Рентабельність: {Profitability}";
        }
    }
}
