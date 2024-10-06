using bmi_calculator_core.Interpreters;

namespace bmi_calculator_core_tests.Interpreters;

[TestFixture]
public class BMICategoryInterpreterTests
{
    [TestFixture]
    public class InterpreterTests
    {
        [SetUp]
        public void Setup()
        {
            _interpreter = new BMICategoryInterpreter();
        }

        private BMICategoryInterpreter _interpreter = null!;

        [TestCase(17.5, "Underweight")]
        [TestCase(18.5, "Normal weight")]
        [TestCase(25.0, "Overweight")]
        [TestCase(30.0, "Obese")]
        public void InterpretBMI_ValidInput_ReturnsCorrectCategory(double bmi, string expectedCategory)
        {
            // TODO: Uncomment the following line to call the InterpretBMI method.
            //var category = _interpreter.InterpretBMI(bmi);
            //Assert.That(category, Is.EqualTo(expectedCategory));
        }
    }
}