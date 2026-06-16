using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalMonitoring.Controllers;

public class TrendController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}