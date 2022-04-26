public abstract class Beverage
{
    public int Milk;
    public int Whip;
    public int Choc;

    public double ToppingsCost()
    {
        double result = 0;
        if (Milk > 0) result += Milk * 15;
        if (Whip > 0) result += Whip * 20;
        if (Choc > 0) result += Choc * 25;
        return result;
    }

    public double FullCost() => Cost() + ToppingsCost();

    public abstract double Cost();
}

class Espresso : Beverage
{
    public override double Cost() => 150;
}

class DarkRoast : Beverage
{
    public override double Cost() => 100;
}

class Decaf : Beverage
{
    public override double Cost() => 100;
}

