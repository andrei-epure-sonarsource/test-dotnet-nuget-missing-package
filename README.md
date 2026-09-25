# Missing NuGet package fixture

This is an intentionally broken .NET project for SonarQube Cloud automatic-analysis testing.

`Autoscan.NuGet.Fixture.Does.Not.Exist` with version `99.99.99` is deliberately absent from NuGet.org. AutoScan.NET should log the package-resolution warning (`no matching version was found`), skip the reference, resolve `Newtonsoft.Json`, and complete analysis. This is the warning-only case, so it must not emit `NuGetResolutionErrorCount`.

The application code is otherwise real and uses `Newtonsoft.Json`. A normal `dotnet restore` or `dotnet build` is expected to fail because the missing package is deliberate; use automatic analysis to exercise the continuation behavior.
