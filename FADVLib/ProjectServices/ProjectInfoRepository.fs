module FADVLib.ProjectService.ProjectInfoRepository
open System.IO
open FADVLib.ProjectServices.ProjectInfo

//プロジェクトを保存する
let saveProjectInfo (folderPath:string)  (projectInfo:ProjectInfo):unit = 
     let sw=new StreamWriter(folderPath+"/"+projectInfo.Name+".json" |> File.Create)
     sw.WriteLine("{\"name\":\""+projectInfo.Name+"\"}")
     sw.Close()
     ()