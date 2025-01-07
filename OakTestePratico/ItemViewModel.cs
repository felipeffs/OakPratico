namespace OakTestePratico;

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