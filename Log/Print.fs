module Print

type StringConvertible =
  abstract member to_string : string with get

type Print =
    static member print (value:            string) = printf "%s\n" value
    static member print (value: StringConvertible) = Print.print(value.to_string)
