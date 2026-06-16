using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalMonitoring.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}