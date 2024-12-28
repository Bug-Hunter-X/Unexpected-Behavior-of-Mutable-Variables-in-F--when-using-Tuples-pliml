let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

//However, if you try to swap values within a function that takes a tuple as an argument:

let swapTuple (x, y) = 
    let temp = x
    x <- y
    y <- temp

let myTuple = (10,20)
swapTuple myTuple
printfn "%d %d" (fst myTuple) (snd myTuple) //This will print 10 20, not 20 10 as expected