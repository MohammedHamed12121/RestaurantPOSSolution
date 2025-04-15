using SQLite;

namespace RestaurantPOSMaui.Data;

public class OrderItem
{
    public int Id { get; set; }
    public long OrderId { get; set; }
    public int ItemId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    [Ignore]
    public decimal Amount => Quantity * Price;
}