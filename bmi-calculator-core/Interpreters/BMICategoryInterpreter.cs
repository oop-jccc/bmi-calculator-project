using bmi_calculator_core.Interfaces;

namespace bmi_calculator_core.Interpreters;

public class BMICategoryInterpreter : IBMICategoryInterpreter
{
    public string InterpretBMI(double bmi)
    {
        switch (bmi)
        {
            case < 18.5:
                return "Underweight";
            case >= 18.5 and < 24.9:
                return "Normal weight";
            case >= 24.9 and < 29.9:
                return "Overweight";
            default:
                return "Obese";
        }
    }
}