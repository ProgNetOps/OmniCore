

namespace OmniCore.Domain.Entities;
/// <summary>
/// Class that represents the Base Station
/// </summary>
public class BTS
{
   
    public Guid BTSId { get; set; }
    public string? BTSName { get; set; }
    public BTSAddress? Address { get; set; }
}
