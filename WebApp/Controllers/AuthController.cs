using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;


public class AuthController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager) : Controller
{
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;


    #region signup
    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }


    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(SignUpForm form)
    {
        if (ModelState.IsValid)
        {
            var result = await _userManager.CreateAsync(UserFactory.Create(form), form.Password);
            if (result.Succeeded)
            {
                if ((await _signInManager.PasswordSignInAsync(form.Email, form.Password, false, false)).Succeeded)
                {
                    return RedirectToAction("Details", "Account");
                }
            }
            else
            {
                ViewData["StatusMessage"] = "Something went wrong";
            }
        }

        return View(form);
    }

    #endregion

    #region signin


    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn(string returnUrl)
    {
        ViewData["ReturnUrl"] = returnUrl ?? "/";
        return View();
    }

    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(SignInForm form, string returnUrl)
    {
        if (ModelState.IsValid)
        {
            if ((await _signInManager.PasswordSignInAsync(form.Email, form.Password, form.IsPresistent, false)).Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
        }

        ViewData["StatusMessage"] = "Incorrect e-mail och password";
        return View(form);
    }

    #endregion

    #region signout

    [HttpGet]
    [Route("/signout")]
    public new async Task<IActionResult> SignOut()
    {
        Response.Cookies.Delete("AccessToken");
        await _signInManager.SignOutAsync();
        return LocalRedirect("/");
    }

    #endregion

}


