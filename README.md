### A C# to APEX Converter AND a APEX to C# Converter


Apex <> C# - Two Way [Transpiler](https://en.wikipedia.org/wiki/Source-to-source_compiler). A Quick 10 Min Video Intro can be found at https://vimeo.com/224927838

We are working on a detail documentation, but for now we assume you are a C# developer who is working on Salesforce. Our document Wiki will be https://github.com/apexsharp/apexsharp/wiki

#### Setting up and Running 


0. Create a new SF Dev org, get your API Token
1. Download the whole Git Repo, save it in a folder at root under \ApexSharp
3. This is a Net 2.0 project thus you can open this on Visual Studio, Visual Studio Code, Visual Studio for Mac or [JetBrains Rider](https://www.jetbrains.com/rider/). 
4. Start the apexSharpDemo Solution
5. Demo Project is the project you want to work on
6. On Setup.cs, set your SF Id, PW, Token

 ```csharp
.WithUserId("You SF Id")
.AndPassword("You SF Password")
.AndToken("Token")
```

5. Run the demo project.

Questions ? Post it at https://github.com/apexsharp/apexsharp/issues



