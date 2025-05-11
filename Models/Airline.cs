namespace ApplicationAssigment.Models{
public class Airline
{
    public int AirlineID { get; set; }
    public string Name { get; set; }
    public string ContactNumber { get; set; }
    public string ContactEmail { get; set; }
    public string RepresentativeName { get; set; }

    public List<Flight> Flights { get; set; } = new List<Flight>();
    public List<Gate> Gates { get; set; } = new List<Gate>();
}
}














