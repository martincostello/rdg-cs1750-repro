# Request Delegate Generator CS1750 Repro

To replicate the issue, run `dotnet biuld` in the root directory of this repository.

```terminal
$ dotnet build
MSBuild version 17.8.0+6cdef4241 for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
Microsoft.AspNetCore.Http.RequestDelegateGenerator\Microsoft.AspNetCore.Http.RequestDelegateGenerator.RequestDelegateGenerator\GeneratedRouteBuilderExtensions.g.cs(94,202): error CS1750: A value of type '<null>' cannot be used as a default parameter because there are no standard conversions to type'CancellationToken' [Repro.csproj]

Build FAILED.

Microsoft.AspNetCore.Http.RequestDelegateGenerator\Microsoft.AspNetCore.Http.RequestDelegateGenerator.RequestDelegateGenerator\GeneratedRouteBuilderExtensions.g.cs(94,202): error CS1750: A value of type '<null>' cannot be used as a default parameter because there are no standard conversions to type 'CancellationToken' [Repro.csproj]
    0 Warning(s)
    1 Error(s)

Time Elapsed 00:00:01.56
```
