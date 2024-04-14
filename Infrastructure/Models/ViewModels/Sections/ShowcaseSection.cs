using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Sections
{
    public class ShowcaseSection
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
   
        public Image Image { get; set; } = null!;   
        public Button GetStartedButton { get; set; } = null!;
        public LargestBrandsSection LargestBrandsSection { get; set; } = null!;
    }
}
