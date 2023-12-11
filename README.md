# DotNetTemplateQualityRules
Template to create .NET quality rules using Roslyn

# Windows
## Running tests using the Test Explorer


# Linux
## Deploy .NET 8.0
- Install:
  sudo dnf install dotnet-sdk-8.0
- Verify SDKs:
  dotnet --list-sdks
- Verify runtimes:
  dotnet --list-runtimes
## Unzip data
- Unzip the folder for example in /home/xxx/Documents/data/TCQR/
## Compile projects
- Go to /home/xxx/Documents/data/TCQR/TemplateCastQualityRule/
- dotnet build TemplateCastQualityRules.csproj -c Release --runtime linux-x64 /p:PublishReadyToRun=true /p:Platform=x64
- Go to home/xxx/Documents/data/TCQR/ TestsTemplateQualityRules/
- dotnet build UnitTestTemplateCastQualityRules.csproj -c Release --runtime linux-x64 /p:PublishReadyToRun=true /p:Platform=x64
## Deploy third\_parties folder for tests
- Unzip the third\_parties folder to /home/xxx/Documents/data/TCQR/TestsTemplateQualityRules/bin/x64/Release/net8.0/linux-x64/
## Run the tests
- Go to /home/xxx/Documents/data/TCQR/TestsTemplateQualityRules/bin/x64/Release/net8.0/linux-x64/
- dotnet test UnitTestTemplateCastQualityRules.dll
