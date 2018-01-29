Imports ETSSUtility.BLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class ProductionArea

    Dim _telcon As New TelerikControls
    Dim _ProductionArea As New clsProductionArea
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        rb_Add.FieldControl = rp_Fields
        rb_Add.ButtonControl = rp_ButtonControls
        rb_Add.SaveFunction = "Save"
        rb_Add.DataControl = rgv_ProductionArea
        rb_Add.UserControl = Me
        rb_Cancel.FieldControl = rp_Fields
        rb_Cancel.ButtonControl = rp_ButtonControls
        rb_Cancel.DataControl = rgv_ProductionArea
        rb_Cancel.UserControl = Me
        AddHandler rgv_ProductionArea.CommandCellClick, AddressOf rgv_ProductionArea_CommandCellClick
        AddHandler rgv_ProductionArea.SelectionChanging, AddressOf rgv_ProductionArea_SelectionChanging

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "EVENTS"
    Public Sub ProductionArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rp_Fields.InitiliazeDefault(True, False)
        rb_Cancel.Enabled = True
        rb_Add.Enabled = True
        rb_Add.Text = "&Add"
        rgv_ProductionArea.Enabled = True
        rgv_ProductionArea.DataLoad(_ProductionArea.ProductionAreaList)
        rgv_ProductionArea.RadGridAdd_EditDeleteButton()
    End Sub

    Private Sub rgv_ProductionArea_CommandCellClick(sender As Object, e As EventArgs)
        If (TryCast(sender, Telerik.WinControls.UI.GridCommandCellElement).ColumnInfo.Name = "rgvb_Edit") Then
            rp_Fields.Enabled = True
            rb_Add.Text = "&Save"
            rb_Cancel.Text = "&Cancel"
            rb_Cancel.Enabled = True
            rb_Add.UpdateID = rgv_ProductionArea.CurrentRow.Cells("ClusterID").Value
            _ProductionArea.ClusterID = rgv_ProductionArea.CurrentRow.Cells("ClusterID").Value
            rgv_ProductionArea.Enabled = False
        Else
            If MessageBox.Show("Are you sure do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                _ProductionArea.ClusterID = rgv_ProductionArea.CurrentRow.Cells("ClusterID").Value
                If _ProductionArea.Delete Then
                    ProductionArea_Load(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Public Sub Save()
        If rp_Fields.IsControlFieldValid Then
            _ProductionArea.ProductionArea = etb_ProductionArea.Text.Trim()
            If _ProductionArea.Save Then
                MessageBox.Show("Successfully Saved", "System Notification")
                ProductionArea_Load(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub rgv_ProductionArea_SelectionChanging(sender As Object, e As EventArgs)
        If TypeOf (rgv_ProductionArea.CurrentRow) Is GridViewDataRowInfo Then
            etb_ProductionArea.Text = rgv_ProductionArea.CurrentRow.Cells("ProductionArea").Value
        End If
    End Sub
#End Region




End Class