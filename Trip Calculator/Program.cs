/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 02, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

//Part One: Road Trip
Console.WriteLine("=== Part 1: Road Trip ===");

//Questions
Console.Write("Round trip miles: ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations
double gallonsNeeded = tripMiles / milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print The Calculations
Console.WriteLine(" ");

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine(" ");

//Part Two: Pizza Party
Console.WriteLine("=== Part 2: Pizza Party ===");

//Questions
Console.Write("How many people are going: ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
double numberPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

//Constant
const int pizzaSlices = 8;

//Calculations
double totalSlices = numberPizzas * pizzaSlices;
double personSlices = totalSlices / peopleGoing;
double pizzaCost = numberPizzas * pizzaPrice;

//Print The Calculations
Console.WriteLine(" ");

Console.WriteLine("Total slices: " + totalSlices.ToString("F0"));
Console.WriteLine("Slices per person: " + personSlices.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine(" ");

//Part Three: Paycheck
Console.WriteLine("=== Part 3: PayCheck ===");
//Questions
Console.Write("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Hourly rate: ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

//Constant
const double taxRate = 0.18;

//Calculations
double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

//Print The Calculations
Console.WriteLine(" ");

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine(" ");

//Part Four: The Whole Trip
Console.WriteLine("=== Part 4: The Whole Trip ===");

//Calculations
double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

//Print The Calculations
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursYouMustWork.ToString("F2"));