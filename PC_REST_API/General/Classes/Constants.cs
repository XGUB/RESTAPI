namespace PC_REST_API.General.Classes;

/// <summary>
/// Constants
/// </summary>
public class Constants
{
    /// <summary>
    /// Includes exception responses
    /// </summary>
    public class ExceptionResponses
    {
        public const string characteristicNotFound = "Characteristic was not found";

        public const string characteristicAlreadyExists = "Characteristic already exists";

        public const string characteristicNotModify = "Characteristic can't be modified because it doesn't exist";

        public const string characteristicNotDelete = "Characteristic can't be deleted because it doesn't exist";

        public const string characteristicDelete = "Characteristic successfully deleted";
    }

    /// <summary>
    /// Includes constants of table names
    /// </summary>
    public class TableNames
    {
        public const string characteristics = "Characteristics";
    }
}
