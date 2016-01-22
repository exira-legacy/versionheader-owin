namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.3.15")>]
[<assembly: AssemblyFileVersionAttribute("0.3.15")>]
[<assembly: AssemblyMetadataAttribute("githash","4c86051c1d5241c1b374007f76efabd5aaf644e2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.15"
