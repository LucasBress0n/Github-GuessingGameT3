using System.Collections;

int userDifficultyChoice = 0;
while (userDifficultyChoice == 0 || userDifficultyChoice > 5)
{
    Console.WriteLine(
        @"
    Wanna play a game? 
    pick your difficulty.

    1. Easy, guesses: 8
    2. Medium, guesses: 6
    3. Hard, guesses: 4
    4. CHEATER MODE: unlimited guesses
    5. Exit
    
    Pick a difficulty"
    );
    userDifficultyChoice = int.Parse(Console.ReadLine()!.Trim());
    switch (userDifficultyChoice)
    {
        case 1:
            game(8, false);
            break;
        case 2:
            game(6, false);
            break;
        case 3:
            game(4, false);
            break;
        case 4:
            game(5, true);
            break;    
    }
}




void game(int guessesNumber, bool isCheater)
{
    Console.WriteLine(
        @"
Guess the secret number between 1 and 100:"
    );
    int countChance = 0;
    Random random = new Random();

    int secretNumber = random.Next(1, 101);

    while (countChance != guessesNumber)
    {
        int userInput = int.Parse(Console.ReadLine()!.Trim());

        if (userInput == secretNumber)
        {
            Console.WriteLine("You guessed it right!!");
            countChance = guessesNumber;
        }
        else
        {
            if (userInput > secretNumber)
            {
                Console.WriteLine("Your guess is too high, guess lower");
            }
            else if (userInput < secretNumber)
            {
                Console.WriteLine("Your guess is too low, guess higher");
            }
            
            if(isCheater == false)
            {
                countChance++;
            Console.WriteLine(
                $@"You're on guess number: {countChance}. You have {guessesNumber - countChance} chances left!"
            );

            }
        }
    }
}



// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.
// Phase 8
