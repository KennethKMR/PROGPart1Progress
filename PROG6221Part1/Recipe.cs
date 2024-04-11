using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221Part1
{
   class Recipe
    {
        public string Name { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public string[] Steps { get; set; }

        public Recipe()
        {
            Ingredients = new Ingredient[0];
            Steps = new string[0]; 
        }
    }
}
