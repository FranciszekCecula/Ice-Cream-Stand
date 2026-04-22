using System;
namespace Ice_Cream_Shop{

public class IceCreamFactory
{
    private int current_mode =1;

    public void SetMode(int mode)
    {
        if (mode >= 1 && mode <= 7)
        {
            current_mode = mode;
        }
        else
        {
            Console.WriteLine("Invalid mode. Please select a mode between 1 and 7.");
            current_mode = 1;
        }
    }
    public IceCream TodaySpecial()
    {
        switch (current_mode)
        {
            case 1:
                return new WaterIceCream(10,"Strawberry");
            case 2:
                return new MilkIceCream(20,"Vanilla",true, "Chocolate", true);
            case 3:
                return new ItalianIceCream(15, "Vanilla", true, false);
            case 4:
                return new WaterIceCream(12, "Lemon");
            case 5: 
                return new FruityIceCream(18, "Mango", true, "Carmel");
            case 6:
                return new MilkIceCream(13, "Vanilla-Chocolate", false, "Strawberry", false);
            case 7:
                return new ItalianIceCream(17, "Pistachio", false, true);
            default:
                return new WaterIceCream(10, "Strawberry");
        }
    }
}
}