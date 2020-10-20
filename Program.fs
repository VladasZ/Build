
type Path(path: string) =
    member this.path = path
    
    member this.spath = "s" + path


let path = new Path("pjt1")

printfn "%A" path.spath
