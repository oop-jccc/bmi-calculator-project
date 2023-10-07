### BMI Calculator Project Guide

#### Introduction

In this programming project, you are tasked with developing a Body Mass Index (BMI) Calculator. The primary goal is to practice the SOLID design principles, unit testing, and ensure high code coverage. The BMI Calculator should be able to compute BMI from given height and weight inputs, both in Metric and Standard units. Additionally, it should categorize the computed BMI into Underweight, Normal weight, Overweight, or Obese.

#### Project Structure

The project is structured into various components to ensure separation of concerns and adherence to SOLID principles. Below is the breakdown of the components and their responsibilities.

![UML.png](..%2Fbmi-calculator-core%2FUML.png)

#### Note:
Though the instructions suggest starting from scratch, you'll receive starter code. Your task is to complete the sections marked with "TODO" comments.

#### Models

1. **Weight Class**:
    - Constructor: Accepts a `double` for the weight value and a `UnitType` enumeration for the unit of measurement.
    - Validation: Ensure the weight value is greater than zero within the constructor, throwing an `ArgumentException` otherwise.
    - Properties: Create properties to hold the weight value and unit type.

2. **Height Class**:
    - Constructor: Accepts a `double` for the height value and a `UnitType` enumeration for the unit of measurement.
    - Validation: Ensure the height value is greater than zero within the constructor, throwing an `ArgumentException` otherwise.
    - Properties: Create properties to hold the height value and unit type.

#### Enums

1. **UnitType Enumeration**:
    - Define an enumeration named `UnitType` with two values: `Metric` and `Standard`.

#### Interfaces

1. **IBMICalculatorStrategy Interface**:
    - Define a method signature for calculating BMI given `Weight` and `Height` instances.

2. **IBMICategoryInterpreter Interface**:
    - Define a method signature for interpreting BMI and returning a string description of the BMI category.

#### Strategies

1. **MetricBMICalculatorStrategy Class**:
    - Implementation: Implement the `IBMICalculatorStrategy` interface, ensuring the units are Metric, and calculate BMI using the formula `weight (kg) / height (m)^2`.

2. **StandardBMICalculatorStrategy Class**:
    - Implementation: Implement the `IBMICalculatorStrategy` interface, ensuring the units are Standard, and calculate BMI using the formula `(weight (lbs) / height (in)^2) * 703`.

#### Interpreters

1. **BMICategoryInterpreter Class**:
    - Implementation: Implement the `IBMICategoryInterpreter` interface, interpreting the BMI value and returning the respective category as a string.

#### Calculators

1. **BMICalculator Class**:
    - Dependencies: Hold references to `IBMICalculatorStrategy` and `IBMICategoryInterpreter` through constructor injection.
    - Methods: Define methods to calculate BMI and get the BMI category, utilizing the injected strategy and interpreter.

![BMI Equations](BMI%20Calc.png)

#### Unit Testing

Ensure that you write unit tests to cover all the logic in your models, strategies, interpreters, and calculators. Aim for 100% code coverage to ensure every line of code in your core logic is tested. This will likely involve writing multiple test methods per class to cover all possible scenarios and edge cases.

#### SOLID Principles Reflection

Reflect on how your design adheres to each of the SOLID principles:

- **Single Responsibility Principle**: Each class should have a singular responsibility.
- **Open/Closed Principle**: Your design should be open for extension but closed for modification.
- **Liskov Substitution Principle**: Implementations of interfaces should be substitutable without altering the correctness of the program.
- **Interface Segregation Principle**: Create small, client-specific interfaces to ensure clients only implement methods they need.- **Dependency Inversion Principle**: Depend on abstractions, not on concrete implementations.

Ensure your final submission is well-organized, with clear separation of concerns, and adheres to the SOLID principles.



