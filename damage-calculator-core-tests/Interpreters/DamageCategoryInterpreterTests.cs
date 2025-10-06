using damage_calculator_core.Interpreters;

namespace damage_calculator_core_tests.Interpreters;

[TestFixture]
public class DamageCategoryInterpreterTests
{
    [SetUp]
    public void Setup()
    {
        _interpreter = new DamageCategoryInterpreter();
    }

    private DamageCategoryInterpreter _interpreter = null!;

    [TestCase(-5.0, "Miss")]
    [TestCase(0.0, "Miss")]
    [TestCase(5.0, "Scratch")]
    [TestCase(9.9, "Scratch")]
    [TestCase(10.0, "Hit")]
    [TestCase(30.0, "Hit")]
    [TestCase(49.9, "Hit")]
    [TestCase(50.0, "Critical")]
    [TestCase(75.0, "Critical")]
    [TestCase(99.9, "Critical")]
    [TestCase(100.0, "Devastating")]
    [TestCase(150.0, "Devastating")]
    public void InterpretDamage_ValidInput_ReturnsCorrectCategory(double damage, string expectedCategory)
    {
        var category = _interpreter.InterpretDamage(damage);
        Assert.That(category, Is.EqualTo(expectedCategory));
    }
}