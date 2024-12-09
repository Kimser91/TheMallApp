namespace TheMallApp;

public class Store
{
    List<IItem> Items = new List<IItem>();
    List<IItem> ShoppingCart = new List<IItem>();
    List<CarPart> CarParts = new List<CarPart>()
    {
        new CarPart("Engine", "Main power unit of the car", "Mechanical", 5000, 1001),
        new CarPart("Transmission", "Transfers power from engine to wheels", "Mechanical", 3000, 1002),
        new CarPart("Brake Pads", "Friction material for stopping the car", "Wearable", 150, 1003),
        new CarPart("Alternator", "Generates electrical power", "Electrical", 200, 1004),
        new CarPart("Radiator", "Cools the engine", "Cooling", 400, 1005),
        new CarPart("Fuel Pump", "Pumps fuel to the engine", "Mechanical", 250, 1006),
        new CarPart("Starter Motor", "Starts the engine", "Electrical", 300, 1007),
        new CarPart("Battery", "Stores electrical energy", "Electrical", 100, 1008),
        new CarPart("Exhaust Pipe", "Releases engine exhaust gases", "Exhaust", 150, 1009),
        new CarPart("Catalytic Converter", "Reduces harmful emissions", "Exhaust", 500, 1010),
        new CarPart("Shock Absorbers", "Absorbs suspension impacts", "Suspension", 200, 1011),
        new CarPart("Air Filter", "Filters air entering the engine", "Filtration", 50, 1012),
        new CarPart("Oil Filter", "Filters engine oil", "Filtration", 30, 1013),
        new CarPart("Spark Plugs", "Ignites fuel-air mixture", "Ignition", 20, 1014),
        new CarPart("Tires", "Rubber components for traction", "Wearable", 800, 1015),
        new CarPart("Steering Wheel", "Controls the car's direction", "Control", 150, 1016),
        new CarPart("Headlights", "Front illumination", "Lighting", 100, 1017),
        new CarPart("Tail Lights", "Rear illumination", "Lighting", 80, 1018),
        new CarPart("Windshield", "Front glass for visibility", "Body", 400, 1019),
        new CarPart("Wipers", "Clears the windshield", "Accessory", 40, 1020)
    };

    List<Tool> Tools = new List<Tool>()
    {
        new Tool("Hammer", "Used to drive nails into wood", "Hand Tool", 15, 3001),
        new Tool("Screwdriver", "Used to turn screws", "Hand Tool", 10, 3002),
        new Tool("Wrench", "Used to tighten or loosen bolts", "Hand Tool", 12, 3003),
        new Tool("Drill", "Used to create holes in materials", "Power Tool", 50, 3004),
        new Tool("Saw", "Used to cut wood or metal", "Hand Tool", 20, 3005),
        new Tool("Pliers", "Used to grip and bend materials", "Hand Tool", 8, 3006),
        new Tool("Tape Measure", "Used to measure distances", "Accessory", 5, 3007),
        new Tool("Level", "Used to check if a surface is flat", "Accessory", 8, 3008),
        new Tool("Sander", "Used to smooth surfaces", "Power Tool", 40, 3009),
        new Tool("Chainsaw", "Used to cut trees or large materials", "Power Tool", 100, 3010)
    };

    List<Food> Foods = new List<Food>()
    {
        new Food("Apple", "A sweet, crunchy fruit", "Fruit", 2, 2001),
        new Food("Bread", "A staple food made from wheat", "Grain", 3, 2002),
        new Food("Milk", "A nutritious dairy product", "Dairy", 4, 2003),
        new Food("Eggs", "Protein-rich food from chickens", "Protein", 5, 2004),
        new Food("Cheese", "A dairy product made from milk", "Dairy", 6, 2005),
        new Food("Carrot", "An orange root vegetable", "Vegetable", 2, 2006),
        new Food("Rice", "A staple grain food", "Grain", 8, 2007),
        new Food("Chicken", "A common source of protein", "Meat", 10, 2008),
        new Food("Banana", "A yellow tropical fruit", "Fruit", 2, 2009),
        new Food("Chocolate", "A sweet treat made from cacao", "Snack", 3, 2010)
    };

    
    public void MainMenu()
    {
        Console.WriteLine("Welcome to the Everything Store");
        Console.WriteLine("what can i get you?");
        Console.WriteLine("1. Just Browsing");
        Console.WriteLine("2. Food");
        Console.WriteLine("3. Tools");
        Console.WriteLine("4. Carparts");
        Console.WriteLine("5. Exit");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                PrintAllItems();
                break;
            case "2":
                PrintFood();
                break;
            case "3":
                PrintTools();
                break;
            case "4":
                PrintCarParts();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                MainMenu();
                break;
        }
    }

    public void buyItem()
    {
        Console.WriteLine("add to cart by number");
        int i = int.Parse(Console.ReadLine());
        ShoppingCart.Add(Items[i]);
        Console.WriteLine(ShoppingCart.Last().Name);
    }

    public void PrintAllItems()
    {
        
        foreach (var carPart in CarParts)
        {
            Items.Add(carPart);
        }

        foreach (var tool in Tools)
        {
            Items.Add(tool);
        }
        foreach (var food in Foods) 
        {
            Items.Add(food);
        }

        for (int i = 0; i< Items.Count; i++)
        {
            Console.WriteLine(i + ": " + Items[i].Name);
        }

        buyItem();

    }

    public void PrintCarParts()
    {
        foreach (var carpart in CarParts)
        {
            Console.WriteLine(carpart.Name);
        }
    }

    public void PrintFood()
    {
        foreach (var food in Foods)
        {
            Console.WriteLine(food.Name);
        }
    }

    public void PrintTools()
    {
        foreach (var tool in Tools)
        {
            Console.WriteLine(tool.Name);
        }
    }



}