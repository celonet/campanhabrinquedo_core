@echo on

SET dotnet="C:\Program Files\dotnet\dotnet.exe"  
SET opencover=%userprofile%\.nuget\packages\OpenCover\4.6.519\tools\OpenCover.Console.exe  
SET reportgenerator=%userprofile%\.nuget\packages\ReportGenerator\2.5.11\tools\ReportGenerator.exe

SET targetargs="test test/campanhabrinquedo.tests/campanhabrinquedo.tests.csproj"  
SET filter="+[*]test/campanhabrinquedo.* -[*.Test]* -[xunit.*]* -[FluentValidation]*"  
SET coveragefile=Coverage.xml  
SET coveragedir=Coverage

echo Run code coverage analysis  
%opencover% 
    -target:%dotnet% 
    -oldStyle 
    -register:user     
    -output:%coveragefile% 
    -targetargs:%targetargs% 
    -filter:%filter% 
    -skipautoprops 
    -hideskipped:All

echo Generate the report  
%reportgenerator% -targetdir:%coveragedir% -reporttypes:Html;Badges -reports:%coveragefile% -verbosity:Error

echo Open the report  
start "report" "%coveragedir%\index.htm"  