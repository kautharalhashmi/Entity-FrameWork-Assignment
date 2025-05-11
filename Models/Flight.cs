namespace ApplicationAssigment.Models{
public class Flight
{
    public int FlightID { get; set; }
    public int AirlineID { get; set; }
    public string DepartureCity { get; set; }
    public string DestinationCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string FlightStatus { get; set; }
    public int GateID { get; set; }
    public Airline Airline { get; set; }
    public Gate Gate { get; set; }
    public List<Passenger> Passengers { get; set; } = new List<Passenger>();

    
}
}