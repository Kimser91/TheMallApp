namespace TheMallApp;

public class CarPart : IItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int Price { get; set; }

    public int Partnumber { get; set; }

    public CarPart(string name , string description, string type , int price , int partnumber )
    {
        Name = name;
        Description = description;
        Type = type;
        Price = price;
        Partnumber = partnumber;
    }


}