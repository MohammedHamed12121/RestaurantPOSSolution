using SQLite;

namespace RestaurantPOSMaui.Data;

public class MenuCategory
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}
