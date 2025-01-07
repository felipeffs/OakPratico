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
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new ProductListWindow(_inventoryManager));
    }
}