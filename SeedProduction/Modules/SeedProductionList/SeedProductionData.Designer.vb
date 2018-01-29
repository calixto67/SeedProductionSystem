<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeedProductionData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeedProductionData))
        Me.rp_ButtonControls = New Telerik.WinControls.UI.RadPanel()
        Me.rb_Update = New ETSSUtility.BLL.Radbutton()
        Me.rb_Create = New ETSSUtility.BLL.Radbutton()
        Me.rgv_SeedProductionData = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rp_ButtonControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rp_ButtonControls.SuspendLayout()
        CType(Me.rb_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Create, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_SeedProductionData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_SeedProductionData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rp_ButtonControls
        '
        Me.rp_ButtonControls.Controls.Add(Me.rb_Update)
        Me.rp_ButtonControls.Controls.Add(Me.rb_Create)
        Me.rp_ButtonControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.rp_ButtonControls.Location = New System.Drawing.Point(0, 0)
        Me.rp_ButtonControls.Name = "rp_ButtonControls"
        Me.rp_ButtonControls.Size = New System.Drawing.Size(768, 55)
        Me.rp_ButtonControls.TabIndex = 0
        '
        'rb_Update
        '
        Me.rb_Update.AddFunction = Nothing
        Me.rb_Update.ButtonControl = Nothing
        Me.rb_Update.Class = Nothing
        Me.rb_Update.DataControl = Nothing
        Me.rb_Update.FieldControl = Nothing
        Me.rb_Update.Image = CType(resources.GetObject("rb_Update.Image"), System.Drawing.Image)
        Me.rb_Update.Location = New System.Drawing.Point(121, 7)
        Me.rb_Update.Name = "rb_Update"
        Me.rb_Update.SaveFunction = Nothing
        Me.rb_Update.Size = New System.Drawing.Size(94, 42)
        Me.rb_Update.TabIndex = 1
        Me.rb_Update.Text = "&Update"
        Me.rb_Update.UpdateID = Nothing
        Me.rb_Update.UserControl = Nothing
        '
        'rb_Create
        '
        Me.rb_Create.AddFunction = Nothing
        Me.rb_Create.ButtonControl = Nothing
        Me.rb_Create.Class = Nothing
        Me.rb_Create.DataControl = Nothing
        Me.rb_Create.FieldControl = Nothing
        Me.rb_Create.Image = CType(resources.GetObject("rb_Create.Image"), System.Drawing.Image)
        Me.rb_Create.Location = New System.Drawing.Point(12, 7)
        Me.rb_Create.Name = "rb_Create"
        Me.rb_Create.SaveFunction = Nothing
        Me.rb_Create.Size = New System.Drawing.Size(94, 42)
        Me.rb_Create.TabIndex = 0
        Me.rb_Create.Text = "&Create"
        Me.rb_Create.UpdateID = Nothing
        Me.rb_Create.UserControl = Nothing
        '
        'rgv_SeedProductionData
        '
        Me.rgv_SeedProductionData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgv_SeedProductionData.Location = New System.Drawing.Point(0, 55)
        '
        'rgv_SeedProductionData
        '
        Me.rgv_SeedProductionData.MasterTemplate.AllowAddNewRow = False
        Me.rgv_SeedProductionData.MasterTemplate.AllowDeleteRow = False
        Me.rgv_SeedProductionData.MasterTemplate.AllowEditRow = False
        Me.rgv_SeedProductionData.Name = "rgv_SeedProductionData"
        Me.rgv_SeedProductionData.Size = New System.Drawing.Size(768, 408)
        Me.rgv_SeedProductionData.TabIndex = 1
        Me.rgv_SeedProductionData.Text = "RadGridView1"
        '
        'SeedProductionData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 463)
        Me.Controls.Add(Me.rgv_SeedProductionData)
        Me.Controls.Add(Me.rp_ButtonControls)
        Me.Name = "SeedProductionData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainSeedProductionData"
        CType(Me.rp_ButtonControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rp_ButtonControls.ResumeLayout(False)
        CType(Me.rb_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Create, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_SeedProductionData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_SeedProductionData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rp_ButtonControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgv_SeedProductionData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rb_Create As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Update As ETSSUtility.BLL.Radbutton
End Class
