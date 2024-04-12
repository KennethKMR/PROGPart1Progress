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

                    //Prompt user to enter the unit of measurement
                    Console.WriteLine($"Enter the unit of measurement for {ingredient.Name}:");
                    ingredient.Unit = Console.ReadLine();

                    recipe.Ingredients[i] = ingredient;
                }
                //Prompt the user to enter the number of steps
                Console.WriteLine("Enter the number of steps:");
                int numSteps;
            while (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
                {
                    Console.WriteLine("Try that again, make sure you are entering a positive number for the number of steps");
                }
                    recipe.Steps = new string[numSteps]; //Initialize Steps array with specified size
            
            //Loop to input details for each step
            for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    recipe.Steps[i] = Console.ReadLine();
                }
                //Display the recipe details
                Console.WriteLine("\nRecipe details:");
                Console.WriteLine($"Name: {recipe.Name}");

                Console.WriteLine("\nIngredients:");
            foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }

                Console.WriteLine("\nSteps");
            for (int i = 0;i < recipe.Steps.Length;i++)
                {
                    Console.WriteLine($"{i + 1}. {recipe.Steps[i]}");
                }
            }
        }
    }
}
