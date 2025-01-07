namespace OakTestePratico;

public partial class ProductListWindow : Form
{
    private InventoryManager _inventoryManager;

    private ProductRegistrationWindow _registerWindow = null!;

    public ProductListWindow(InventoryManager inventoryManager)
    {
        InitializeComponent();
        _inventoryManager = inventoryManager;

        ProductListTable.DataSource = _inventoryManager.GetProductsListView();
    }

    private void RegisterProductButton_Click(object sender, EventArgs e)
    {
        if (_registerWindow != null) return;

        Hide();
        _registerWindow = new ProductRegistrationWindow(this);
        _registerWindow.Show();
    }

    public void Return_SaveItem(Item? newItem)
    {
        if (newItem == null) return;

        _inventoryManager.AddProduct(newItem);
        ProductListTable.DataSource = _inventoryManager.GetProductsListView();
        Return_Button();
    }

    public void Return_Button()
    {
        _registerWindow.Close();
        _registerWindow = null!;
        Show();
    }

    public void Return_Close()
    {
        Show();
        _registerWindow = null!;
    }
}