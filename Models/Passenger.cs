namespace ApplicationAssigment.Models{
    public class Passenger
{
    public int PassengerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Nationality { get; set; }
    public string PassportNumber { get; set; }
    public string ContactPhone { get; set; }
    public string ContactEmail { get; set; }
    public int FlightID { get; set; }

    public Flight Flight { get; set; }
    public List<Baggage> BaggageItems { get; set; } = new List<Baggage>();
}
}