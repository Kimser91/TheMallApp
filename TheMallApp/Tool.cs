﻿namespace TheMallApp;

public class Tool : IItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int Price { get; set; }

    public int Barcode { get; set; }



    public Tool(string name, string description, string type, int price, int barcode)
    {
        Name = name;
        Description = description;
        Type = type;
        Price = price;
        Barcode = barcode;
    }

}