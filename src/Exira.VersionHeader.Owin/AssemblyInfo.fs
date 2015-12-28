namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.1.8")>]
[<assembly: AssemblyFileVersionAttribute("0.1.8")>]
[<assembly: AssemblyMetadataAttribute("githash","75d4b8edf5d7c58df74090d65e48e4bb5508d83a")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.8"
