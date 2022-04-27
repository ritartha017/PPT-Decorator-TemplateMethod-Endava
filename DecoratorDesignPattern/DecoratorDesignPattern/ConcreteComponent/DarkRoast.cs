using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern.ConcreteComponent;

// Concrete Components provide default implementations of the operations.
// There might be several variations of these classes.
public class DarkRoast : Beverage
{
    public override double Cost() => 144;
}

