namespace Pantry;

class Program
{
    static void Main()
    {
        Database.Ingredient.CreateConnection();
        Console.WriteLine("Yay!");
    }
}