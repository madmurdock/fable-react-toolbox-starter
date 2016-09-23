﻿module Starter.App

open Fable.Import

type Model = unit

module R = Fable.Helpers.React
module RT = Fable.Import.ReactToolbox.Components
    
type App() =
    inherit React.Component<obj, Model>()
    
    member x.render() =
        RT.button [] [ unbox "Click!" ]
//        R.div [] [ unbox "Hello, world" ]

ReactDom.render(
        R.com<App,_,_> () [],
        Browser.document.getElementsByClassName("app").[0]
    ) |> ignore