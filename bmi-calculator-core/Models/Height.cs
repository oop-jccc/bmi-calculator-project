using bmi_calculator_core.Enums;

namespace bmi_calculator_core.Models;

public class Height
{
    // TODO: Declare a property named 'UnitType' of type UnitType with a public getter.

    public Height(double value, UnitType unitType)
    {
        // TODO: Implement validation to ensure 'value' is greater than zero.
        //       - If 'value' is less than or equal to zero, throw a new ArgumentException with the message "Height value must be greater than zero."
        // TODO: Assign 'value' to the 'Value' property.
        // TODO: Assign 'unitType' to the 'UnitType' property.
    }

    public double Value { get; } // note: this is a read-only property using a getter only
}