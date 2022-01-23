using MyShop.Core.Domain.Media;

namespace MyShop.Core.Domain.Products;

public class ProductPicture : BaseEntity
{
    public int ProductId { get; set; }

    public virtual Product Product { get; set; }

    public int PictureId { get; set; }

    public virtual Picture Picture { get; set; }

    public int DisplayOrder { get; set; }
}

