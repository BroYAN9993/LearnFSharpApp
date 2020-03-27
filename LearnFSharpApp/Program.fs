// Learn more about F# at http://fsharp.org

open System
module BasicFunctions =
    let sampleFunction1 x = x * x + 3
    let result = sampleFunction1 56
    let square x = x * x
    let addOne x = x + 1
    let isOdd x = x % 2 <> 0
    let sampleList = [0..99]
    let sampleMultiplicationTable = [for i in 1..9 -> [for j in 1..i -> (j, i, i * j)]]
    let numbers = [1..5]
    let squareOddAndAddOne values =
        let odds = List.filter isOdd values
        let squares = List.map square odds
        let result = List.map addOne squares
        result
    let result2 = squareOddAndAddOne numbers

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "BasicFunctions.sampleFunction1 56: %d" BasicFunctions.result
    printfn "sampleList:\n %A" BasicFunctions.sampleList
    printfn "sampleMultiplicationTable:\n %A" BasicFunctions.sampleMultiplicationTable
    printfn "squareOddAndAddOne:\n %A" BasicFunctions.result2
    0 // return an integer exit code
