
namespace Fields_Properties.Models;

/***
 * * Properties also have access modifiers to control their accessability
 * * We can also declare a Property as static
 *
 * * With static there is only one instance of the property across all instances of the class within the same application domain.
 */

public class Circle
{
    public static double Radius { get; set; } = 1.1;
}