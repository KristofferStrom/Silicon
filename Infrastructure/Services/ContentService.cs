using Infrastructure.Data.Content;
using Infrastructure.Models.ViewModels.Sections;

namespace Infrastructure.Services;

public class ContentService
{
    public FeaturesSection GetFeaturesSection()
    {
        return Content.FeaturesSection;
    }
    public ShowcaseSection GetShowcaseSection()
    {
        return Content.ShowcaseSection;
    }
    public TaskmasterSection GetTaskmasterSection()
    {
        return Content.TaskmasterSection;
    }
    public WorktoolsSection GetWorkToolsSection()
    {
        return Content.WorktoolsSection;
    }
    public SubscriberSection GetSubscriberSection()
    {
        return Content.SubscriberSection;
    }
}
