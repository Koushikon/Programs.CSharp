using System;
using System.Collections.Generic;

public class HttpCookie
{
    private readonly Dictionary<string, string> _cookies;
    public DateTime Expiry { get; set; }

    public HttpCookie()
    {
        _cookies = new Dictionary<string, string>();
    }

    public string this[string key]
    {
        get { return this._cookies[key]; }
        set { this._cookies[key] = value; }
    }


    // Or, we could use separate method for get and set the value
    public void setItem(string key, string value)
    {
        this._cookies[key] = value;
    }

    public string getItem(string key)
    {
        return this._cookies[key];
    }
}
