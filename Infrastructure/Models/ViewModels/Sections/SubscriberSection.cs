using Infrastructure.Models;
using Infrastructure.Models.ViewModels.Components;
using Infrastructure.Models.ViewModels.Forms;

namespace Infrastructure.Models.ViewModels.Sections;

public class SubscriberSection
{
    public string Title { get; set; } = null!;
    public Image Image { get; set; } = null!;
    public SubscriberViewForm SubscriptionForm { get; set; } = new SubscriberViewForm();
   
}
