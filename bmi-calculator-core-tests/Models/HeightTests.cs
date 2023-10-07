using bmi_calculator_core.Enums;
using bmi_calculator_core.Models;

namespace bmi_calculator_core_tests.Models;

[TestFixture]
public class HeightTests
{
    [Test]
    public void Constructor_ValidInput_CreatesInstance()
    {
        var height = new Height(1.75, UnitType.Metric);
        Assert.That(height.Value, Is.EqualTo(1.75));
        Assert.That(height.UnitType, Is.EqualTo(UnitType.Metric));
    }

    [Test]
    public void Constructor_NegativeValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new Height(-1.75, UnitType.Metric));
    }
}