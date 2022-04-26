using DecoratorDesignPattern.DecoratorPattern.Component;
using DecoratorDesignPattern.DecoratorPattern.Decorator;

namespace DecoratorDesignPattern.DecoratorPattern.ConcreteDecorator;

// Decorators can execute their behavior either before or after the call to
// a wrapped object.
public class Soy : BeverageDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
    }

    public override double Cost() => _beverage.Cost() + 500;
}
