namespace Mission3FoodBank;

public class Menu
{
    public FoodItem AddFoodItem()
    {
        string name = "";
        string category = "";
        int quantity = 0;
        DateTime expiryDate = new DateTime();
        
        Console.WriteLine("What is the name of the food item?");
        name = Console.ReadLine();
        
        Console.WriteLine("What is the category of the food item?");
        category = Console.ReadLine();
        
        Console.WriteLine("How many units in this food item?");
        
        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
        {
            Console.WriteLine("What is the expiration date of this item? (e.g., 2025-01-21)");
            expiryDate = DateTime.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter the number of this food item.");
        }
        FoodItem food = new FoodItem(name, category, quantity, expiryDate);
        
        return food;
    } 

    public void DeleteFoodItem(List<FoodItem> foodList)
    {
        int remove = 0;
        Console.WriteLine("Here are all the food items: ");
        int iterator = 1;
        foreach (FoodItem item in foodList)
        {
            Console.WriteLine(iterator + ": Name: " + item.Name);
            Console.WriteLine("Category: " + item.Category);
            Console.WriteLine("Quantity: " + item.Quantity);
            Console.WriteLine("Expiry Date: " + item.ExpiryDate.ToShortDateString());
            Console.WriteLine("-----------------------------------");
            iterator++;
        }
        Console.WriteLine("Which food item would you like to delete? (Enter the number)");
        remove = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(foodList[remove - 1].Name + " has been removed.");
        foodList.Remove(foodList[remove - 1]);
        
    }

    public void ShowMenu(List<FoodItem> foodList)
    {
        int iterator = 1;
        Console.WriteLine("Here are all the food items:\n");
        
        foreach (FoodItem item in foodList)
        {
            Console.WriteLine(iterator + ": Name: " + item.Name);
            Console.WriteLine("Category: " + item.Category);
            Console.WriteLine("Quantity: " + item.Quantity);
            Console.WriteLine("Expiry Date: " + item.ExpiryDate.ToShortDateString());
            Console.WriteLine("-----------------------------------");
            iterator++;
        }
        Console.WriteLine();
    }
}