using Infrastructure.Factories;
using Infrastructure.Models.ViewModels.Forms;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;


namespace WebApp.Controllers
{
    public class SubscribersController(HttpClient http) : Controller
    {
        private readonly HttpClient _http = http;

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscriberViewForm form)
        {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(SubscribeFactory.Create(form)), Encoding.UTF8, "application/json");
                var response = await _http.PostAsync("https://localhost:7106/api/Subscriber", content);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Status"] = "You are a new subscriber";
                    return RedirectToAction("Index", "Home", "subscribe");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    TempData["Status"] = "You already have a subscription";
                    return RedirectToAction("Index", "Home", "subscribe");
                }
            }

            TempData["Status"] = "Something went wrong";
            return RedirectToAction("Index", "Home", "subscribe");
        }
    }
}
