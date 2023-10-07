using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;

namespace bmi_calculator_core.Strategies;

public class MetricBMICalculatorStrategy : IBMICalculatorStrategy
{
    public double CalculateBMI(Weight weight, Height height)
    {
        // Ensure the units are metric, otherwise throw an exception
        if (weight.UnitType != UnitType.Metric || height.UnitType != UnitType.Metric)
            throw new InvalidOperationException("Both weight and height units must be metric.");

        var heightInMeters = height.Value;
        var weightInKg = weight.Value;
        var bmi = weightInKg / (heightInMeters * heightInMeters);

        return bmi;
    }
}