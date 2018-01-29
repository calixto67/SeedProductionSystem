Public Class MainSelection
    Dim ModuleSelection As New ModuleSelection


    Public Sub New()
        InitializeComponent()
        AddHandler rb_SeedProductionList.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_YieldEstimateMasterData.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_SeedProductionDeliveryList.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_ProductionArea.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_Crop.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_SeedClass.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_FieldFormula.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_ReferenceGeneration.Click, AddressOf ModuleSelection.OpenModule
        AddHandler rb_UserAccounts.Click, AddressOf ModuleSelection.OpenModule
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class