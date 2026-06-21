using Microsoft.AspNetCore.Mvc;

namespace EnvironmentalMonitoring.Controllers;

public class DeviceController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}