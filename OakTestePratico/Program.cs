namespace OakTestePratico;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    ///
    private static InventoryManager _inventoryManager = new();

    [STAThread]
    static void Main()
    {
        _inventoryManager.AddProduct(new Item("Sabão em pó", "Não liquido", 37.5f, false));

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new ProductListWindow(_inventoryManager));
    }
}

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

public class InventoryManager
{
    private List<Item> _productList = new();

    public InventoryManager()
    {
    }

    public void AddProduct(Item product)
    {
        _productList.Add(product);
    }

    public ItemViewModel[] GetProductsListView()
    {
        return _productList.Select(p => new ItemViewModel(p.Name, p.Price))
            .OrderBy(p => p.Preço).ToArray();
    }

    public class ItemViewModel
    {
        public string Nome { get; set; }
        public float Preço { get; set; }

        public ItemViewModel(string name, float price)
        {
            Nome = name;
            Preço = price;
        }
    }
}