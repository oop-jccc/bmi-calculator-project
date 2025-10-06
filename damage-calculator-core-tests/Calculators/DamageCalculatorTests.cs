using damage_calculator_core.Calculators;
using damage_calculator_core.Enums;
using damage_calculator_core.Interfaces;
using damage_calculator_core.Models;
using Moq;

namespace damage_calculator_core_tests.Calculators;

[TestFixture]
public class DamageCalculatorTests
{
    [SetUp]
    public void Setup()
    {
        _mockStrategy = new Mock<IDamageCalculatorStrategy>();
        _mockInterpreter = new Mock<IDamageCategoryInterpreter>();
        _calculator = new DamageCalculator(_mockStrategy.Object, _mockInterpreter.Object);
    }

    private Mock<IDamageCalculatorStrategy> _mockStrategy = null!;
    private Mock<IDamageCategoryInterpreter> _mockInterpreter = null!;
    private DamageCalculator _calculator = null!;

    [Test]
    public void CalculateDamage_ValidInput_CallsStrategy()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        var defensePower = new DefensePower(50, DamageType.Physical);
        _calculator.CalculateDamage(attackPower, defensePower);
        _mockStrategy.Verify(s => s.CalculateDamage(attackPower, defensePower), Times.Once);
    }

    [Test]
    public void GetDamageCategory_ValidInput_CallsInterpreter()
    {
        var damage = 75.5;
        _calculator.GetDamageCategory(damage);
        _mockInterpreter.Verify(i => i.InterpretDamage(damage), Times.Once);
    }

    [Test]
    public void CalculateDamage_ValidInput_ReturnsStrategyResult()
    {
        var attackPower = new AttackPower(100, DamageType.Physical);
        var defensePower = new DefensePower(50, DamageType.Physical);
        _mockStrategy.Setup(s => s.CalculateDamage(attackPower, defensePower)).Returns(75.0);

        var result = _calculator.CalculateDamage(attackPower, defensePower);

        Assert.That(result, Is.EqualTo(75.0));
    }

    [Test]
    public void GetDamageCategory_ValidInput_ReturnsInterpreterResult()
    {
        var damage = 75.5;
        _mockInterpreter.Setup(i => i.InterpretDamage(damage)).Returns("Critical");

        var result = _calculator.GetDamageCategory(damage);

        Assert.That(result, Is.EqualTo("Critical"));
    }
}