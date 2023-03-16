// Homework with all Tasks from 1 to 4 in one project

// Task 1
//Take one string from the input and print its last 5 characters.
// =====================================================================

//Console.WriteLine("Please input a word bigger than 5 characters");
//string userInput = Console.ReadLine();

//if (userInput.Length >= 5)
//{
//    string printLastFiveCharacters = userInput.Substring(userInput.Length - 5);

//    Console.WriteLine($"The last 5 characters from the input is: {printLastFiveCharacters} ");

//}
//else if (userInput.Length <= 5)
//{
//    Console.WriteLine("You entered word smaller than 5");
//}
//else
//{
//    Console.WriteLine("Oops! Something went wrong.");
//}


// Task 2 
// Take a sentence as input and print its words.
// =====================================================================
//Console.WriteLine("Please insert a sentence");
//string sentenceInput = Console.ReadLine();

//string[] splittedString = sentenceInput.Split(" ");
//for (int i = 0; i < splittedString.Length; i++)
//{
//    Console.WriteLine(splittedString[i]);
//}


//Task 3
//Create a function that takes a number as input.
//This method should return the sum of the digits in the number
// =====================================================================
//Console.WriteLine("Enter a number: ");
//bool resultInput1 = int.TryParse(Console.ReadLine(), out int userInput1);

//if (resultInput1)
//{
//    int sumOfDigitsFromInput = SumOfDigits(userInput1);
//    Console.WriteLine($"The sum of the digits of the number {userInput1} is {sumOfDigitsFromInput}");
//}
//else
//{
//    Console.WriteLine("Please insert number");
//}

//int SumOfDigits(int number)
//{
//    int digitSum = 0;

//    while (number > 0)
//    {
//        int currentDigit = number % 10;
//        digitSum += currentDigit;
//        number /= 10;
//    }

//    return digitSum;

//}


// Task 4 
// Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
// =====================================================================
//Console.WriteLine("Enter your birthdate (yyyy-MM-dd):");
//DateTime birthDate = DateTime.Parse(Console.ReadLine());

//int AgeCalculator1(DateTime birthDate)
//{
//    DateTime currentDate = DateTime.Now;
//    int age = currentDate.Year - birthDate.Year;

//    if (currentDate < birthDate.AddYears(age))
//    {
//        age--;
//    }

//    return age;
//}


//int age = AgeCalculator1(birthDate);
//Console.WriteLine($"Your age is {age} years old.");
