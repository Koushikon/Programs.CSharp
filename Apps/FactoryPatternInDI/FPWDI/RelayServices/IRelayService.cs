using FPWDI.Relay;

namespace FPWDI.RelayServices;

public interface IRelayService
{
    string Relay(string message);

    RelayMode RelayMode { get; }
}