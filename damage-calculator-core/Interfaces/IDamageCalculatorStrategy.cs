using damage_calculator_core.Models;

namespace damage_calculator_core.Interfaces;

public interface IDamageCalculatorStrategy
{
    double CalculateDamage(AttackPower attackPower, DefensePower defensePower);
}