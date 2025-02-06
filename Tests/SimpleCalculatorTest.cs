using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;
        
        // Act
        var result = calc.Add(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }


    [Test]
    public void Multiply()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var a = 3;
        var b = 3;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 3;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Factorial_2()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var invalidNumber = -1;

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => calc.Factorial(invalidNumber));
        Assert.That(ex.Message, Is.EqualTo("Factorial is not defined for negative numbers"));
    }

    [Test]
    public void Factorial_3()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 0;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial_4()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 0;

        // Act
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.LessThan(2));
    }


    [Test]
    public void IsPrime()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 5;

        // Act
        var result = calc.IsPrime(n);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPrime_2()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 1;

        // Act
        var result = calc.IsPrime(n);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPrime_3()
    {
        // Arrange
        var calc = new SimpleCalculator();
        var n = 2;

        // Act
        var result = calc.IsPrime(n);

        // Assert
        Assert.That(result, Is.False);
    }
}