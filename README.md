# FizzBuzz_CM
This is a FizzBuzz application, it is written in C#.    

# Tests
GenerateData_RulesReturnFizzBuzzWhenIndexIsProductMinusOne_True  
GenerateData_RulesDoNotReturnFizzBuzzWhenIndexIsProduct_True  
GenerateData_FirstRuleReturnFizz_True  
GenerateData_SecondRuleReturnBuzz_True  

# Build instructions
Since I am using Visual Studio 2019 my path to the MSBuild.exe file is `C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\msbuild.exe`
So therefore I run this command    

.\Script_To_Build.ps1 -path ConsoleApp2.sln -msBuildExe 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\msbuild.exe'