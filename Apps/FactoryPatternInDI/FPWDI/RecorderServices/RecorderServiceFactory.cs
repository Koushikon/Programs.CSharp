namespace FPWDI.RecorderServices;

public class RecorderServiceFactory
{
    // Creates RecorderService Instance and return it
    public RecorderService CreateRecorderService()
    {
        var service = new RecorderService();
        service.Initialize();

        return service;
    }
}
