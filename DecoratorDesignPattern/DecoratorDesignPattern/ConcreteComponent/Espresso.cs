using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteComponent;

public class Espresso : Beverage
{
    public override double Cost() => 100;
}

