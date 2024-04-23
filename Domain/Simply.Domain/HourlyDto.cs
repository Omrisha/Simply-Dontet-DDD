namespace Simply.DomainModel;

/// <summary>
/// Hourly data transfer object.
/// </summary>
public class HourlyDto
{
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public DateTime[] Time { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public double[] Temperature { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public int[] RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    public double[] WindSpeed { get; set; }
}