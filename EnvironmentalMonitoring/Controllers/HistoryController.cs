using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalMonitoring.Controllers;

public class HistoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}