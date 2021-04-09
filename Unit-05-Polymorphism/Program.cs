/* Here the method or the fields that is to be override is 
written with virtual to its parent class method and override 
on the child class method. */
using System;

namespace Unit_05_Polymorphism
{
    class Product
    {
        private string _name;
        private double _purchasePrice;
        
        // Parameterized Constructor
        public Product(string name, double purchasePrice)
        {
            this._name = name;
            this._purchasePrice = purchasePrice;
        }

        // Getters
        public string GetName()
        {
            return this._name;
        }

        public double GetPurchasePrice()
        {
            return this._purchasePrice;
        }
        // Method to calculate selling price
        public virtual double GetPrice() //method that is to be override
        {
            return 0;
        }
        // Method to print details
        public virtual void PrintDetails()
        {
            Console.WriteLine("Selected Product's Name: " + this.GetName());
        }

    }


    class Beverage : Product
    {

        
        private double _refCost;
        private double _profit;

        // Parameterized Constructor
        public Beverage(string name, double price)
            : base(name,price)
        {
            this._refCost = GetPurchasePrice() * 0.10; // 10% of purchase price
            this._profit = GetPurchasePrice() * 0.15; // 15% of purchase price
        }

        // public method to get selling price
        public override double GetPrice() //method that is overriden
        {   //calculating selling price, Math.Round is just an inbuilt method to round off the price
            return (GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit));
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Selling price: {0}", this.GetPrice());
        }

    }


    class Chocolate : Product
    {

        private double _profit;

        // Parameterized Constructor
        public Chocolate(string name, double price)
            : base(name, price)
        {
            this._profit = base.GetPurchasePrice() * 0.20; // 20% of purchase price
        }

        

        // public method to get selling price
        public override double GetPrice()
        {   //calculating selling price, Math.Round is just an inbuilt method to round off the price
            return (base.GetPurchasePrice() + (int)Math.Round(this._profit));
        }


        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Selling price: {0}", this.GetPrice());
        }
    }


    class Demo
    {
        public static void Main(string[] args)
        {
            // Placing the products in an array
            Product[] products = new Product[4];
            products [0] = new Beverage("Cola", 9);
            products [1] = new Chocolate("Crunch", 15);
            products [2] = new Chocolate("Kit-kat", 20);
            products [3] = new Beverage("Fanta", 8);

            // name and price of respective  product is displayed
            foreach(Product product in products)
            product.PrintDetails();
        }
    }
}
