﻿//https://www.codewars.com/kata/5418a1dd6d8216e18a0012b2/train/fsharp

namespace FSharp

open System

module ValidateCreditCardNumber =

    let toIntArray input =
        input
        |> String.filter (fun letter -> letter <> ' ')
        |> Seq.map (fun a -> System.Int32.Parse(string a))
    
    let doubleIfSecond digit index =
        if index % 2 = 0 then
            digit
        else
            digit * 2
            
    let replaceGreaterThenNine digit =
        if digit > 9 then
            digit - 9
        else
            digit
    
    let doubleDigits input =
        input
        |> Seq.rev
        |> Seq.mapi (fun index digit -> doubleIfSecond digit index)
        |> Seq.rev
        
    let validate str =
        let code = toIntArray str
        let checksum = 
            code
            |> doubleDigits
            |> Seq.map (replaceGreaterThenNine)
            |> Seq.sum      
        checksum % 10 = 0
        