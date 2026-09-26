using OmniCore.Domain.Entities.Geography;

namespace OmniCore.Domain.Entities.InfrastructureManagement;

/// <summary>
/// No database table required, so, no Id property
/// </summary>
public class BTSAddress
{
    private string? _coordinates;

    public string? LocationAddress { get; set; }
    public State? State { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Coordinates
    {
        get { return _coordinates; }
        set { _coordinates = CalculateCoord(); }
    }

    private string? CalculateCoord()
    {

        string latitudeCoord, longitudeCoord;
        if (Latitude.HasValue && Longitude.HasValue)
        {
            int degrees;
            double minutes, seconds;

            // set decimal_degrees value here
            if (Latitude.Value.ToString().IndexOf('.') != -1)
            {
                degrees = Convert.ToInt32(Latitude.Value.ToString().Split(".")[0]);
                minutes = (Latitude.Value - degrees) * 60;
                seconds = (minutes - Math.Floor(minutes)) * 60.0;

                // get rid of fractional part
                minutes = Math.Floor(minutes);
                seconds = Math.Round(seconds, 2);
                latitudeCoord = $"{degrees}\u00b0{minutes}'{seconds}\"N";
            }
            else
            {
                latitudeCoord = $"{Latitude.Value}\u00b00'0\"N";
            }

            if (Longitude.Value.ToString().IndexOf('.') != -1)
            {
                degrees = Convert.ToInt32(Longitude.Value.ToString().Split(".")[0]);
                minutes = (Longitude.Value - degrees) * 60;
                seconds = (minutes - Math.Floor(minutes)) * 60.0;

                // get rid of fractional part
                minutes = Math.Floor(minutes);
                seconds = Math.Round(seconds, 2);
                longitudeCoord = $"{degrees}\u00b0{minutes}'{seconds}\"E";
            }
            else
            {
                longitudeCoord = $"{Latitude.Value}\u00b00'0\"E";
            }

            return $"{latitudeCoord} {longitudeCoord}";

        }
        else
        {
            return null;
        }
    }
}
