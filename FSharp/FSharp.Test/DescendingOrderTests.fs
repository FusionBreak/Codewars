module DescendingOrderTests

open System
open Xunit
open FSharp.DescendingOrder

[<Fact>]
let ``test 01`` () = Assert.Equal(descendingOrder 42145, 54421)

[<Fact>]
let ``test 02`` () = Assert.Equal(descendingOrder 145263, 654321)

[<Fact>]
let ``test 03`` () = Assert.Equal(descendingOrder 123456789, 987654321)
