namespace OmniCore.Domain.Entities.Enums;
/// <summary>
/// Indicates the urgency it gets for resolution
/// </summary>
public enum TicketPriority
{
    /// <summary>
    /// A system-wide outage stops all business operations and has no workaround. Target resolution: 1 to 2 hours
    /// </summary>
    P1Critical = 1,
    P2High,
    P3Medium,
    P4Low,
    P5Planning
}
