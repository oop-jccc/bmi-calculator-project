using damage_calculator_core.Calculators;
using damage_calculator_core.Enums;
using damage_calculator_core.Interfaces;
using damage_calculator_core.Interpreters;
using damage_calculator_core.Models;
using damage_calculator_core.Strategies;

namespace damage_calculator_cli;

internal static class Program
{
    private static void Main()
    {
        while (true)
        {
            DisplayMenu();

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var damageType = GetDamageType();
                    var attackPower = GetAttackPower(damageType);
                    var defensePower = GetDefensePower(damageType);

                    DisplayDamageResult(attackPower, defensePower, damageType);
                    break;

                case "2":
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\n=== RPG Damage Calculator ===");
        Console.WriteLine("1. Calculate Damage");
        Console.WriteLine("2. Exit");
        Console.Write("Select an option: ");
    }

    private static double GetUserInput(string prompt)
    {
        double input;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }

        return input;
    }

    private static DamageType GetDamageType()
    {
        while (true)
        {
            Console.WriteLine("\nSelect damage type:");
            Console.WriteLine("1. Physical");
            Console.WriteLine("2. Magical");
            Console.Write("Select damage type: ");
            var damageTypeInput = Console.ReadLine();
            if (damageTypeInput == "1")
                return DamageType.Physical;
            if (damageTypeInput == "2")
                return DamageType.Magical;

            Console.WriteLine("Invalid choice, please try again.");
        }
    }

    private static AttackPower GetAttackPower(DamageType damageType)
    {
        var attackValue = GetUserInput("Enter attack power: ");
        return new AttackPower(attackValue, damageType);
    }

    private static DefensePower GetDefensePower(DamageType damageType)
    {
        var defenseValue = GetUserInput("Enter defense power: ");
        return new DefensePower(defenseValue, damageType);
    }

    private static void DisplayDamageResult(AttackPower attackPower, DefensePower defensePower, DamageType damageType)
    {
        IDamageCalculatorStrategy damageCalculatorStrategy = damageType == DamageType.Physical
            ? new PhysicalDamageStrategy()
            : new MagicalDamageStrategy();

        var damageCategoryInterpreter = new DamageCategoryInterpreter();

        var damageCalculator = new DamageCalculator(damageCalculatorStrategy, damageCategoryInterpreter);

        var damage = damageCalculator.CalculateDamage(attackPower, defensePower);
        var damageCategory = damageCalculator.GetDamageCategory(damage);

        Console.WriteLine("\n--- RESULT ---");
        Console.WriteLine($"Damage Dealt: {damage:F1}");
        Console.WriteLine($"Category: {damageCategory}");
    }
}