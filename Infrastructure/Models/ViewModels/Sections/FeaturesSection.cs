using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Sections
{
    public class FeaturesSection
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<FeatureBox> FeatureBoxes { get; set; } = new List<FeatureBox>();
    }
}
