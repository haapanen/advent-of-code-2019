open System
open System.IO

let calculateRequiredFueld x = Math.Floor ((x / 3.0) - 2.0)

[<EntryPoint>]
let main argv =
    let inputLines = File.ReadLines("Input.txt");

    let modules = inputLines |> Seq.map int |> Seq.map float |> Seq.map calculateRequiredFueld 
    
    printfn "Required fuel: %d" (Seq.sum modules |> int)

    0 // return an integer exit code
