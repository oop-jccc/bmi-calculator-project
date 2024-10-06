using bmi_calculator_core.Calculators;
using bmi_calculator_core.Enums;
using bmi_calculator_core.Interfaces;
using bmi_calculator_core.Models;
using Moq;

namespace bmi_calculator_core_tests.Calculators;

[TestFixture]
public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
        _mockStrategy = new Mock<IBMICalculatorStrategy>();
        _mockInterpreter = new Mock<IBMICategoryInterpreter>();
        // TODO: Uncomment the following line to create an instance of the BMICalculator class.
        //_calculator = new BMICalculator(_mockStrategy.Object, _mockInterpreter.Object);
    }

    private Mock<IBMICalculatorStrategy> _mockStrategy = null!;
    private Mock<IBMICategoryInterpreter> _mockInterpreter = null!;
    private BMICalculator _calculator = null!;

    [Test]
    public void CalculateBMI_ValidInput_CallsStrategy()
    {
        var weight = new Weight(70, UnitType.Metric);
        var height = new Height(1.75, UnitType.Metric);
        // TODO: Uncomment the following line to call the CalculateBMI method.
        //_calculator.CalculateBMI(weight, height);
        //_mockStrategy.Verify(s => s.CalculateBMI(weight, height), Times.Once);
    }

    [Test]
    public void GetBMICategory_ValidInput_CallsInterpreter()
    {
        var bmi = 22.86;
        // TODO: Uncomment the following line to call the GetBMICategory method.
        //_calculator.GetBMICategory(bmi);
        //_mockInterpreter.Verify(i => i.InterpretBMI(bmi), Times.Once);
    }
}