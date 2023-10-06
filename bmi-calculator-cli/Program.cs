using bmi_calculator_core;
using bmi_calculator_core.Models;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("1. Enter weight and height");
            Console.WriteLine("2. Exit");
            Console.Write("Select an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    double weightInput;
                    while (true)
                    {
                        Console.Write("Enter weight: ");
                        if (double.TryParse(Console.ReadLine(), out weightInput) && weightInput > 0)
                            break;
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                    }

                    double heightInput;
                    while (true)
                    {
                        Console.Write("Enter height: ");
                        if (double.TryParse(Console.ReadLine(), out heightInput) && heightInput > 0)
                            break;
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                    }

                    UnitType unitType;
                    while (true)
                    {
                        Console.WriteLine("Select unit type:");
                        Console.WriteLine("1. Metric");
                        Console.WriteLine("2. Standard");
                        var unitTypeInput = Console.ReadLine();
                        if (unitTypeInput == "1")
                        {
                            unitType = UnitType.Metric;
                            break;
                        }

                        if (unitTypeInput == "2")
                        {
                            unitType = UnitType.Standard;
                            break;
                        }

                        Console.WriteLine("Invalid choice, please try again.");
                    }

                    var weight = new Weight(weightInput, unitType);
                    var height = new Height(heightInput, unitType);

                    IBMICalculatorStrategy bmiCalculatorStrategy = unitType == UnitType.Metric
                        ? new MetricBMICalculatorStrategy()
                        : new StandardBMICalculatorStrategy();

                    var bmiCategoryInterpreter = new BMICategoryInterpreter();

                    var bmiCalculator = new BMICalculator(bmiCalculatorStrategy, bmiCategoryInterpreter);

                    var bmi = bmiCalculator.CalculateBMI(weight, height);
                    var bmiCategory = bmiCalculator.GetBMICategory(bmi);

                    Console.WriteLine($"Your BMI is {bmi:F1}. Category: {bmiCategory}");
                    break;

                case "2":
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}