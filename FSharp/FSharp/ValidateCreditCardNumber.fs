//https://www.codewars.com/kata/5418a1dd6d8216e18a0012b2/train/fsharp

namespace FSharp

open System

module ValidateCreditCardNumber =

    let toIntArray input =
        input
        |> String.filter (fun letter -> letter <> ' ')
        |> Seq.map (fun a -> System.Int32.Parse(string a))
        
    let validate str =
        let code = toIntArray str
        let checksum = 
            code
            |> Seq.mapi (fun index digit -> if index % 2 = 0 then digit * 2 else digit)
            |> Seq.map (fun digit ->if digit > 9 then digit - 9 else digit)
            |> Seq.sum      
        checksum % 10 = 0
        