using DecoratorDesignPattern.DecoratorPattern.Component;

namespace DecoratorDesignPattern.DecoratorPattern.ConcreteComponent;

public class Espresso : Beverage
{
    public override double Cost() => 100;
}

