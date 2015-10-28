namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.1.7")>]
[<assembly: AssemblyFileVersionAttribute("0.1.7")>]
[<assembly: AssemblyMetadataAttribute("githash","40696710c67913909c218ad28d58b33fc44fff7e")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.7"
