namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.1.9")>]
[<assembly: AssemblyFileVersionAttribute("0.1.9")>]
[<assembly: AssemblyMetadataAttribute("githash","7de697425bea8718d795da6af16ef20dcd694885")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.9"
