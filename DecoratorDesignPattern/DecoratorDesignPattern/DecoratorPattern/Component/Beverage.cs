namespace DecoratorDesignPattern.DecoratorPattern.Component;

// The base Component interface defines operations that can be altered by
// decorators.
public abstract class Beverage
{
    public abstract double Cost();
}