
Random dice = new();

Console.WriteLine("Welcome to Gambling with D'Arby!, what might your name be?");
string name = Console.ReadLine();
Console.WriteLine($"Ah, {name}, I see! Well, let's decide on a starting budget for you!");
int amount = dice.Next(0, 100000);
Console.WriteLine($"Well, it seems that you're starting budget will be ${amount}!");


// Loops until the user has no money left.
while (amount > 0)
{

    // Gives the user the option to select between two gambling games and uses a string user input to store the answer.
    Console.WriteLine("Now, are you willing to play a low-risk game or a high-risk game? Or type END if you want to end the game.");
    string answer = Console.ReadLine();

    // In the Low-risk game, a random number is assigned to a decimal variable, and the user guesses if the variable is an odd or even number, winning money if their answer is correct.
    if (answer == "Low-risk")
    {
        decimal lowRandNumb = dice.Next(1, 50);
        Console.WriteLine($"Safe choice, {name}! Now, are you willing to bet on odds or even? Answer in all-caps.");
        string answerTwo = Console.ReadLine();

        if (answerTwo == "ODDS")
        {
            Console.WriteLine("Okay, odds it is! Now, let's gamble.");

            if (lowRandNumb % 2 != 0)
            {
                amount += dice.Next(50, 250);
                Console.WriteLine($"Congrats, {name}! You won! Now you have ${amount}! Good boy!");
            }

            else if (lowRandNumb % 2 == 0)
            {
                amount -= dice.Next(50, 250);
                Console.WriteLine($"{name}... Man you just lost some money and now you have ${amount} left...");
            }
        }

        else if (answerTwo == "EVEN")
        {
            Console.WriteLine("Okay, evens it is! Now, let's gamble.");
            {
                if (lowRandNumb % 2 == 0)
                {
                    amount += dice.Next(50, 250);
                    Console.WriteLine($"Congrats, {name}! You won! Now you have ${amount}! Good boy!");
                }

                else if (lowRandNumb % 2 != 0)
                {
                    amount -= dice.Next(50, 250);
                    Console.WriteLine($"{name}... Man you just lost some money and now you have ${amount} left...");
                }
            }
        }


    }
    
    // Same as the low-risk game, except that the random number is multiplied and added by other random numbers, giving/depriving the user a higher amount of money if they correctly guess the answer rather than the low-risk game.
    else if (answer == "High-risk")
    {
        int highRiskNumber = dice.Next(1, 1000);
        Console.WriteLine("Okay, big boy, high-risk it is. Will you pick odds or evens? Write your answer in all-caps.");
        string answerThree = Console.ReadLine();

        if (answerThree == "ODDS")
        {
            Console.WriteLine("Okay, odds it is! Now, let's gamble.");
            decimal oddsnumber = highRiskNumber * dice.Next(1, 20) + dice.Next(20, 40);
            if (oddsnumber % 2 != 0)
            {
                amount += dice.Next(1000, 5000);
                Console.WriteLine($"DAMN {name} YOU JUST WON THE GAMBLE GOOD JOB, NOW YOU HAVE ${amount}");
            }

            else if (oddsnumber % 2 == 0)
            {
                amount -= dice.Next(1000, 5000);
                Console.WriteLine($"Well, well, well... {name}, you just lost the bet... Now you only have ${amount} left...");
            }

        }

        else if (answerThree == "EVEN")
        {
            Console.WriteLine("Okay, evens it is! Now, let's gamble.");
            decimal evenNumber = highRiskNumber * dice.Next(1, 20) + dice.Next(20, 40);
            if (evenNumber % 2 == 0)
            {
                amount += dice.Next(1000, 5000);
                Console.WriteLine($"DAMN {name} YOU JUST WON THE GAMBLE GOOD JOB YOU NOW HAVE ${amount}");
            }

            else if (evenNumber % 2 != 0)
            {
                amount -= dice.Next(1000, 5000);
                Console.WriteLine($"Well, well, well... {name}, you just lost the bet... Now you only have ${amount} left...");
            }

        }
    }

    // Command to allow the user to end the gambling session.
    else if (answer == "END")
    {
        Console.WriteLine($"Well, {name}, you finished with ${amount}! Good boy!");
        return;
    }

    else
    {
        Console.WriteLine("Sorry, but you haven't provided a valid answer. Please try again.");
    }
}

// Message in case the user loses all the money.
if (amount <= 0)
{
    Console.WriteLine($"Oh, my dear {name}... You just lost all your money and went bankrupt. Final amount: ${amount}.");
    return;
}
