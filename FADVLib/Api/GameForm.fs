module public FADVLib.Api.GameForm

open System.Windows.Forms

type GameForm()=
    class
        inherit Form()
    end

let startApplication _=
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault false
    Application.Run(new GameForm())