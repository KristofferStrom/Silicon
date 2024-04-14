using Infrastructure.Entities;
using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Factories;

public class ImageFactory
{
    public static ImageEntity Create(Image image)
    {
        return new ImageEntity
        {
            Url = image.Url,
            AltText = image.AltText
        };
    }
    public static Image Create(ImageEntity entity)
    {
        return new Image
        {
            Url = entity.Url,
            AltText = entity.AltText
        };
    }
}
