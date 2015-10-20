module NUnit_Palindrome

open System
open System.Collections
open NUnit.Framework
open NUnit.Framework.Constraints
    
[<Test>]
let IsTrue() =
    let isPalindrome aLista = 
      List.rev aLista = aLista

      in

[<Test>]
let That1() =
    Assert.That(2+2=4)

[<Test>]
let That2() =
    Assert.That(2+2=4, Is.True)
