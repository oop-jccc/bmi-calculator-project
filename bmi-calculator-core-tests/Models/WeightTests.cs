using bmi_calculator_core.Enums;
using bmi_calculator_core.Models;

namespace bmi_calculator_core_tests.Models;

[TestFixture]
public class WeightTests
{
    [Test]
    public void Constructor_ValidInput_CreatesInstance()
    {
        var weight = new Weight(70, UnitType.Metric);
        Assert.That(weight.Value, Is.EqualTo(70));
        Assert.That(weight.UnitType, Is.EqualTo(UnitType.Metric));
    }

    [Test]
    public void Constructor_NegativeValue_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _ = new Weight(-70, UnitType.Metric));
    }
}