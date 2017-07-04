Imports SmallBiz.DAL
Imports SmallBiz.Entity

Public Class Query
    Public Function FillInventoryCategories() As List(Of InvCategory)
        Using dal As New DAL.Query
            Return dal.FillCategories
        End Using
    End Function
    Public Function FillInvMaster() As List(Of InvMaster)
        Using dal As New DAL.Query
            Return dal.FillInvMaster
        End Using
    End Function
    Public Function FillInvWhMaster() As List(Of InvWhMaster)
        Using dal As New DAL.Query
            Return dal.FillInvWarehouse
        End Using
    End Function
    Public Function FillAvailableStock() As List(Of InvWarehouse)
        Using dal As New DAL.Query
            Return dal.FillAvailableStock
        End Using
    End Function

End Class
