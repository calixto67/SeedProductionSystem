<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_CreateOperation = New Telerik.WinControls.UI.RadButton()
        Me.EMultiColumnComboBox2 = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.rp_FieldControl = New Telerik.WinControls.UI.RadPanel()
        Me.EMultiColumnComboBox1 = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.Radbutton1 = New ETSSUtility.BLL.Radbutton()
        Me.Radbutton2 = New ETSSUtility.BLL.Radbutton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etb_ContactNo = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_Email = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_UserFullName = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_Pasword = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_Login = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_CreateOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.rp_FieldControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rp_FieldControl.SuspendLayout()
        CType(Me.EMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.Radbutton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Radbutton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.etb_ContactNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_UserFullName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Pasword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 44)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "Create Field Formula"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.rb_Cancel)
        Me.RadPanel2.Controls.Add(Me.rb_Save)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel2.Location = New System.Drawing.Point(0, 383)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(554, 58)
        Me.RadPanel2.TabIndex = 264
        '
        'rp_FieldControl
        '
        Me.rp_FieldControl.Controls.Add(Me.rb_CreateOperation)
        Me.rp_FieldControl.Controls.Add(Me.EMultiColumnComboBox2)
        Me.rp_FieldControl.Controls.Add(Me.Label2)
        Me.rp_FieldControl.Controls.Add(Me.EMultiColumnComboBox1)
        Me.rp_FieldControl.Location = New System.Drawing.Point(0, 44)
        Me.rp_FieldControl.Name = "rp_FieldControl"
        Me.rp_FieldControl.Size = New System.Drawing.Size(200, 100)
        Me.rp_FieldControl.TabIndex = 0
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
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.Radbutton1)
        Me.RadPanel1.Controls.Add(Me.Radbutton2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel1.Location = New System.Drawing.Point(0, 199)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(322, 71)
        Me.RadPanel1.TabIndex = 259
        '
        'Radbutton1
        '
        Me.Radbutton1.AddFunction = Nothing
        Me.Radbutton1.ButtonControl = Nothing
        Me.Radbutton1.Class = Nothing
        Me.Radbutton1.DataControl = Nothing
        Me.Radbutton1.FieldControl = Nothing
        Me.Radbutton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbutton1.Image = CType(resources.GetObject("Radbutton1.Image"), System.Drawing.Image)
        Me.Radbutton1.Location = New System.Drawing.Point(175, 12)
        Me.Radbutton1.Name = "Radbutton1"
        Me.Radbutton1.SaveFunction = Nothing
        Me.Radbutton1.Size = New System.Drawing.Size(95, 51)
        Me.Radbutton1.TabIndex = 253
        Me.Radbutton1.Text = "    Cancel"
        Me.Radbutton1.UpdateID = Nothing
        Me.Radbutton1.UserControl = Nothing
        '
        'Radbutton2
        '
        Me.Radbutton2.AddFunction = Nothing
        Me.Radbutton2.ButtonControl = Nothing
        Me.Radbutton2.Class = Nothing
        Me.Radbutton2.DataControl = Nothing
        Me.Radbutton2.FieldControl = Nothing
        Me.Radbutton2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radbutton2.Image = CType(resources.GetObject("Radbutton2.Image"), System.Drawing.Image)
        Me.Radbutton2.Location = New System.Drawing.Point(54, 12)
        Me.Radbutton2.Name = "Radbutton2"
        Me.Radbutton2.SaveFunction = Nothing
        Me.Radbutton2.Size = New System.Drawing.Size(95, 51)
        Me.Radbutton2.TabIndex = 252
        Me.Radbutton2.Text = "   Save"
        Me.Radbutton2.UpdateID = Nothing
        Me.Radbutton2.UserControl = Nothing
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(322, 44)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Seed Class"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 44)
        Me.Panel1.TabIndex = 257
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etb_ContactNo)
        Me.GroupBox1.Controls.Add(Me.etb_Email)
        Me.GroupBox1.Controls.Add(Me.etb_UserFullName)
        Me.GroupBox1.Controls.Add(Me.etb_Pasword)
        Me.GroupBox1.Controls.Add(Me.etb_Login)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 161)
        Me.GroupBox1.TabIndex = 260
        Me.GroupBox1.TabStop = False
        '
        'etb_ContactNo
        '
        Me.etb_ContactNo.Location = New System.Drawing.Point(137, 117)
        Me.etb_ContactNo.Name = "etb_ContactNo"
        '
        '
        '
        Me.etb_ContactNo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ContactNo.Size = New System.Drawing.Size(145, 20)
        Me.etb_ContactNo.TabIndex = 267
        Me.etb_ContactNo.TabStop = False
        Me.etb_ContactNo.Text = "ETextBox7"
        Me.etb_ContactNo.ValidateRequiredField = True
        '
        'etb_Email
        '
        Me.etb_Email.Location = New System.Drawing.Point(137, 91)
        Me.etb_Email.Name = "etb_Email"
        '
        '
        '
        Me.etb_Email.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Email.Size = New System.Drawing.Size(145, 20)
        Me.etb_Email.TabIndex = 268
        Me.etb_Email.TabStop = False
        Me.etb_Email.Text = "ETextBox6"
        Me.etb_Email.ValidateRequiredField = True
        '
        'etb_UserFullName
        '
        Me.etb_UserFullName.Location = New System.Drawing.Point(137, 65)
        Me.etb_UserFullName.Name = "etb_UserFullName"
        '
        '
        '
        Me.etb_UserFullName.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_UserFullName.Size = New System.Drawing.Size(145, 20)
        Me.etb_UserFullName.TabIndex = 266
        Me.etb_UserFullName.TabStop = False
        Me.etb_UserFullName.Text = "ETextBox5"
        Me.etb_UserFullName.ValidateRequiredField = True
        '
        'etb_Pasword
        '
        Me.etb_Pasword.Location = New System.Drawing.Point(137, 39)
        Me.etb_Pasword.Name = "etb_Pasword"
        '
        '
        '
        Me.etb_Pasword.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Pasword.Size = New System.Drawing.Size(145, 20)
        Me.etb_Pasword.TabIndex = 265
        Me.etb_Pasword.TabStop = False
        Me.etb_Pasword.Text = "ETextBox4"
        Me.etb_Pasword.ValidateRequiredField = True
        '
        'etb_Login
        '
        Me.etb_Login.Location = New System.Drawing.Point(137, 13)
        Me.etb_Login.Name = "etb_Login"
        '
        '
        '
        Me.etb_Login.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Login.Size = New System.Drawing.Size(145, 20)
        Me.etb_Login.TabIndex = 264
        Me.etb_Login.TabStop = False
        Me.etb_Login.Text = "ETextBox3"
        Me.etb_Login.ValidateRequiredField = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-19, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "Contact Number:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-19, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 262
        Me.Label5.Text = "Email:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-16, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 261
        Me.Label3.Text = "Login:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 23)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "User Full Name:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 23)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "Password:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 270)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAccount"
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_CreateOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.rp_FieldControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rp_FieldControl.ResumeLayout(False)
        Me.rp_FieldControl.PerformLayout()
        CType(Me.EMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.Radbutton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Radbutton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.etb_ContactNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_UserFullName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Pasword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_CreateOperation As Telerik.WinControls.UI.RadButton
    Friend WithEvents EMultiColumnComboBox2 As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rp_FieldControl As Telerik.WinControls.UI.RadPanel
    Friend WithEvents EMultiColumnComboBox1 As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Radbutton1 As ETSSUtility.BLL.Radbutton
    Friend WithEvents Radbutton2 As ETSSUtility.BLL.Radbutton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents etb_ContactNo As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_Email As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_UserFullName As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_Pasword As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_Login As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
