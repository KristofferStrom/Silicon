using Infrastructure.Models.ViewModels.Sections;

namespace Infrastructure.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public FeaturesSection FeaturesSection { get; set; } = null!;
        public ShowcaseSection ShowcaseSection { get; set; } = null!;
        public TaskmasterSection TaskmasterSection { get; set; } = null!;
        public WorktoolsSection WorktoolsSection { get; set; } = null!;
        public SubscriberSection SubscriberSection { get; set; } = null!;

    }
}
