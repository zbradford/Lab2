//Part One: Road Trip

//Questions
using System.Numerics;

Console.Write("How Many Miles For Your Trip? ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How Many Miles Per Gallon Can Your Car Go? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How Much Did You Pay For Gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations
double gallonsNeeded = tripMiles / milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print The Calculations

Console.WriteLine("Gallons Needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

//Part Two: Pizza Party

//Questions
Console.Write("How Many People Are Going? ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.Write("How Many Pizzas? ");
double numberPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("What Is The Price Per Pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

//Constant
const int pizzaSlices = 8;

//Calculations
double totalSlices = numberPizzas * pizzaSlices;
double personSlices = totalSlices / peopleGoing;
double pizzaCost = numberPizzas * pizzaPrice;

//Print The Calculations
Console.WriteLine("Total Slices: " + totalSlices.ToString("F0"));
Console.WriteLine("Slices Per Person: " + personSlices.ToString("F1"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

//Part Three: Paycheck

//Questions
Console.Write("How Many Hours Did You Work This Week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("What is Your Hourly Rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

//Constant
const double taxRate = 0.18;

//Calculations
double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

//Print The Calculations
Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax Withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take Home Pay: " + takeHomePay.ToString("C"));

//Part Four: The Whole Trip

//Calculations
double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

//Print TheCalculations