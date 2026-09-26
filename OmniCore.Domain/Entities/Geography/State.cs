namespace OmniCore.Domain.Entities.Geography;
/// <summary>
/// Class that represents the State of the Federation
/// </summary>
public class State
{
    public int StateId { get; set; }
    public string? StateName { get; set; } = string.Empty;
    public int ZoneId { get; set; }
    public Zone? Zone { get; set; }
}
