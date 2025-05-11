namespace ApplicationAssigment.Models{
    public class Baggage
{
    public int BaggageID { get; set; }
    public int PassengerID { get; set; }
    public float Weight { get; set; }
    public string TrackingNumber { get; set; }

    public Passenger Passenger { get; set; }
}
}