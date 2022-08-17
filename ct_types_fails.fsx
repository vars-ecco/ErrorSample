module Sometypes

#r "nuget: FSharp.Data,5.0.1"
open FSharp.Data
type Auth = JsonProvider<const(__SOURCE_DIRECTORY__ + "/samples/auth.json")>

let getToken json = 
    (Auth.Parse(json)).AccessToken