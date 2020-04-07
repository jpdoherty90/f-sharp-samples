
type OptionT = 
    | Put of float
    | Call of float
    | Combine of OptionT * OptionT

let combine = Combine (Put 4.5, Combine (Put 6.5, Call 6.7))
System.Console.WriteLine(combine)

type Tree = 
    | Leaf of int
    | Node of Tree * Tree

let leaf = Leaf 2
let simpleTree1 = Node (leaf, Leaf 2)
let simpleTree2 = Node (Leaf 4, Leaf 7)
let simpleTree3 = Node (Leaf 5, Leaf 8)
let complexTree1 = Node (simpleTree1, simpleTree2)
let complexTree2 = Node (simpleTree3, complexTree1)

let countLeaves tree = 
    let rec loop sum = function
        | Leaf(_) -> sum + 1
        | Node(tree1, tree2) -> sum + (loop 0 tree1) + (loop 0 tree2)
    loop 0 tree

System.Console.WriteLine(countLeaves complexTree2)

let countNumbers tree = 
    let rec loop sum = function
        | Leaf(x) -> sum + x
        | Node(tree1, tree2) -> sum + (loop 0 tree1) + (loop 0 tree2)
    loop 0 tree

System.Console.WriteLine(countNumbers complexTree2)