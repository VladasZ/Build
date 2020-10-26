module main
open Path
open Print

let path = new Path(".")

[<EntryPoint>]
let main args =
    print path.info
    print path.parent.info
    print path.parent.parent.parent.parent.info
    print path.parent.parent.parent.parent.parent.parent.info
    print path.parent.parent.parent.parent.parent.parent.parent.info
    print path.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.parent.info
    0
    