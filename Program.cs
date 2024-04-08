// Phase 4
// The program should be updated to...

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

Console.WriteLine(
    @"
Wanna play a game?
Guess the secret number:"
);

int secretNumber = 42;
int countChance = 0;
while (countChance != 4)
{
    int userInput = int.Parse(Console.ReadLine()!.Trim());

    if (userInput == secretNumber)
    {
        Console.WriteLine("You guessed it right!!");
        countChance = 4;
    }
    else
    {
        Console.WriteLine(
            @"You guessed WRONG....guess again:
        "
        );
        countChance++;
        Console.WriteLine(
            $@"You're on guess number: ({countChance} out of 4)
        "
        );
        // secretNumber=int.Parse(Console.ReadLine());
    }
}
