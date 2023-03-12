// Bonus Homework

#region BonusExercise

Console.WriteLine("Please select what you want ? (1.Check balance, 2. Withdraw money)");
bool resultInput = int.TryParse(Console.ReadLine(), out int userInput);
int balance = 10000;


while (true)
{

    if (resultInput)
    {

        if (userInput > 2)
        {
            Console.WriteLine("You entered wrong number. Please try again.");
        }
        if (userInput == 1)
        {
            Console.WriteLine($"You have {balance}$ on your account");

        }
        if (userInput == 2)
        {
            Console.WriteLine("What amount of money do you need?");
            bool resultInput1 = int.TryParse(Console.ReadLine(), out int userInput1);
            int leftMoney = balance - userInput1;
            if (resultInput1)
            {
                if (userInput1 == 0)
                {
                    Console.WriteLine($"You cannot withdraw {userInput1}$ money.");
                }
                else if (userInput1 < balance)
                {
                    Console.WriteLine($"You have successfully withdrawn {userInput1}$ and you left {leftMoney}$ on your account");
                }

                else if (userInput1 > balance)
                {
                    Console.WriteLine($"You cannot withdraw {userInput1}$ because your balance is {balance}$. Please try again with appropriate amount!");
                }
                else
                {
                    Console.WriteLine("You entered wrong amount. Please try again!");
                }
            }
            else
            {
                Console.WriteLine("You entered wrong amount. Please try again!");
            }
        }

    }
    else
    {
        Console.WriteLine("Please enter number!");
    }

    Console.WriteLine("Do you want to run the program again? (Y/N)");
    string answer = Console.ReadLine();

    if (answer.ToUpper() == "Y")
    {
        continue;
    }
    else if (answer.ToUpper() == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("You entered wrong letter. Please try again!");
    };
}

#endregion
