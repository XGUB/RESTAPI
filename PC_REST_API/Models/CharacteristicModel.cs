namespace PC_REST_API.Models;

/// <summary>
/// PC Characteristic Model
/// </summary>
public class CharacteristicModel
{
    /// <summary>
    /// PC's ID
    /// </summary>
    private int _id;

    /// <summary>
    /// PC's Brand
    /// </summary>
    private string _brand;

    /// <summary>
    /// PC's Price
    /// </summary>
    private int _price;

    /// <summary>
    /// CPU Type
    /// </summary>
    private string _cpu;

    /// <summary>
    /// PC's ID
    /// </summary>
    public int Id { get => _id; set => _id = value; }

    /// <summary>
    /// PC's Brand
    /// </summary>
    public string Brand { get => _brand; set => _brand = value; }

    /// <summary>
    /// PC's Price
    /// </summary>
    public int Price { get => _price; set => _price = value; }

    /// <summary>
    /// CPU Type
    /// </summary>
    public string Cpu { get => _cpu; set => _cpu = value; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CharacteristicModel() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="Id"></param>
    public CharacteristicModel(int Id) => _id = Id;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="Id">PC's ID</param>
    /// <param name="Brand">Brand name</param>
    /// <param name="Price">PC's price</param>
    /// <param name="Cpu">CPU type</param>
    public CharacteristicModel(int Id, string Brand, int Price, string Cpu)
    {
        _id = Id;
        _brand = Brand;
        _price = Price;
        _cpu = Cpu;

    }
}
