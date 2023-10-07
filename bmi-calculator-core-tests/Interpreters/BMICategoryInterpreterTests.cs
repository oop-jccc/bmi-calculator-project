using bmi_calculator_core.Interpreters;

namespace bmi_calculator_core_tests.Interpreters;

[TestFixture]
public class BMICategoryInterpreterTests
{
    [TestFixture]
    public class InterpreterTests
    {
        private BMICategoryInterpreter _interpreter = null!;

        [SetUp]
        public void Setup()
        {
            _interpreter = new BMICategoryInterpreter();
        }

        [TestCase(17.5, "Underweight")]
        [TestCase(18.5, "Normal weight")]
        [TestCase(25.0, "Overweight")]
        [TestCase(30.0, "Obese")]
        public void InterpretBMI_ValidInput_ReturnsCorrectCategory(double bmi, string expectedCategory)
        {
            var category = _interpreter.InterpretBMI(bmi);
            Assert.That(category, Is.EqualTo(expectedCategory));
        }
    }
}