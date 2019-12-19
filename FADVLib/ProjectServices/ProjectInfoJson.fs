module FADVLib.ProjectServices.ProjectInfoJson

open FADVLib.ProjectServices.ProjectInfo

//ProjectInfoをjson文字列に変換する
let toJsonFromProjectInfo (projectInfo:ProjectInfo):string=
    "{\"name\":\""+projectInfo.Name+"\"}"