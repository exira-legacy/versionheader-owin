namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.1.5")>]
[<assembly: AssemblyFileVersionAttribute("0.1.5")>]
[<assembly: AssemblyMetadataAttribute("githash","ad269a330d1e23cf51b9be3ce20f3d8eb9cba0cb")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.5"
