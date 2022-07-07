module ValidateCreditCardNumberTests

open System
open Xunit
open FSharp.ValidateCreditCardNumber

[<Fact>]
let ``test 01`` () = Assert.True(validate "677  674")

[<Fact>]
let ``test 02`` () = Assert.True(validate "8707  3848  8176")

[<Fact>]
let ``test 03`` () = Assert.True(validate "252  866")

[<Fact>]
let ``test 04`` () = Assert.True(validate "1786  8374  3359")

[<Fact>]
let ``test 06`` () = Assert.True(validate "7737  6212  43880")

[<Fact>]
let ``test 07`` () = Assert.False(validate "6466 2631 57527")

[<Fact>]
let ``test 08`` () = Assert.False(validate "7144 0207 7322")

[<Fact>]
let ``test 09`` () = Assert.False(validate "442 831")

[<Fact>]
let ``test 10`` () = Assert.False(validate "52 33 31 28") 

[<Fact>]
let ``test 05`` () = Assert.False(validate "7612 1156 0071")


