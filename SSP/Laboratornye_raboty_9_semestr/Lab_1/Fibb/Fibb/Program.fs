module lab_1 = 
    let rec fibb (n: int) = 
        if n <= 1 then 1 
        else fibb (n-2) + fibb (n-1)

[<EntryPoint>]
let main argv = 
    printfn "%d" (lab_1.fibb 3)
    System.Console.ReadLine()
    0