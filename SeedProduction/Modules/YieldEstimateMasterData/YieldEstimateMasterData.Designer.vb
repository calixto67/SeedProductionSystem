<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YieldEstimateMasterData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YieldEstimateMasterData))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.edtp_SowingDate = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.etb_ActualArea = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_NewTargetQty = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_TargetQty = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_TargetArea = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_ActualPlantPop = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.EMCCB_FBN = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.etb_CropCode = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_FarmersName = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_save = New ETSSUtility.BLL.Radbutton()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_NewYieldEstimate = New ETSSUtility.BLL.Radbutton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.edtp_SowingDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ActualArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_NewTargetQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_TargetQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_TargetArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ActualPlantPop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMCCB_FBN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMCCB_FBN.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMCCB_FBN.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FarmersName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.rb_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_NewYieldEstimate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-22, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 23)
        Me.Label7.TabIndex = 266
        Me.Label7.Text = "Farmer batch number:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yield Estimate Master Data Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 44)
        Me.Panel1.TabIndex = 246
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 23)
        Me.Label8.TabIndex = 270
        Me.Label8.Text = "Target area:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "Farmer's name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 21)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "Sowing Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(341, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 23)
        Me.Label12.TabIndex = 282
        Me.Label12.Text = "Crop Code:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(306, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 284
        Me.Label10.Text = "Actual plant pop:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(318, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 23)
        Me.Label11.TabIndex = 286
        Me.Label11.Text = "Target quantity:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(332, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 23)
        Me.Label14.TabIndex = 288
        Me.Label14.Text = "Actual Area:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 23)
        Me.Label15.TabIndex = 291
        Me.Label15.Text = "New Target Quantity:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.edtp_SowingDate)
        Me.GroupBox1.Controls.Add(Me.etb_ActualArea)
        Me.GroupBox1.Controls.Add(Me.etb_NewTargetQty)
        Me.GroupBox1.Controls.Add(Me.etb_TargetQty)
        Me.GroupBox1.Controls.Add(Me.etb_TargetArea)
        Me.GroupBox1.Controls.Add(Me.etb_ActualPlantPop)
        Me.GroupBox1.Controls.Add(Me.EMCCB_FBN)
        Me.GroupBox1.Controls.Add(Me.etb_CropCode)
        Me.GroupBox1.Controls.Add(Me.etb_FarmersName)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 150)
        Me.GroupBox1.TabIndex = 293
        Me.GroupBox1.TabStop = False
        '
        'edtp_SowingDate
        '
        Me.edtp_SowingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_SowingDate.Location = New System.Drawing.Point(166, 101)
        Me.edtp_SowingDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_SowingDate.MinDate = New Date(CType(0, Long))
        Me.edtp_SowingDate.Name = "edtp_SowingDate"
        Me.edtp_SowingDate.NullableValue = New Date(2018, 1, 27, 21, 24, 1, 477)
        Me.edtp_SowingDate.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_SowingDate.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_SowingDate.Size = New System.Drawing.Size(145, 18)
        Me.edtp_SowingDate.TabIndex = 293
        Me.edtp_SowingDate.TabStop = False
        Me.edtp_SowingDate.Text = "27/01/2018"
        Me.edtp_SowingDate.ValidateRequiredField = True
        Me.edtp_SowingDate.Value = New Date(2018, 1, 27, 21, 24, 1, 477)
        '
        'etb_ActualArea
        '
        Me.etb_ActualArea.Location = New System.Drawing.Point(429, 99)
        Me.etb_ActualArea.Name = "etb_ActualArea"
        '
        '
        '
        Me.etb_ActualArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ActualArea.Size = New System.Drawing.Size(145, 20)
        Me.etb_ActualArea.TabIndex = 261
        Me.etb_ActualArea.TabStop = False
        Me.etb_ActualArea.Text = "ETextBox7"
        Me.etb_ActualArea.ValidateRequiredField = True
        '
        'etb_NewTargetQty
        '
        Me.etb_NewTargetQty.Location = New System.Drawing.Point(166, 125)
        Me.etb_NewTargetQty.Name = "etb_NewTargetQty"
        '
        '
        '
        Me.etb_NewTargetQty.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_NewTargetQty.Size = New System.Drawing.Size(145, 20)
        Me.etb_NewTargetQty.TabIndex = 261
        Me.etb_NewTargetQty.TabStop = False
        Me.etb_NewTargetQty.Text = "ETextBox7"
        Me.etb_NewTargetQty.ValidateRequiredField = True
        '
        'etb_TargetQty
        '
        Me.etb_TargetQty.Location = New System.Drawing.Point(429, 73)
        Me.etb_TargetQty.Name = "etb_TargetQty"
        '
        '
        '
        Me.etb_TargetQty.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_TargetQty.Size = New System.Drawing.Size(145, 20)
        Me.etb_TargetQty.TabIndex = 262
        Me.etb_TargetQty.TabStop = False
        Me.etb_TargetQty.Text = "ETextBox6"
        Me.etb_TargetQty.ValidateRequiredField = True
        '
        'etb_TargetArea
        '
        Me.etb_TargetArea.Location = New System.Drawing.Point(166, 73)
        Me.etb_TargetArea.Name = "etb_TargetArea"
        '
        '
        '
        Me.etb_TargetArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_TargetArea.Size = New System.Drawing.Size(145, 20)
        Me.etb_TargetArea.TabIndex = 260
        Me.etb_TargetArea.TabStop = False
        Me.etb_TargetArea.Text = "ETextBox7"
        Me.etb_TargetArea.ValidateRequiredField = True
        '
        'etb_ActualPlantPop
        '
        Me.etb_ActualPlantPop.Location = New System.Drawing.Point(429, 47)
        Me.etb_ActualPlantPop.Name = "etb_ActualPlantPop"
        '
        '
        '
        Me.etb_ActualPlantPop.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ActualPlantPop.Size = New System.Drawing.Size(145, 20)
        Me.etb_ActualPlantPop.TabIndex = 260
        Me.etb_ActualPlantPop.TabStop = False
        Me.etb_ActualPlantPop.Text = "ETextBox5"
        Me.etb_ActualPlantPop.ValidateRequiredField = True
        '
        'EMCCB_FBN
        '
        Me.EMCCB_FBN.AutoFilter = True
        Me.EMCCB_FBN.AutoReset = True
        Me.EMCCB_FBN.Data = Nothing
        Me.EMCCB_FBN.Dislaycol = ""
        Me.EMCCB_FBN.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'EMCCB_FBN.NestedRadGridView
        '
        Me.EMCCB_FBN.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.EMCCB_FBN.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMCCB_FBN.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EMCCB_FBN.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.EMCCB_FBN.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.EMCCB_FBN.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.EMCCB_FBN.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.EMCCB_FBN.EditorControl.MasterTemplate.EnableFiltering = True
        Me.EMCCB_FBN.EditorControl.MasterTemplate.EnableGrouping = False
        Me.EMCCB_FBN.EditorControl.Name = "NestedRadGridView"
        Me.EMCCB_FBN.EditorControl.ReadOnly = True
        Me.EMCCB_FBN.EditorControl.ShowGroupPanel = False
        Me.EMCCB_FBN.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.EMCCB_FBN.EditorControl.TabIndex = 0
        Me.EMCCB_FBN.Location = New System.Drawing.Point(166, 20)
        Me.EMCCB_FBN.Name = "EMCCB_FBN"
        '
        '
        '
        Me.EMCCB_FBN.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.EMCCB_FBN.SelectedDisplayValue = ""
        Me.EMCCB_FBN.SelectedValue = Nothing
        Me.EMCCB_FBN.Size = New System.Drawing.Size(143, 18)
        Me.EMCCB_FBN.TabIndex = 292
        Me.EMCCB_FBN.TabStop = False
        Me.EMCCB_FBN.Text = "EMultiColumnComboBox1"
        Me.EMCCB_FBN.ValidateRequiredField = True
        Me.EMCCB_FBN.Valuecol = ""
        '
        'etb_CropCode
        '
        Me.etb_CropCode.Location = New System.Drawing.Point(429, 21)
        Me.etb_CropCode.Name = "etb_CropCode"
        '
        '
        '
        Me.etb_CropCode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_CropCode.Size = New System.Drawing.Size(145, 20)
        Me.etb_CropCode.TabIndex = 259
        Me.etb_CropCode.TabStop = False
        Me.etb_CropCode.Text = "ETextBox4"
        Me.etb_CropCode.ValidateRequiredField = True
        '
        'etb_FarmersName
        '
        Me.etb_FarmersName.Location = New System.Drawing.Point(166, 47)
        Me.etb_FarmersName.Name = "etb_FarmersName"
        '
        '
        '
        Me.etb_FarmersName.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FarmersName.Size = New System.Drawing.Size(145, 20)
        Me.etb_FarmersName.TabIndex = 259
        Me.etb_FarmersName.TabStop = False
        Me.etb_FarmersName.Text = "ETextBox6"
        Me.etb_FarmersName.ValidateRequiredField = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_save)
        Me.GroupBox2.Controls.Add(Me.rb_Cancel)
        Me.GroupBox2.Controls.Add(Me.rb_NewYieldEstimate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 102)
        Me.GroupBox2.TabIndex = 294
        Me.GroupBox2.TabStop = False
        '
        'rb_save
        '
        Me.rb_save.AddFunction = Nothing
        Me.rb_save.ButtonControl = Nothing
        Me.rb_save.Class = Nothing
        Me.rb_save.DataControl = Nothing
        Me.rb_save.FieldControl = Nothing
        Me.rb_save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_save.Image = CType(resources.GetObject("rb_save.Image"), System.Drawing.Image)
        Me.rb_save.Location = New System.Drawing.Point(354, 23)
        Me.rb_save.Name = "rb_save"
        Me.rb_save.SaveFunction = Nothing
        Me.rb_save.Size = New System.Drawing.Size(95, 51)
        Me.rb_save.TabIndex = 295
        Me.rb_save.Text = "   Save"
        Me.rb_save.UpdateID = Nothing
        Me.rb_save.UserControl = Nothing
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
        Me.rb_Cancel.Location = New System.Drawing.Point(479, 23)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(95, 51)
        Me.rb_Cancel.TabIndex = 294
        Me.rb_Cancel.Text = "    Cancel"
        Me.rb_Cancel.UpdateID = Nothing
        Me.rb_Cancel.UserControl = Nothing
        '
        'rb_NewYieldEstimate
        '
        Me.rb_NewYieldEstimate.AddFunction = Nothing
        Me.rb_NewYieldEstimate.ButtonControl = Nothing
        Me.rb_NewYieldEstimate.Class = Nothing
        Me.rb_NewYieldEstimate.DataControl = Nothing
        Me.rb_NewYieldEstimate.FieldControl = Nothing
        Me.rb_NewYieldEstimate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_NewYieldEstimate.Location = New System.Drawing.Point(21, 25)
        Me.rb_NewYieldEstimate.Name = "rb_NewYieldEstimate"
        Me.rb_NewYieldEstimate.SaveFunction = Nothing
        Me.rb_NewYieldEstimate.Size = New System.Drawing.Size(124, 49)
        Me.rb_NewYieldEstimate.TabIndex = 293
        Me.rb_NewYieldEstimate.Text = "New Yield Estimate"
        Me.rb_NewYieldEstimate.UpdateID = Nothing
        Me.rb_NewYieldEstimate.UserControl = Nothing
        '
        'YieldEstimateMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 296)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "YieldEstimateMasterData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YieldMasterData"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.edtp_SowingDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ActualArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_NewTargetQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_TargetQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_TargetArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ActualPlantPop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMCCB_FBN.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMCCB_FBN.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMCCB_FBN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FarmersName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.rb_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_NewYieldEstimate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EMCCB_FBN As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents etb_NewTargetQty As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_TargetArea As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_FarmersName As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ActualArea As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_TargetQty As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ActualPlantPop As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_CropCode As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_NewYieldEstimate As ETSSUtility.BLL.Radbutton
    Friend WithEvents edtp_SowingDate As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents rb_save As ETSSUtility.BLL.Radbutton
End Class
