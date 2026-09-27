namespace OmniCore.Domain.Enums;

/// <summary>
/// Enumerated list that represents the current status of the service:
/// Up, Slow, Down, Degraded etc
/// </summary>
public enum LinkStatus
{
    Up=1,
    Down,
    Slow,
    Degraded,
    /// <summary>
    /// The maximum usable bandwidth is far below the subscribed bandwidth
    /// </summary>
    BandwidthShortfall,
    Unstable
}
