Public Class clsProductionArea
    Inherits DLL

    Public Property ClusterID As Integer
    Public Property ProductionArea As String

    Public ReadOnly Property Save As Boolean
        Get
            SPName = "sp_CRUD_ProductionArea"
            Dim lst As New List(Of Object())
            lst.Add(New Object() {"@ProductionArea", ProductionArea})
            lst.Add(New Object() {"@ID", ClusterID})
            SPParameters = New List(Of Object) From {lst}
            CRUD = If(String.IsNullOrEmpty(ClusterID) Or ClusterID = 0, CRUDCode.Create, CRUDCode.Update)
            Dim dt As New DataTable
            dt = CRUDCodeMode
            If Not New ETSSUtility.BLL.ErrorHandler().HasSqlError(dt) Then
                Return dt.Rows.Item(0).Item("Result")
            End If
            Return False
        End Get
    End Property
    Public ReadOnly Property Delete As Boolean
        Get
            SPName = "sp_CRUD_ProductionArea"
            Dim lst As New List(Of Object())
            lst.Add(New Object() {"@ID", ClusterID})
            SPParameters = New List(Of Object) From {lst}
            CRUD = CRUDCode.Delete
            Dim dt As New DataTable
            dt = CRUDCodeMode
            If Not New ETSSUtility.BLL.ErrorHandler().HasSqlError(dt) Then
                Return dt.Rows.Item(0).Item("Result")
            End If
            Return False
        End Get
    End Property
    Public ReadOnly Property ProductionAreaList As DataTable
        Get
            SPName = "sp_CRUD_ProductionArea"
            SPParameters = Nothing
            CRUD = CRUDCode.Retrieve
            Return CRUDCodeMode
        End Get
    End Property


End Class
