namespace QuadraticEquationSolver.Core;

/// <summary>
/// Represents the result of solving a quadratic equation.
/// </summary>
public class QuadraticEquationResult
{
    /// <summary>
    /// Indicates whether the equation has real roots.
    /// </summary>
    public bool HasRealRoots { get; set; }

    /// <summary>
    /// The number of real roots (0, 1, or 2).
    /// </summary>
    public int RootCount { get; set; }

    /// <summary>
    /// The first root (if exists).
    /// </summary>
    public double? Root1 { get; set; }

    /// <summary>
    /// The second root (if exists).
    /// </summary>
    public double? Root2 { get; set; }

    /// <summary>
    /// The discriminant value (b² - 4ac).
    /// </summary>
    public double Discriminant { get; set; }
}

