namespace FADVLibTest.ProjectInfoJsonTest

open NUnit.Framework
open FADVLib.ProjectServices.ProjectInfoRepository
open FADVLib.ProjectServices.ProjectInfo

[<TestFixture>]
type  ProjectInfoJsonTest() =

    [<Test>]
    member this.toJsonPassing() =
        Assert.AreEqual("{\"name\":\"hogefuga\"}",toJsonFromProjectInfo {Name="hogefuga"})
