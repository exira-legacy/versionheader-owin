(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
versionheader-owin [![NuGet Status](http://img.shields.io/nuget/v/Exira.VersionHeader.Owin.svg?style=flat)](https://www.nuget.org/packages/Exira.VersionHeader.Owin/)
======================

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The versionheader-owin library can be <a href="https://nuget.org/packages/Exira.VersionHeader.Owin">installed from NuGet</a>:
      <pre>PM> Install-Package Exira.VersionHeader.Owin</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Usage
-----
Use the `UseVersionHeader` extension method with a `VersionHeaderOptions`.

Pass in the `System.Type` of the assembly you wish the version information to be included in the HTTP header.

Using this from F# can be done as follows:

*)
let registerVersionHeader (app: IAppBuilder) =
    let config =
        VersionHeaderOptions(
            versionType = typedefof<Startup>,
            HeaderName = "Release")

    app.UseVersionHeader(config) |> ignore
(**

Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork
the project and submit pull requests. You might also want to read the
[library design notes][readme] to understand how it works.

For more information see the [License file][license] in the GitHub repository.

  [content]: https://github.com/exira/versionheader-owin/tree/master/docs/content
  [gh]: https://github.com/exira/versionheader-owin
  [issues]: https://github.com/exira/versionheader-owin/issues
  [readme]: https://github.com/exira/versionheader-owin/blob/master/README.md
  [license]: https://github.com/exira/versionheader-owin/blob/master/LICENSE.txt
*)
