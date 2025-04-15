using SQLite;

namespace RestaurantPOSMaui.Data;

public class DatabaseServices : IAsyncDisposable
{
    private readonly SQLiteAsyncConnection _connection;
    public DatabaseServices()
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "restPos.db");

        _connection = new SQLiteAsyncConnection(dbPath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);
    }

    public async Task InitializeDatabaseAsync()
    {
        await _connection.CreateTableAsync<MenuCategory>();
        await _connection.CreateTableAsync<MenuItem>();
        await _connection.CreateTableAsync<Order>();
        await _connection.CreateTableAsync<MenuItemCategoryMapping>();
        await _connection.CreateTableAsync<OrderItem>();
    }

    public async Task SeedDataAsync()
    {
        var firstcategory = await _connection.Table<MenuCategory>().FirstOrDefaultAsync();
        if (firstcategory != null) 
            return;

        List<MenuCategory> categories = SeedData.GetMenuCategories();
        List<MenuItem> MenuItems = SeedData.GetMenuItems();
        List<MenuItemCategoryMapping> Mappings = SeedData.GetMenuItemCategoryMappings();

        await _connection.InsertAllAsync(categories);
        await _connection.InsertAllAsync(MenuItems);
        await _connection.InsertAllAsync(Mappings);
    }

    public async ValueTask DisposeAsync()
    {
        if (_connection != null)
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<MenuCategory[]> GetMenuItemsCategoryAsync() => await _connection.Table<MenuCategory>().ToArrayAsync();

    public async Task<MenuItem[]> GetMenuItemByCategoryAsync(int categoryId)
    {
        var query = @"
                SELECT menu.*
                FROM MenuItem AS menu
                INNER JOIN MenuItemCategoryMapping AS mapping
                    ON menu.Id = mapping.MenuItemId
                WHERE mapping.MenuCategoryId = ?
                ";

        var menuItem = await _connection.QueryAsync<MenuItem>(query, categoryId);
        return [.. menuItem];
    }
}
