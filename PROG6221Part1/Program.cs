// See https://aka.ms/new-console-template for more information
namespace PROG6221Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            Console.WriteLine("Enter the name of the recipe: ");
            recipe.Name = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
        }
    }
}
