using FPWDI.Devices.SmartServices;

namespace FPWDI.DeviceServices;

public class MasterDeviceFactory
{
    private readonly IEnumerable<IDeviceFactory> _deviceFactories;

    public MasterDeviceFactory(IEnumerable<IDeviceFactory> deviceFactories)
    {
        _deviceFactories = deviceFactories;
    }

    public IDeviceFactory GetClassicFactory()
    {
        return _deviceFactories.OfType<DeviceFactory>()
            .FirstOrDefault()!;
    }

    public IDeviceFactory GetSmartFactory()
    {
        return _deviceFactories.OfType<SmartDeviceFactory>()
            .FirstOrDefault()!;
    }
}