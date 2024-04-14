using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Sections;

public class LargestBrandsSection
{
    public string Title { get; set; } = null!;
    public List<Image> BrandImages { get; set; } = [];
}
