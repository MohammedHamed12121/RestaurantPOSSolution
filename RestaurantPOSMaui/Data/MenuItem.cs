using SQLite;

namespace RestaurantPOSMaui.Data;

public class MenuItem
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
