using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;

namespace bmi_calculator_core.Calculators;

public class BMICalculator
{
    private readonly IBMICalculatorStrategy _bmiCalculatorStrategy;
    private readonly IBMICategoryInterpreter _bmiCategoryInterpreter;

    public BMICalculator(IBMICalculatorStrategy bmiCalculatorStrategy, IBMICategoryInterpreter bmiCategoryInterpreter)
    {
        _bmiCalculatorStrategy = bmiCalculatorStrategy;
        _bmiCategoryInterpreter = bmiCategoryInterpreter;
    }

    public double CalculateBMI(Weight weight, Height height)
    {
        return _bmiCalculatorStrategy.CalculateBMI(weight, height);
    }

    public string GetBMICategory(double bmi)
    {
        return _bmiCategoryInterpreter.InterpretBMI(bmi);
    }
}