// Task 2

#region StudentGroup

string[] studentsG1 = new string[] { "John", "Kim", "Harry", "Donald", "Tim" };
string[] studentsG2 = new string[] { "Dan", "Alen", "Toby", "Darren", "Mike" };

Console.WriteLine("Enter student group: (there are 1 and 2)");
bool resultInput = int.TryParse(Console.ReadLine(), out int userInput);


if (resultInput)
{
    if (userInput == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);

        }
    }

    if (userInput == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
}
else
{
    Console.WriteLine("You write wrong number");
}

#endregion