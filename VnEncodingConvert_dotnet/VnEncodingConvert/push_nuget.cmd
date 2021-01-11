
dotnet nuget push "bin\Release\*.nupkg" -n --skip-duplicate -s "github"
dotnet nuget push "bin\Release\*.nupkg" -n --skip-duplicate -s "nuget.org"