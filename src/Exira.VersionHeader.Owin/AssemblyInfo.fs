namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyProductAttribute("Exira.VersionHeader.Owin")>]
[<assembly: AssemblyDescriptionAttribute("Exira.VersionHeader.Owin is an OWIN middleware to add assembly version information to HTTP headers")>]
[<assembly: AssemblyVersionAttribute("0.2.0")>]
[<assembly: AssemblyFileVersionAttribute("0.2.0")>]
[<assembly: AssemblyMetadataAttribute("githash","dac074d6924b4c503bd32ef70e5cbbaa2e4ea1f7")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.0"
