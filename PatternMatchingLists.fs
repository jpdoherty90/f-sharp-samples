
// The pattern head :: tail is not concatenating, it is looking for a head + tail pattern
// the "l" here is not for list, it is for length.  The second argument, the list itself, is implied.
let rec getLengthOfList l = function
    | [] -> printfn "Length of list: %d" l
    | head :: tail -> getLengthOfList (l + 1) tail
let myList = [1..10]
getLengthOfList 0 myList
// This one could also have been written:
let rec getLengthOfListAlt len li = 
    match li with
    | [] -> printfn "Length of list: %d" len
    | head :: tail -> getLengthOfListAlt (len + 1) tail


let list1 = [ 1; 2; 3; 4 ]
// This example uses a cons pattern and a list pattern.
// Key here to remember is that a 1 item list has that item as head and [] as tail
// In this case l means list
let rec printList l =
    match l with
    | head :: tail -> printf " %d " head; printList tail
    | [] -> printfn "done"
printList list1
// This could also have been written:
let rec printListAlt = function
    | head :: tail -> printf " %d " head; printListAlt tail
    | [] -> printfn "done"


// Get the second to last item in a list
let rec getSecondLastItem = function
    | head :: tail :: [] -> head
    | head :: tail -> getSecondLastItem tail

printfn "%A" (getSecondLastItem list1)
// This one is a little more convoluted and language-specific