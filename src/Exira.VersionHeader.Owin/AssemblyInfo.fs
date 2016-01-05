namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.2.14")>]
[<assembly: AssemblyFileVersionAttribute("0.2.14")>]
[<assembly: AssemblyMetadataAttribute("githash","87a827a999cf1d5e800ec6e8c3868c1a32340635")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.14"
