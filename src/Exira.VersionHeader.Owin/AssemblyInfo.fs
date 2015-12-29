namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.2.10")>]
[<assembly: AssemblyFileVersionAttribute("0.2.10")>]
[<assembly: AssemblyMetadataAttribute("githash","8be00412d3c6f2c52c76dbfef20ae4d7228ec417")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.10"
