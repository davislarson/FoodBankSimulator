using System.Runtime.InteropServices.JavaScript;

namespace Mission3FoodBank;

public class FoodItem
{
    // Constructor for the foodItem
    public string Name {get; set;}
    public string Category {get; set;}
    public int Quantity {get; set;}
    public DateTime ExpiryDate {get; set;}

    public FoodItem(string name, string category, int quantity, DateTime expiryDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpiryDate = expiryDate;
    }
}