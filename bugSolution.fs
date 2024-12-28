let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

//Correct way to swap values within a function using a tuple:

let swapTuple (x, y) = (y, x)

let myTuple = (10,20)
let swappedTuple = swapTuple myTuple
printfn "%d %d" (fst swappedTuple) (snd swappedTuple) //This will print 20 10 as expected