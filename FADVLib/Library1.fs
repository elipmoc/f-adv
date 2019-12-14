namespace FADVLib

open Microsoft.CodeAnalysis.CSharp
open Microsoft.CodeAnalysis

module testRoslyn=

    //using System;のコード生成
    let private usingList=
        SyntaxList[|SyntaxFactory.UsingDirective(SyntaxFactory.ParseName "System")|]

    (*
    static void Main(){
        Console.WriteLine("HelloWorld");
    }
    のコード生成
    *)
    let private mainMethod=
        SyntaxFactory.MethodDeclaration(
            SyntaxList(),
            SyntaxFactory.TokenList(SyntaxFactory.Token SyntaxKind.StaticKeyword),
            SyntaxFactory.PredefinedType(SyntaxFactory.Token SyntaxKind.VoidKeyword), 
            null,
            SyntaxFactory.ParseToken "Main",
            SyntaxFactory.TypeParameterList(),
            SyntaxFactory.ParameterList(),
            SyntaxList(),
            SyntaxFactory.Block [|
                SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.ParseExpression "Console.WriteLine",
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SeparatedList [| 
                                SyntaxFactory.Argument(SyntaxFactory.ParseExpression "\"HelloWorld\"")
                            |]
                        )
                    )
                )
                :>Syntax.StatementSyntax
            |],
            SyntaxFactory.Token SyntaxKind.SemicolonToken
        )

    //class Programのコード生成
    let private memberDeclarationList:SyntaxList<Syntax.MemberDeclarationSyntax> =
        (
            SyntaxFactory.ClassDeclaration(
                SyntaxList(),
                SyntaxTokenList(),
                SyntaxFactory.ParseToken "Program",
                SyntaxFactory.TypeParameterList(),
                SyntaxFactory.BaseList(),
                SyntaxList (),
                SyntaxList (mainMethod:>Syntax.MemberDeclarationSyntax)
            )
            :>Syntax.MemberDeclarationSyntax
        )
        |> SyntaxList

    //コンパイルできる最小単位の生成
    let private compilationUnit:Syntax.CompilationUnitSyntax =
        SyntaxFactory.CompilationUnit(SyntaxList(),usingList,SyntaxList(),memberDeclarationList)

    //コンパイルできる最小単位の集合
    let private syntaxTreeList :SyntaxTree[]=
        [|
            CSharpSyntaxTree.Create compilationUnit
        |]

    //コンパイル結果のエラーメッセージ整形
    let private resultMessage :(seq<Diagnostic>->string) =
        Seq.map (fun diagnostic->diagnostic.GetMessage())
        >> Seq.fold (fun acc x->acc+x) ""

    //コンパイルに必要なアセンブリ一覧
    let private addAssembly :MetadataReference[]=
        [|
            MetadataReference.CreateFromFile  typeof<System.Object>.Assembly.Location :>MetadataReference
        |]
        
    //コンパイルインスタンス生成
    let private createCompilation (assemblyName:string) :CSharpCompilation =
        CSharpCompilation.Create(assemblyName,syntaxTreeList)
            .AddReferences
                addAssembly

    //コンパイルインスタンスをEmitでexe出力
    let private emit (fileName:string) (compilation:CSharpCompilation)  : seq<Diagnostic> =
        compilation.Emit(fileName).Diagnostics
        :>seq<Diagnostic>

    //全てのワークフローを開始する
    let build (fileName:string) (assemblyName:string):string=
        createCompilation assemblyName
        |>emit fileName
        |>resultMessage
