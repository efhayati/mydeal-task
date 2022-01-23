namespace MyShop.Core.Domain.Products;

public class ShoppingCartItem : BaseEntity
{
    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

}

