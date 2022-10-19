using System;

Console.WriteLine("Hello, World!");

//Percent makeup of starting sample
Steel startersteel = new Steel();
startersteel.Chromium = 0.1479;
startersteel.Nickel = 0.02;
startersteel.Molybdenum = 0.005;
startersteel.Carbon = 0.0001;
startersteel.Manganese = 0.01;
startersteel.Phosphorus = 0.0003;
startersteel.Sulfur = 0.0002;
startersteel.Silicon = 0.006;
startersteel.Nitrogen = 0.0005;
startersteel.Iron = 0.81;

//Percent makeup of goal product
Steel finalsteel = new Steel();
finalsteel.Chromium = 0.17;
finalsteel.Nickel = 0.12;
finalsteel.Molybdenum = 0.025;
finalsteel.Carbon = 0.0008;
finalsteel.Manganese = 0.02;
finalsteel.Phosphorus = 0.0005;
finalsteel.Sulfur = 0.0003;
finalsteel.Silicon = 0.0075;
finalsteel.Nitrogen = 0.001;
finalsteel.Iron = 0.6549;

//User inputs current weight of product
Console.WriteLine("Insert the current weight of materials in grams: ");
double weight = Convert.ToDouble(Console.ReadLine());

//Get percent difference of starting from final
Steel differencesteel = GetDifference(startersteel, finalsteel);

//Find minimum difference to add to all elements
double change = GetChange(differencesteel);

//Find amount in grams to add to each element
Steel addsteel = AddElements(differencesteel, change, weight);

//Calculate how many grams the final product will weigh
double finalweight = GetFinalWeight(addsteel, weight);

//Display to amounts needed to add and final weight of sample to user
FinalMenu(addsteel, finalweight);

//Sums grams being added with starting weight
static double GetFinalWeight(Steel addsteel, double weight)
{
    double chromium = addsteel.Chromium;
    double nickel = addsteel.Nickel;
    double molybdenum = addsteel.Molybdenum;
    double carbon = addsteel.Carbon;
    double manganese = addsteel.Manganese;
    double phosphorus = addsteel.Phosphorus;
    double sulfur = addsteel.Sulfur;
    double silicon = addsteel.Silicon;
    double nitrogen = addsteel.Nitrogen;
    double iron = addsteel.Iron;

    double[] elements = {chromium, nickel, molybdenum, carbon, manganese, phosphorus, sulfur, silicon, nitrogen, iron};

    double finalweight = elements.Sum() + weight;

    return finalweight;
}

//Using the difference percentage, adding the change percent, and multiplying by current weight to get grams to add
static Steel AddElements(Steel differencesteel, double change, double weight)
{
    Steel addsteel = new Steel();
    addsteel.Chromium = (differencesteel.Chromium + change) * weight;
    addsteel.Nickel = (differencesteel.Nickel + change) * weight;
    addsteel.Molybdenum = (differencesteel.Molybdenum + change) * weight;
    addsteel.Carbon = (differencesteel.Carbon + change) * weight;
    addsteel.Manganese = (differencesteel.Manganese + change) * weight;
    addsteel.Phosphorus = (differencesteel.Phosphorus + change) * weight;
    addsteel.Sulfur = (differencesteel.Sulfur + change) * weight;
    addsteel.Silicon = (differencesteel.Silicon + change) * weight;
    addsteel.Nitrogen = (differencesteel.Nitrogen + change) * weight;
    addsteel.Iron = (differencesteel.Iron + change) * weight;

    return addsteel;
}

//Subtracting starting steel compostition from final to get difference for each element
static Steel GetDifference(Steel startersteel, Steel finalsteel)
{
    Steel differencesteel = new Steel();
    differencesteel.Chromium = finalsteel.Chromium - startersteel.Chromium;
    differencesteel.Nickel = finalsteel.Nickel - startersteel.Nickel;
    differencesteel.Molybdenum = finalsteel.Molybdenum - startersteel.Molybdenum;
    differencesteel.Carbon = finalsteel.Carbon - startersteel.Carbon;
    differencesteel.Manganese = finalsteel.Manganese - startersteel.Manganese;
    differencesteel.Phosphorus = finalsteel.Phosphorus - startersteel.Phosphorus;
    differencesteel.Sulfur = finalsteel.Sulfur - startersteel.Sulfur;
    differencesteel.Silicon = finalsteel.Silicon - startersteel.Silicon;
    differencesteel.Nitrogen = finalsteel.Nitrogen - startersteel.Nitrogen;
    differencesteel.Iron = finalsteel.Iron - startersteel.Iron;

    return differencesteel;
}

//Finding minimum value of differences to add to all elements
static double GetChange(Steel differencesteel)
{
    double chromium = differencesteel.Chromium;
    double nickel = differencesteel.Nickel;
    double molybdenum = differencesteel.Molybdenum;
    double carbon = differencesteel.Carbon;
    double manganese = differencesteel.Manganese;
    double phosphorus = differencesteel.Phosphorus;
    double sulfur = differencesteel.Sulfur;
    double silicon = differencesteel.Silicon;
    double nitrogen = differencesteel.Nitrogen;
    double iron = differencesteel.Iron;

    double[] elements = {chromium, nickel, molybdenum, carbon, manganese, phosphorus, sulfur, silicon, nitrogen, iron};

    double change = elements.Min();

    return System.Math.Abs(change);
}

//Displays amounts to add and the total expected weight to the user
static void FinalMenu(Steel addsteel, double weight)
{
    Console.WriteLine("Elements to Add:");
    Console.WriteLine("Chromium: " + Math.Round(addsteel.Chromium, 2) + " grams");
    Console.WriteLine("Nickel: " + Math.Round(addsteel.Nickel, 2) + " grams");
    Console.WriteLine("Molybdenum: " + Math.Round(addsteel.Molybdenum, 2) + " grams");
    Console.WriteLine("Carbon: " + Math.Round(addsteel.Carbon, 2) + " grams");
    Console.WriteLine("Manganese: " + Math.Round(addsteel.Manganese, 2) + " grams");
    Console.WriteLine("Phosphorus: " + Math.Round(addsteel.Phosphorus, 2) + " grams");
    Console.WriteLine("Sulfur: " + Math.Round(addsteel.Sulfur, 2) + " grams");
    Console.WriteLine("Silicon: " + Math.Round(addsteel.Silicon, 2) + " grams");
    Console.WriteLine("Nitrogen: " + Math.Round(addsteel.Nitrogen, 2) + " grams");
    Console.WriteLine("Iron: " + Math.Round(addsteel.Iron, 2) + " grams");
    Console.WriteLine("Total Weight: " + Math.Round(weight, 2) + " grams");
}