namespace OmniCore.Domain.Entities.Enums;
/// <summary>
/// The current status of the ticket; used to communicate the progress on resolutions of escalated issues to customer 
/// </summary>
public enum TicketStatus
{
    /// <summary>
    /// The ticket is logged and waiting for an agent to review or assign it
    /// </summary>
    New = 1,
    /// <summary>
    /// The support team has acknowledged the request and started looking into it
    /// </summary>
    Open,
    /// <summary>
    /// An agent or engineer is actively working on a fix or investigation
    /// </summary>
    InProgress,
    /// <summary>
    /// The team is waiting for more details
    /// </summary>
    Pending,
    /// <summary>
    /// A solution has been provided, but the ticket can still be reopened if the issue persists
    /// </summary>
    Resolved,
    /// <summary>
    /// The request is fully finished and finalized
    /// </summary>
    Closed
}
