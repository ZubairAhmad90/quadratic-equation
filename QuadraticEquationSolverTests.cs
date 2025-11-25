using QuadraticEquationSolver.Core;
using Core = QuadraticEquationSolver.Core;
using Xunit;
using Xunit.Abstractions;

namespace QuadraticEquationSolver.Tests;

/// <summary>
/// Comprehensive unit tests for the QuadraticEquationSolver class.
/// Tests cover all scenarios: no real roots, one real root, and two real roots.
/// </summary>
public class QuadraticEquationSolverTests
{
    private readonly ITestOutputHelper _output;

    public QuadraticEquationSolverTests(ITestOutputHelper output)
    {
        _output = output;
    }
    #region Tests for No Real Roots (Negative Discriminant)

    [Fact]
    public void Solve_NoRealRoots_NegativeDiscriminant_ReturnsNoRoots()
    {
        // Arrange: x² + x + 1 = 0 has discriminant = 1 - 4 = -3 < 0
        double a = 1, b = 1, c = 1;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"Expected: No real roots (discriminant = {b * b - 4 * a * c})");

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.False(result.HasRealRoots);
        Assert.Equal(0, result.RootCount);
        Assert.Null(result.Root1);
        Assert.Null(result.Root2);
        Assert.True(result.Discriminant < 0);
    }

    [Theory]
    [InlineData(1, 2, 3)]      // x² + 2x + 3 = 0, discriminant = 4 - 12 = -8
    [InlineData(2, 1, 1)]      // 2x² + x + 1 = 0, discriminant = 1 - 8 = -7
    [InlineData(5, 3, 2)]      // 5x² + 3x + 2 = 0, discriminant = 9 - 40 = -31
    [InlineData(-1, 1, -1)]    // -x² + x - 1 = 0, discriminant = 1 - 4 = -3
    public void Solve_NoRealRoots_VariousCoefficients_ReturnsNoRoots(double a, double b, double c)
    {
        // Act
        double discriminant = b * b - 4 * a * c;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {discriminant} (negative, no real roots)");
        
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.False(result.HasRealRoots, $"Equation {a}x² + {b}x + {c} = 0 should have no real roots");
        Assert.Equal(0, result.RootCount);
        Assert.Null(result.Root1);
        Assert.Null(result.Root2);
        Assert.True(result.Discriminant < 0, "Discriminant should be negative");
    }

    #endregion

    #region Tests for One Real Root (Zero Discriminant)

    [Fact]
    public void Solve_OneRealRoot_ZeroDiscriminant_ReturnsSingleRoot()
    {
        // Arrange: x² - 2x + 1 = 0 has discriminant = 4 - 4 = 0, root = 1
        double a = 1, b = -2, c = 1;
        double expectedRoot = 1.0;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {b * b - 4 * a * c} (zero, one repeated root)");
        _output.WriteLine($"Expected: Root = {expectedRoot}");

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.True(result.HasRealRoots);
        Assert.Equal(1, result.RootCount);
        Assert.NotNull(result.Root1);
        Assert.Null(result.Root2);
        Assert.Equal(0, result.Discriminant, 10);
        Assert.Equal(expectedRoot, result.Root1.Value, 10);
    }

    [Theory]
    [InlineData(1, -4, 4, 2.0)]        // x² - 4x + 4 = 0, root = 2
    [InlineData(1, 6, 9, -3.0)]        // x² + 6x + 9 = 0, root = -3
    [InlineData(2, -8, 8, 2.0)]        // 2x² - 8x + 8 = 0, root = 2
    [InlineData(4, 12, 9, -1.5)]       // 4x² + 12x + 9 = 0, root = -1.5
    [InlineData(9, -6, 1, 1.0 / 3.0)]  // 9x² - 6x + 1 = 0, root = 1/3
    public void Solve_OneRealRoot_VariousCoefficients_ReturnsCorrectRoot(
        double a, double b, double c, double expectedRoot)
    {
        // Act
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {b * b - 4 * a * c} (zero)");
        _output.WriteLine($"Expected: Root = {expectedRoot}");
        
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.True(result.HasRealRoots, $"Equation {a}x² + {b}x + {c} = 0 should have one real root");
        Assert.Equal(1, result.RootCount);
        Assert.NotNull(result.Root1);
        Assert.Null(result.Root2);
        Assert.Equal(0, result.Discriminant, 10);
        Assert.Equal(expectedRoot, result.Root1.Value, 10);
    }

    #endregion

    #region Tests for Two Real Roots (Positive Discriminant)

    [Fact]
    public void Solve_TwoRealRoots_PositiveDiscriminant_ReturnsTwoRoots()
    {
        // Arrange: x² - 5x + 6 = 0 has roots x = 2 and x = 3
        double a = 1, b = -5, c = 6;
        double expectedRoot1 = 2.0;
        double expectedRoot2 = 3.0;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {b * b - 4 * a * c} (positive, two real roots)");
        _output.WriteLine($"Expected: Root1 = {expectedRoot1}, Root2 = {expectedRoot2}");

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.True(result.HasRealRoots);
        Assert.Equal(2, result.RootCount);
        Assert.NotNull(result.Root1);
        Assert.NotNull(result.Root2);
        Assert.True(result.Discriminant > 0);
        
        // Check that roots match (order may vary)
        bool rootsMatch = (Math.Abs(result.Root1.Value - expectedRoot1) < 0.0001 && 
                          Math.Abs(result.Root2.Value - expectedRoot2) < 0.0001) ||
                         (Math.Abs(result.Root1.Value - expectedRoot2) < 0.0001 && 
                          Math.Abs(result.Root2.Value - expectedRoot1) < 0.0001);
        Assert.True(rootsMatch, $"Roots should be {expectedRoot1} and {expectedRoot2}");
    }

    [Theory]
    [InlineData(1, -3, 2, 1.0, 2.0)]           // x² - 3x + 2 = 0, roots: 1, 2
    [InlineData(1, 0, -4, -2.0, 2.0)]          // x² - 4 = 0, roots: -2, 2
    [InlineData(1, 1, -6, -3.0, 2.0)]          // x² + x - 6 = 0, roots: -3, 2
    [InlineData(2, -7, 3, 0.5, 3.0)]           // 2x² - 7x + 3 = 0, roots: 0.5, 3
    [InlineData(1, -7, 10, 2.0, 5.0)]          // x² - 7x + 10 = 0, roots: 2, 5
    public void Solve_TwoRealRoots_VariousCoefficients_ReturnsCorrectRoots(
        double a, double b, double c, double expectedRoot1, double expectedRoot2)
    {
        // Act
        double discriminant = b * b - 4 * a * c;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {discriminant} (positive)");
        _output.WriteLine($"Expected: Root1 = {expectedRoot1}, Root2 = {expectedRoot2}");
        
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.True(result.HasRealRoots, $"Equation {a}x² + {b}x + {c} = 0 should have two real roots");
        Assert.Equal(2, result.RootCount);
        Assert.NotNull(result.Root1);
        Assert.NotNull(result.Root2);
        Assert.True(result.Discriminant > 0, "Discriminant should be positive");
        
        // Verify roots match expected values (order may vary)
        double root1 = result.Root1.Value;
        double root2 = result.Root2.Value;
        
        bool rootsMatch = (Math.Abs(root1 - expectedRoot1) < 0.0001 && 
                          Math.Abs(root2 - expectedRoot2) < 0.0001) ||
                         (Math.Abs(root1 - expectedRoot2) < 0.0001 && 
                          Math.Abs(root2 - expectedRoot1) < 0.0001);
        Assert.True(rootsMatch, $"Roots should be {expectedRoot1} and {expectedRoot2}, but got {root1} and {root2}");
    }

    [Fact]
    public void Solve_TwoRealRoots_VerifyRootsSatisfyEquation()
    {
        // Arrange: x² - 5x + 6 = 0
        double a = 1, b = -5, c = 6;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"Verifying that calculated roots satisfy the equation");

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.Equal(2, result.RootCount);
        double root1 = result.Root1.Value;
        double root2 = result.Root2.Value;

        _output.WriteLine($"OUTPUT: Root1 = {root1}, Root2 = {root2}");

        // Verify both roots satisfy the equation: ax² + bx + c = 0
        double value1 = a * root1 * root1 + b * root1 + c;
        double value2 = a * root2 * root2 + b * root2 + c;

        _output.WriteLine($"Verification: {a}*({root1})² + {b}*({root1}) + {c} = {value1}");
        _output.WriteLine($"Verification: {a}*({root2})² + {b}*({root2}) + {c} = {value2}");

        Assert.Equal(0, value1, 10);
        Assert.Equal(0, value2, 10);
    }

    #endregion

    #region Edge Cases and Special Scenarios

    [Fact]
    public void Solve_ZeroCoefficientA_ThrowsArgumentException()
    {
        // Arrange
        double a = 0, b = 1, c = 1;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"Expected: ArgumentException (coefficient 'a' cannot be zero)");

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => 
            Core.QuadraticEquationSolver.Solve(a, b, c));
        
        _output.WriteLine($"OUTPUT: Exception thrown - {exception.GetType().Name}");
        _output.WriteLine($"OUTPUT: Parameter name = {exception.ParamName}");
        _output.WriteLine($"OUTPUT: Message = {exception.Message}");
        
        Assert.Equal("a", exception.ParamName);
        Assert.Contains("cannot be zero", exception.Message);
    }

    [Fact]
    public void Solve_LinearEquation_ThrowsArgumentException()
    {
        // Arrange: 0x² + 2x + 3 = 0 is not a quadratic equation
        double a = 0, b = 2, c = 3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => 
            Core.QuadraticEquationSolver.Solve(a, b, c));
    }

    [Theory]
    [InlineData(1, 0, 0, 0.0)]          // x² = 0, root: 0
    [InlineData(1, 0, -1, -1.0, 1.0)]  // x² - 1 = 0, roots: -1, 1
    [InlineData(1, 0, -9, -3.0, 3.0)]  // x² - 9 = 0, roots: -3, 3
    public void Solve_NoLinearTerm_VariousCases_ReturnsCorrectResult(
        double a, double b, double c, params double[] expectedRoots)
    {
        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        if (expectedRoots.Length == 1)
        {
            Assert.Equal(1, result.RootCount);
            Assert.Equal(expectedRoots[0], result.Root1.Value, 10);
        }
        else
        {
            Assert.Equal(2, result.RootCount);
            Assert.Contains(result.Root1.Value, expectedRoots);
            Assert.Contains(result.Root2.Value, expectedRoots);
        }
    }

    [Theory]
    [InlineData(1, 0, 1)]    // x² + 1 = 0, no real roots
    [InlineData(2, 0, 5)]   // 2x² + 5 = 0, no real roots
    public void Solve_NoLinearTerm_NegativeConstant_ReturnsNoRoots(
        double a, double b, double c)
    {
        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.False(result.HasRealRoots);
        Assert.Equal(0, result.RootCount);
    }

    [Fact]
    public void Solve_NegativeCoefficientA_TwoRoots_ReturnsCorrectResult()
    {
        // Arrange: -x² + 5x - 6 = 0, which is equivalent to x² - 5x + 6 = 0
        // Roots should be 2 and 3
        double a = -1, b = 5, c = -6;

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.True(result.HasRealRoots);
        Assert.Equal(2, result.RootCount);
        
        // Verify roots satisfy the equation
        double root1 = result.Root1.Value;
        double root2 = result.Root2.Value;
        double value1 = a * root1 * root1 + b * root1 + c;
        double value2 = a * root2 * root2 + b * root2 + c;

        Assert.Equal(0, value1, 10);
        Assert.Equal(0, value2, 10);
    }

    [Fact]
    public void Solve_LargeCoefficients_HandlesCorrectly()
    {
        // Arrange: 1000x² - 5000x + 6000 = 0, roots: 2, 3
        double a = 1000, b = -5000, c = 6000;

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.True(result.HasRealRoots);
        Assert.Equal(2, result.RootCount);
        
        // Verify roots satisfy the equation
        double root1 = result.Root1.Value;
        double root2 = result.Root2.Value;
        double value1 = a * root1 * root1 + b * root1 + c;
        double value2 = a * root2 * root2 + b * root2 + c;

        Assert.Equal(0, value1, 1);  // Allow larger tolerance for large numbers
        Assert.Equal(0, value2, 1);
    }

    [Fact]
    public void Solve_DiscriminantProperty_IsCorrectlyCalculated()
    {
        // Arrange
        double a = 2, b = 5, c = 3;
        double expectedDiscriminant = 25 - 24; // b² - 4ac = 25 - 24 = 1

        // Act
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        Assert.Equal(expectedDiscriminant, result.Discriminant, 10);
    }

    #endregion

    #region Comprehensive Theory Tests with Multiple Data Sets

    [Theory]
    [InlineData(1, 1, 1, false, 0, null, null)]           // No roots
    [InlineData(1, -2, 1, true, 1, 1.0, null)]           // One root
    [InlineData(1, -3, 2, true, 2, 1.0, 2.0)]            // Two roots
    [InlineData(1, 0, -4, true, 2, -2.0, 2.0)]           // Two roots (no linear term)
    [InlineData(2, -4, 2, true, 1, 1.0, null)]            // One root (scaled)
    public void Solve_ComprehensiveTestCases_ReturnsExpectedResult(
        double a, double b, double c, 
        bool expectedHasRealRoots, int expectedRootCount,
        double? expectedRoot1, double? expectedRoot2)
    {
        // Act
        double discriminant = b * b - 4 * a * c;
        _output.WriteLine($"INPUT: Equation {a}x² + {b}x + {c} = 0");
        _output.WriteLine($"INPUT: Discriminant = {discriminant}");
        _output.WriteLine($"Expected: HasRealRoots = {expectedHasRealRoots}, RootCount = {expectedRootCount}");
        _output.WriteLine($"Expected: Root1 = {expectedRoot1}, Root2 = {expectedRoot2}");
        
        var result = Core.QuadraticEquationSolver.Solve(a, b, c);

        // Assert
        _output.WriteLine($"OUTPUT: HasRealRoots = {result.HasRealRoots}, RootCount = {result.RootCount}");
        _output.WriteLine($"OUTPUT: Discriminant = {result.Discriminant}");
        _output.WriteLine($"OUTPUT: Root1 = {result.Root1?.ToString() ?? "null"}, Root2 = {result.Root2?.ToString() ?? "null"}");
        
        Assert.Equal(expectedHasRealRoots, result.HasRealRoots);
        Assert.Equal(expectedRootCount, result.RootCount);
        
        if (expectedRoot1.HasValue)
        {
            Assert.NotNull(result.Root1);
            Assert.Equal(expectedRoot1.Value, result.Root1.Value, 10);
        }
        else
        {
            Assert.Null(result.Root1);
        }

        if (expectedRoot2.HasValue)
        {
            Assert.NotNull(result.Root2);
            Assert.Equal(expectedRoot2.Value, result.Root2.Value, 10);
        }
        else
        {
            Assert.Null(result.Root2);
        }
    }

    #endregion
}

