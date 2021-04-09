using System;

namespace Unit_03_Constructor
{
   class Program
   {
     public int count;
     public int money;
     public string name;

     public Program(int count, int money)
     {
       this.count = count;
       this.money = money;
     }

     public Program(int count, int money, string name)
     :this(count, money)
     {
       this.name = name;
     }
   } 

  class Demo {
    public static void Main(string[] args) {
      Program p = new Program(16,4500,"John Doe");
      Console.WriteLine("Money : {0}",p.money);
      Console.WriteLine("Count : {0}",p.count);
      Console.WriteLine("Name : {0}",p.name);
    }
  }
}
