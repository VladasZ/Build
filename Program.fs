module main
open Path

let path = new Path(".")

[<EntryPoint>]
let main args =
    printfn "%A" path.info
    printfn "%A" path.parent.info
    printfn "%A" path.parent.parent.parent.parent.info
    printfn "%A" path.parent.parent.parent.parent.parent.parent.info
    printfn "%A" path.parent.parent.parent.parent.parent.parent.parent.info
    printfn "%A" path.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.info
    0
    