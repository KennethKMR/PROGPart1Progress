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
                recipe.OriginalQuantities = new double[numIngredients]; //Initialize ingredients array with specified size

                //Loop to input details for each ingredient
            for (int i= 0; i < numIngredients; i++)
                {
                    Ingredient ingredient = new Ingredient(); //Create a new ingredient object

                    //Prompt the user to enter the name of the ingredient
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    ingredient.Name = Console.ReadLine();

                    //Loop put in place to ensure valid input for quantity
                    double quantity;
                    string quantityInput;
                    do
                    {
                        Console.WriteLine($"Enter the quantity of {ingredient.Name}:");
                        quantityInput = Console.ReadLine();
                    } while (!double.TryParse(quantityInput, out quantity) || quantity <= 0);

                    ingredient.Quantity = quantity; //Set quantity of the ingredient
                    recipe.OriginalQuantities[i] = quantity; //Store original quantity

                }
            }

        }
    }
}
