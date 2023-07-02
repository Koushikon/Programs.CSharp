using FPWDI.Relay;

namespace FPWDI.RelayServices;

public class OfflineRelayService : IRelayService
{
    // returns Offline Relay value
    public RelayMode RelayMode => RelayMode.Offline;

    // return the provived "Offline: message"
    public string Relay(string message) => $"Offline: {message}";
}