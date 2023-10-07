namespace Matrix.Models;

public static class DateUtils
{
    /***
     * To Mark a method as deprecated we can use [Obsolete] attribute
     * 
     * Obsolete attribute: [Obsolete]
     * With no parameters the default warning message will be displayed when method call.
     * 
     * Obsolete attribute with message: [Obsolete("Please use GetCurrentYear_v3 instead.")]
     * Here with this custom Warning message will be displayed when method call.
     * 
     * Obsolete attribute with error: [Obsolete("Please use GetCurrentYear_v3 instead.", true)]
     * Here with this Error message will be displayed program will not be build.
     */
    [Obsolete]
    public static int GetCurrentYear_v1()
    {
        return 2023;
    }

    [Obsolete("Please use GetCurrentYear_v3 instead.")]
    public static int GetCurrentYear_v2()
    {
        return DateTime.Now.Year;
    }

    [Obsolete("Please use GetCurrentYear_v3 instead.", true)]
    public static int GetPreviousYear()
    {
        return DateTime.Now.Year;
    }

    public static int GetCurrentYear_v3()
    {
        return DateTime.Now.Year;
    }
}