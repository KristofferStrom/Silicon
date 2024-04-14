using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Sections;

public class TaskmasterSection
{
    public string Title { get; set; } = null!;
    
    public Image Image { get; set; } = null!;
    public Button LearnMoreButton { get; set; } = null!;
    public List<SellingArgument> SellingArguments { get; set; } = [];
}
