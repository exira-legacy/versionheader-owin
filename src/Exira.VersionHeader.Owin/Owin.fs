namespace Exira.VersionHeader.Owin

open Owin
open System
open System.Collections.Generic
open System.Threading.Tasks
open System.Runtime.CompilerServices
open System.Reflection

type VersionHeaderOptions(versionType: Type) =
    member val VersionType = versionType with get, set
    member val HeaderName = "Release" with get, set
    member val HeaderFormat = "%s %O" with get, set

type VersionHeaderMiddleware(next: Func<IDictionary<string, obj>, Task>, options: VersionHeaderOptions) =
    let awaitTask = Async.AwaitIAsyncResult >> Async.Ignore
    let owinResponseHeaders = "owin.ResponseHeaders"
    let customFormat = Printf.StringFormat<string -> Version -> string>(options.HeaderFormat)

    let updateOrAdd key value (dict: dict<'Key, 'T>) =
        lock dict <| fun () -> dict.[key] <- value
        dict

    member this.Invoke (environment: IDictionary<string, obj>) =
       async {
            do! next.Invoke environment |> awaitTask

            let assemblyName = Assembly.GetAssembly(options.VersionType).GetName()
            let versionNumber = sprintf customFormat assemblyName.Name assemblyName.Version

            let updatedHeaders =
                environment.[owinResponseHeaders] :?> IDictionary<string, string[]>
                |> updateOrAdd options.HeaderName [| versionNumber |]

            do environment.[owinResponseHeaders] <- updatedHeaders
        } |> Async.StartAsTask :> Task

[<ExtensionAttribute>]
type AppBuilderExtensions =
    [<ExtensionAttribute>]
    static member UseVersionHeader(appBuilder: IAppBuilder, options: VersionHeaderOptions) =
        appBuilder.Use<VersionHeaderMiddleware>(options)
