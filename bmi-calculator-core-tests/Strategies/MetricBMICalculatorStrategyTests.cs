using bmi_calculator_core.Enums;
using bmi_calculator_core.Models;
using bmi_calculator_core.Strategies;

namespace bmi_calculator_core_tests.Strategies;

[TestFixture]
public class MetricBMICalculatorStrategyTests
{
    private MetricBMICalculatorStrategy _metricStrategy = null!;

    [SetUp]
    public void Setup()
    {
        _metricStrategy = new MetricBMICalculatorStrategy();
    }

    [Test]
    public void CalculateBMI_ValidMetricInput_CalculatesBMI()
    {
        var weight = new Weight(70, UnitType.Metric);
        var height = new Height(1.75, UnitType.Metric);
        var bmi = _metricStrategy.CalculateBMI(weight, height);
        Assert.That(bmi, Is.EqualTo(22.86).Within(0.01));
    }

    [Test]
    public void CalculateBMI_InvalidUnitType_ThrowsException()
    {
        var weight = new Weight(70, UnitType.Standard);
        var height = new Height(1.75, UnitType.Standard);
        Assert.Throws<InvalidOperationException>(() => _metricStrategy.CalculateBMI(weight, height));
    }
}