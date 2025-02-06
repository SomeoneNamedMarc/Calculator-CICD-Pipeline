using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Add(a, b);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Subtract(a, b);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Multiply()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Multiply(a, b);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }


    [Test]
    public void Divide()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 3;
        var b = 2;

        // Act
        calc.Divide(a, b);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Factorial()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 3;

        // Act
        calc.Factorial(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void Factorial_3()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 0;

        // Act
        calc.Factorial(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }


    [Test]
    public void IsPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 5;

        // Act
        calc.IsPrime(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void IsPrime_2()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 1;

        // Act
        calc.IsPrime(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    [Test]
    public void IsPrime_3()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 4;

        // Act
        calc.IsPrime(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }
}