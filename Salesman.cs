using System;
namespace Ice_Cream_Shop{

public class Salesman
{
    private IceCreamFactory factory;
    public Salesman(IceCreamFactory factory)
    {
        this.factory = factory;
    }

    public void ProposeSpecial()
    {
        IceCream special = factory.TodaySpecial();
        Console.WriteLine($"Today's special is:");
        Console.WriteLine(special.ToString());
        Console.WriteLine("Highly recommended!");
    }

}
}