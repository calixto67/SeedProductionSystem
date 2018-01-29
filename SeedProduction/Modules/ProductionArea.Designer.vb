<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionArea
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductionArea))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rp_Fields = New Telerik.WinControls.UI.RadPanel()
        Me.etb_ProductionArea = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rp_ButtonControls = New Telerik.WinControls.UI.RadPanel()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Add = New ETSSUtility.BLL.Radbutton()
        Me.rgv_ProductionArea = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.rp_Fields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rp_Fields.SuspendLayout()
        CType(Me.etb_ProductionArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rp_ButtonControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rp_ButtonControls.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_ProductionArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_ProductionArea.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(547, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Production Area"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 44)
        Me.Panel1.TabIndex = 249
        '
        'rp_Fields
        '
        Me.rp_Fields.Controls.Add(Me.etb_ProductionArea)
        Me.rp_Fields.Controls.Add(Me.Label18)
        Me.rp_Fields.Dock = System.Windows.Forms.DockStyle.Top
        Me.rp_Fields.Location = New System.Drawing.Point(0, 44)
        Me.rp_Fields.Name = "rp_Fields"
        Me.rp_Fields.Size = New System.Drawing.Size(547, 40)
        Me.rp_Fields.TabIndex = 250
        '
        'etb_ProductionArea
        '
        Me.etb_ProductionArea.Location = New System.Drawing.Point(130, 11)
        Me.etb_ProductionArea.Name = "etb_ProductionArea"
        '
        '
        '
        Me.etb_ProductionArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ProductionArea.Size = New System.Drawing.Size(145, 20)
        Me.etb_ProductionArea.TabIndex = 255
        Me.etb_ProductionArea.TabStop = False
        Me.etb_ProductionArea.Text = "ETextBox1"
        Me.etb_ProductionArea.ValidateRequiredField = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 23)
        Me.Label18.TabIndex = 254
        Me.Label18.Text = "Production Area:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rp_ButtonControls
        '
        Me.rp_ButtonControls.Controls.Add(Me.rb_Cancel)
        Me.rp_ButtonControls.Controls.Add(Me.rb_Add)
        Me.rp_ButtonControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rp_ButtonControls.Location = New System.Drawing.Point(0, 332)
        Me.rp_ButtonControls.Name = "rp_ButtonControls"
        Me.rp_ButtonControls.Size = New System.Drawing.Size(547, 80)
        Me.rp_ButtonControls.TabIndex = 251
        '
        'rb_Cancel
        '
        Me.rb_Cancel.AddFunction = Nothing
        Me.rb_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb_Cancel.ButtonControl = Nothing
        Me.rb_Cancel.Class = Nothing
        Me.rb_Cancel.DataControl = Nothing
        Me.rb_Cancel.FieldControl = Nothing
        Me.rb_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Cancel.Image = CType(resources.GetObject("rb_Cancel.Image"), System.Drawing.Image)
        Me.rb_Cancel.Location = New System.Drawing.Point(416, 17)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(115, 51)
        Me.rb_Cancel.TabIndex = 253
        Me.rb_Cancel.Text = "&Cancel"
        Me.rb_Cancel.UpdateID = Nothing
        Me.rb_Cancel.UserControl = Nothing
        '
        'rb_Add
        '
        Me.rb_Add.AddFunction = Nothing
        Me.rb_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb_Add.ButtonControl = Nothing
        Me.rb_Add.Class = Nothing
        Me.rb_Add.DataControl = Nothing
        Me.rb_Add.FieldControl = Nothing
        Me.rb_Add.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Add.Image = CType(resources.GetObject("rb_Add.Image"), System.Drawing.Image)
        Me.rb_Add.Location = New System.Drawing.Point(295, 17)
        Me.rb_Add.Name = "rb_Add"
        Me.rb_Add.SaveFunction = Nothing
        Me.rb_Add.Size = New System.Drawing.Size(115, 51)
        Me.rb_Add.TabIndex = 252
        Me.rb_Add.Text = "&Add"
        Me.rb_Add.UpdateID = Nothing
        Me.rb_Add.UserControl = Nothing
        '
        'rgv_ProductionArea
        '
        Me.rgv_ProductionArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgv_ProductionArea.Location = New System.Drawing.Point(0, 84)
        '
        'rgv_ProductionArea
        '
        Me.rgv_ProductionArea.MasterTemplate.AllowAddNewRow = False
        Me.rgv_ProductionArea.MasterTemplate.AllowDeleteRow = False
        Me.rgv_ProductionArea.MasterTemplate.AllowEditRow = False
        Me.rgv_ProductionArea.Name = "rgv_ProductionArea"
        Me.rgv_ProductionArea.Size = New System.Drawing.Size(547, 248)
        Me.rgv_ProductionArea.TabIndex = 252
        Me.rgv_ProductionArea.Text = "RadGridView1"
        '
        'ProductionArea
        '
        Me.AcceptButton = Me.rb_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 412)
        Me.Controls.Add(Me.rgv_ProductionArea)
        Me.Controls.Add(Me.rp_ButtonControls)
        Me.Controls.Add(Me.rp_Fields)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductionArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductionArea"
        Me.Panel1.ResumeLayout(False)
        CType(Me.rp_Fields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rp_Fields.ResumeLayout(False)
        Me.rp_Fields.PerformLayout()
        CType(Me.etb_ProductionArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rp_ButtonControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rp_ButtonControls.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_ProductionArea.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_ProductionArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rp_Fields As Telerik.WinControls.UI.RadPanel
    Friend WithEvents etb_ProductionArea As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents rp_ButtonControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgv_ProductionArea As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Add As ETSSUtility.BLL.Radbutton
End Class
