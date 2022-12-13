namespace PC_REST_API.Models
{
    public class CharacteristicsModel
    {
        //Create the Model folder and a Models class
        //Create attributes that were created in DB Table, but this time use private modifier
        //Also delete the get-set part of the code in each attribute

        private int _id;

        private string _brand;

        private int _price;

        private string _cpu;

        public int id { get => _id; set { _id = value; } }

        public string brand { get => _brand; set { _brand = value; } }

        public int price { get => _price; set { _price = value; } }

        public string cpu { get => _cpu; set { _cpu = value; } }

        //Constructor
        public CharacteristicsModel(int id, string brand, int price, string cpu)
        {
            _id = id;
            _brand = brand;
            _price = price;
            _cpu = cpu;
           
        }
    }
}
