Public Class WaitForm1
    Sub New
        InitializeComponent()
        progressPanel1.AutoHeight = True
    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        progressPanel1.Caption = caption
    End Sub
    
    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        progressPanel1.Description = description
    End Sub    

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum
End Class
