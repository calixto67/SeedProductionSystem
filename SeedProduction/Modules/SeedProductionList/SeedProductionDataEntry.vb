Imports ETSSUtility.BLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class SeedProductionDataEntry

    Dim SeedProductionDataEntry As clsSeedProductionData
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        rb_Cancel.OverrideOnClickEvent = True
        rb_Save.OverrideOnClickEvent = True
        AddHandler rb_Save.Click, AddressOf rb_Save_Click
        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "EVENTS"
    Private Sub SeedProductionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.InitiliazeDefault(True)
    End Sub

    Private Sub rb_Save_Click(sender As Object, e As EventArgs)

        If GroupBox1.IsControlFieldValid Then

        End If

    End Sub

#End Region
  
End Class