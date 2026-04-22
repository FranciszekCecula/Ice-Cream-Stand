using System;
namespace Ice_Cream_Shop{

public class ItalianIceCream : IceCream
{
    public bool inCone {get; private set;}
    public bool chocolate_sprinkles {get; private set;}

    public ItalianIceCream(int price, string flavour, bool inCone, bool chocolate_sprinkles) : base(price, flavour)
    {
        this.inCone = inCone;
        this.chocolate_sprinkles = chocolate_sprinkles;
    }

    public override string ToString()
    {
        string coneText = inCone ? "In cone" : "In cup";
        string sprinklesText = chocolate_sprinkles ? "and with chocolate sprinkles" : "";
        return base.ToString() + $" rich and creamy Italian Ice Cream {coneText} {sprinklesText}";
    }
}
}