let array1 = [| 3; 76; 43; 2; 1; 6; 7 |]
// printfn "%A" array1
// printfn "%A" (Array.min array1)
// printfn "%A" (Array.max array1)
// printfn "%A" (Array.filter (fun e -> e > 40) array1)
// printfn "%A" (Array.find (fun e -> e > 40) array1)

array1.[1] <- 5
// printfn "%A" array1

let array2 = [| for i in 1 .. 10 -> i * i |]
// printfn "%A" array2
// printfn "%A" array2.[2..4]
// printfn "%A" array2.[..4]
// printfn "%A" array2.[2..]
// printfn "%A" (Array.isEmpty array2)
printfn "%A" (Array.exists (fun x -> x = 4) array2)

// printfn "%A" (Array.append array2 array1)

let arrayOfZeroes : int array = Array.zeroCreate 10

// printfn "%A" arrayOfZeroes
// printfn "%A" (Array.length arrayOfZeroes)

let emptyArray = Array.empty
// printfn "%A" emptyArray
// printfn "%A" (Array.isEmpty emptyArray)

// printfn "%A" (Array.filter (fun elem -> elem % 2 = 0) [| 1 .. 10 |])

let floatArray = [| 5.6; 76.5; 432.3; 96.0; |]
// printfn "%A" (Array.average floatArray)