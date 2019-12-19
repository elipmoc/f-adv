module FADVLib.ProjectServices.ProjectInfoJson

open FADVLib.ProjectServices.ProjectInfo
open FSharp.Data

type  ProjectInfoJson=JsonProvider<"""{"Name":"sample"}""">

//ProjectInfoをjson文字列に変換する
let toJsonFromProjectInfo (projectInfo:ProjectInfo):string=
    "{\"name\":\""+projectInfo.Name+"\"}"

//Json文字列をProjectInfoに変換する
let toProjectInfoFromJson (jsonText:string):ProjectInfo=
    let projectInfoJson = ProjectInfoJson.Parse(jsonText)
    { Name = projectInfoJson.Name }