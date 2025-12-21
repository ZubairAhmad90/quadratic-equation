# zubair-A-class
![logo](https://github.com/ZubairAhmad90/Zubair-Ahmad/blob/main/github-header-image-4.png)
<h1 align="center">Hi 👋, I'm Zubair Ahmad</h1>
<h3 align="center">A passionate frontend developer from poland</h3>

<img align="right" alt="coding" width="400" src="https://user-images.githubusercontent.com/55389276/140866485-8fb1c876-9a8f-4d6a-98dc-08c4981eaf70.gif">
<p align="left"> <img src="https://komarev.com/ghpvc/?username=Zubair-Ahmad90&label=Profile%20views&color=0e75b6&style=flat" alt="Zubair-Ahmad90" /> </p>

- 🌱 I’m currently learning **Angular**

- 👨‍💻 All of my projects are available at http://linkedin.com/in/zubair-ahmad-385a9b253?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BX1RovXkpRL6SH%2F8etkYwHw%3D%3D](https://www.linkedin.com/in/usama-farooq-ab2392263?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BX1RovXkpRL6SH%2F8etkYwHw%3D%3D)

- 💬 Ask me about **HTML5,CSS3,SASS,SCSS,GITHUB,BOOTSTRAP5,FIGMA,JAVASCRIPT,ANGULAR,UI COMPONENTS,**

- 📫 How to reach me **zubair.leo.1990@gmail.com**

- 📄 Know about my experiences [ASK ME ABOUT MY RESUME](ASK ME ABOUT MY RESUME)

- ⚡ Fun fact **I M FUNNY AND SMART**

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/Zubair Ahmad" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="Zubair Ahmad" height="30" width="40" /></a>
<a href="https://fb.com/Zubair Ahmad" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/facebook.svg" alt="Zubair Ahmad" height="30" width="40" /></a>
<a href="https://instagram.com/leo.ahmad08" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/instagram.svg" alt="leo.ahmad08" height="30" width="40" /></a>
</p>

<h3 align="left">Languages and Tools:</h3>
<p align="left"> <a href="https://developer.android.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/android/android-original-wordmark.svg" alt="android" width="40" height="40"/> </a> <a href="https://angular.io" target="_blank" rel="noreferrer"> <img src="https://angular.io/assets/images/logos/angular/angular.svg" alt="angular" width="40" height="40"/> </a> <a href="https://angular.io" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/angularjs/angularjs-original-wordmark.svg" alt="angularjs" width="40" height="40"/> </a> <a href="https://getbootstrap.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/bootstrap/bootstrap-plain-wordmark.svg" alt="bootstrap" width="40" height="40"/> </a> <a href="https://www.w3schools.com/css/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="css3" width="40" height="40"/> </a> <a href="https://www.figma.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/figma/figma-icon.svg" alt="figma" width="40" height="40"/> </a> <a href="https://git-scm.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/git-scm/git-scm-icon.svg" alt="git" width="40" height="40"/> </a> <a href="https://www.w3.org/html/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="html5" width="40" height="40"/> </a> <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg" alt="javascript" width="40" height="40"/> </a> <a href="https://nodejs.org" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/nodejs/nodejs-original-wordmark.svg" alt="nodejs" width="40" height="40"/> </a> <a href="https://sass-lang.com" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/sass/sass-original.svg" alt="sass" width="40" height="40"/> </a> </p>

<p><img align="left" src="https://github-readme-stats.vercel.app/api/top-langs?username=ZubairAhmad90&show_icons=true&locale=en&layout=compact" alt="ZubairAhmad90" /></p>

<p>&nbsp;<img align="center" src="https://github-readme-stats.vercel.app/api?username=ZubairAhmad90&show_icons=true&locale=en" alt="ZubairAhmad90" /></p>

<p><img align="center" src="https://github-readme-streak-stats.herokuapp.com/?user=ZubairAhmad90&show" alt="ZubairAhmad90" /></p>

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


