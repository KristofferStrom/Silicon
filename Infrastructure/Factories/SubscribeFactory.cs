using Infrastructure.Entities;
using Infrastructure.Models;
using Infrastructure.Models.ViewModels.Forms;

namespace Infrastructure.Factories;

public class SubscribeFactory
{
    public static SubscriberEntity Create(SubscribeForm form)
    {
        var dateTime = DateTime.Now;
        try
        {
            return new SubscriberEntity
            {
                Email = form.Email,
                DailyNewsletter = form.DailyNewsletter,
                AdvertisingUpdates = form.AdvertisingUpdates,
                WeekinReview = form.WeekinReview,
                EventUpdates = form.EventUpdates,
                StartupsWeekly = form.StartupsWeekly,
                Podcasts = form.Podcasts,
                Created = dateTime,
                Modified = dateTime
            };
        }
        catch {}
        return null!;
    }

    public static SubscribeForm Create(SubscriberViewForm form)
    {
        try
        {
            return new SubscribeForm
            {
                Email = form.Email,
                DailyNewsletter = form.DailyNewsletter,
                AdvertisingUpdates = form.AdvertisingUpdates,
                WeekinReview = form.WeekinReview,
                EventUpdates = form.EventUpdates,
                StartupsWeekly = form.StartupsWeekly,
                Podcasts = form.Podcasts,
            };
        }
        catch { }
        return null!;
    }
}
