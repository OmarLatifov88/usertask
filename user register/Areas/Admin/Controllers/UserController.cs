using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using user_register.Areas.Admin.Models;
using user_register.Areas.Admin.Models.ViewModels;

namespace user_register.Areas.Admin.Controllers;

public class UserController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public UserController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
    {
        if(!ModelState.IsValid)
        {
            return View();
        }

        AppUser appuser = new AppUser()
        {
            Fullname = registerViewModel.Fullname,
            UserName = registerViewModel.Username,
            Email = registerViewModel.Email,
            IsActive = true
        };

        await _userManager.CreateAsync(appuser, registerViewModel.Password);

        return RedirectToAction("Index", "Home");
    }
}
