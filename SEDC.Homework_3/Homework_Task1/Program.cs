// Student Homeworks for Loops and Arrays

// Task 1
#region SumOfEven


int[] sumArrayNumbers = new int[6];

for (int i = 0; i < sumArrayNumbers.Length; i++)
{

    Console.Write($"Enter integer no.{i + 1}: ");
    sumArrayNumbers[i] = int.Parse(Console.ReadLine());
}

int oddsum = 0;
int evensum = 0;
foreach (int number in sumArrayNumbers)
{
    if (number % 2 == 0)
    {
        oddsum += number;
    }
    if (number % 2 == 1)
    {
        evensum += number;
    }

}

Console.WriteLine($"The result is: {oddsum}"); 
Console.WriteLine($"The result from even is: {evensum}"); // Bonus

#endregion
