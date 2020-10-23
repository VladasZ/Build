module main
open Path

let path = new Path("pjt1")

[<EntryPoint>]
let main args =
    printfn "%A" path.spath
    0
    