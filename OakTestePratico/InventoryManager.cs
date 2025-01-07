namespace OakTestePratico;

public class InventoryManager
{
    private List<Item> _productList =
    [
        new("Sabão em pó", "Não liquido", 37.5f, true),
        new("Tesoura sem ponta", "Não fura", 9.72f, true),
        new("Caneca verde grunge ", "Tem alça para segurar para tomar liquidos", 5.42f, true)
    ];

    public void AddProduct(Item product)
    {
        _productList.Add(product);
    }

    public ItemViewModel[] GetProductsListView()
    {
        return _productList.Select(p => new ItemViewModel(p.Name, p.Price))
            .OrderBy(p => p.Preço).ToArray();
    }
}