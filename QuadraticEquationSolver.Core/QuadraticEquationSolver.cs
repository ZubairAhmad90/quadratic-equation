namespace QuadraticEquationSolver.Core;

/// <summary>
/// Solves quadratic equations of the form ax² + bx + c = 0
/// </summary>
public class QuadraticEquationSolver
{
    /// <summary>
    /// Solves a quadratic equation ax² + bx + c = 0
    /// </summary>
    /// <param name="a">Coefficient of x² (must not be zero)</param>
    /// <param name="b">Coefficient of x</param>
    /// <param name="c">Constant term</param>
    /// <returns>A QuadraticEquationResult containing the roots and discriminant</returns>
    /// <exception cref="ArgumentException">Thrown when coefficient 'a' is zero</exception>
    public static QuadraticEquationResult Solve(double a, double b, double c)
    {
        if (Math.Abs(a) < double.Epsilon)
        {
            throw new ArgumentException("Coefficient 'a' cannot be zero for a quadratic equation.", nameof(a));
        }

        double discriminant = b * b - 4 * a * c;
        var result = new QuadraticEquationResult
        {
            Discriminant = discriminant
        };

        if (discriminant < 0)
        {
            // No real roots
            result.HasRealRoots = false;
            result.RootCount = 0;
            result.Root1 = null;
            result.Root2 = null;
        }
        else if (Math.Abs(discriminant) < double.Epsilon)
        {
            // One real root (repeated root)
            result.HasRealRoots = true;
            result.RootCount = 1;
            result.Root1 = -b / (2 * a);
            result.Root2 = null;
        }
        else
        {
            // Two real roots
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            result.HasRealRoots = true;
            result.RootCount = 2;
            result.Root1 = (-b - sqrtDiscriminant) / (2 * a);
            result.Root2 = (-b + sqrtDiscriminant) / (2 * a);
        }

        return result;
    }
}

