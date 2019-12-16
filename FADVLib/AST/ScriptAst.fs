module ScriptAst

type ActionAst=
    |Exit

type MessageAst= 
    {
        SpeakerText:string
        MessageText:string
    }

type StatementAst=
    | ActionAst of ActionAst
    | MessageAst of MessageAst

type ScriptAst=
    {
        StatementAstList:StatementAst[]
    }