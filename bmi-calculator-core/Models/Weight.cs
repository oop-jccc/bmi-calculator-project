namespace bmi_calculator_core.Models;

public class Weight
{
    public double Value { get; }
    public UnitType UnitType { get; }

    public Weight(double value, UnitType unitType)
    {
        if (value <= 0)
            throw new ArgumentException("Weight value must be greater than zero.", nameof(value));

        Value = value;
        UnitType = unitType;
    }
}