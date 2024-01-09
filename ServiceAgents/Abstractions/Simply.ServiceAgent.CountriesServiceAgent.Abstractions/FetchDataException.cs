namespace Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

using System;

/// <summary>
/// Fetch data exception.
/// </summary>
public class FetchDataException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FetchDataException"/> class.
    /// </summary>
    /// <param name="message">A message</param>
    public FetchDataException(string message) 
        : base($"{message}")
    {
        
    }
}
