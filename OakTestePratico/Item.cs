namespace OakTestePratico;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public bool IsAvailableForSale { get; set; }

    public Item(string name, string description, float price, bool isAvailableForSale)
    {
        Name = name;
        Description = description;
        Price = price;
        IsAvailableForSale = isAvailableForSale;
    }
}