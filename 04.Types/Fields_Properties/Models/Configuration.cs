
namespace Fields_Properties.Models;

/***
 * * Both of these properties are “read-write” properties.
 * * We can also have “read-only” properties with only get accessors,
 * * or “write-only” properties with only set accessors.
 */

public class Configuration
{
    private string _secretKey = string.Empty;

    public string SecretKey
    {
        set { _secretKey = $"PGP==***{value}***"; }
    }

    public string MaskedSecretKey
    {
        get { return _secretKey; }
    }
}