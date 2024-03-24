
namespace Fields_Properties.Models;

public class Train
{
    // This requires us to initialize the required field by an object initializer when creating an object.
    // If we cannot provide the when creating object we'll get an error:
    // "Required member 'Train.Id' must be set in the object initializer or attribute constructor."
    public required int Id;
}