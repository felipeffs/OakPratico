using System.Text.RegularExpressions;

namespace OakTestePratico;

public partial class ProductRegistrationWindow : Form
{
    private bool _isAvailableForSale = false;
    private string _productName = string.Empty;
    private string _productDescription = string.Empty;
    private float _productPrice = 0;

    private Action<Item?> _returnAction;

    public ProductRegistrationWindow(Action<Item?> returnAction)
    {
        InitializeComponent();
        _returnAction = returnAction;
    }

    private void DescriptionLabel_Click(object sender, EventArgs e)
    {
        return;
    }

    private void PriceLabel_Click(object sender, EventArgs e)
    {
        return;
    }

    private void PriceInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
        {
            e.Handled = true;
        }
    }

    private void PriceInput_TextChanged(object sender, EventArgs e)
    {
        var textBox = (TextBox)sender;
        var text = textBox.Text;

        // Caso copie e cole valores que não são números
        var formatedValue = Regex.Replace(text ?? string.Empty, @"[^\d.,]|\.(?=.*\.)|,(?=.*[,\.])|(?<!\d)[.,]", "");

        if (float.TryParse(formatedValue, out var price))
        {
            _productPrice = price;
        }
        else
        {
            _productPrice = 0;
        }

        textBox.Text = formatedValue;
    }

    private void ProductNameInput_TextChanged(object sender, EventArgs e)
    {
        _productName = (sender as TextBox)?.Text.Trim() ?? string.Empty;
        return;
    }

    private void DescriptionInput_TextChanged(object sender, EventArgs e)
    {
        _productDescription = (sender as TextBox)?.Text.Trim() ?? string.Empty;
        return;
    }

    private void ToggleIsAvailable_CheckedChanged(object sender, EventArgs e)
    {
        _isAvailableForSale = true;
        return;
    }

    private void IsAvailableForSale_Click(object sender, EventArgs e)
    {
        return;
    }

    private void ToggleIsNotAvailable_CheckedChanged(object sender, EventArgs e)
    {
        _isAvailableForSale = false;
        return;
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        if (_productName != string.Empty && _productPrice != 0)
        {
            var newItem = new Item(_productName, _productDescription, _productPrice, _isAvailableForSale);
            _returnAction.Invoke(newItem);
        }

        return;
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        _returnAction.Invoke(null);
        return;
    }
}