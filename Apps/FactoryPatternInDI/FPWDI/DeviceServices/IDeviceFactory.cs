using FPWDI.Devices;

namespace FPWDI.DeviceServices;

public interface IDeviceFactory
{
    Device CreateDevice(DeviceType deviceType);
}