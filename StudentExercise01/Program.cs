

using Newtonsoft.Json;
using StudentExercise01;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

string folderPath = @"..\..\..\StudentExerciseJson";
string filePath = folderPath + @"\dogJson.json";


Console.WriteLine("Please enter a dog name");
string dogName = Console.ReadLine();
Console.WriteLine("Please enter a dog age");
int dogAge = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a dog color");
string dogColor = Console.ReadLine();

Dog dog = new Dog() { Name = dogName, Age = dogAge, Color = dogColor };

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

string jsonDog = JsonConvert.SerializeObject(dog);

ReaderWriter.WriteFile(filePath, jsonDog);

string jsonData = ReaderWriter.ReadFile(filePath);
Dog deserializedDog = JsonConvert.DeserializeObject<Dog>(jsonData);
Console.WriteLine(deserializedDog.Name + " " + deserializedDog.Age + " " + deserializedDog.Color);