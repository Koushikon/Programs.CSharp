using FPWDI.Relay;

namespace FPWDI.RelayServices;

public class LiveRelayService : IRelayService
{
    // returns Live Relay value
    public RelayMode RelayMode => RelayMode.Live;

    // return the provived "Live: message"
    public string Relay(string message) => $"Live: {message}";
}
