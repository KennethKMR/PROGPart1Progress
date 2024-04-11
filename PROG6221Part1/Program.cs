// See https://aka.ms/new-console-template for more information
namespace PROG6221Part1
{
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            //Prompt the user to enter the name of the recipe

            Recipe recipe = new Recipe();
            Console.WriteLine("Enter the name of the recipe: ");
            recipe.Name = Console.ReadLine();

            //Prompt the user to enter the number of ingredients

            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
        }
    }
}
