namespace bmi_calculator_core.Models;

public class Height
{
    public double Value { get; }
    public UnitType UnitType { get; }

    public Height(double value, UnitType unitType)
    {
        if (value <= 0)
            throw new ArgumentException("Height value must be greater than zero.", nameof(value));

        Value = value;
        UnitType = unitType;
    }
}