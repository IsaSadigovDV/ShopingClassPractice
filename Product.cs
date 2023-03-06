
    internal class Product
    {
    private string _name;
    private double _price;
        public string Name { get => _name; set
        {
            if (value.Length > 0 && value.Length < 30 && !string.IsNullOrWhiteSpace(value))
            {   
                _name = value;
            }
            else
            {
                Console.WriteLine("Plese enter product name correctly");
            }
                
        }
        }
        public double Price
    {
        get => _price; set
        {
            if (value > 0)
            {
                _price = value;

            }
            else
            {
                Console.WriteLine("Price can not less than zero! Please enter correctly");
            };
        }
    }


    }

