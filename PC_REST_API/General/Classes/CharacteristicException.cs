namespace PC_REST_API.General.Classes;

/// <summary>
/// Characteristic Exception
/// </summary>
public class CharacteristicException : Exception
{
    /// <summary>
    /// Message Id
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CharacteristicException() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="message"></param>
    public CharacteristicException(string message)
        : base(message) => Message = message;
}
