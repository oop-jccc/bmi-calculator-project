using damage_calculator_core.Enums;
using damage_calculator_core.Models;

namespace damage_calculator_core_tests.Models;

[TestFixture]
public class DefensePowerTests
{
    [Test]
    public void Constructor_ValidInput_CreatesInstance()
    {
        var defensePower = new DefensePower(50, DamageType.Physical);
        Assert.That(defensePower.Value, Is.EqualTo(50));
        Assert.That(defensePower.DamageType, Is.EqualTo(DamageType.Physical));
    }

    [Test]
    public void Constructor_NegativeValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new DefensePower(-50, DamageType.Physical));
    }

    [Test]
    public void Constructor_ZeroValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new DefensePower(0, DamageType.Magical));
    }
}