Imports ETSSUtility.BLL
Public Class User
    Inherits DLL
    Private Property _ID As Integer = 0
    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private Property _Login As String
    Public Property Login As String
        Get
            Return _Login
        End Get
        Set(value As String)
            _Login = value
        End Set
    End Property

    Private Property _Password As String
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Private Property _UserFullname As String
    Public Property UserFullname As String
        Get
            Return _UserFullname
        End Get
        Set(value As String)
            _UserFullname = value
        End Set
    End Property

    Private Property _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Private Property _ContactNo As String
    Public Property ContactNo As String
        Get
            Return _ContactNo
        End Get
        Set(value As String)
            _ContactNo = value
        End Set
    End Property


    Public ReadOnly Property Save As Boolean
        Get
            SPName = "sp_CRUD_UserAccount"
            'SPParameters = New List(Of Object) With { new string(){ "@Login",_ID } }
            CRUD = If(String.IsNullOrEmpty(ID) And ID = 0, CRUDCode.Create, CRUDCode.Update)
            Dim dt As New DataTable
            dt = CRUDCodeMode
            If Not New ETSSUtility.BLL.ErrorHandler().HasSqlError(dt) Then
                Return dt.Rows.Item(0).Item("Result").ToBoolean
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property Delete As Boolean
        Get
            SPName = "sp_CRUD_UserAccount"
            CRUD = CRUDCode.Delete
            Dim dt As New DataTable
            dt = CRUDCodeMode
            If Not New ETSSUtility.BLL.ErrorHandler().HasSqlError(dt) Then
                Return dt.Rows.Item(0).Item("Result").ToBoolean
            End If
            Return False
        End Get
    End Property


End Class
