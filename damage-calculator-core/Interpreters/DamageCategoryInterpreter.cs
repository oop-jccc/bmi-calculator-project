using damage_calculator_core.Interfaces;

namespace damage_calculator_core.Interpreters;

public class DamageCategoryInterpreter : IDamageCategoryInterpreter
{
    public string InterpretDamage(double damage)
    {
        return damage switch
        {
            <= 0 => "Miss",
            < 10.0 => "Scratch",
            < 50.0 => "Hit",
            < 100.0 => "Critical",
            _ => "Devastating"
        };
    }
}