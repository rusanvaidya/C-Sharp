using System;

namespace Unit_04_Inheritance
{
    class Food
    {
        public int money, quantity;
        public string product;
        public void set(int money, string product, int qty)
        {
            this.money = money;
            this.product = product;
            quantity = qty;
        }

        protected void set_fruit(int m, string p, int q)
        {
            money = m;
            product = p;
            quantity = q;
        }
    }

    class Vegetables: Food
    {   
        public void display()
        {   
            Console.WriteLine("Your amount for {0} is : ", product);
            Console.WriteLine(money*quantity);
        }

    }

    class Fruits: Food
    {      
        public void display()
        {   
            set_fruit(10, "Strawberry", 4);
            Console.WriteLine("Your amount for {0} is : ", product);
            Console.WriteLine(money*quantity);
        }

    }


    class Demo
    {
        static void Main(string[] args)
        {
            Vegetables v = new Vegetables();
            v.set(50, "Potato", 4);
            v.display();

            Fruits f = new Fruits();
            f.display();
        }
    }
}
