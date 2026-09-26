namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Class that represents the current state of the service - Active, Suspended, Terminated etc
/// </summary>
public class CircuitState
{
        public Guid CircuitStateId { get; set; }
        public string? Name { get; set; } 
}
