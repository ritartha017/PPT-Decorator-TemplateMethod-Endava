using DecoratorDesignPattern.DecoratorPattern.Component;

namespace DecoratorDesignPattern.DecoratorPattern.Decorator;

// The base Decorator class follows the same interface as the other
// components. The primary purpose of this class is to define the wrapping
// interface for all concrete decorators. The default implementation of the
// wrapping code might include a field for storing a wrapped component and
// the means to initialize it.
public abstract class BeverageDecorator : Beverage
{
    protected Beverage _beverage;
    public BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    // The Decorator delegates all work to the wrapped component.
    public override double Cost() => _beverage.Cost();
}
