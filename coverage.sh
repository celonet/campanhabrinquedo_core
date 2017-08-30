#!/bin/bash

set -e

# Install OpenCover and ReportGenerator, and save the path to their executables.
# nuget install -Verbosity quiet -OutputDirectory packages -Version 4.6.519 OpenCover
# nuget install -Verbosity quiet -OutputDirectory packages -Version 2.4.5.0 ReportGenerator

#OPENCOVER= ~/.nuget/packages/opencover/4.6.519/tools/OpenCover.Console.exe
#REPORTGENERATOR= ~/.nuget/packages/reportgenerator/2.4.11/tools/ReportGenerator.exe

CONFIG=Release
# Arguments to use for the build
DOTNET_BUILD_ARGS="-c $CONFIG"
# Arguments to use for the test
DOTNET_TEST_ARGS="$DOTNET_BUILD_ARGS"

echo CLI args: $DOTNET_BUILD_ARGS

echo Restoring

dotnet restore ./test/campanhabrinquedo.tests

echo Building

dotnet build ./test/campanhabrinquedo.tests $DOTNET_BUILD_ARGS

echo Testing

coverage=./coverage
rm -rf $coverage
mkdir $coverage

dotnet test -f netcoreapp2.0 $DOTNET_TEST_ARGS test/campanhabrinquedo.tests/campanhabrinquedo.tests.csproj

#-filter:"+[Stubbery*]* -[Stubbery.*Tests*]*" \

# $OPENCOVER \
#  -target:"c:\Program Files\dotnet\dotnet.exe" \
#  -targetargs:"test -f netcoreapp1.0 $DOTNET_TEST_ARGS test/Stubbery.IntegrationTests/Stubbery.IntegrationTests.csproj" \
#  -mergeoutput \
#  -hideskipped:File \
#  -output:$coverage/coverage.xml \
#  -oldStyle \
#  -filter:"+[Stubbery*]* -[Stubbery.*Tests*]*" \
#  -searchdirs:$testdir/bin/$CONFIG/netcoreapp1.0 \
#  -register:user

echo "Calculating coverage with OpenCover"
~/.nuget/packages/opencover/4.6.519/tools/OpenCover.Console.exe \
  -target:"c:\Program Files\dotnet\dotnet.exe" \
  -targetargs:"test -f netcoreapp2.0 $DOTNET_TEST_ARGS test/campanhabrinquedo.tests/campanhabrinquedo.tests.csproj" \
  -mergeoutput \
  -hideskipped:File \
  -output:$coverage/coverage.xml \
  -oldStyle \
  -searchdirs:$testdir/bin/$CONFIG/netcoreapp2.0 \
  -register:user

echo "Generating HTML report"
~/.nuget/packages/reportgenerator/2.4.11/tools/ReportGenerator.exe \
  -reports:$coverage/coverage.xml \
  -targetdir:$coverage \
  -verbosity:Error