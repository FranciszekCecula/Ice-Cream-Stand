using System;
namespace Ice_Cream_Shop{
public class FruityIceCream : IceCream
{
    public bool inCone {get; private set;}
    public string frosting {get; private set;}

    public FruityIceCream (int price, string flavour, bool inCone, string frosting) : base (price, flavour)
    {
        this.inCone = inCone;
        this.frosting = frosting;
    }

    public override string ToString()
    {
        string coneText = inCone ? "In cone" : "In cup";
        string frostingText = string.IsNullOrEmpty(frosting) ? "without frosting" : $"with {frosting} frosting";
        return base.ToString() + $" delicious Fruity Ice Cream {coneText}, {frostingText}";
    }
}
}