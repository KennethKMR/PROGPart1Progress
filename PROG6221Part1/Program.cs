// See https://aka.ms/new-console-template for more information
namespace PROG6221Part1
{
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            //Infinite loop that will continously add recipes
            while (true)
            {
                //Create a new recipe object
                Recipe recipe = new Recipe();

                //Prompt the user to enter the name of the recipe
                Console.WriteLine("Enter the name of the recipe: ");
                recipe.Name = Console.ReadLine();

                //Prompt the user to enter the number of ingredients

                Console.WriteLine("Enter the number of ingredients: ");
                int numIngredients = int.Parse(Console.ReadLine());

                //A loop that will continously ask the user to enter the correct value
                while (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <=0);
                {
                    Console.WriteLine("Try that again, make sure you are entering a positive number for the number of ingredients: ");
                }
                recipe.Ingredients = new Ingredient[numIngredients]; //Initialize ingredients array with specified size
                recipe.OriginalQuanitities = new double[numIngredients]; //Initialize ingredients array with specified size
            }
        }
    }
}
