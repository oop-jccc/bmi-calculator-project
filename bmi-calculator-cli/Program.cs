using bmi_calculator_core.Calculators;
using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Interpreters;
using bmi_calculator_core.Models;
using bmi_calculator_core.Strategies;

namespace bmi_calculator_cli;

internal static class Program
{
    private static void Main()
    {
        while (true)
        {
            DisplayMenu();

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var weight = GetWeight();
                    var height = GetHeight();
                    var unitType = GetUnitType();

                    DisplayBMIResult(weight.Value, height.Value, unitType);
                    break;

                case "2":
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("BMI Calculator");
        Console.WriteLine("1. Enter weight and height");
        Console.WriteLine("2. Exit");
        Console.Write("Select an option: ");
    }

    private static double GetUserInput(string prompt)
    {
        double input;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        return input;
    }

    private static Weight GetWeight()
    {
        var weightInput = GetUserInput("Enter weight: ");
        return new Weight(weightInput, UnitType.Metric); // Defaulting to Metric, will be reset later
    }

    private static Height GetHeight()
    {
        var heightInput = GetUserInput("Enter height: ");
        return new Height(heightInput, UnitType.Metric); // Defaulting to Metric, will be reset later
    }

    private static UnitType GetUnitType()
    {
        while (true)
        {
            Console.WriteLine("Select unit type:");
            Console.WriteLine("1. Metric");
            Console.WriteLine("2. Standard");
            var unitTypeInput = Console.ReadLine();
            if (unitTypeInput == "1")
                return UnitType.Metric;
            if (unitTypeInput == "2")
                return UnitType.Standard;

            Console.WriteLine("Invalid choice, please try again.");
        }
    }

    private static void DisplayBMIResult(double weightValue, double heightValue, UnitType unitType)
    {
        var weight = new Weight(weightValue, unitType);
        var height = new Height(heightValue, unitType);

        IBMICalculatorStrategy bmiCalculatorStrategy = unitType == UnitType.Metric
            ? new MetricBMICalculatorStrategy()
            : new StandardBMICalculatorStrategy();

        var bmiCategoryInterpreter = new BMICategoryInterpreter();

        var bmiCalculator = new BMICalculator(bmiCalculatorStrategy, bmiCategoryInterpreter);

        var bmi = bmiCalculator.CalculateBMI(weight, height);
        var bmiCategory = bmiCalculator.GetBMICategory(bmi);

        Console.WriteLine($"Your BMI is {bmi:F1}. Category: {bmiCategory}");
    }
}