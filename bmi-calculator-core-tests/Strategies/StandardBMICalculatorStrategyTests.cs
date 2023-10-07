using bmi_calculator_core.Enums;
using bmi_calculator_core.Models;
using bmi_calculator_core.Strategies;

namespace bmi_calculator_core_tests.Strategies;

[TestFixture]
public class StandardBMICalculatorStrategyTests
{
    private StandardBMICalculatorStrategy _standardStrategy = null!;

    [SetUp]
    public void Setup()
    {
        _standardStrategy = new StandardBMICalculatorStrategy();
    }

    [Test]
    public void CalculateBMI_ValidStandardInput_CalculatesBMI()
    {
        var weight = new Weight(154.32, UnitType.Standard);  // 70 kg in lbs
        var height = new Height(68.90, UnitType.Standard);  // 1.75 m in inches
        var bmi = _standardStrategy.CalculateBMI(weight, height);
        Assert.That(bmi, Is.EqualTo(22.86).Within(0.01));
    }
    
    [Test]
    public void CalculateBMI_InvalidUnitType_ThrowsException()
    {
        var weight = new Weight(70, UnitType.Metric);
        var height = new Height(1.75, UnitType.Metric);
        Assert.Throws<InvalidOperationException>(() => _standardStrategy.CalculateBMI(weight, height));
    }
}