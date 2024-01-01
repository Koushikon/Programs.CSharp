using Microsoft.Extensions.Logging;

namespace PrimaryConstructor;

public class FromDIBefore
{
    private readonly ILogger<FromDIBefore> logger;

    public FromDIBefore(ILogger<FromDIBefore> logger)
    {
        this.logger = logger;
    }
}



public class FromDIAfter(ILogger<FromDIBefore> logger)
{
    // We can use this Primary Constructor parameter name to make it readonly.
    // So, its cannot be changed later on
    private readonly ILogger<FromDIBefore> logger = logger;


    public void Test()
    {
        // Making the same name if we want to change the value
        //logger = null;
    }
}