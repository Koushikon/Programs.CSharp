namespace Testability.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime DatePlaced { get; set; }
    public Shipment Shipment { get; set; } = default!;
    public float TotalPrice { get; set; }

    public bool IsShipped
    {
        get { return Shipment != null; }
    }
}