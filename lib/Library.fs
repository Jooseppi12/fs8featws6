namespace lib

type X =
    | A
    | B of X

    static let rec myFunc (x: X) =
        match x with
        | A -> printfn "Hello"
        | B x -> myFunc x

    static let unit : X = A

module Say =


    let hello name =
        printfn "Hello %s" name
