namespace TheMallApp;

public interface IItem
{
    public string Name { get;  set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int Price { get; set; }

    public int Barcode { get; set; }
}