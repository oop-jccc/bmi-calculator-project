using bmi_calculator_core.Interfaces;

namespace bmi_calculator_core.Strategies;

public class MetricBMICalculatorStrategy : IBMICalculatorStrategy
{
    // TODO: Ensure 'weight' and 'height' are metric, throw InvalidOperationException if not.
    // Assign 'height.Value' to 'heightInMeters', 'weight.Value' to 'weightInKg',
    // then calculate and return BMI using the formula: BMI = weightInKg / (heightInMeters * heightInMeters).
}