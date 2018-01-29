Public Class SeedProductionData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        AddHandler rgv_SeedProductionData.SelectionChanging, AddressOf rgv_SeedProductionData_SelectionChanging
        AddHandler rb_Create.Click, AddressOf rb_Create_Click
        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "EVENTS"
    Public Sub SeedProductionData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_Create.Enabled = True
        rb_Update.Enabled = Not rgv_SeedProductionData.CurrentRow Is Nothing

    End Sub

    Private Sub rb_Create_Click(sender As Object, e As EventArgs)
        Using SeedProductionDataEntry As New SeedProductionDataEntry
            SeedProductionDataEntry.ShowDialog()
        End Using
    End Sub

    Private Sub rgv_SeedProductionData_SelectionChanging(sender As Object, e As EventArgs)

        If Not rgv_SeedProductionData.CurrentRow Is Nothing Then
            rb_Update.Enabled = True
        End If

    End Sub

#End Region

End Class