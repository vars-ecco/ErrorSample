module Sometypes

#r "nuget: FSharp.Data,4.2.9"
open FSharp.Data
type Auth = JsonProvider<const(__SOURCE_DIRECTORY__ + "/samples/auth.json")>

let getToken json = 
    (Auth.Parse(json)).AccessToken