using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Product_Catalog
{
    class Product
    {
        private int productId;
        private string name;
        private double price;
        private int stock;
        protected string category;

        public Product(int id, string name, double price, int stock)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public void AddStock(int qty)
        {
            stock += qty;
        }

        public void ReduceStock(int qty)
        {
            if (stock >= qty)
                stock -= qty;
            else
                Console.WriteLine("Insufficient stock");
        }

        public void DisplayProduct()
        {
            Console.WriteLine(productId + " " + name + " " + price + " " + stock + " " + category);
        }

        public string GetCategory()
        {
            return category;
        }

        public double GetPrice()
        {
            return price;
        }
    }
    class Electronics : Product
    {
        private string brand;
        private int warranty;

        public Electronics(int id, string name, double price, int stock,
                           string brand, int warranty)
            : base(id, name, price, stock)
        {
            this.brand = brand;
            this.warranty = warranty;
            category = "Electronics";
        }
    }
    class Clothing : Product
    {
        private string size;
        private string material;

        public Clothing(int id, string name, double price, int stock,
                        string size, string material)
            : base(id, name, price, stock)
        {
            this.size = size;
            this.material = material;
            category = "Clothing";
        }
    }
    class Books : Product
    {
        private string author;
        private string isbn;

        public Books(int id, string name, double price, int stock,
                     string author, string isbn)
            : base(id, name, price, stock)
        {
            this.author = author;
            this.isbn = isbn;
            category = "Books";
        }
    }
    class Cart
    {
        private List<Product> items = new List<Product>();

        public void AddProduct(Product p)
        {
            items.Add(p);
        }

        public void ViewCart()
        {
            foreach (Product p in items)
                p.DisplayProduct();
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Product p in items)
                total += p.GetPrice();
            return total;
        }
    }
    class Customer
    {
        private int customerId;
        private string name;
        public Cart cart = new Cart();

        public Customer(int id, string name)
        {
            this.customerId = id;
            this.name = name;
        }
    }
    class Order
    {
        public void PlaceOrder(Customer c)
        {
            Console.WriteLine("Order placed successfully");
            Console.WriteLine("Total Amount: " + c.cart.CalculateTotal());
        }
    }

}
