using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;

namespace bmi_calculator_core.Strategies;

public class MetricBMICalculatorStrategy // TODO: Implement the IBMICalculatorStrategy interface.
{
    public double CalculateBMI(Weight weight, Height height)
    {
        // Ensure the units are metric, otherwise throw an exception
        // TODO: Implement a check to ensure the units of 'weight' and 'height' are metric.
        //       - If either 'weight' or 'height' units are not metric, throw a new InvalidOperationException with the message "Both weight and height units must be metric."

        // TODO: Assign 'height.Value' to a variable named 'heightInMeters'.

        // TODO: Assign 'weight.Value' to a variable named 'weightInKg'.

        // TODO: Calculate the BMI using the formula: BMI = weightInKg / (heightInMeters * heightInMeters).

        // TODO: Return the calculated BMI.

        throw new NotImplementedException();
    }
}