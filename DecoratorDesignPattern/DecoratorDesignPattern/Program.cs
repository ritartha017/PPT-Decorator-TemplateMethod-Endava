using DecoratorDesignPattern;
using DecoratorDesignPattern.ConcreteComponent;
using DecoratorDesignPattern.ConcreteDecorator;

Client client = new();

var espresso = new Espresso();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(espresso);

Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.

Milk decorator1 = new(espresso);
Soy decorator2  = new(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);
