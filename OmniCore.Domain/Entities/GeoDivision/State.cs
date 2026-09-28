namespace OmniCore.Domain.Entities.GeoDivision;
/// <summary>
/// Class that represents the State of the Federation
/// </summary>
public class State
{
    public Guid StateId { get; set; }
    public string? StateName { get; set; }
    public Guid ZoneId { get; set; }
    public Zone? Zone { get; set; }
}
