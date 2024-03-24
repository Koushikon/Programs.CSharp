
namespace Fields_Properties.Models;

/***
 * * init accessor:
 * * This allows us to set the initial value of a property during object creation,
 * * but then prevent further modifications to that property:
 */

public class Rectangle
{
    public double Height { get; init; }
    public double Width { get; init; }
}