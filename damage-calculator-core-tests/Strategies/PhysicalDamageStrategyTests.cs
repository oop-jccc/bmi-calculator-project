using damage_calculator_core.Enums;
using damage_calculator_core.Models;
using damage_calculator_core.Strategies;

namespace damage_calculator_core_tests.Strategies;

[TestFixture]
public class PhysicalDamageStrategyTests
{
    [SetUp]
    public void Setup()
    {
        _physicalStrategy = new PhysicalDamageStrategy();
    }

    private PhysicalDamageStrategy _physicalStrategy = null!;

    [Test]
    public void CalculateDamage_ValidPhysicalInput_CalculatesDamage()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        var defensePower = new DefensePower(60, DamageType.Physical);
        var damage = _physicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(70.0).Within(0.01));
    }

    [Test]
    public void CalculateDamage_LowDefense_CalculatesHighDamage()
    {
        var attackPower = new AttackPower(150, DamageType.Physical);
        var defensePower = new DefensePower(20, DamageType.Physical);
        var damage = _physicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(140.0).Within(0.01));
    }

    [Test]
    public void CalculateDamage_HighDefense_CalculatesNegativeDamage()
    {
        var attackPower = new AttackPower(20, DamageType.Physical);
        var defensePower = new DefensePower(50, DamageType.Physical);
        var damage = _physicalStrategy.CalculateDamage(attackPower, defensePower);
        Assert.That(damage, Is.EqualTo(-5.0).Within(0.01));
    }

    [Test]
    public void CalculateDamage_InvalidDamageType_ThrowsException()
    {
        var attackPower = new AttackPower(100, DamageType.Magical);
        var defensePower = new DefensePower(60, DamageType.Magical);
        Assert.Throws<InvalidOperationException>(() => _physicalStrategy.CalculateDamage(attackPower, defensePower));
    }

    [Test]
    public void CalculateDamage_MismatchedDamageTypes_ThrowsException()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        var defensePower = new DefensePower(60, DamageType.Magical);
        Assert.Throws<InvalidOperationException>(() => _physicalStrategy.CalculateDamage(attackPower, defensePower));
    }
}