namespace FPWDI.RecorderServices;

public class RecorderService
{
    private bool _isDeviceReady = false;

    // Set the _isDeviceReady to true
    public void Initialize()
    {
        // Initialization of hardware connection goes here
        _isDeviceReady = true;
    }


    // throw an exception if _isDeviceReady is false Otherwise
    // return the provived "Recorded: message"
    public string Record(string message)
    {
        if (!_isDeviceReady)
            throw new InvalidOperationException("Device is not ready");

        return $"Recorded: {message}";
    }
}
