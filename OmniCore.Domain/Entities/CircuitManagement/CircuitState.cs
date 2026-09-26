namespace OmniCore.Domain.Entities.CircuitManagement;
/// <summary>
/// Class that represents the current state of the service - Active, Suspended, Terminated etc
/// </summary>
public class CircuitState
{
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    
}
