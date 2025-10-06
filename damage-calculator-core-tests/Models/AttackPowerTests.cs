using damage_calculator_core.Enums;
using damage_calculator_core.Models;

namespace damage_calculator_core_tests.Models;

[TestFixture]
public class AttackPowerTests
{
    [Test]
    public void Constructor_ValidInput_CreatesInstance()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        Assert.That(attackPower.Value, Is.EqualTo(100));
        Assert.That(attackPower.DamageType, Is.EqualTo(DamageType.Physical));
    }

    [Test]
    public void Constructor_NegativeValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new AttackPower(-100, DamageType.Physical));
    }

    [Test]
    public void Constructor_ZeroValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new AttackPower(0, DamageType.Magical));
    }
}