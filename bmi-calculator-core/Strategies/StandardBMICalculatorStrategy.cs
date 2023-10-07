using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;

namespace bmi_calculator_core.Strategies;

public class StandardBMICalculatorStrategy : IBMICalculatorStrategy
{
    public double CalculateBMI(Weight weight, Height height)
    {
        // Ensure the units are standard, otherwise throw an exception
        if (weight.UnitType != UnitType.Standard || height.UnitType != UnitType.Standard)
            throw new InvalidOperationException("Both weight and height units must be standard.");

        var heightInInches = height.Value;
        var weightInLbs = weight.Value;
        var bmi = (weightInLbs / (heightInInches * heightInInches)) * 703;

        return bmi;
    }
}