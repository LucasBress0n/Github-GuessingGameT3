// Phase 1
// The program should...

// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

Console.WriteLine(
    @"
Wanna play a game?
Guess the secret number:"
);



// The program should be updated to...

int secretNumber = 42;
int countChance=0;
while(countChance!=4)
{
    int userInput = int.Parse(Console.ReadLine()!.Trim());

// Console.WriteLine($"You guessed: {userInput}");
    if (userInput == secretNumber)
    {
        Console.WriteLine("You guessed it right!!");
        countChance=4;
    }
    else
    {
        Console.WriteLine("You guessed WRONG....guess again:");
        countChance++;
        // secretNumber=int.Parse(Console.ReadLine());
    }
}

// The program should be updated to...


// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2