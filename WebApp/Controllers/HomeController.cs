using Infrastructure.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;

namespace WebApp.Controllers
{
    public class HomeController(ContentService contentService) : Controller
    {
        private readonly ContentService _contentService = contentService;

        public IActionResult Index()
        {
            var homeIndexViewModel = new HomeIndexViewModel
            {
                FeaturesSection = _contentService.GetFeaturesSection(),
                ShowcaseSection = _contentService.GetShowcaseSection(),
                TaskmasterSection = _contentService.GetTaskmasterSection(),
                WorktoolsSection = _contentService.GetWorkToolsSection(),
                SubscriberSection = _contentService.GetSubscriberSection()
            };

            return View(homeIndexViewModel);
        }
    }
}
