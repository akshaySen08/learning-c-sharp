
string fullName = "Akshay Sen ";
string role = "Full Stack Developer";
int yearsOfExperience = 6;
bool wantsBackendRole = true;
string currentLearning = ".Net Core";

Console.WriteLine("===== Developer Profile =====");
Console.WriteLine($"Name: {fullName}");
Console.WriteLine($"Role: {role}");
Console.WriteLine($"Experience: {yearsOfExperience} years");
Console.WriteLine($"Currently Learning: {currentLearning}");
Console.WriteLine($"Interested in Backend Role: {wantsBackendRole}");


Console.WriteLine("===== Readline =====");
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();

Console.WriteLine("What role you are targeting?");
string? role2 = Console.ReadLine();

Console.WriteLine($"hello my name is {name} and I am looking for {role2}");


Console.WriteLine("===== Conditionals =====");
string? input = Console.ReadLine();
int years = Convert.ToInt32(input);

if (years >= 6)
{
    Console.WriteLine("You are ready for senior full-stack roles.");
}
else if (years >= 3)
{
    Console.WriteLine("You are ready for mid-level roles.");
}
else
{
    Console.WriteLine("Keep building projects and practicing.");
}

// Calling a function from other class
Console.WriteLine(Function.SayMyName(name));

ExpenseCalculator.UserExpCalc();