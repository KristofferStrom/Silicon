using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Sections;

public class WorktoolsSection
{   
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<ToolBox> ToolBoxes { get; set; } = [];
}
