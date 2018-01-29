<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeedClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeedClass))
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.etb_Description = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_Code = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Location = New System.Drawing.Point(0, 100)
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(537, 204)
        Me.RadGridView1.TabIndex = 256
        Me.RadGridView1.Text = "RadGridView1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seed Class"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.rb_Cancel)
        Me.RadPanel2.Controls.Add(Me.rb_Save)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel2.Location = New System.Drawing.Point(0, 304)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(537, 80)
        Me.RadPanel2.TabIndex = 255
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.etb_Description)
        Me.RadPanel1.Controls.Add(Me.Label2)
        Me.RadPanel1.Controls.Add(Me.etb_Code)
        Me.RadPanel1.Controls.Add(Me.Label18)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 44)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(537, 56)
        Me.RadPanel1.TabIndex = 254
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Description:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 23)
        Me.Label18.TabIndex = 258
        Me.Label18.Text = "Code:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 44)
        Me.Panel1.TabIndex = 253
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
        'etb_Description
        '
        Me.etb_Description.Location = New System.Drawing.Point(104, 30)
        Me.etb_Description.Name = "etb_Description"
        '
        '
        '
        Me.etb_Description.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Description.Size = New System.Drawing.Size(145, 20)
        Me.etb_Description.TabIndex = 261
        Me.etb_Description.TabStop = False
        Me.etb_Description.Text = "ETextBox1"
        Me.etb_Description.ValidateRequiredField = True
        '
        'etb_Code
        '
        Me.etb_Code.Location = New System.Drawing.Point(104, 7)
        Me.etb_Code.Name = "etb_Code"
        '
        '
        '
        Me.etb_Code.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Code.Size = New System.Drawing.Size(145, 20)
        Me.etb_Code.TabIndex = 259
        Me.etb_Code.TabStop = False
        Me.etb_Code.Text = "ETextBox1"
        Me.etb_Code.ValidateRequiredField = True
        '
        'SeedClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 384)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SeedClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeedClass"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents etb_Description As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etb_Code As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
