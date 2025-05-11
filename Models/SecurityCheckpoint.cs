namespace ApplicationAssigment.Models{
    public class SecurityCheckpoint
{
    public int CheckpointID { get; set; }
    public int TerminalID { get; set; }
    public string TerminalName { get; set; }
    public int PassengerCapacity { get; set; }
    public string Location { get; set; }

    public Terminal Terminal { get; set; }
}
}