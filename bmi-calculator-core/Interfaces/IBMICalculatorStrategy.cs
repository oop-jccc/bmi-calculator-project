using bmi_calculator_core.Models;

namespace bmi_calculator_core.Interfaces;

public interface IBMICalculatorStrategy
{
    double CalculateBMI(Weight weight, Height height);
}