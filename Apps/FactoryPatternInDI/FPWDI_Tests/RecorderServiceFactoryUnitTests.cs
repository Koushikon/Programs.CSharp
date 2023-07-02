using FPWDI.RecorderServices;

namespace FPWDI_Tests;

public class RecorderServiceFactoryUnitTests : BaseUnitTest
{
    [Fact]
    public void GivenService_WhenUsedWithFactory_ThenHaveAbstractionOverInitialization()
    {
        var factory = _serviceProvider.GetService<RecorderServiceFactory>()!;

        var recorder = factory.CreateRecorderService();

        Assert.Equal("Recorded: Demo", recorder.Record("Demo"));
    }
}
