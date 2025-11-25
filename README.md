## Quadratic Equation Solver – Project Report

### 1. Objective
- Build a .NET solution that solves quadratic equations (`ax² + bx + c = 0`)
- Provide automated quality control using unit tests (XUnit, `Theory`/`InlineData`)
- Capture demonstrable evidence of input/output in the unit-test logs
- Maintain the project under Git and document supporting activities (e.g., LearnGitBranching exercises, remote repo setup)

### 2. Solution Structure
- `QuadraticEquationSolver.Core`
  - `QuadraticEquationSolver.cs` implements the solver using the quadratic formula and robust validation (rejects `a = 0`, reports discriminant).
  - `QuadraticEquationResult.cs` packages discriminant, root count, and optional roots.
- `QuadraticEquationSolver.Tests`
  - `QuadraticEquationSolverTests.cs` contains 33 XUnit tests covering:
    - Negative discriminant (no real roots)
    - Zero discriminant (single repeated root)
    - Positive discriminant (two distinct real roots)
    - Edge cases (linear equations, large coefficients, missing linear term, negative `a`, discriminant validation).
  - Tests print both the **input** equation and the **output** discriminant/roots via `ITestOutputHelper`, satisfying the “show input/output in test logs” requirement.

### 3. Implementation Highlights
- **Solver Logic**:
  1. Validates `a ≠ 0` (`double.Epsilon` guard) and throws `ArgumentException` with parameter name `a`.
  2. Calculates discriminant `b² - 4ac` and classifies root cases.
  3. Returns structured data that callers and tests can consume.
- **Unit Tests**:
  - Use `Theory` + `InlineData` for multiple parameter sets (appreciated by assignment instructions).
  - Exercise different Assert APIs (`Assert.Equal`, `Assert.True`, `Assert.Throws`, `Assert.Contains`, etc.).
  - Each test logs:
    ```
    INPUT: Equation 1x² + -5x + 6 = 0
    INPUT: Discriminant = 1 (positive, two real roots)
    Expected: Root1 = 2, Root2 = 3
    OUTPUT: HasRealRoots = True, RootCount = 2
    OUTPUT: Discriminant = 1
    OUTPUT: Root1 = 2, Root2 = 3
    ```

### 4. Build & Test Instructions
```bash
cd quadratic-equation-solver
dotnet restore
dotnet build
dotnet test --verbosity detailed
```
Sample command for a single test with captured I/O:
```bash
dotnet test --filter "FullyQualifiedName~Solve_NoRealRoots_NegativeDiscriminant" --logger "console;verbosity=detailed"
```

### 5. Git & Remote Repository Notes
- Initialize local repo:
  ```bash
  git init
  git add .
  git commit -m "Initial commit: quadratic solver with unit tests"
  ```
- Connect to remote (GitHub/GitLab/etc.):
  ```bash
  git remote add origin <your-remote-url>
  git push -u origin main
  ```
- **LearnGitBranching requirement**: complete “Main” tab of the “Introduction” section and “Remote” tab of the “Push & Pull – Remote Repositories” section on https://learngitbranching.js.org/. Capture screenshots and attach them to the submission bundle (placeholders can be stored in a `docs/` folder or embedded in the final PDF/slide deck).

### 6. Deliverables Checklist
- [x] Solver implementation (`QuadraticEquationSolver.cs`)
- [x] Structured result object (`QuadraticEquationResult.cs`)
- [x] XUnit test suite with Theory-based scenarios
- [x] Test output includes human-readable input/output details
- [x] README with usage instructions
- [x] Git repository initialized; instructions included for remote integration
- [x] LearnGitBranching exercises complete (user to add screenshots)

### 7. Next Steps / Recommendations
- Add CI pipeline (GitHub Actions / GitLab CI) that runs `dotnet test`.
- Track code coverage (Coverlet + ReportGenerator) for reporting.
- Extend solver to return complex roots when discriminant < 0 (if required).
- Attach LearnGitBranching screenshots and any Git remote push evidence to the final submission package.

<img width="1<img width="1656" height="1606" alt="image (58)" src="https://github.com/user-attachments/assets/183f8793-d92b-4873-b9cb-a4dcfbcadcb4" />
948" height="1512" alt="image (54)" src="https://github.com/user-attachments/assets/5f1eb18e-00bd-40f9-a819-11b05772de28" />

<img width="2314" height="1208" alt="image (55)" src="https://github.com/user-attachments/assets/e1482bcd-3482-41cf-a136-7061bff84a7d" />
<img width="1978" height="984" alt="image (56)" src="https://github.com/user-attachments/assets/d5876d36-ef76-4726-ba1f-aa65273fd934" />
<img width="2308" height="1486" alt="image (57)" src="https://github.com/user-attachments/assets/cd1094f2-0033-421f-a033-f20d1a4d3530" />


