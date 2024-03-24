
namespace Fields_Properties.Models;

/***
 * * We access the fields directly without the need for explicit accessors.
 * * Whereas, properties utilize get and set accessors, allowing for additional logic during access or modification.
 * * For instance, we can introduce a validation logic for a rectangle’s width:
 */

public class Box
{
    private double _width = 1.0;

    public double Width
    {
        get { return _width; }
        init
        {
            if (value < 0)
                throw new ArgumentException("A Box cannot have negative width: " + nameof(value));
            _width = value;
        }
    }
}