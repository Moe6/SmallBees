Imports Actom.SysproTrigger.DAL
Imports Actom.SysproTrigger.Entity.Actom.SysproTrigger.DAL

Public Class PurchaseOrder
    Private _reqdetail As List(Of ReqDetail)
    Private _reqPlus As ReqDetail_
    Private Property _keyVal As String
    Public Sub New(val As String)
        _keyVal = val
    End Sub

    Public Function UpdatePurchaseOrder() As Boolean
        '    •	launched when the user creates the PO from the Requisition
        '•	It will pick up the PO number then 
        '•	find the Requisition number then 
        '•	find the values that have been entered into the custom form field for this requisition
        '•	Then add these values into the custom form field on the PO 
        'Note I am assuming that the Description Of the custom form field On the requisition And PO will be exactly the same And that will be my link 
        'I will add a pop up message box To tell the user
        FillReqDetial()
        Dim foundreq = _reqdetail.FirstOrDefault
        If foundreq IsNot Nothing Then
            FillReqDetailPlus(foundreq.Requisition)
            If _reqPlus IsNot Nothing Then
                Dim poPlus As New PorMasterHdr_
                With _reqPlus
                    poPlus.Incoterms = .Incoterms
                    poPlus.ConsigneeOrderNo = .ConsigneeOrderNo
                    poPlus.Packaging = .Packaging
                    poPlus.MethodOfPayment = .MethodOfPayment
                    poPlus.YourTenderOf = .YourTenderOf
                    poPlus.PortOfEntry = .PortOfEntry
                    poPlus.ForwardingAgentDet = .ForwardingAgentDet
                    poPlus.For002 = .For002
                    poPlus.For003 = .For003
                    poPlus.ForwardCoverRequir = .ForwardCoverRequir
                    poPlus.FobDate = .FobDate
                    poPlus.SubstationName = .SubstationName
                    poPlus.Confirmed = .Confirmed
                    poPlus.ConfirmedDate = .ConfirmedDate
                    poPlus.IncotermPort = .IncotermPort
                    poPlus.DeliveryMethod = .DeliveryMethod
                End With
                UpdatePurchaseOrderPlus(poPlus)
                If SaveChanges() Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Sub FillReqDetial()
        Using dal As New DAL.Query
            _reqdetail = dal.FillReqDetail(_keyVal)
        End Using
    End Sub

    Private Sub FillReqDetailPlus(req As String)
        Using dal As New DAL.Query
            _reqplus = dal.FillReqDetailPlus(req)
        End Using
    End Sub

    Private Sub UpdatePurchaseOrderPlus(obj As PorMasterHdr_)
        Using d As New DAL.Maintain
            d.Update(obj)
        End Using
    End Sub
    Private Function SaveChanges() As Boolean
        Using d As New DAL.Maintain
            Return d.SaveChanges
        End Using
    End Function

End Class
