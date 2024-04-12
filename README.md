Once the application is running, the first thing the user will be greeted with is the requirement to name the recipe, you can use text and numbers to make your recipes have a more unique name.
(Press enter you have added the data necessary for each question)
Next the user will be prompt to enter the number of ingredients for the recipe, this only allows for integer values.
Then, according to the amount of ingredients the user has entered, the user will be presented with "Enter the name of ingredient 1:", and this number will go up to the amount the user requires.
This is where the user enters the name of the ingredient, this also allows for text and numbers.
Next the user will be prompt to enter the quantity of that ingredient, this only allows for integer values, so if its something like a chicken, then say "2" and add the respective unit of measurement in the following prompt.
Now the user will be prompt to enter the unit of measurement, only string values allowed for this. You can add things like (kg,g,L,ml,Pieces,Slices,..etc).
Next the user will be prompted to enter the amount of steps in the recipe. Just like the "Enter the name of ingredient 1" prompt this promp will display "Enter step 1:" and the number will go up to the amount the user requires.
Each step will allow the user to enter a description for the steps in the recipe.
Then the entire recipe gets displayed to the user.
Next the user will be given the option to scale the recipe, if they wish to they will have to enter either "0,5", "2", or "3" to scale the recipe accordingly. However if they would want to skip it, the user could just press enter. Then the system will display "No scaling has been added to the recipe."
For this programme the system only takes the users input after the second try, but its a bit different for the "0,5" choice
If the user enters "0,5", the system passes it as the else factor, which would instruct the programme to display "No scaling has been added to the recipe."
But if the user enters "0.5" first, presses enter, and then enters "0,5" then it will scale the recipe by a half.
Its similar for the "2" and "3" option. For those other two options, the user just has to enter the value twice. So, the user has to enter "2", press enter, and then enter "2" again and press enter to scale, its the same for "3".
If the user has scaled the recipe, the new scaled values will be displayed to the user.
Now only if the use chose to scale the recipe, only then will they be presented by the following prompt.
The user will be prompt to select (Y or N) when asked if they would like to reset their scaled values back to the original values.
If the user selects Yes, their scaled values will be reset to the original.
If the user selects no then the next final prompt will pop up.
This promp either displays if the user has selected (N) when asked if they would like to scale the recipe, or this prompt will display once the users recipe has been scaled.
This promp allows the user to Reset the entire recipe and start a new recipe, they are prompted with a simple (Y / N).
If answered (Y) then the user will have the option to start from scractch with creating their recipe. This cycle can continue infinitely, because its a loop and will only end once the user chooses (N)
If answered (N) the user will be greeted with the text "I hope you enjoy your very own personal recipe."
And then the program will end.
