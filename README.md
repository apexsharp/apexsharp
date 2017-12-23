### A C# to APEX Converter AND a APEX to C# Converter


Apex <> C# - Two Way [Transpiler](https://en.wikipedia.org/wiki/Source-to-source_compiler). A Quick 10 Min Video Intro can be found at https://vimeo.com/224927838

We are working on a detail documentation, but for now we assume you are a C# developer who is working on Salesforce. Our document Wiki will be https://github.com/apexsharp/apexsharp/wiki

#### Setting up and Running 


0. Create a new SF Dev org, get your API Token
1. Download this Repo (If you want to contribute please work on the dev branch)
3. This is a Net 2.0 project thus you can open this on Visual Studio, Visual Studio Code, Visual Studio for Mac or [JetBrains Rider](https://www.jetbrains.com/rider/). 
4. Open the apexSharp Solution
5. Create an appsettings.json file with the following info. Here we assume you save the git repo to your C: drive and you are using Windows. 

```json
{
  // The location of your log File
  "LogFile": "c:/apexsharp/Demo/log.log", 
  // SessionFileInfo is where your SF session will be saved or located
  "SessionFileInfo": "c:/apexSharp/config.json",
  // SalesForceLocation is the location of your Salesofrce project
  "SalesForceLocation": "c:/apexSharp/SalesForce/src/",
  // VsProjectLocation is the location of your Visual Studio Project
  "VsProjectocation": "c:/apexSharp/Demo/",
  // Your SF Id
  "SalesForceUserId": "Your SF Id",
  // Your SF Password
  "SalesForcePassword": "SF Password",
  // Your SF Token
  "SalesForceToken": "SF Token"
}
```
6. Open the Demo Project. You can find examples in the /CSharpClasses Folder
6. Run Program.cs

Folder Structure


<a href="https://github.com/apexsharp/apexsharp/tree/master/Demo" target="_blank">/Demo</a> is the folder you will be working on. It contains few examples

<a href="https://github.com/apexsharp/apexsharp/tree/master/SalesForce" target="_blank">/Salesforce </a>contains a SF project that is used for the above demo

Questions ? Post it at https://github.com/apexsharp/apexsharp/issues



