module Path

type Path(path: string) =
    member this.path = path
    member this.spath = "s" + path
    