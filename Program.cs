

Console.WriteLine(
    @"
Wanna play a game?
Guess the secret number between 1 and 100:"
);
int countChance = 0;

Random random = new Random();

int secretNumber = random.Next(1, 101);

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
            $@"You're on guess number: ({countChance}. You have {4 - countChance} chances left!");

        // secretNumber=int.Parse(Console.ReadLine());
    }
}

