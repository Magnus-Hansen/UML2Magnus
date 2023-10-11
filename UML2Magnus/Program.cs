using UML2Magnus;

internal class Program
{
    private static void Main(string[] args)
    {
        PizzaRepository pizzaRepository = new PizzaRepository();
        CustomerRepository customerRepository = new CustomerRepository();

        Terminal terminal = new Terminal(pizzaRepository, customerRepository);

        terminal.Run();
    }
}