using FPWDI;

namespace FPWDI_Tests;

public abstract class BaseUnitTest
{
    protected readonly IServiceProvider _serviceProvider;

    public BaseUnitTest()
    {
        _serviceProvider = Helper.CreateServiceProvider();
    }
}