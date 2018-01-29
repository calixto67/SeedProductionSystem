Public Class LoginForm1
    Dim role As String = ""
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '  Dim flag As Boolean = False
        '  opencon()
        '  Try
        'cmd.Connection = con
        ' cmd.CommandText = "SELECT * FROM users WHERE Username='" & txtusers.Text & "' AND Password='" & txtpass.Text & "'"
        ' reader = cmd.ExecuteReader
        ' While reader.Read
        '   flag = True
        '
        '    End While
        '  reader.Close()
        '  If flag Then
        ' main.Show()
        '  Me.Hide()

        '  Else
        '  MsgBox("Invalid Username and Password!", , "System Message!")
        '  End If
        ' Catch ex As Exception
        'MsgBox(ex.ToString)

        '  End Try
        ' con.Close()
        '  txtusers.Clear()
        ' txtpass.Clear()

    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
