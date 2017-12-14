### A C# to APEX Converter AND a APEX to C# Converter

[![appveyor](https://ci.appveyor.com/api/projects/status/github/jayonsoftware/apexsharp?svg=true)](https://ci.appveyor.com/project/jayonsoftware/apexsharp)
[![tests](https://img.shields.io/appveyor/tests/jayonsoftware/apexsharp.svg)](https://ci.appveyor.com/project/jayonsoftware/apexsharp/build/tests)
[![codecov](https://codecov.io/gh/yallie/apexsharp/branch/master/graph/badge.svg)](https://codecov.io/gh/yallie/apexsharp)
[![NuGet](https://img.shields.io/nuget/v/ApexParser.svg)](https://nuget.org/packages/ApexParser)


Apex <> C# - Two Way [Transpiler](https://en.wikipedia.org/wiki/Source-to-source_compiler). A Quick 10 Min Video Intro can be found at https://vimeo.com/224927838

I am working on a detail documentation, but for now I assume you are a C# developer who is working on Salesforce.

#### Setting up and Running 

0. Create a new SF Dev org, get your API Token
1. Download the whole Git Repo, save it in a folder at root leave under /ApexSharp
2. Start the apexSharpDemo Solution
3. Demo Project is the project you want to work on
4. On Setup.cs, set your SF Id, PW, Token

 ```csharp
.WithUserId("You SF Id")
.AndPassword("You SF Password")
.AndToken("Token")
```

5. Run the demo project.

Questions, Post it at https://github.com/apexsharp/apexsharp/issues

