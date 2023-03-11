namespace Simply.Core;

/// <summary>
/// Server error exception.
/// </summary>
public class ServerErrorException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerErrorException"/> class. 
    /// </summary>
    /// <param name="message">An error message.</param>
    public ServerErrorException(string message)
		: base($"Domain server error: {message}")
	{
	}
}

