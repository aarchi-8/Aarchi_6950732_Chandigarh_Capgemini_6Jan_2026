namespace E_Commerce_Product_Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Electronics(1, "Laptop", 60000, 10, "HP", 2));
            products.Add(new Clothing(2, "T-Shirt", 1200, 25, "M", "Cotton"));
            products.Add(new Books(3, "C# Programming", 450, 15, "Herbert Schildt", "ISBN123"));

            Console.WriteLine("ALL PRODUCTS");
            foreach (Product p in products)
                p.DisplayProduct();

            Console.WriteLine("\nFILTER BY CATEGORY: Electronics");
            foreach (Product p in products)
            {
                if (p.GetCategory() == "Electronics")
                    p.DisplayProduct();
            }

            // Customer & cart
            Customer customer = new Customer(101, "Aarchi");
            customer.cart.AddProduct(products[0]);
            customer.cart.AddProduct(products[2]);

            Console.WriteLine("\nCART ITEMS");
            customer.cart.ViewCart();

            // Place order
            Order order = new Order();
            order.PlaceOrder(customer);
        }
    }
}
