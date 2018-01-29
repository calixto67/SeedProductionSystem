<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeedProductionDataEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeedProductionDataEntry))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.emccb_Crop = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.emccb_ProductionArea = New ETSSUtility.BLL.EMultiColumnComboBox(Me.components)
        Me.RadLabelValidation__CropYear = New Telerik.WinControls.UI.RadLabel()
        Me.etb_TargetQty = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_EstPlantPop = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_ClusterID = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_TargetArea = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_SeedClass = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.RadLabelValidation__FarmersName = New Telerik.WinControls.UI.RadLabel()
        Me.etb_CropCode = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.rddl_CropYear = New Telerik.WinControls.UI.RadDropDownList()
        Me.rddl_FarmersName = New Telerik.WinControls.UI.RadDropDownList()
        Me.etb_PricePerKilo = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_PlanYield = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_ContractNo = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_SSNo = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_FarmAddress = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.etb_FarmersBatchNo = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.emccb_Crop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_Crop.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_Crop.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_ProductionArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_ProductionArea.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emccb_ProductionArea.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabelValidation__CropYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_TargetQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_EstPlantPop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ClusterID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_TargetArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_SeedClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabelValidation__FarmersName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rddl_CropYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rddl_FarmersName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_PricePerKilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_PlanYield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ContractNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_SSNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FarmAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FarmersBatchNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(65, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 23)
        Me.Label16.TabIndex = 211
        Me.Label16.Text = "Contract #:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(617, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seed Production Data Entry Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 23)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "SS #:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = "Farmer's Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 44)
        Me.Panel1.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 23)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "Farm Address:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Plan Yield:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 228
        Me.Label6.Text = "Price Per Kilo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 23)
        Me.Label7.TabIndex = 230
        Me.Label7.Text = "Farmer Batch Number:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(396, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 23)
        Me.Label12.TabIndex = 235
        Me.Label12.Text = "Crop:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(364, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 23)
        Me.Label13.TabIndex = 237
        Me.Label13.Text = "Crop Code:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(359, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 23)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "Seed Class:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(361, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 23)
        Me.Label15.TabIndex = 241
        Me.Label15.Text = "Target Area:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(300, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 23)
        Me.Label17.TabIndex = 243
        Me.Label17.Text = "Estimated Plant Pop:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(298, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 23)
        Me.Label8.TabIndex = 245
        Me.Label8.Text = "Target Quantity:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etb_FarmersBatchNo)
        Me.GroupBox1.Controls.Add(Me.emccb_Crop)
        Me.GroupBox1.Controls.Add(Me.emccb_ProductionArea)
        Me.GroupBox1.Controls.Add(Me.RadLabelValidation__CropYear)
        Me.GroupBox1.Controls.Add(Me.etb_TargetQty)
        Me.GroupBox1.Controls.Add(Me.etb_EstPlantPop)
        Me.GroupBox1.Controls.Add(Me.etb_ClusterID)
        Me.GroupBox1.Controls.Add(Me.etb_TargetArea)
        Me.GroupBox1.Controls.Add(Me.etb_SeedClass)
        Me.GroupBox1.Controls.Add(Me.RadLabelValidation__FarmersName)
        Me.GroupBox1.Controls.Add(Me.etb_CropCode)
        Me.GroupBox1.Controls.Add(Me.rddl_CropYear)
        Me.GroupBox1.Controls.Add(Me.rddl_FarmersName)
        Me.GroupBox1.Controls.Add(Me.etb_PricePerKilo)
        Me.GroupBox1.Controls.Add(Me.etb_PlanYield)
        Me.GroupBox1.Controls.Add(Me.etb_ContractNo)
        Me.GroupBox1.Controls.Add(Me.etb_SSNo)
        Me.GroupBox1.Controls.Add(Me.etb_FarmAddress)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 269)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        '
        'emccb_Crop
        '
        Me.emccb_Crop.AutoFilter = True
        Me.emccb_Crop.AutoReset = True
        Me.emccb_Crop.Data = Nothing
        Me.emccb_Crop.Dislaycol = ""
        Me.emccb_Crop.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'emccb_Crop.NestedRadGridView
        '
        Me.emccb_Crop.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.emccb_Crop.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emccb_Crop.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.emccb_Crop.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'emccb_Crop.NestedRadGridView
        '
        Me.emccb_Crop.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.emccb_Crop.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.emccb_Crop.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.emccb_Crop.EditorControl.MasterTemplate.EnableFiltering = True
        Me.emccb_Crop.EditorControl.MasterTemplate.EnableGrouping = False
        Me.emccb_Crop.EditorControl.Name = "NestedRadGridView"
        Me.emccb_Crop.EditorControl.ReadOnly = True
        Me.emccb_Crop.EditorControl.ShowGroupPanel = False
        Me.emccb_Crop.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.emccb_Crop.EditorControl.TabIndex = 0
        Me.emccb_Crop.Location = New System.Drawing.Point(457, 67)
        Me.emccb_Crop.Name = "emccb_Crop"
        '
        '
        '
        Me.emccb_Crop.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.emccb_Crop.SelectedDisplayValue = ""
        Me.emccb_Crop.SelectedValue = Nothing
        Me.emccb_Crop.Size = New System.Drawing.Size(140, 18)
        Me.emccb_Crop.TabIndex = 265
        Me.emccb_Crop.TabStop = False
        Me.emccb_Crop.Text = "EMultiColumnComboBox1"
        Me.emccb_Crop.ValidateRequiredField = True
        Me.emccb_Crop.Valuecol = ""
        '
        'emccb_ProductionArea
        '
        Me.emccb_ProductionArea.AutoFilter = True
        Me.emccb_ProductionArea.AutoReset = True
        Me.emccb_ProductionArea.Data = Nothing
        Me.emccb_ProductionArea.Dislaycol = ""
        Me.emccb_ProductionArea.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'emccb_ProductionArea.NestedRadGridView
        '
        Me.emccb_ProductionArea.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.emccb_ProductionArea.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emccb_ProductionArea.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.emccb_ProductionArea.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'emccb_ProductionArea.NestedRadGridView
        '
        Me.emccb_ProductionArea.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.emccb_ProductionArea.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.emccb_ProductionArea.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.emccb_ProductionArea.EditorControl.MasterTemplate.EnableFiltering = True
        Me.emccb_ProductionArea.EditorControl.MasterTemplate.EnableGrouping = False
        Me.emccb_ProductionArea.EditorControl.Name = "NestedRadGridView"
        Me.emccb_ProductionArea.EditorControl.ReadOnly = True
        Me.emccb_ProductionArea.EditorControl.ShowGroupPanel = False
        Me.emccb_ProductionArea.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.emccb_ProductionArea.EditorControl.TabIndex = 0
        Me.emccb_ProductionArea.Location = New System.Drawing.Point(166, 36)
        Me.emccb_ProductionArea.Name = "emccb_ProductionArea"
        '
        '
        '
        Me.emccb_ProductionArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.emccb_ProductionArea.SelectedDisplayValue = ""
        Me.emccb_ProductionArea.SelectedValue = Nothing
        Me.emccb_ProductionArea.Size = New System.Drawing.Size(145, 18)
        Me.emccb_ProductionArea.TabIndex = 264
        Me.emccb_ProductionArea.TabStop = False
        Me.emccb_ProductionArea.Text = "EMultiColumnComboBox1"
        Me.emccb_ProductionArea.ValidateRequiredField = True
        Me.emccb_ProductionArea.Valuecol = ""
        '
        'RadLabelValidation__CropYear
        '
        Me.RadLabelValidation__CropYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabelValidation__CropYear.ForeColor = System.Drawing.Color.Red
        Me.RadLabelValidation__CropYear.Location = New System.Drawing.Point(588, 44)
        Me.RadLabelValidation__CropYear.Name = "RadLabelValidation__CropYear"
        Me.RadLabelValidation__CropYear.Size = New System.Drawing.Size(13, 19)
        Me.RadLabelValidation__CropYear.TabIndex = 262
        Me.RadLabelValidation__CropYear.Text = "*"
        '
        'etb_TargetQty
        '
        Me.etb_TargetQty.Location = New System.Drawing.Point(457, 195)
        Me.etb_TargetQty.Name = "etb_TargetQty"
        '
        '
        '
        Me.etb_TargetQty.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_TargetQty.Size = New System.Drawing.Size(145, 20)
        Me.etb_TargetQty.TabIndex = 262
        Me.etb_TargetQty.TabStop = False
        Me.etb_TargetQty.Text = "ETextBox9"
        Me.etb_TargetQty.ValidateRequiredField = True
        '
        'etb_EstPlantPop
        '
        Me.etb_EstPlantPop.Location = New System.Drawing.Point(457, 169)
        Me.etb_EstPlantPop.Name = "etb_EstPlantPop"
        '
        '
        '
        Me.etb_EstPlantPop.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_EstPlantPop.Size = New System.Drawing.Size(145, 20)
        Me.etb_EstPlantPop.TabIndex = 263
        Me.etb_EstPlantPop.TabStop = False
        Me.etb_EstPlantPop.Text = "ETextBox10"
        Me.etb_EstPlantPop.ValidateRequiredField = True
        '
        'etb_ClusterID
        '
        Me.etb_ClusterID.Location = New System.Drawing.Point(455, 17)
        Me.etb_ClusterID.Name = "etb_ClusterID"
        '
        '
        '
        Me.etb_ClusterID.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ClusterID.Size = New System.Drawing.Size(145, 20)
        Me.etb_ClusterID.TabIndex = 256
        Me.etb_ClusterID.TabStop = False
        Me.etb_ClusterID.Text = "ETextBox2"
        Me.etb_ClusterID.ValidateRequiredField = True
        '
        'etb_TargetArea
        '
        Me.etb_TargetArea.Location = New System.Drawing.Point(457, 143)
        Me.etb_TargetArea.Name = "etb_TargetArea"
        '
        '
        '
        Me.etb_TargetArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_TargetArea.Size = New System.Drawing.Size(145, 20)
        Me.etb_TargetArea.TabIndex = 261
        Me.etb_TargetArea.TabStop = False
        Me.etb_TargetArea.Text = "ETextBox11"
        Me.etb_TargetArea.ValidateRequiredField = True
        '
        'etb_SeedClass
        '
        Me.etb_SeedClass.Location = New System.Drawing.Point(457, 117)
        Me.etb_SeedClass.Name = "etb_SeedClass"
        '
        '
        '
        Me.etb_SeedClass.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_SeedClass.Size = New System.Drawing.Size(145, 20)
        Me.etb_SeedClass.TabIndex = 260
        Me.etb_SeedClass.TabStop = False
        Me.etb_SeedClass.Text = "ETextBox12"
        Me.etb_SeedClass.ValidateRequiredField = True
        '
        'RadLabelValidation__FarmersName
        '
        Me.RadLabelValidation__FarmersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabelValidation__FarmersName.ForeColor = System.Drawing.Color.Red
        Me.RadLabelValidation__FarmersName.Location = New System.Drawing.Point(302, 62)
        Me.RadLabelValidation__FarmersName.Name = "RadLabelValidation__FarmersName"
        Me.RadLabelValidation__FarmersName.Size = New System.Drawing.Size(13, 19)
        Me.RadLabelValidation__FarmersName.TabIndex = 261
        Me.RadLabelValidation__FarmersName.Text = "*"
        '
        'etb_CropCode
        '
        Me.etb_CropCode.Location = New System.Drawing.Point(457, 91)
        Me.etb_CropCode.Name = "etb_CropCode"
        '
        '
        '
        Me.etb_CropCode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_CropCode.Size = New System.Drawing.Size(145, 20)
        Me.etb_CropCode.TabIndex = 259
        Me.etb_CropCode.TabStop = False
        Me.etb_CropCode.Text = "ETextBox13"
        Me.etb_CropCode.ValidateRequiredField = True
        '
        'rddl_CropYear
        '
        Me.rddl_CropYear.DropDownAnimationEnabled = True
        Me.rddl_CropYear.Location = New System.Drawing.Point(457, 41)
        Me.rddl_CropYear.Name = "rddl_CropYear"
        Me.rddl_CropYear.ShowImageInEditorArea = True
        Me.rddl_CropYear.Size = New System.Drawing.Size(128, 20)
        Me.rddl_CropYear.TabIndex = 260
        Me.rddl_CropYear.Text = "RadDropDownList2"
        '
        'rddl_FarmersName
        '
        Me.rddl_FarmersName.DropDownAnimationEnabled = True
        Me.rddl_FarmersName.Location = New System.Drawing.Point(166, 61)
        Me.rddl_FarmersName.Name = "rddl_FarmersName"
        Me.rddl_FarmersName.ShowImageInEditorArea = True
        Me.rddl_FarmersName.Size = New System.Drawing.Size(135, 20)
        Me.rddl_FarmersName.TabIndex = 259
        Me.rddl_FarmersName.Text = "RadDropDownList1"
        '
        'etb_PricePerKilo
        '
        Me.etb_PricePerKilo.Location = New System.Drawing.Point(166, 191)
        Me.etb_PricePerKilo.Name = "etb_PricePerKilo"
        '
        '
        '
        Me.etb_PricePerKilo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_PricePerKilo.Size = New System.Drawing.Size(145, 20)
        Me.etb_PricePerKilo.TabIndex = 258
        Me.etb_PricePerKilo.TabStop = False
        Me.etb_PricePerKilo.Text = "ETextBox7"
        Me.etb_PricePerKilo.ValidateRequiredField = True
        '
        'etb_PlanYield
        '
        Me.etb_PlanYield.Location = New System.Drawing.Point(166, 165)
        Me.etb_PlanYield.Name = "etb_PlanYield"
        '
        '
        '
        Me.etb_PlanYield.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_PlanYield.Size = New System.Drawing.Size(145, 20)
        Me.etb_PlanYield.TabIndex = 258
        Me.etb_PlanYield.TabStop = False
        Me.etb_PlanYield.Text = "ETextBox6"
        Me.etb_PlanYield.ValidateRequiredField = True
        '
        'etb_ContractNo
        '
        Me.etb_ContractNo.Location = New System.Drawing.Point(166, 139)
        Me.etb_ContractNo.Name = "etb_ContractNo"
        '
        '
        '
        Me.etb_ContractNo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ContractNo.Size = New System.Drawing.Size(145, 20)
        Me.etb_ContractNo.TabIndex = 257
        Me.etb_ContractNo.TabStop = False
        Me.etb_ContractNo.Text = "ETextBox5"
        Me.etb_ContractNo.ValidateRequiredField = True
        '
        'etb_SSNo
        '
        Me.etb_SSNo.Location = New System.Drawing.Point(166, 113)
        Me.etb_SSNo.Name = "etb_SSNo"
        '
        '
        '
        Me.etb_SSNo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_SSNo.Size = New System.Drawing.Size(145, 20)
        Me.etb_SSNo.TabIndex = 256
        Me.etb_SSNo.TabStop = False
        Me.etb_SSNo.Text = "ETextBox4"
        Me.etb_SSNo.ValidateRequiredField = True
        '
        'etb_FarmAddress
        '
        Me.etb_FarmAddress.Location = New System.Drawing.Point(166, 87)
        Me.etb_FarmAddress.Name = "etb_FarmAddress"
        '
        '
        '
        Me.etb_FarmAddress.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FarmAddress.Size = New System.Drawing.Size(145, 20)
        Me.etb_FarmAddress.TabIndex = 255
        Me.etb_FarmAddress.TabStop = False
        Me.etb_FarmAddress.Text = "ETextBox3"
        Me.etb_FarmAddress.ValidateRequiredField = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 23)
        Me.Label18.TabIndex = 248
        Me.Label18.Text = "Production Area:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 249
        Me.Label11.Text = "Crop Year:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 23)
        Me.Label10.TabIndex = 248
        Me.Label10.Text = "Cluster:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_Cancel)
        Me.GroupBox2.Controls.Add(Me.rb_Save)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 65)
        Me.GroupBox2.TabIndex = 247
        Me.GroupBox2.TabStop = False
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
        Me.rb_Cancel.Location = New System.Drawing.Point(496, 8)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(95, 51)
        Me.rb_Cancel.TabIndex = 251
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
        Me.rb_Save.Location = New System.Drawing.Point(382, 8)
        Me.rb_Save.Name = "rb_Save"
        Me.rb_Save.SaveFunction = Nothing
        Me.rb_Save.Size = New System.Drawing.Size(95, 51)
        Me.rb_Save.TabIndex = 250
        Me.rb_Save.Text = "&Save"
        Me.rb_Save.UpdateID = Nothing
        Me.rb_Save.UserControl = Nothing
        '
        'etb_FarmersBatchNo
        '
        Me.etb_FarmersBatchNo.Location = New System.Drawing.Point(166, 11)
        Me.etb_FarmersBatchNo.Name = "etb_FarmersBatchNo"
        '
        '
        '
        Me.etb_FarmersBatchNo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FarmersBatchNo.Size = New System.Drawing.Size(145, 20)
        Me.etb_FarmersBatchNo.TabIndex = 266
        Me.etb_FarmersBatchNo.TabStop = False
        Me.etb_FarmersBatchNo.Text = "ETextBox3"
        Me.etb_FarmersBatchNo.ValidateRequiredField = True
        '
        'SeedProductionDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 378)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "SeedProductionDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeedProductionEntry"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.emccb_Crop.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_Crop.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_Crop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_ProductionArea.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_ProductionArea.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emccb_ProductionArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabelValidation__CropYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_TargetQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_EstPlantPop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ClusterID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_TargetArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_SeedClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabelValidation__FarmersName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rddl_CropYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rddl_FarmersName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_PricePerKilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_PlanYield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ContractNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_SSNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FarmAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FarmersBatchNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etb_ContractNo As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_SSNo As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_FarmAddress As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents rddl_FarmersName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents etb_PricePerKilo As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_PlanYield As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents rddl_CropYear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabelValidation__FarmersName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents etb_TargetQty As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_EstPlantPop As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ClusterID As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_TargetArea As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_SeedClass As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_CropCode As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
    Friend WithEvents RadLabelValidation__CropYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents emccb_Crop As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents emccb_ProductionArea As ETSSUtility.BLL.EMultiColumnComboBox
    Friend WithEvents etb_FarmersBatchNo As ETSSUtility.ETSSControls.ETextBox
End Class
