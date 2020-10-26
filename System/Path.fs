module Path

type Path(path: string) =
    member this.path = path
    member this.full = System.IO.Path.GetFullPath(path)
    member this.is_root = obj.ReferenceEquals(System.IO.DirectoryInfo(this.full).Parent, null)
    
    member this.parent = match this.is_root with
    | true  -> new Path(this.full)
    | false -> new Path(System.IO.Directory.GetParent(path).ToString())
    
    member this.info = "Path: " + this.full + " is root: " + this.is_root.ToString()