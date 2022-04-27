using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.ConcreteDecorator;

// Concrete Decorators call the wrapped object and alter its result in some
// way.
public class Milk : BeverageDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }

    // Decorators may call parent implementation of the operation, instead
    // of calling the wrapped object directly. This approach simplifies
    // extension of decorator classes.
    public override double Cost() => _beverage.Cost() + 2500;
}
