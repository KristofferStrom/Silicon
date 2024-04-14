using System.ComponentModel.DataAnnotations;
using Infrastructure.Models.ViewModels.Components;

namespace Infrastructure.Models.ViewModels.Forms
{
    public class SubscriberViewForm
    {
        public string? Title { get; set; }
        public Button? SubmitButton { get; set; }

        [Required]
        [EmailAddress]
        [Display(Prompt = "Your Email")]
        public string Email { get; set; } = null!;

        [Display(Name = "Daily Newsletter")]
        public bool DailyNewsletter { get; set; }

        [Display(Name = "Advertising Updates")]
        public bool AdvertisingUpdates { get; set; }

        [Display(Name = "Week in Review")]
        public bool WeekinReview { get; set; }

        [Display(Name = "Event Updates")]
        public bool EventUpdates { get; set; }

        [Display(Name = "Startups Weekly")]
        public bool StartupsWeekly { get; set; }

        [Display(Name = "Podcasts")]
        public bool Podcasts { get; set; }

    }
}
