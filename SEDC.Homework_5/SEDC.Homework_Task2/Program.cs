using SEDC.Homework_Task2.models;
using System.Diagnostics;


// Method RaceCars() 
void RaceCars(Car carOne, Car carTwo)
{

    if (carOne.CalculateSpeed(carOne.Driver) > carTwo.CalculateSpeed(carTwo.Driver))
    {
        Console.WriteLine($"In the race {carOne.Model} is the winner.It was driving with {carOne.Speed} km/h and the driver was {carOne.Driver.Name}. Congrats!");
    }
    else if (carOne.CalculateSpeed(carOne.Driver) < carTwo.CalculateSpeed(carTwo.Driver))
    {
        Console.WriteLine($"In the race {carTwo.Model} is the winner.It was driving with {carTwo.Speed} km / h and the driver was {carTwo.Driver.Name}. Congrats!");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }

}

// Make 4 car objects and 4 driver objects.
Car car1 = new Car("Toyota", 200);
Car car2 = new Car("Opel", 160);
Car car3 = new Car("Tesla", 260);
Car car4 = new Car("Mercedes", 220);

Driver driver1 = new Driver("Kostadin", 4);
Driver driver2 = new Driver("Antonio", 3);
Driver driver3 = new Driver("Rocky", 6);
Driver driver4 = new Driver("John", 5);


Car[] cars = new Car[] { car1, car2, car3, car4 };
Driver[] drivers = new Driver[] { driver1, driver2, driver3, driver4 };
bool endGame = true;

do
{

    Console.WriteLine($"Choose a car no.1:");
    Console.WriteLine($"1: {car1.Model}");
    Console.WriteLine($"2: {car2.Model}");
    Console.WriteLine($"3: {car3.Model}");
    Console.WriteLine($"4: {car4.Model}");
    //string choosingCarOne = Console.ReadLine();
    bool carOneChoosing = int.TryParse(Console.ReadLine(), out int carOneChoice);

    Console.WriteLine($"Choose a car no.2:");
    Console.WriteLine($"1: {car1.Model}");
    Console.WriteLine($"2: {car2.Model}");
    Console.WriteLine($"3: {car3.Model}");
    Console.WriteLine($"4: {car4.Model}");
    //string choosingCarTwo = Console.ReadLine();
    bool carTwoChoosing = int.TryParse(Console.ReadLine(), out int carTwoChoice);

    Console.WriteLine($"Choose driver:");
    Console.WriteLine($"1: {driver1.Name}");
    Console.WriteLine($"2: {driver2.Name}");
    Console.WriteLine($"3: {driver3.Name}");
    Console.WriteLine($"4: {driver4.Name}");
    //string choosingDriverOne = Console.ReadLine();
    bool driverOneChoosing = int.TryParse(Console.ReadLine(), out int driverOneChoice);

    Console.WriteLine($"Choose driver:");
    Console.WriteLine($"1: {driver1.Name}");
    Console.WriteLine($"2: {driver2.Name}");
    Console.WriteLine($"3: {driver3.Name}");
    Console.WriteLine($"4: {driver4.Name}");
    //string choosingDriverTwo = Console.ReadLine();
    bool driverTwoChoosing = int.TryParse(Console.ReadLine(), out int driverTwoChoice);


    if (carOneChoosing && driverOneChoosing && carTwoChoosing && driverTwoChoosing)
    {

        Car firstSelectedCar = cars[carOneChoice - 1];
        Car secondSelectedCar = cars[carTwoChoice - 1];

        Driver firstSelectedDriver = drivers[driverOneChoice - 1];
        Driver secondSelectedDriver = drivers[driverTwoChoice - 1];

        firstSelectedCar.Driver = firstSelectedDriver;
        secondSelectedCar.Driver = secondSelectedDriver;

        RaceCars(firstSelectedCar, secondSelectedCar);

        Console.WriteLine("Do you want to play again! If not please enter n or N otherwise enter y or Y");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "n")
        {
            endGame = false;
        }


    }
    else
    {
        Console.WriteLine("You entered wrong input. Please select using numbers from 1-4");
    }

} while (endGame);

