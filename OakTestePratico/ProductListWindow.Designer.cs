using System.ComponentModel;

namespace OakTestePratico;

partial class ProductListWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        RegisterProductButton = new System.Windows.Forms.Button();
        ProductListTable = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)ProductListTable).BeginInit();
        SuspendLayout();
        // 
        // RegisterProductButton
        // 
        RegisterProductButton.Location = new System.Drawing.Point(436, 336);
        RegisterProductButton.Name = "RegisterProductButton";
        RegisterProductButton.Size = new System.Drawing.Size(75, 23);
        RegisterProductButton.TabIndex = 2;
        RegisterProductButton.Text = "Cadastrar produto";
        RegisterProductButton.UseVisualStyleBackColor = true;
        RegisterProductButton.Click += RegisterProductButton_Click;
        // 
        // ProductListTable
        // 
        ProductListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        ProductListTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        ProductListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ProductListTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        ProductListTable.Location = new System.Drawing.Point(21, 66);
        ProductListTable.Name = "ProductListTable";
        ProductListTable.ReadOnly = true;
        ProductListTable.RowHeadersVisible = false;
        ProductListTable.RowTemplate.ReadOnly = true;
        ProductListTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        ProductListTable.ShowEditingIcon = false;
        ProductListTable.Size = new System.Drawing.Size(490, 252);
        ProductListTable.TabIndex = 3;
        // 
        // ProductListWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(528, 386);
        Controls.Add(ProductListTable);
        Controls.Add(RegisterProductButton);
        Location = new System.Drawing.Point(15, 15);
        Text = "Lista de Produtos";
        ((System.ComponentModel.ISupportInitialize)ProductListTable).EndInit();
        ResumeLayout(false);
    }
    
    private System.Windows.Forms.DataGridView ProductListTable;

    private System.Windows.Forms.Button RegisterProductButton;
    
    #endregion
}