using damage_calculator_core.Enums;
using damage_calculator_core.Models;
using damage_calculator_core.Strategies;

namespace damage_calculator_core_tests.Strategies;

[TestFixture]
public class MagicalDamageStrategyTests
{
    [SetUp]
    public void Setup()
    {
        _magicalStrategy = new MagicalDamageStrategy();
    }

    private MagicalDamageStrategy _magicalStrategy = null!;

    [Test]
    public void CalculateDamage_ValidMagicalInput_CalculatesDamage()
    {
        var attackPower = new AttackPower(100, DamageType.Magical);
        var defensePower = new DefensePower(50, DamageType.Magical);
        var damage = _magicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(66.67).Within(0.01));
    }

    [Test]
    public void CalculateDamage_LowDefense_CalculatesHighDamage()
    {
        var attackPower = new AttackPower(80, DamageType.Magical);
        var defensePower = new DefensePower(20, DamageType.Magical);
        var damage = _magicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(66.67).Within(0.01));
    }

    [Test]
    public void CalculateDamage_HighDefense_CalculatesLowDamage()
    {
        var attackPower = new AttackPower(10, DamageType.Magical);
        var defensePower = new DefensePower(90, DamageType.Magical);
        var damage = _magicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(5.26).Within(0.01));
    }

    [Test]
    public void CalculateDamage_VeryHighAttack_CalculatesDevastatingDamage()
    {
        var attackPower = new AttackPower(200, DamageType.Magical);
        var defensePower = new DefensePower(100, DamageType.Magical);
        var damage = _magicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(100.0).Within(0.01));
    }

    [Test]
    public void CalculateDamage_InvalidDamageType_ThrowsException()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        var defensePower = new DefensePower(50, DamageType.Physical);
        Assert.Throws<InvalidOperationException>(() => _magicalStrategy.CalculateDamage(attackPower, defensePower));
    }

    [Test]
    public void CalculateDamage_MismatchedDamageTypes_ThrowsException()
    {
        var attackPower = new AttackPower(100, DamageType.Magical);
        var defensePower = new DefensePower(50, DamageType.Physical);
        Assert.Throws<InvalidOperationException>(() => _magicalStrategy.CalculateDamage(attackPower, defensePower));
    }
}