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

string userInput = Console.ReadLine()!.Trim();

Console.WriteLine($"You guessed: {userInput}");
