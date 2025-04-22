using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Assignment_4;
using Microsoft.VisualBasic;


//ASYNC............................................................................................................................
Async test = new Async();

Console.WriteLine("Collecting Info..");

// Start all tasks in parallel
Task<string> nameTask = test.GetUserNameAsync();
Task<int> ageTask = test.GetUserAgeAsync();
Task<string> locationTask = test.GetUserLocationAsync();

// Wait for all tasks to finish
await Task.WhenAll(nameTask, ageTask, locationTask);

await Task.Delay(2000);
Console.WriteLine("Information Complete\nBuilding profile.....");
Console.WriteLine();

// Now use the results in a new task
string name = await nameTask;
int age = await ageTask;
string location = await locationTask;

// Use result in a follow-up task
string profile = await test.BuildProfileAsync(name, age, location);

Console.WriteLine(profile);
Console.WriteLine();


//DELEGATION .....................................................................................................

//Simple Delegation 
delegate_methods del = new delegate_methods();


delegation input = del.LogInputs;

input(20, 10);
Console.WriteLine();

//Action
Action<double> display = del.DisplayResult;
display(200);
Console.WriteLine();

//Function
Func<double,double,double> add = del.Add;
double result1 = add(780, 140);
Console.WriteLine(result1);
Console.WriteLine();
try
{
    Func<double, double, double> sub = del.Subtract;
    double result2 = sub(2, 24);
    Console.WriteLine(result2);
}
catch (InvalidOperationException ex)
{ Console.WriteLine(ex.Message); }
Console.WriteLine();

//Predicate
Predicate<double> pred = del.IsPositive;

bool tan = pred(-50);

if (tan == true)
{
    Console.WriteLine("Its a Positive number");
}
else
{
    Console.WriteLine("Its a Negative number");
}
Console.WriteLine();

  //anothher thing you can do with predicate
List<double> numbers = new List<double>() { 2, 0, -5, 4, -8, 9 };

List<double> positiveNumbers = new List<double>(numbers.FindAll(pred));
Console.WriteLine("List of Positive numbers");
foreach (double number in positiveNumbers)
    { Console.WriteLine(number); }

Console.WriteLine();










Console.ReadKey();
