Imports ETSSUtility.BLL
Imports ETSSUtility.BLL.ObjectMethod
Public Class ModuleSelection

    Private Property _ModuleID
    Public Property ModuleID
        Get
            Return _ModuleID
        End Get
        Set(value)
            _ModuleID = value
        End Set
    End Property


    Public Sub OpenModule(ByVal sender As Object, ByVal e As EventArgs)

        If Not IsNothing(sender) Then
            Dim ModuleID As Integer = TryCast(sender, Radbutton).Tag
            Dim ModuleName As String = TryCast(sender, Radbutton).Text.Replace(" ", "")

            Dim frmNewForm As Form = Nothing
            Dim frmNewForm_Type As Type = Type.GetType(My.Application.Info.AssemblyName & "." & ModuleName)
            frmNewForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)

            For Each frm As Form In Application.OpenForms
                If frm.GetType() = frmNewForm_Type Then
                    frm.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (frm.Height \ 2)
                    frm.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (frm.Width \ 2)
                    frm.Focus()
                    Return
                End If
            Next
            frmNewForm.Show()
        End If

    End Sub


End Class
