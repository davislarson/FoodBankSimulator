namespace Mission3FoodBank;

public class Menu
{
    public FoodItem AddFoodItem()
    {
        Console.WriteLine("What is the name of the food item?");
        string name = Console.ReadLine();
        
        Console.WriteLine("What is the category of the food item?");
        string category = Console.ReadLine();
        
        Console.WriteLine("How many of this food item?");
        int quantity;
        DateTime exipryDate;
        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
        {
            Console.WriteLine("What is the expiration date of this item? (e.g., 2025-01-21)");
            exipryDate = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter the number of this food item.");
        }
        FoodItem(name, category, quantity, exipryDate);
    }

    public void DeleteFoodItem()
    {
        
    }

    public void ShowMenu()
    {

    }
}