namespace RestaurantPOSMaui.Data;

public static class SeedData
{
    public static List<MenuCategory> GetMenuCategories()
    {
        return new List<MenuCategory>()
        {
            new MenuCategory { Id = 1, Name = "Beverages", Icon = "drink.png" },
            new MenuCategory { Id = 2, Name = "Appetizers", Icon = "appetizer.png" },
            new MenuCategory { Id = 3, Name = "Main Course", Icon = "main_course.png" },
            new MenuCategory { Id = 4, Name = "Desserts", Icon = "dessert.png" },
            new MenuCategory { Id = 5, Name = "Salads", Icon = "salad.png" },
            new MenuCategory { Id = 6, Name = "Soups", Icon = "soup.png" },
            new MenuCategory { Id = 7, Name = "Pasta", Icon = "pasta.png" },
            new MenuCategory { Id = 8, Name = "Pizza", Icon = "pizza.png" },
            new MenuCategory { Id = 9, Name = "Grill", Icon = "grill.png" },
            new MenuCategory { Id = 10, Name = "Seafood", Icon = "seafood.png" },
            new MenuCategory { Id = 11, Name = "Vegan", Icon = "vegan.png" },
            new MenuCategory { Id = 12, Name = "Kids Menu", Icon = "kids_menu.png" }
        };
    }

    public static List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Orange Power Drink", Description = "Power drink made from oranges", Price = 10.99m, Icon = "orange_drink.png" },
            new MenuItem { Id = 2, Name = "Lemonade", Description = "Freshly squeezed lemonade", Price = 4.50m, Icon = "lemonade.png" },
            new MenuItem { Id = 3, Name = "Espresso", Description = "Strong Italian-style coffee", Price = 3.25m, Icon = "espresso.png" },

            new MenuItem { Id = 4, Name = "Chicken Wings", Description = "Spicy buffalo wings", Price = 7.99m, Icon = "chicken_wings.png" },
            new MenuItem { Id = 5, Name = "Mozzarella Sticks", Description = "Crispy cheese sticks", Price = 6.49m, Icon = "mozzarella_sticks.png" },

            new MenuItem { Id = 6, Name = "Grilled Steak", Description = "Juicy grilled steak", Price = 19.99m, Icon = "grilled_steak.png" },
            new MenuItem { Id = 7, Name = "Roasted Chicken", Description = "Herb roasted chicken", Price = 14.99m, Icon = "roasted_chicken.png" },

            new MenuItem { Id = 8, Name = "Chocolate Cake", Description = "Rich chocolate layer cake", Price = 5.75m, Icon = "chocolate_cake.png" },
            new MenuItem { Id = 9, Name = "Fruit Tart", Description = "Tart with fresh fruits", Price = 5.50m, Icon = "fruit_tart.png" },

            new MenuItem { Id = 10, Name = "Caesar Salad", Description = "Classic Caesar with dressing", Price = 6.25m, Icon = "caesar_salad.png" },
            new MenuItem { Id = 11, Name = "Greek Salad", Description = "Fresh salad with feta and olives", Price = 6.75m, Icon = "greek_salad.png" },

            new MenuItem { Id = 12, Name = "Tomato Soup", Description = "Creamy tomato basil soup", Price = 4.99m, Icon = "tomato_soup.png" },
            new MenuItem { Id = 13, Name = "Mushroom Soup", Description = "Cream of mushroom soup", Price = 5.25m, Icon = "mushroom_soup.png" },

            new MenuItem { Id = 14, Name = "Spaghetti Bolognese", Description = "Spaghetti with meat sauce", Price = 12.50m, Icon = "spaghetti_bolognese.png" },
            new MenuItem { Id = 15, Name = "Fettuccine Alfredo", Description = "Pasta with Alfredo sauce", Price = 11.99m, Icon = "fettuccine_alfredo.png" },

            new MenuItem { Id = 16, Name = "Margherita Pizza", Description = "Classic cheese and tomato pizza", Price = 9.99m, Icon = "margherita_pizza.png" },
            new MenuItem { Id = 17, Name = "Pepperoni Pizza", Description = "Pepperoni and cheese pizza", Price = 10.99m, Icon = "pepperoni_pizza.png" },

            new MenuItem { Id = 18, Name = "BBQ Ribs", Description = "Slow-cooked barbecue ribs", Price = 17.99m, Icon = "bbq_ribs.png" },
            new MenuItem { Id = 19, Name = "Grilled Lamb Chops", Description = "Tender lamb chops", Price = 21.99m, Icon = "lamb_chops.png" },

            new MenuItem { Id = 20, Name = "Grilled Salmon", Description = "Salmon with lemon butter", Price = 18.50m, Icon = "grilled_salmon.png" },
            new MenuItem { Id = 21, Name = "Shrimp Cocktail", Description = "Chilled shrimp with cocktail sauce", Price = 9.50m, Icon = "shrimp_cocktail.png" },

            new MenuItem { Id = 22, Name = "Vegan Burger", Description = "Plant-based burger with avocado", Price = 10.25m, Icon = "vegan_burger.png" },
            new MenuItem { Id = 23, Name = "Tofu Stir Fry", Description = "Tofu with vegetables and soy glaze", Price = 9.75m, Icon = "tofu_stirfry.png" },

            new MenuItem { Id = 24, Name = "Mini Pancakes", Description = "Mini pancakes with syrup", Price = 4.99m, Icon = "mini_pancakes.png" },
            new MenuItem { Id = 25, Name = "Chicken Nuggets", Description = "Crispy nuggets for kids", Price = 5.25m, Icon = "chicken_nuggets.png" },

            new MenuItem { Id = 26, Name = "Iced Tea", Description = "Chilled iced tea", Price = 3.50m, Icon = "iced_tea.png" },
            new MenuItem { Id = 27, Name = "Cappuccino", Description = "Coffee with frothed milk", Price = 3.75m, Icon = "cappuccino.png" },

            new MenuItem { Id = 28, Name = "Garlic Bread", Description = "Toasted bread with garlic", Price = 4.25m, Icon = "garlic_bread.png" },
            new MenuItem { Id = 29, Name = "Bruschetta", Description = "Toasted bread with tomato topping", Price = 5.25m, Icon = "bruschetta.png" },
            new MenuItem { Id = 30, Name = "Stuffed Mushrooms", Description = "Mushrooms stuffed with cheese", Price = 6.00m, Icon = "stuffed_mushrooms.png" },

            new MenuItem { Id = 31, Name = "Lasagna", Description = "Layered pasta with meat and cheese", Price = 13.50m, Icon = "lasagna.png" },
            new MenuItem { Id = 32, Name = "Mac & Cheese", Description = "Cheesy macaroni", Price = 8.99m, Icon = "mac_cheese.png" },
            new MenuItem { Id = 33, Name = "Vegetarian Pizza", Description = "Pizza with assorted veggies", Price = 10.25m, Icon = "veg_pizza.png" },
            new MenuItem { Id = 34, Name = "Prawn Pasta", Description = "Pasta with prawns in garlic sauce", Price = 14.50m, Icon = "prawn_pasta.png" },
            new MenuItem { Id = 35, Name = "Beef Stroganoff", Description = "Beef in creamy mushroom sauce", Price = 15.99m, Icon = "beef_stroganoff.png" },

            new MenuItem { Id = 36, Name = "Cheesecake", Description = "Classic New York cheesecake", Price = 6.25m, Icon = "cheesecake.png" },
            new MenuItem { Id = 37, Name = "Ice Cream Sundae", Description = "Vanilla ice cream with toppings", Price = 5.99m, Icon = "ice_cream_sundae.png" },

            new MenuItem { Id = 38, Name = "Caprese Salad", Description = "Tomato, mozzarella & basil", Price = 6.99m, Icon = "caprese_salad.png" },
            new MenuItem { Id = 39, Name = "French Onion Soup", Description = "Soup with caramelized onions", Price = 5.99m, Icon = "french_onion_soup.png" },

            new MenuItem { Id = 40, Name = "Green Smoothie", Description = "Spinach, apple & banana", Price = 6.50m, Icon = "green_smoothie.png" },
            new MenuItem { Id = 41, Name = "Carrot Juice", Description = "Fresh carrot juice", Price = 4.99m, Icon = "carrot_juice.png" },

            new MenuItem { Id = 42, Name = "Pumpkin Soup", Description = "Creamy pumpkin soup", Price = 5.25m, Icon = "pumpkin_soup.png" },
            new MenuItem { Id = 43, Name = "Veggie Wrap", Description = "Wrap with grilled veggies", Price = 8.50m, Icon = "veggie_wrap.png" },

            new MenuItem { Id = 44, Name = "Club Sandwich", Description = "Triple-layer sandwich with chicken", Price = 9.75m, Icon = "club_sandwich.png" },
            new MenuItem { Id = 45, Name = "Fish and Chips", Description = "Crispy fish with fries", Price = 11.50m, Icon = "fish_chips.png" },

            new MenuItem { Id = 46, Name = "Tuna Salad", Description = "Fresh tuna with greens", Price = 7.50m, Icon = "tuna_salad.png" },
            new MenuItem { Id = 47, Name = "Choco Lava Cake", Description = "Cake with molten center", Price = 6.75m, Icon = "lava_cake.png" },
            new MenuItem { Id = 48, Name = "Apple Pie", Description = "Classic apple pie slice", Price = 5.50m, Icon = "apple_pie.png" },

            new MenuItem { Id = 49, Name = "Kids Spaghetti", Description = "Small serving of pasta for kids", Price = 5.99m, Icon = "kids_spaghetti.png" },
            new MenuItem { Id = 50, Name = "Milkshake", Description = "Vanilla milkshake with cream", Price = 4.75m, Icon = "milkshake.png" }
        };
    }


    public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
    {
        return new List<MenuItemCategoryMapping>
        {
            new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 1 }, 
            new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 2 }, 
            new MenuItemCategoryMapping { MenuCategoryId = 1, MenuItemId = 3 }, 

            new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 4 }, 
            new MenuItemCategoryMapping { MenuCategoryId = 2, MenuItemId = 5 }, 

            new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 6 }, 
            new MenuItemCategoryMapping { MenuCategoryId = 3, MenuItemId = 7 }, 

            new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 8 }, 
            new MenuItemCategoryMapping { MenuCategoryId = 4, MenuItemId = 9 }, 

            new MenuItemCategoryMapping { MenuCategoryId = 5, MenuItemId = 10 },
            new MenuItemCategoryMapping { MenuCategoryId = 5, MenuItemId = 11 },

            new MenuItemCategoryMapping { MenuCategoryId = 6, MenuItemId = 12 },
            new MenuItemCategoryMapping { MenuCategoryId = 6, MenuItemId = 13 },

            new MenuItemCategoryMapping { MenuCategoryId = 7, MenuItemId = 14 },
            new MenuItemCategoryMapping { MenuCategoryId = 7, MenuItemId = 15 },

            new MenuItemCategoryMapping { MenuCategoryId = 8, MenuItemId = 16 },
            new MenuItemCategoryMapping { MenuCategoryId = 8, MenuItemId = 17 },

            new MenuItemCategoryMapping { MenuCategoryId = 9, MenuItemId = 18 },
            new MenuItemCategoryMapping { MenuCategoryId = 9, MenuItemId = 19 },

            new MenuItemCategoryMapping { MenuCategoryId = 10, MenuItemId = 20 },
            new MenuItemCategoryMapping { MenuCategoryId = 10, MenuItemId = 21 },
            new MenuItemCategoryMapping { MenuCategoryId = 11, MenuItemId = 22 },
            new MenuItemCategoryMapping { MenuCategoryId = 11, MenuItemId = 23 },
            new MenuItemCategoryMapping { MenuCategoryId = 12, MenuItemId = 24 },
            new MenuItemCategoryMapping { MenuCategoryId = 12, MenuItemId = 25 },
            new MenuItemCategoryMapping { MenuCategoryId = 12, MenuItemId = 49 }
        };
    }

}
