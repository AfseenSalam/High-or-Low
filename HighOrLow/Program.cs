Console.WriteLine("==================================");
Console.WriteLine("High or Low -Conditional Exercise");
Console.WriteLine("==================================");

Random randomGenerator = new Random();  // Random class
int randomNumber = randomGenerator.Next(1,101); // generate random number starting with 1 to 100 excluding 101
bool IsValid = true;
int guessCount = 0;

Console.WriteLine("Enter your name:");

string? userName = Console.ReadLine();

while (IsValid)
{

    Console.WriteLine($"{userName} can you guess what the random number is (1 to 100):");
    if (int.TryParse(Console.ReadLine(), out int guess))     // Checking if it is integer or not
    {
        guessCount++;// store the number of guesses
        if (guess > randomNumber)
        {
            Console.WriteLine("the guess is higher than the random number");
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("the guess is lower than the random number");
        }
        else
        {
            Console.WriteLine($" the guess is correct,congratulations. you took {guessCount} to complete the challenge");
            IsValid = false;
        }

    }
    else
    {
        Console.WriteLine("Please enter a valid integer");
    }
}

