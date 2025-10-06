using damage_calculator_core.Interfaces;
using damage_calculator_core.Models;

namespace damage_calculator_core.Calculators;

public class DamageCalculator
{
    private readonly IDamageCalculatorStrategy _strategy;
    private readonly IDamageCategoryInterpreter _interpreter;

    public DamageCalculator(IDamageCalculatorStrategy strategy, IDamageCategoryInterpreter interpreter)
    {
        _strategy = strategy;
        _interpreter = interpreter;
    }

    public double CalculateDamage(AttackPower attackPower, DefensePower defensePower)
    {
        return _strategy.CalculateDamage(attackPower, defensePower);
    }

    public string GetDamageCategory(double damage)
    {
        return _interpreter.InterpretDamage(damage);
    }
}