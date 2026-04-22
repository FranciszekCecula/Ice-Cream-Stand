using System;
namespace Ice_Cream_Shop{

public class MilkIceCream : IceCream
{
    public bool cone {get; private set;}
    public string frosting {get; private set;}
    public bool chocolate_sprinkles {get; private set;}

    public MilkIceCream(int price, string flavour, bool cone, string frosting, bool chocolate_sprinkles) : base (price, flavour)
    {
        this.cone = cone;
        this.frosting = frosting;
        this.chocolate_sprinkles = chocolate_sprinkles;
    }

    public override string ToString()
    {
        string coneText = cone ? "In cone" : "In cup";
        string sprinklesText = chocolate_sprinkles ? "and with chocolate sprinkles" : "";
        string frostingText = string.IsNullOrEmpty(frosting) ? "without frosting" : $"with {frosting} frosting";
        return base.ToString() + $" creamy Milk Ice Cream {coneText}, {frostingText} {sprinklesText}";
    } 
}
}
