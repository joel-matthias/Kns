## Build Package
```
dotnet pack
```
## Install (first time)
```
dotnet tool install --global --add-source ./nupkg Kns
```
## List Currently Installed Glbal Tools
```
dotnet tool list --global
```
## Install (subsequent times)
```
dotnet tool update --global --add-source ./nupkg Kns
```
## Uninstall
```
dotnet tool uninstall --global kns
```