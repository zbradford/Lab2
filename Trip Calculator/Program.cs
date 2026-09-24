//Part One: Road Trip
//Questions
Console.Write("How Many Miles For Your Trip? ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How Many Miles Per Gallon Can Your Car Go? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How Much Did You Pay For Gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());
//Calc
double gallonsNeeded = tripMiles / milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print The Calculations
Console.WriteLine("Gallons Needed " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost " + fuelCost.ToString("C"));