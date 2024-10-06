using bmi_calculator_core.Interfaces;

namespace bmi_calculator_core.Strategies;

public class StandardBMICalculatorStrategy : IBMICalculatorStrategy
{
    // TODO: Ensure 'weight' and 'height' are standard, throw InvalidOperationException if not.
    // Calculate BMI using the formula: BMI = (weightInLbs / (heightInInches * heightInInches)) * 703,
    // and return the result.
}