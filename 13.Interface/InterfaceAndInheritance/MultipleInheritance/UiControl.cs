namespace MultipleInheritance;

public class UiControl
{
    public string Id { get; set; } = default!;
    public Size Size { get; set; } = default!;
    public Position TopLeft { get; set; } = default!;

    public virtual void Draw()
    {

    }

    public void Focus()
    {
        Console.WriteLine("Received forus.");
    }
}

public class TextBox : UiControl, IDraggable, IDroppable
{
    public void Drag()
    {
        throw new NotImplementedException();
    }

    public void Drop()
    {
        throw new NotImplementedException();
    }
}