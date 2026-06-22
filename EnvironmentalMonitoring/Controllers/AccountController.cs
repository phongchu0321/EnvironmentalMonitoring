using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalMonitoring.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        if(HttpContext.Session.GetString("User")
           == null)
        {
            return RedirectToAction(
                "Login",
                "Account");
        }

        return View();
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Logout()
    {
        return RedirectToAction(
            "Login",
            "Account");
        
        //await _signInManager.SignOutAsync();
    }
    
}