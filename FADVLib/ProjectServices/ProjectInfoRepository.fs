module FADVLib.ProjectServices.ProjectInfoRepository
open System.IO
open FADVLib.ProjectServices.ProjectInfo

//ProjectInfoをjson文字列に変換する
let toJsonFromProjectInfo (projectInfo:ProjectInfo):string=
    "{\"name\":\""+projectInfo.Name+"\"}"
    
//プロジェクトを保存する
let saveProjectInfo (folderPath:string)  (projectInfo:ProjectInfo):unit = 
    Directory.CreateDirectory(folderPath+"/"+projectInfo.Name) |> ignore
    use sw=new StreamWriter(folderPath+"/"+projectInfo.Name+"/"+"project.json" |> File.Create)
    toJsonFromProjectInfo projectInfo |> sw.WriteLine
    ()

