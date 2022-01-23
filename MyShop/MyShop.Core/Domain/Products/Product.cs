namespace MyShop.Core.Domain.Products;

public class Product : BaseEntity
{
    /// <summary>
    /// Gets or sets product name
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets full description for a product
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the product SKU
    /// </summary>
    public string Sku { get; set; }

    /// <summary>
    /// Gets or sets the price
    /// </summary>
    public decimal Price { get; set; }

}

