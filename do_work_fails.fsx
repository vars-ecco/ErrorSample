#load "./ct_types_fails.fsx"
open Sometypes

let token = getToken "{\"access_token\":\"123\"}"

printfn "Token is %s" token