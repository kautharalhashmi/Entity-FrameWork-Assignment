namespace ApplicationAssigment.Models{
    public class Terminal
{
    public int TerminalID { get; set; }
    public string TerminalName { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }

    public List<Gate> Gates { get; set; } = new List<Gate>();
    public List<SecurityCheckpoint> Checkpoints { get; set; } = new List<SecurityCheckpoint>();
}
}