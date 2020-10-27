module main
open Path
open Print

let path = new Path(".")

[<EntryPoint>]
let main args =
    Print.print path.info
   // print path
    0
    