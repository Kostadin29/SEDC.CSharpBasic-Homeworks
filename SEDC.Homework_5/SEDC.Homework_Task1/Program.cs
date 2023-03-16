// Task 1 from Class05 - Classes

using SEDC.Homework_Task1.models;

Console.WriteLine("Please insert your first name!");
string userFirstName = Console.ReadLine();
Console.WriteLine("Please insert your last name");
string userLastName = Console.ReadLine();
Console.WriteLine("Please insert your age!");
bool resultAge = int.TryParse(Console.ReadLine(), out int userAge);

if (resultAge)
{
    Human human = new Human()
    {
        FirstName = userFirstName,
        LastName = userLastName,
        Age = userAge
    };

    string result = human.GetPersonDetails();
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Oops! Something went wrong.");
}


