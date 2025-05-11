namespace ApplicationAssigment.Models{
    public class Gate
{
    public int GateID { get; set; }
    public int TerminalID { get; set; }
    public int AirlineID { get; set; }
    public string GateNumber { get; set; }
    public string AvailabilityStatus { get; set; }

    public Terminal Terminal { get; set; }
    public Airline Airline { get; set; }
    public List<Flight> Flights { get; set; } = new List<Flight>();
}
}