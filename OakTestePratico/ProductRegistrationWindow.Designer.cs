namespace OakTestePratico;

partial class ProductRegistrationWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ProductNameInput = new System.Windows.Forms.TextBox();
        DescriptionInput = new System.Windows.Forms.TextBox();
        DescriptionLabel = new System.Windows.Forms.Label();
        ProductNameLabel = new System.Windows.Forms.Label();
        PriceInput = new System.Windows.Forms.TextBox();
        PriceLabel = new System.Windows.Forms.Label();
        IsAvailableForSale = new System.Windows.Forms.Label();
        ToggleIsAvailable = new System.Windows.Forms.RadioButton();
        panel1 = new System.Windows.Forms.Panel();
        ToggleIsNotAvailable = new System.Windows.Forms.RadioButton();
        SubmitButton = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // ProductNameInput
        // 
        ProductNameInput.Location = new System.Drawing.Point(45, 41);
        ProductNameInput.Name = "ProductNameInput";
        ProductNameInput.Size = new System.Drawing.Size(197, 23);
        ProductNameInput.TabIndex = 1;
        ProductNameInput.TextChanged += ProductNameInput_TextChanged;
        // 
        // DescriptionInput
        // 
        DescriptionInput.Location = new System.Drawing.Point(45, 105);
        DescriptionInput.Name = "DescriptionInput";
        DescriptionInput.Size = new System.Drawing.Size(197, 23);
        DescriptionInput.TabIndex = 3;
        DescriptionInput.TextChanged += DescriptionInput_TextChanged;
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.AccessibleName = "";
        DescriptionLabel.Location = new System.Drawing.Point(45, 79);
        DescriptionLabel.Name = "DescriptionLabel";
        DescriptionLabel.Size = new System.Drawing.Size(124, 23);
        DescriptionLabel.TabIndex = 2;
        DescriptionLabel.Text = "Descrição";
        DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        DescriptionLabel.Click += DescriptionLabel_Click;
        // 
        // ProductNameLabel
        // 
        ProductNameLabel.AccessibleName = "";
        ProductNameLabel.Location = new System.Drawing.Point(45, 15);
        ProductNameLabel.Name = "ProductNameLabel";
        ProductNameLabel.Size = new System.Drawing.Size(124, 23);
        ProductNameLabel.TabIndex = 4;
        ProductNameLabel.Text = "Nome do Produto";
        ProductNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // PriceInput
        // 
        PriceInput.Location = new System.Drawing.Point(314, 41);
        PriceInput.Name = "PriceInput";
        PriceInput.Size = new System.Drawing.Size(197, 23);
        PriceInput.TabIndex = 6;
        PriceInput.TextChanged += PriceInput_TextChanged;
        PriceInput.KeyPress += PriceInput_KeyPress;
        // 
        // PriceLabel
        // 
        PriceLabel.AccessibleName = "";
        PriceLabel.Location = new System.Drawing.Point(314, 15);
        PriceLabel.Name = "PriceLabel";
        PriceLabel.Size = new System.Drawing.Size(124, 23);
        PriceLabel.TabIndex = 5;
        PriceLabel.Text = "Preço";
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        PriceLabel.Click += PriceLabel_Click;
        // 
        // IsAvailableForSale
        // 
        IsAvailableForSale.Location = new System.Drawing.Point(3, 6);
        IsAvailableForSale.Name = "IsAvailableForSale";
        IsAvailableForSale.Size = new System.Drawing.Size(163, 23);
        IsAvailableForSale.TabIndex = 7;
        IsAvailableForSale.Text = "Está disponível para venda?";
        IsAvailableForSale.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        IsAvailableForSale.Click += IsAvailableForSale_Click;
        // 
        // ToggleIsAvailable
        // 
        ToggleIsAvailable.Location = new System.Drawing.Point(3, 32);
        ToggleIsAvailable.Name = "ToggleIsAvailable";
        ToggleIsAvailable.Size = new System.Drawing.Size(104, 24);
        ToggleIsAvailable.TabIndex = 8;
        ToggleIsAvailable.Text = "Sim";
        ToggleIsAvailable.UseVisualStyleBackColor = true;
        ToggleIsAvailable.CheckedChanged += ToggleIsAvailable_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(ToggleIsNotAvailable);
        panel1.Controls.Add(IsAvailableForSale);
        panel1.Controls.Add(ToggleIsAvailable);
        panel1.Location = new System.Drawing.Point(314, 73);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(218, 59);
        panel1.TabIndex = 9;
        // 
        // ToggleIsNotAvailable
        // 
        ToggleIsNotAvailable.Checked = true;
        ToggleIsNotAvailable.Location = new System.Drawing.Point(108, 32);
        ToggleIsNotAvailable.Name = "ToggleIsNotAvailable";
        ToggleIsNotAvailable.Size = new System.Drawing.Size(104, 24);
        ToggleIsNotAvailable.TabIndex = 9;
        ToggleIsNotAvailable.TabStop = true;
        ToggleIsNotAvailable.Text = "Não";
        ToggleIsNotAvailable.UseVisualStyleBackColor = true;
        ToggleIsNotAvailable.CheckedChanged += ToggleIsNotAvailable_CheckedChanged;
        // 
        // SubmitButton
        // 
        SubmitButton.Location = new System.Drawing.Point(457, 193);
        SubmitButton.Name = "SubmitButton";
        SubmitButton.Size = new System.Drawing.Size(75, 23);
        SubmitButton.TabIndex = 10;
        SubmitButton.Text = "Salvar";
        SubmitButton.UseVisualStyleBackColor = true;
        SubmitButton.Click += SubmitButton_Click;
        // 
        // ProductRegistrationWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(572, 228);
        Controls.Add(SubmitButton);
        Controls.Add(panel1);
        Controls.Add(PriceInput);
        Controls.Add(PriceLabel);
        Controls.Add(ProductNameLabel);
        Controls.Add(DescriptionInput);
        Controls.Add(DescriptionLabel);
        Controls.Add(ProductNameInput);
        Text = "Cadastrar Produto";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button SubmitButton;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton ToggleIsNotAvailable;

    private System.Windows.Forms.RadioButton ToggleIsAvailable;

    private System.Windows.Forms.Label IsAvailableForSale;

    private System.Windows.Forms.TextBox PriceInput;
    private System.Windows.Forms.Label PriceLabel;

    private System.Windows.Forms.Label ProductNameLabel;

    private System.Windows.Forms.TextBox ProductNameInput;
    private System.Windows.Forms.TextBox DescriptionInput;

    private System.Windows.Forms.Label DescriptionLabel;

    #endregion
}