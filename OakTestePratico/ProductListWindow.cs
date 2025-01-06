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
        _registerWindow = new ProductRegistrationWindow(ReturnToWindow);
        _registerWindow.Show();
    }

    private void ReturnToWindow(Item? newItem)
    {
        if (newItem != null)
        {
            _inventoryManager.AddProduct(newItem);
            ProductListTable.DataSource = _inventoryManager.GetProductsListView();
        }

        Show();
        _registerWindow.Close();
        _registerWindow = null!;
    }
}