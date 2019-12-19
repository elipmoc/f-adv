module FADVLib.ProjectServices.ProjectInfoRepository
open System.IO
open FADVLib.ProjectServices.ProjectInfo
open FADVLib.ProjectServices.ProjectInfoJson
    
//プロジェクトを保存する
let saveProjectInfo (folderPath:string)  (projectInfo:ProjectInfo):unit = 
    Directory.CreateDirectory(folderPath+"/"+projectInfo.Name) |> ignore
    use sw=new StreamWriter(folderPath+"/"+projectInfo.Name+"/"+"project.json" |> File.Create)
    toJsonFromProjectInfo projectInfo |> sw.WriteLine
    ()

