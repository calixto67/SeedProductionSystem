<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crop))
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.etb_Code = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.emccb_SeedID = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.etb_Description = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.emccb_SeedID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_SeedID.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_SeedID.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb_Cancel
        '
        Me.rb_Cancel.AddFunction = Nothing
        Me.rb_Cancel.ButtonControl = Nothing
        Me.rb_Cancel.Class = Nothing
        Me.rb_Cancel.DataControl = Nothing
        Me.rb_Cancel.FieldControl = Nothing
        Me.rb_Cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Cancel.Image = CType(resources.GetObject("rb_Cancel.Image"), System.Drawing.Image)
        Me.rb_Cancel.Location = New System.Drawing.Point(418, 12)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(95, 51)
        Me.rb_Cancel.TabIndex = 253
        Me.rb_Cancel.Text = "    Cancel"
        Me.rb_Cancel.UpdateID = Nothing
        Me.rb_Cancel.UserControl = Nothing
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Location = New System.Drawing.Point(0, 126)
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(546, 187)
        Me.RadGridView1.TabIndex = 256
        Me.RadGridView1.Text = "RadGridView1"
        '
        'etb_Code
        '
        Me.etb_Code.Location = New System.Drawing.Point(112, 9)
        Me.etb_Code.Name = "etb_Code"
        '
        '
        '
        Me.etb_Code.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Code.Size = New System.Drawing.Size(145, 20)
        Me.etb_Code.TabIndex = 255
        Me.etb_Code.TabStop = False
        Me.etb_Code.Text = "ETextBox1"
        Me.etb_Code.ValidateRequiredField = True
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.rb_Cancel)
        Me.RadPanel2.Controls.Add(Me.rb_Save)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel2.Location = New System.Drawing.Point(0, 313)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(546, 80)
        Me.RadPanel2.TabIndex = 255
        '
        'rb_Save
        '
        Me.rb_Save.AddFunction = Nothing
        Me.rb_Save.ButtonControl = Nothing
        Me.rb_Save.Class = Nothing
        Me.rb_Save.DataControl = Nothing
        Me.rb_Save.FieldControl = Nothing
        Me.rb_Save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Save.Image = CType(resources.GetObject("rb_Save.Image"), System.Drawing.Image)
        Me.rb_Save.Location = New System.Drawing.Point(297, 12)
        Me.rb_Save.Name = "rb_Save"
        Me.rb_Save.SaveFunction = Nothing
        Me.rb_Save.Size = New System.Drawing.Size(95, 51)
        Me.rb_Save.TabIndex = 252
        Me.rb_Save.Text = "   Save"
        Me.rb_Save.UpdateID = Nothing
        Me.rb_Save.UserControl = Nothing
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.emccb_SeedID)
        Me.RadPanel1.Controls.Add(Me.Label3)
        Me.RadPanel1.Controls.Add(Me.etb_Description)
        Me.RadPanel1.Controls.Add(Me.Label2)
        Me.RadPanel1.Controls.Add(Me.etb_Code)
        Me.RadPanel1.Controls.Add(Me.Label18)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 44)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(546, 82)
        Me.RadPanel1.TabIndex = 254
        '
        'emccb_SeedID
        '
        Me.emccb_SeedID.AutoFilter = True
        Me.emccb_SeedID.AutoReset = True
        Me.emccb_SeedID.Data = Nothing
        Me.emccb_SeedID.Dislaycol = ""
        Me.emccb_SeedID.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'emccb_SeedID.NestedRadGridView
        '
        Me.emccb_SeedID.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.emccb_SeedID.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emccb_SeedID.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.emccb_SeedID.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.emccb_SeedID.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.emccb_SeedID.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.emccb_SeedID.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.emccb_SeedID.EditorControl.MasterTemplate.EnableFiltering = True
        Me.emccb_SeedID.EditorControl.MasterTemplate.EnableGrouping = False
        Me.emccb_SeedID.EditorControl.Name = "NestedRadGridView"
        Me.emccb_SeedID.EditorControl.ReadOnly = True
        Me.emccb_SeedID.EditorControl.ShowGroupPanel = False
        Me.emccb_SeedID.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.emccb_SeedID.EditorControl.TabIndex = 0
        Me.emccb_SeedID.Location = New System.Drawing.Point(112, 56)
        Me.emccb_SeedID.Name = "emccb_SeedID"
        '
        '
        '
        Me.emccb_SeedID.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.emccb_SeedID.SelectedDisplayValue = ""
        Me.emccb_SeedID.SelectedValue = Nothing
        Me.emccb_SeedID.Size = New System.Drawing.Size(142, 20)
        Me.emccb_SeedID.TabIndex = 259
        Me.emccb_SeedID.TabStop = False
        Me.emccb_SeedID.Text = "EMultiColumnComboBox1"
        Me.emccb_SeedID.ValidateRequiredField = True
        Me.emccb_SeedID.Valuecol = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 258
        Me.Label3.Text = "Seed ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etb_Description
        '
        Me.etb_Description.Location = New System.Drawing.Point(112, 32)
        Me.etb_Description.Name = "etb_Description"
        '
        '
        '
        Me.etb_Description.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Description.Size = New System.Drawing.Size(145, 20)
        Me.etb_Description.TabIndex = 257
        Me.etb_Description.TabStop = False
        Me.etb_Description.Text = "ETextBox1"
        Me.etb_Description.ValidateRequiredField = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "Description:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 23)
        Me.Label18.TabIndex = 254
        Me.Label18.Text = "Code:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 44)
        Me.Panel1.TabIndex = 253
        '
        'Crop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 393)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Crop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crop"
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.emccb_SeedID.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_SeedID.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_SeedID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Description, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents etb_Code As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents emccb_SeedID As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents etb_Description As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
