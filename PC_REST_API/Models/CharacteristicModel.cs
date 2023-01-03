namespace PC_REST_API.Models
{
    /// <summary>
    /// PC Characteristic Model
    /// </summary>
    public class CharacteristicModel
    {


        /// <summary>
        /// PC's ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// PC's Brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// PC's Price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// CPU Type
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CharacteristicModel() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Id"></param>
        public CharacteristicModel(int Id)
        {
            this.Id = Id;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Id">PC's ID</param>
        /// <param name="Brand">Brand name</param>
        /// <param name="Price">PC's price</param>
        /// <param name="Cpu">CPU type</param>
        public CharacteristicModel(int Id, string Brand, int Price, string Cpu)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Price = Price;
            this.Cpu = Cpu;

        }


    }
}
