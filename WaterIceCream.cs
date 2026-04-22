using System;
namespace Ice_Cream_Shop{
    
public class WaterIceCream : IceCream
{
    public WaterIceCream(int price, string flavour) : base(price, flavour)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " crisp and refreshing Water Ice Cream";
    }
}
}