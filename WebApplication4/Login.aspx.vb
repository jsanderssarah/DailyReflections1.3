Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub CheckUsers()
        If Login1.UserName = "admin" Then
            Server.Transfer("~\MembersPage\AdminData.aspx")
        ElseIf Login1.UserName = "AdminUsers" Then
            Server.Transfer("~\MembersPage\Register.aspx")
        Else
            Server.Transfer("~\MembersPage\DailyReflection.aspx")
        End If
    End Sub

    Protected Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        Session("UserName") = Login1.UserName
        Call CheckUsers()
    End Sub

End Class