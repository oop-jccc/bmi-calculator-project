using damage_calculator_core.Enums;

namespace damage_calculator_core.Models;

public record AttackPower
{
    public double Value { get; init; }
    public DamageType DamageType { get; init; }

    public AttackPower(double value, DamageType damageType)
    {
        if (value <= 0)
            throw new ArgumentException("Attack power value must be greater than zero.");

        Value = value;
        DamageType = damageType;
    }
}