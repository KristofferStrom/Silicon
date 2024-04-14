using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Attributes;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController(SubscribeRepo repo) : ControllerBase
    {
        private readonly SubscribeRepo _repo = repo;

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscribeForm form)
        {
            if (ModelState.IsValid)
            {
                if(!await _repo.ExistsAsync(x => x.Email == form.Email))
                {
                    try
                    {
                        await _repo.CreateAsync(SubscribeFactory.Create(form));
                        return Created("", null);
                    }
                    catch { }

                    return Problem();
                }

                return Conflict();
            }
            
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Unsubscribe(string email)
        {
            if (ModelState.IsValid)
            {
                var subscriberToDelete = await _repo.GetAsync(x => x.Email == email);
                if(subscriberToDelete != null)
                {
                    try
                    {
                        await _repo.DeleteAsync(subscriberToDelete);
                        return Ok();
                    }
                    catch { }
                }

                return NotFound();
            }
            
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetSubscribers()
        {
            try
            {
                return Ok(await _repo.GetAll().ToListAsync());
            }
            catch { }
         
            return Problem();
        }   
    }
}
