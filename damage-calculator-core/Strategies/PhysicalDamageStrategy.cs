using damage_calculator_core.Enums;
using damage_calculator_core.Interfaces;
using damage_calculator_core.Models;

namespace damage_calculator_core.Strategies;

public class PhysicalDamageStrategy : IDamageCalculatorStrategy
{
    public double CalculateDamage(AttackPower attackPower, DefensePower defensePower)
    {
        if (attackPower.DamageType != DamageType.Physical || defensePower.DamageType != DamageType.Physical)
            throw new InvalidOperationException("Attack and Defense must both be Physical damage type.");

        // Physical damage formula: Damage = Attack - (Defense × 0.5)
        var damage = attackPower.Value - (defensePower.Value * 0.5);

        return damage;
    }
}