using System;

namespace Task_5.Models
{
    public class RouteRegister
    {
        public int RouteRegisterID { get; set; }
        public int TransportID { get; set; }
        public int RouteID { get; set; }
        public string Direction { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
    }
}
