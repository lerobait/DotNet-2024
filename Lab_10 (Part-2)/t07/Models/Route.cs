namespace Task_7.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int Stops { get; set; }
        public decimal Length { get; set; }
        public int TravelTime { get; set; }
    }
}
