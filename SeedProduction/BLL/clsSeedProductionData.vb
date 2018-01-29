Public Class clsSeedProductionData
    Inherits DLL

    Public Property ID As Integer
    Public Property ModuleID As Integer
    Public Property CropID As Integer
    Public Property FarmerBatchNo As String
    Public Property ClusterID As Integer
    Public Property CropYear As Integer
    Public Property FarmersName As String
    Public Property FarmAddress As String
    Public Property SSNo As String
    Public Property ContractNo As String
    Public Property PlanYield As Double
    Public Property PricePerKilo As Decimal
    Public Property TargetArea As Double
    Public Property EstimatedPlantPop As Double
    Public Property TargetQty As Double

    Public ReadOnly Property Save As Boolean
        Get
            SPName = "sp_CRUD_SeedProductionList"
            Dim lst As New List(Of Object())
            lst.Add(New Object() {"@ID", ID})
            lst.Add(New Object() {"@ModuleID", ModuleID})
            lst.Add(New Object() {"@CropID", CropID})
            lst.Add(New Object() {"@FarmerBatchNo", FarmerBatchNo})
            lst.Add(New Object() {"@ClusterID", ClusterID})
            lst.Add(New Object() {"@CropYear", CropYear})
            lst.Add(New Object() {"@FarmersName", FarmersName})
            lst.Add(New Object() {"@FarmAddress", FarmAddress})
            lst.Add(New Object() {"@SSNo", SSNo})
            lst.Add(New Object() {"@ContractNo", ContractNo})
            lst.Add(New Object() {"@PlanYield", PlanYield})
            lst.Add(New Object() {"@PricePerKilo", PricePerKilo})
            lst.Add(New Object() {"@TargetArea", TargetArea})
            lst.Add(New Object() {"@EstPlantPop", EstimatedPlantPop})
            lst.Add(New Object() {"@TargetQty", TargetQty})
            SPParameters = New List(Of Object) From {lst}
            CRUD = If(String.IsNullOrEmpty(ID) Or ID = 0, CRUDCode.Create, CRUDCode.Update)
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
            SPName = "sp_CRUD_SeedProductionList"
            SPParameters = Nothing
            CRUD = CRUDCode.Retrieve
            Return CRUDCodeMode
        End Get
    End Property
    Public ReadOnly Property FarmersNameList As DataTable
        Get
            SPName = "sp_FarmersList"
            SPParameters = Nothing
            Return ExecuteStoredProcedure
        End Get
    End Property


End Class
