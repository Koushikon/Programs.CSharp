using FPWDI.Relay;

namespace FPWDI.RelayServices;

public class SandBoxRelayService : IRelayService
{
    // returns Live SandBox value
    public RelayMode RelayMode => RelayMode.SandBox;

    // return the provived "SandBox: message"
    public string Relay(string message) => $"SandBox: {message}";
}