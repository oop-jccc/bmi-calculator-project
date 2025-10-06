using damage_calculator_core.Enums;

namespace damage_calculator_core.Models;

public record AttackPower
{
    private readonly double _value;

    public required double Value
    {
        get => _value;
        init
        {
            if (value <= 0)
                throw new ArgumentException("Attack power value must be greater than zero.");
            _value = value;
        }
    }

    public required DamageType DamageType { get; init; }
}