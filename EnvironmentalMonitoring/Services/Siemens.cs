namespace EnvironmentalMonitoring.Services;

using S7.Net;

public class PlcService
{
    private readonly Plc _plc;

    public PlcService()
    {
        _plc = new Plc(
            CpuType.S71200,
            "192.168.1.10",
            0,
            1);
    }

    public bool Connect()
    {
        if (!_plc.IsConnected)
            _plc.Open();

        return _plc.IsConnected;
    }
}