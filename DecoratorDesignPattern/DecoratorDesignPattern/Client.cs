using DecoratorDesignPattern.Component;

namespace DecoratorDesignPattern
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ClientCode(Beverage beverage)
        {
            Console.WriteLine("RESULT COST: " + beverage.Cost());
        }
    }
}
