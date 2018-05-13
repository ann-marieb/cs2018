using System;

namespace Assignment5
{
    /// <summary>
    /// event information
    /// </summary>
    public class FlightEventsArgs
    {
        public string FlightNumber { get; set; }
        public string FlightAction { get; set; }
        public DateTime DateTime { get; set; }
    }
}