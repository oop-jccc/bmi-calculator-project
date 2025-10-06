using damage_calculator_core.Enums;
using damage_calculator_core.Interfaces;
using damage_calculator_core.Models;

namespace damage_calculator_core.Strategies;

public class MagicalDamageStrategy : IDamageCalculatorStrategy
{
    public double CalculateDamage(AttackPower attackPower, DefensePower defensePower)
    {
        if (attackPower.DamageType != DamageType.Magical || defensePower.DamageType != DamageType.Magical)
            throw new InvalidOperationException("Attack and Defense must both be Magical damage type.");

        // Magical damage formula: Damage = Attack × (100 / (100 + Defense))
        var damage = attackPower.Value * (100.0 / (100.0 + defensePower.Value));

        return damage;
    }
}