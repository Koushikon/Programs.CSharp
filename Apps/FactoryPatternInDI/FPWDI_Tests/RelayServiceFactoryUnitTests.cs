using FPWDI.Relay;
using FPWDI.RelayServices;

namespace FPWDI_Tests;

public class RelayServiceFactoryUnitTests : BaseUnitTest
{
    [Fact]
    public void GivenMultipleConcereteServices_WhenUsedWithFactory_ThenCanBeResolvedConditionally()
    {
        var factory = _serviceProvider.GetService<RelayServiceFactory>()!;

        var liveRelay = factory.GetRelayService(RelayMode.Live);
        var sandboxRelay = factory.GetRelayService(RelayMode.SandBox);

        Assert.Equal("Live: Demo", liveRelay.Relay("Demo"));
        Assert.Equal("SandBox: Demo", sandboxRelay.Relay("Demo"));
    }
}
