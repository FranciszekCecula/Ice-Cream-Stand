using System;
namespace Ice_Cream_Shop{
public abstract class IceCream
{
    public int price {get; protected set;}
    public string flavour {get; protected set;}

    public IceCream(int price, string flavour)
    {
        this.price = price;
        this.flavour = flavour;
    }

    public override string ToString()
    {
        return $"Ice cream with {flavour} flavour (Price: {price})";
    }
}
}