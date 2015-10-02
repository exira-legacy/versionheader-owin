# versionheader-owin [![NuGet Status](http://img.shields.io/nuget/v/Exira.VersionHeader.Owin.svg?style=flat)](https://www.nuget.org/packages/Exira.VersionHeader.Owin/)

## Exira.VersionHeader.Owin

Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers.

### Usage

Use the ```UseVersionHeader``` extension method with a ```VersionHeaderOptions```.

Pass in the ```System.Type``` of the assembly you wish the version information to be included in the HTTP header.

Using this from F# can be done as follows:

``` fsharp
let registerVersionHeader (app: IAppBuilder) =
    let config =
        VersionHeaderOptions(
            versionType = typedefof<Startup>,
            HeaderName = "Release")

    app.UseVersionHeader(config) |> ignore
```

## Cloning

```git clone git@github.com:exira/versionheader-owin.git -c core.autocrlf=input```
