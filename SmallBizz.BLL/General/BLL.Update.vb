Imports SmallBiz.DAL
Imports SmallBiz.Entity
Public Class Update
    Public Function update(obj As InvCategory) As Boolean
        Using dal As New DAL.Update
            dal.Update(obj)
            Return dal.SaveChanges
        End Using
    End Function

    Public Function update(obj As InvMaster) As Boolean
        Using dal As New DAL.Update
            dal.Update(obj)
            Return dal.SaveChanges
        End Using
    End Function
    Public Function update(obj As InvWhMaster) As Boolean
        Using dal As New DAL.Update
            dal.Update(obj)
            Return dal.SaveChanges
        End Using
    End Function
End Class
