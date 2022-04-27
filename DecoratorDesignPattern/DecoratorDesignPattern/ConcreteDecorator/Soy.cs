using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.ConcreteDecorator;

// Decorators can execute their behavior either before or after the call to
// a wrapped object.
public class Soy : BeverageDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
    }

    public override double Cost() => _beverage.Cost() + 500;
}
