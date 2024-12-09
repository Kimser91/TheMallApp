using System.Net.Http.Headers;
using System.Xml.Serialization;using TheMallApp;

CarPart part = new CarPart("Pipe", "Bend", "Steel", 45, 90);
Food food = new Food("Onion", "Spring onions", "Vegi", 1);
List<Tool> tools = new List<Tool>()
{
    new Tool("Spanner", "10mm", "Hand Tool", 15),
    new Tool("Hammer", "1000g", "Hand Tool", 10)
};

Console.WriteLine(part.Name);
Console.WriteLine(food.Name);
Console.WriteLine(tools[0].Name);
Console.WriteLine();
Console.ReadKey();


var Cart = new ShoppingCart();
Cart.getList(part, food, tools);
