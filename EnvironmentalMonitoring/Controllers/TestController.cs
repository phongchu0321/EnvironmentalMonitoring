using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using EnvironmentalMonitoring.Hubs;

public class TestController : Controller
{
    private readonly IHubContext<MonitoringHub> _hub;

    public TestController(IHubContext<MonitoringHub> hub)
    {
        _hub = hub;
    }

    public async Task<IActionResult> Send()
    {
        await _hub.Clients.All.SendAsync("ReceiveData", new
        {
            temperature = 31.25,
            humidity = 56.87,
            pressure = 4.51,
            level = 6.58,
            flow = 9.80,
            totalFlow = 71447,
            voltage1 = 4.28,
            voltage2 = 1.27,
            waterTemp = 28.65
        });

        return Ok();
    }
}