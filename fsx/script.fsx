
let square x = x * x
printfn "%A" (square 20)


open System
printf "Enter your command human:"
let input = Console.ReadLine()
printfn"Your command is: %A" input

let m =3.

let d:float = 3


let atuple= (1, 2., "Hi!")
let (a, b, c) = atuple

type person = { FirstName: string; LastName: string; Age:int;}
let person1 = { FirstName = "John"; LastName= "Doe"; Age= 30}

let astring = "dec\
ssa"

let swap (a, b) = (b, a)
swap(2, 4.)


let a = 2
let b = 3
let a = 4 in a*b |> ignore
let a = 5 in let b = 6 in a*b |> ignore
a


open System

let writetofile filename obj =
    using
        (IO.File.CreateText(filename))
        (fun file1 -> file1.WriteLine("{0}", obj.ToString())
    )

writetofile "abc.txt" "this is a test!"    

let detectZeroAnd = function
    | (0, 0) -> "Both values zero"
    | (var1, var2) & (0, _) -> $"First value is 0 in ({var1}, {var2})"
    | (var1, var2) & (_, 0) -> $"Second value is 0 in ({var1}, {var2})"
    | _ -> "Both nonzero"



let detectZeroAnd = function
    | (0, 0) -> "Both values zero"
    | (0, _) -> $"First value is 0"
    | (_, 0) -> $"Second value is 0"
    | _ -> "Both nonzero"

//detectZeroAnd (0, 0)

//detectZeroAnd (10, 0)

//detectZeroAnd (0, 10)

//detectZeroAnd (10, 10)


let sum_imperative items = 
    let mutable total = 0
    for item in items do total <- total + item
    total

sum_imperative [1..5]    