// Introduce the program

using Mission3FoodBank;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Food Bank Inventory System!\n");

        Console.WriteLine("Here are the valid actions:");
        Console.WriteLine("1) Add food item");
        Console.WriteLine("2) Delete food item");
        Console.WriteLine("3) See all current food items");
        Console.WriteLine("4) Exit Program\n");

        bool exit = false;
        int choice = 0;
        Menu menu = new Menu();
        

        List<FoodItem> foodList = new List<FoodItem>();

        while (exit == false)
        {
            try
            {
                Console.WriteLine("What you you like to do?");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("That is an invalid choice.");
                Console.WriteLine(e.Message + "\n");
                continue;
            }
// Make sure the choice is a valid action
            if (choice >= 1 && choice <= 4)
            {
                if (choice == 1)
                {
                    foodList.Add(menu.AddFoodItem());
                }
                else if (choice == 2)
                {
                    menu.DeleteFoodItem();
                }
                else if (choice == 3)
                {
                    menu.ShowMenu();
                }
                else
                {
                    exit = true;
                }
            }
            else
            {
                Console.WriteLine("That's not a valid choice. Choose a number from 1 to 4.\n");
            }
        }
        
        Console.WriteLine("Exiting the program. Thank you for using the Food Bank Inventory System!\n");
    }

    
}
