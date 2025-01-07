namespace OakTestePratico;

public class InventoryManager
{
    private List<Item> _productList = [];

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