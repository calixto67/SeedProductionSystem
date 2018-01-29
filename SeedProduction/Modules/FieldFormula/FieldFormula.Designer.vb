<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FieldFormula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FieldFormula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rp_FieldControl = New Telerik.WinControls.UI.RadPanel()
        Me.rb_CreateOperation = New Telerik.WinControls.UI.RadButton()
        Me.EMultiColumnComboBox2 = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EMultiColumnComboBox1 = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.rgv_FieldFormula = New Telerik.WinControls.UI.RadGridView()
        CType(Me.rp_FieldControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rp_FieldControl.SuspendLayout()
        CType(Me.rb_CreateOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_FieldFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_FieldFormula.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create Field Formula"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rp_FieldControl
        '
        Me.rp_FieldControl.Controls.Add(Me.rb_CreateOperation)
        Me.rp_FieldControl.Controls.Add(Me.EMultiColumnComboBox2)
        Me.rp_FieldControl.Controls.Add(Me.Label2)
        Me.rp_FieldControl.Controls.Add(Me.EMultiColumnComboBox1)
        Me.rp_FieldControl.Controls.Add(Me.Label18)
        Me.rp_FieldControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.rp_FieldControl.Location = New System.Drawing.Point(0, 44)
        Me.rp_FieldControl.Name = "rp_FieldControl"
        Me.rp_FieldControl.Size = New System.Drawing.Size(485, 72)
        Me.rp_FieldControl.TabIndex = 257
        '
        'rb_CreateOperation
        '
        Me.rb_CreateOperation.Location = New System.Drawing.Point(361, 34)
        Me.rb_CreateOperation.Name = "rb_CreateOperation"
        Me.rb_CreateOperation.Size = New System.Drawing.Size(112, 24)
        Me.rb_CreateOperation.TabIndex = 258
        Me.rb_CreateOperation.Text = "&CreateOperation"
        '
        'EMultiColumnComboBox2
        '
        Me.EMultiColumnComboBox2.AutoFilter = True
        Me.EMultiColumnComboBox2.AutoReset = True
        Me.EMultiColumnComboBox2.Data = Nothing
        Me.EMultiColumnComboBox2.Dislaycol = ""
        Me.EMultiColumnComboBox2.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'EMultiColumnComboBox2.NestedRadGridView
        '
        Me.EMultiColumnComboBox2.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.EMultiColumnComboBox2.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMultiColumnComboBox2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EMultiColumnComboBox2.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'EMultiColumnComboBox2.NestedRadGridView
        '
        Me.EMultiColumnComboBox2.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.EMultiColumnComboBox2.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.EMultiColumnComboBox2.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.EMultiColumnComboBox2.EditorControl.MasterTemplate.EnableFiltering = True
        Me.EMultiColumnComboBox2.EditorControl.MasterTemplate.EnableGrouping = False
        Me.EMultiColumnComboBox2.EditorControl.Name = "NestedRadGridView"
        Me.EMultiColumnComboBox2.EditorControl.ReadOnly = True
        Me.EMultiColumnComboBox2.EditorControl.ShowGroupPanel = False
        Me.EMultiColumnComboBox2.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.EMultiColumnComboBox2.EditorControl.TabIndex = 0
        Me.EMultiColumnComboBox2.Location = New System.Drawing.Point(166, 38)
        Me.EMultiColumnComboBox2.Name = "EMultiColumnComboBox2"
        '
        '
        '
        Me.EMultiColumnComboBox2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.EMultiColumnComboBox2.SelectedDisplayValue = ""
        Me.EMultiColumnComboBox2.SelectedValue = Nothing
        Me.EMultiColumnComboBox2.Size = New System.Drawing.Size(189, 20)
        Me.EMultiColumnComboBox2.TabIndex = 257
        Me.EMultiColumnComboBox2.TabStop = False
        Me.EMultiColumnComboBox2.Text = "EMultiColumnComboBox2"
        Me.EMultiColumnComboBox2.ValidateRequiredField = True
        Me.EMultiColumnComboBox2.Valuecol = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "Formula FieldName:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EMultiColumnComboBox1
        '
        Me.EMultiColumnComboBox1.AutoFilter = True
        Me.EMultiColumnComboBox1.AutoReset = True
        Me.EMultiColumnComboBox1.Data = Nothing
        Me.EMultiColumnComboBox1.Dislaycol = ""
        Me.EMultiColumnComboBox1.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'EMultiColumnComboBox1.NestedRadGridView
        '
        Me.EMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.EMultiColumnComboBox1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'EMultiColumnComboBox1.NestedRadGridView
        '
        Me.EMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.EMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.EMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.EMultiColumnComboBox1.EditorControl.MasterTemplate.EnableFiltering = True
        Me.EMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.EMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
        Me.EMultiColumnComboBox1.EditorControl.ReadOnly = True
        Me.EMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
        Me.EMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.EMultiColumnComboBox1.EditorControl.TabIndex = 0
        Me.EMultiColumnComboBox1.Location = New System.Drawing.Point(166, 12)
        Me.EMultiColumnComboBox1.Name = "EMultiColumnComboBox1"
        '
        '
        '
        Me.EMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.EMultiColumnComboBox1.SelectedDisplayValue = ""
        Me.EMultiColumnComboBox1.SelectedValue = Nothing
        Me.EMultiColumnComboBox1.Size = New System.Drawing.Size(189, 20)
        Me.EMultiColumnComboBox1.TabIndex = 255
        Me.EMultiColumnComboBox1.TabStop = False
        Me.EMultiColumnComboBox1.Text = "EMultiColumnComboBox1"
        Me.EMultiColumnComboBox1.ValidateRequiredField = True
        Me.EMultiColumnComboBox1.Valuecol = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(27, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 23)
        Me.Label18.TabIndex = 254
        Me.Label18.Text = "ModuleName :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.rb_Cancel)
        Me.RadPanel2.Controls.Add(Me.rb_Save)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel2.Location = New System.Drawing.Point(0, 429)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(485, 58)
        Me.RadPanel2.TabIndex = 258
        '
        'rb_Cancel
        '
        Me.rb_Cancel.AddFunction = Nothing
        Me.rb_Cancel.ButtonControl = Nothing
        Me.rb_Cancel.Class = Nothing
        Me.rb_Cancel.DataControl = Nothing
        Me.rb_Cancel.FieldControl = Nothing
        Me.rb_Cancel.Image = CType(resources.GetObject("rb_Cancel.Image"), System.Drawing.Image)
        Me.rb_Cancel.Location = New System.Drawing.Point(362, 6)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(110, 42)
        Me.rb_Cancel.TabIndex = 1
        Me.rb_Cancel.Text = "&Cancel"
        Me.rb_Cancel.UpdateID = Nothing
        Me.rb_Cancel.UserControl = Nothing
        '
        'rb_Save
        '
        Me.rb_Save.AddFunction = Nothing
        Me.rb_Save.ButtonControl = Nothing
        Me.rb_Save.Class = Nothing
        Me.rb_Save.DataControl = Nothing
        Me.rb_Save.FieldControl = Nothing
        Me.rb_Save.Image = CType(resources.GetObject("rb_Save.Image"), System.Drawing.Image)
        Me.rb_Save.Location = New System.Drawing.Point(230, 6)
        Me.rb_Save.Name = "rb_Save"
        Me.rb_Save.SaveFunction = Nothing
        Me.rb_Save.Size = New System.Drawing.Size(110, 42)
        Me.rb_Save.TabIndex = 0
        Me.rb_Save.Text = "&Save"
        Me.rb_Save.UpdateID = Nothing
        Me.rb_Save.UserControl = Nothing
        '
        'rgv_FieldFormula
        '
        Me.rgv_FieldFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgv_FieldFormula.Location = New System.Drawing.Point(0, 116)
        Me.rgv_FieldFormula.Name = "rgv_FieldFormula"
        Me.rgv_FieldFormula.Size = New System.Drawing.Size(485, 313)
        Me.rgv_FieldFormula.TabIndex = 259
        Me.rgv_FieldFormula.Text = "RadGridView1"
        '
        'FieldFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(485, 487)
        Me.Controls.Add(Me.rgv_FieldFormula)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.rp_FieldControl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FieldFormula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FieldFormula"
        CType(Me.rp_FieldControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rp_FieldControl.ResumeLayout(False)
        Me.rp_FieldControl.PerformLayout()
        CType(Me.rb_CreateOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_FieldFormula.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_FieldFormula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rp_FieldControl As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents EMultiColumnComboBox1 As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents EMultiColumnComboBox2 As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgv_FieldFormula As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_CreateOperation As Telerik.WinControls.UI.RadButton
End Class
