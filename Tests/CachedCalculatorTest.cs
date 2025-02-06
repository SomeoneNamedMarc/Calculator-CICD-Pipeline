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
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    public void Add_2()
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
    public void Add_3()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        calc.Add(a, b);
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
    public void Subtract_2()
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
        var result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    public void Multiply_2()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 3;
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
        var b = 3;

        // Act
        var result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    public void Divide_2()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 3;
        var b = 3;

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
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    public void Factorial_2()
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
        var result = calc.Factorial(n);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }


    [Test]
    public void IsPrime()
    {
        // Arrange
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
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
        var calc = new CachedCalculator();
        var n = 4;

        // Act
        var result = calc.IsPrime(n);

        // Assert
        Assert.That(result, Is.False);
    }
    public void IsPrime_4()
    {
        // Arrange
        var calc = new CachedCalculator();
        var n = 5;

        // Act
        calc.IsPrime(n);

        // Assert
        Assert.That(calc._cache.Count, Is.EqualTo(1));
    }

    public void StoreInCache()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 5;
        var b = 1;

        // Act
        var result = calc.Add(a, b));

        // Assert
        Assert.That(calc._cache.ContainsKey(string.Concat(a, "+", b)), Is.True);
    }
}