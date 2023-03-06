
    internal class Shop
    {
        private string _name;

        public Product[] products;
        public Shop()  
        {
            products= new Product[0];
        }
        
        
        public void CreateProduct()
        {
            Console.Write("Product name:");
            string name = Console.ReadLine();

            Console.Write("Product price:");
            int price = int.Parse(Console.ReadLine());

        Product product1= new Product();
        product1.Name = name;
        product1.Price = price;
        Array.Resize(ref products, products.Length + 1);
        products[products.Length-1] = product1;
            
        }

        public void ShowProduct()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Product name:{item.Name}, Product price {item.Price}");
            }
        }
    }

