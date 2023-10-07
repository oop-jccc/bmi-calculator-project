using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;

namespace bmi_calculator_core.Strategies;

public class StandardBMICalculatorStrategy // TODO: Implement the IBMICalculatorStrategy interface.
{
    public double CalculateBMI(Weight weight, Height height)
    {
        // Ensure the units are standard, otherwise throw an exception
        // TODO: Implement a check to ensure the units of 'weight' and 'height' are standard.
        //       - If either 'weight' or 'height' units are not standard, throw a new InvalidOperationException with the message "Both weight and height units must be standard."

        var heightInInches = height.Value;
        var weightInLbs = weight.Value;
        var bmi = (weightInLbs / (heightInInches * heightInInches)) * 703;

        return bmi;
    }
}