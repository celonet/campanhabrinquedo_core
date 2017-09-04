@echo on

SET dotnet="C:\Program Files\dotnet\dotnet.exe"  
SET opencover=%userprofile%\.nuget\packages\OpenCover\4.6.519\tools\OpenCover.Console.exe  
SET reportgenerator=%userprofile%\.nuget\packages\ReportGenerator\2.5.11\tools\ReportGenerator.exe

SET targetargs="test D:\Marcelo\Projetos\campanhabrinquedo_core\test\campanhabrinquedo.tests/campanhabrinquedo.tests.csproj"  
SET filter="+[*]test/campanhabrinquedo.* -[*.Test]* -[xunit.*]* -[FluentValidation]*"  
SET filter="+[*]*" 
SET coveragefile=Coverage.xml  
SET coveragedir=Coverage

echo Run code coverage analysis  

C:\Users\celo-\.nuget\packages\opencover\4.6.519\tools\OpenCover.Console.exe 
    -target:"C:\Program Files\dotnet\dotnet.exe" 
    -targetdir:"D:\Marcelo\Projetos\campanhabrinquedo_core\test\campanhabrinquedo.tests/bin/Debug/netcoreapp2.0"
    -targetargs:"test D:\Marcelo\Projetos\campanhabrinquedo_core\test\campanhabrinquedo.tests/campanhabrinquedo.tests.csproj"


REM %opencover% 
REM     -target:%dotnet% 
REM     -targetargs:%targetargs% 
REM     -output:%coveragefile% 
REM     -oldStyle 
REM     -register:user     
REM     -skipautoprops 
REM     -hideskipped:All

echo Generate the report  
%reportgenerator% -targetdir:%coveragedir% -reporttypes:Html;Badges -reports:%coveragefile% -verbosity:Error

echo Open the report  
start "report" "%coveragedir%\index.htm"  