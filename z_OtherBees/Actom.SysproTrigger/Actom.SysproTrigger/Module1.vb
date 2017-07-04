Imports Actom.SysproTrigger.BLL
Imports Actom.SysproTrigger.Entity.Actom.SysproTrigger.DAL
Module Module1
    '    •	launched when the user creates the PO from the Requisition
    '•	It will pick up the PO number then 
    '•	find the Requisition number then 
    '•	find the values that have been entered into the custom form field for this requisition
    '•	Then add these values into the custom form field on the PO 
    'Note I am assuming that the Description Of the custom form field On the requisition And PO will be exactly the same And that will be my link 
    'I will add a pop up message box To tell the user
    Private _progtype As ProgramType
    Private _msg As String = ""
    Private _ordVal As Decimal
    Sub Main(args() As String)
        If args.Length > 1 Then
            'Args must contain at least 2 params
            ' program Type And Key value e.g order number etc
            Select Case args(0)
                Case "por"
                    _progtype = ProgramType.PurchaseOrder
            End Select
            args(1).ToString()
            Dim p As New PurchaseOrder(args(1))
            p.UpdatePurchaseOrder()
        Else
        End If
    End Sub

End Module
