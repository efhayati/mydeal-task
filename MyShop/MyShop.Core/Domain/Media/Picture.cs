namespace MyShop.Core.Domain.Media;

public class Picture : BaseEntity
{
    public string ContentType { get; set; }

    public string AltAttribute { get; set; }

    public string TitleAttribute { get; set; }

    public byte[] BinaryData { get; set; }
}

