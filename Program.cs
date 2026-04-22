using System;
namespace Ice_Cream_Shop{
class Program
{
    static void Main(string[] args)
    {
        IceCreamFactory myFactory = new IceCreamFactory();
        Salesman MrDough = new Salesman (myFactory);
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        for (int i=0; i<7; i++)
        {
            Console.WriteLine($"==={days[i].ToUpper()}===");
            myFactory.SetMode(i+1);
            MrDough.ProposeSpecial();
            MrDough.ProposeSpecial();
            MrDough.ProposeSpecial();
            MrDough.ProposeSpecial();
            MrDough.ProposeSpecial();
        }
        Console.ReadLine();
    }
}
}
