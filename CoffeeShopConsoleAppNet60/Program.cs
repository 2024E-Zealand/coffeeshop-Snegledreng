// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

BlackCoffee blackCoffee = new BlackCoffee(0);
Cortado cortado = new Cortado(0);
Latte latte = new Latte(0);

List<Coffee> coffees = new List<Coffee>();
coffees.Add(blackCoffee);
coffees.Add(cortado);
coffees.Add(latte);

foreach (Coffee coffee in coffees)
{
    Console.WriteLine(coffee.Price());
    Console.WriteLine(coffee.Strength());
}
