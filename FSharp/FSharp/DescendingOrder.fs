namespace FSharp

module DescendingOrder =
    
    let descendingOrder (n:int) : int =
        n
        |> string
        |> Seq.sortDescending
        |> Seq.toArray
        |> System.String
        |> System.Int32.Parse
