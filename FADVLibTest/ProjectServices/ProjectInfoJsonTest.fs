namespace FADVLibTest.ProjectInfoJsonTest

open NUnit.Framework
open FADVLib.ProjectServices.ProjectInfoJson
open FADVLib.ProjectServices.ProjectInfo

[<TestFixture>]
type  ProjectInfoJsonTest() =

    [<Test>]
    member this.toJsonPassing() =
        Assert.AreEqual("""{"name":"hogefuga"}""",toJsonFromProjectInfo {Name="hogefuga"})

    [<Test>]
    member this.fromJsonPassing() =
        Assert.AreEqual( {Name="testtest"},toProjectInfoFromJson """ { "name": "testtest" } """ )
