<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YieldMasterDataEstimation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YieldMasterDataEstimation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etb_AveSeedsPerPod = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_ThousandSeedsWts = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_FruitCount = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_NewPlanYield = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.edtp_EndDateOfHarvest = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.edtp_StartDateOfHarvest = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.edtp_EndDateOfPollination = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.edtp_StartDateOfPollination = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.edtp_DateStartOfFlowering = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.EDateTimePicker1 = New ETSSUtility.ETSSControls.EDateTimePicker(Me.components)
        Me.etb_ActualArea = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_NewTargetQty = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_CropCode = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_ActualPlantPop = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_FarmersName = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_FBN = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.etb_AveSeedsPerPod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ThousandSeedsWts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FruitCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_NewPlanYield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtp_EndDateOfHarvest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtp_StartDateOfHarvest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtp_EndDateOfPollination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtp_StartDateOfPollination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtp_DateStartOfFlowering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ActualArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_NewTargetQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_ActualPlantPop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FarmersName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_FBN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(602, 45)
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
        Me.Panel1.Size = New System.Drawing.Size(602, 44)
        Me.Panel1.TabIndex = 184
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etb_AveSeedsPerPod)
        Me.GroupBox1.Controls.Add(Me.etb_ThousandSeedsWts)
        Me.GroupBox1.Controls.Add(Me.etb_FruitCount)
        Me.GroupBox1.Controls.Add(Me.etb_NewPlanYield)
        Me.GroupBox1.Controls.Add(Me.edtp_EndDateOfHarvest)
        Me.GroupBox1.Controls.Add(Me.edtp_StartDateOfHarvest)
        Me.GroupBox1.Controls.Add(Me.edtp_EndDateOfPollination)
        Me.GroupBox1.Controls.Add(Me.edtp_StartDateOfPollination)
        Me.GroupBox1.Controls.Add(Me.edtp_DateStartOfFlowering)
        Me.GroupBox1.Controls.Add(Me.EDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.etb_ActualArea)
        Me.GroupBox1.Controls.Add(Me.etb_NewTargetQty)
        Me.GroupBox1.Controls.Add(Me.etb_CropCode)
        Me.GroupBox1.Controls.Add(Me.etb_ActualPlantPop)
        Me.GroupBox1.Controls.Add(Me.etb_FarmersName)
        Me.GroupBox1.Controls.Add(Me.etb_FBN)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 275)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        '
        'etb_AveSeedsPerPod
        '
        Me.etb_AveSeedsPerPod.Location = New System.Drawing.Point(449, 184)
        Me.etb_AveSeedsPerPod.Name = "etb_AveSeedsPerPod"
        '
        '
        '
        Me.etb_AveSeedsPerPod.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_AveSeedsPerPod.Size = New System.Drawing.Size(145, 20)
        Me.etb_AveSeedsPerPod.TabIndex = 327
        Me.etb_AveSeedsPerPod.TabStop = False
        Me.etb_AveSeedsPerPod.Text = "ETextBox3"
        Me.etb_AveSeedsPerPod.ValidateRequiredField = True
        '
        'etb_ThousandSeedsWts
        '
        Me.etb_ThousandSeedsWts.Location = New System.Drawing.Point(451, 140)
        Me.etb_ThousandSeedsWts.Name = "etb_ThousandSeedsWts"
        '
        '
        '
        Me.etb_ThousandSeedsWts.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ThousandSeedsWts.Size = New System.Drawing.Size(145, 20)
        Me.etb_ThousandSeedsWts.TabIndex = 327
        Me.etb_ThousandSeedsWts.TabStop = False
        Me.etb_ThousandSeedsWts.Text = "ETextBox2"
        Me.etb_ThousandSeedsWts.ValidateRequiredField = True
        '
        'etb_FruitCount
        '
        Me.etb_FruitCount.Location = New System.Drawing.Point(449, 99)
        Me.etb_FruitCount.Name = "etb_FruitCount"
        '
        '
        '
        Me.etb_FruitCount.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FruitCount.Size = New System.Drawing.Size(145, 20)
        Me.etb_FruitCount.TabIndex = 326
        Me.etb_FruitCount.TabStop = False
        Me.etb_FruitCount.Text = "ETextBox1"
        Me.etb_FruitCount.ValidateRequiredField = True
        '
        'etb_NewPlanYield
        '
        Me.etb_NewPlanYield.Location = New System.Drawing.Point(449, 73)
        Me.etb_NewPlanYield.Name = "etb_NewPlanYield"
        '
        '
        '
        Me.etb_NewPlanYield.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_NewPlanYield.Size = New System.Drawing.Size(145, 20)
        Me.etb_NewPlanYield.TabIndex = 325
        Me.etb_NewPlanYield.TabStop = False
        Me.etb_NewPlanYield.Text = "ETextBox1"
        Me.etb_NewPlanYield.ValidateRequiredField = True
        '
        'edtp_EndDateOfHarvest
        '
        Me.edtp_EndDateOfHarvest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_EndDateOfHarvest.Location = New System.Drawing.Point(189, 223)
        Me.edtp_EndDateOfHarvest.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_EndDateOfHarvest.MinDate = New Date(CType(0, Long))
        Me.edtp_EndDateOfHarvest.Name = "edtp_EndDateOfHarvest"
        Me.edtp_EndDateOfHarvest.NullableValue = New Date(2018, 1, 27, 21, 33, 52, 121)
        Me.edtp_EndDateOfHarvest.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_EndDateOfHarvest.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_EndDateOfHarvest.Size = New System.Drawing.Size(146, 18)
        Me.edtp_EndDateOfHarvest.TabIndex = 324
        Me.edtp_EndDateOfHarvest.TabStop = False
        Me.edtp_EndDateOfHarvest.Text = "27/01/2018"
        Me.edtp_EndDateOfHarvest.ValidateRequiredField = True
        Me.edtp_EndDateOfHarvest.Value = New Date(2018, 1, 27, 21, 33, 52, 121)
        '
        'edtp_StartDateOfHarvest
        '
        Me.edtp_StartDateOfHarvest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_StartDateOfHarvest.Location = New System.Drawing.Point(189, 199)
        Me.edtp_StartDateOfHarvest.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_StartDateOfHarvest.MinDate = New Date(CType(0, Long))
        Me.edtp_StartDateOfHarvest.Name = "edtp_StartDateOfHarvest"
        Me.edtp_StartDateOfHarvest.NullableValue = New Date(2018, 1, 27, 21, 33, 49, 823)
        Me.edtp_StartDateOfHarvest.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_StartDateOfHarvest.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_StartDateOfHarvest.Size = New System.Drawing.Size(146, 18)
        Me.edtp_StartDateOfHarvest.TabIndex = 323
        Me.edtp_StartDateOfHarvest.TabStop = False
        Me.edtp_StartDateOfHarvest.Text = "27/01/2018"
        Me.edtp_StartDateOfHarvest.ValidateRequiredField = True
        Me.edtp_StartDateOfHarvest.Value = New Date(2018, 1, 27, 21, 33, 49, 823)
        '
        'edtp_EndDateOfPollination
        '
        Me.edtp_EndDateOfPollination.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_EndDateOfPollination.Location = New System.Drawing.Point(189, 172)
        Me.edtp_EndDateOfPollination.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_EndDateOfPollination.MinDate = New Date(CType(0, Long))
        Me.edtp_EndDateOfPollination.Name = "edtp_EndDateOfPollination"
        Me.edtp_EndDateOfPollination.NullableValue = New Date(2018, 1, 27, 21, 33, 46, 792)
        Me.edtp_EndDateOfPollination.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_EndDateOfPollination.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_EndDateOfPollination.Size = New System.Drawing.Size(146, 18)
        Me.edtp_EndDateOfPollination.TabIndex = 322
        Me.edtp_EndDateOfPollination.TabStop = False
        Me.edtp_EndDateOfPollination.Text = "27/01/2018"
        Me.edtp_EndDateOfPollination.ValidateRequiredField = True
        Me.edtp_EndDateOfPollination.Value = New Date(2018, 1, 27, 21, 33, 46, 792)
        '
        'edtp_StartDateOfPollination
        '
        Me.edtp_StartDateOfPollination.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_StartDateOfPollination.Location = New System.Drawing.Point(189, 147)
        Me.edtp_StartDateOfPollination.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_StartDateOfPollination.MinDate = New Date(CType(0, Long))
        Me.edtp_StartDateOfPollination.Name = "edtp_StartDateOfPollination"
        Me.edtp_StartDateOfPollination.NullableValue = New Date(2018, 1, 27, 21, 33, 44, 57)
        Me.edtp_StartDateOfPollination.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_StartDateOfPollination.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_StartDateOfPollination.Size = New System.Drawing.Size(146, 18)
        Me.edtp_StartDateOfPollination.TabIndex = 321
        Me.edtp_StartDateOfPollination.TabStop = False
        Me.edtp_StartDateOfPollination.Text = "27/01/2018"
        Me.edtp_StartDateOfPollination.ValidateRequiredField = True
        Me.edtp_StartDateOfPollination.Value = New Date(2018, 1, 27, 21, 33, 44, 57)
        '
        'edtp_DateStartOfFlowering
        '
        Me.edtp_DateStartOfFlowering.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.edtp_DateStartOfFlowering.Location = New System.Drawing.Point(189, 124)
        Me.edtp_DateStartOfFlowering.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.edtp_DateStartOfFlowering.MinDate = New Date(CType(0, Long))
        Me.edtp_DateStartOfFlowering.Name = "edtp_DateStartOfFlowering"
        Me.edtp_DateStartOfFlowering.NullableValue = New Date(2018, 1, 27, 21, 33, 40, 541)
        Me.edtp_DateStartOfFlowering.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.edtp_DateStartOfFlowering.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.edtp_DateStartOfFlowering.Size = New System.Drawing.Size(146, 18)
        Me.edtp_DateStartOfFlowering.TabIndex = 320
        Me.edtp_DateStartOfFlowering.TabStop = False
        Me.edtp_DateStartOfFlowering.Text = "27/01/2018"
        Me.edtp_DateStartOfFlowering.ValidateRequiredField = True
        Me.edtp_DateStartOfFlowering.Value = New Date(2018, 1, 27, 21, 33, 40, 541)
        '
        'EDateTimePicker1
        '
        Me.EDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EDateTimePicker1.Location = New System.Drawing.Point(189, 73)
        Me.EDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EDateTimePicker1.MinDate = New Date(CType(0, Long))
        Me.EDateTimePicker1.Name = "EDateTimePicker1"
        Me.EDateTimePicker1.NullableValue = New Date(2018, 1, 27, 21, 31, 36, 0)
        Me.EDateTimePicker1.NullDate = New Date(CType(0, Long))
        '
        '
        '
        Me.EDateTimePicker1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.EDateTimePicker1.Size = New System.Drawing.Size(146, 18)
        Me.EDateTimePicker1.TabIndex = 249
        Me.EDateTimePicker1.TabStop = False
        Me.EDateTimePicker1.Text = "27/01/2018"
        Me.EDateTimePicker1.ValidateRequiredField = True
        Me.EDateTimePicker1.Value = New Date(2018, 1, 27, 21, 31, 36, 0)
        '
        'etb_ActualArea
        '
        Me.etb_ActualArea.Location = New System.Drawing.Point(448, 46)
        Me.etb_ActualArea.Name = "etb_ActualArea"
        '
        '
        '
        Me.etb_ActualArea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ActualArea.Size = New System.Drawing.Size(145, 20)
        Me.etb_ActualArea.TabIndex = 258
        Me.etb_ActualArea.TabStop = False
        Me.etb_ActualArea.Text = "ETextBox4"
        Me.etb_ActualArea.ValidateRequiredField = True
        '
        'etb_NewTargetQty
        '
        Me.etb_NewTargetQty.Location = New System.Drawing.Point(189, 250)
        Me.etb_NewTargetQty.Name = "etb_NewTargetQty"
        '
        '
        '
        Me.etb_NewTargetQty.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_NewTargetQty.Size = New System.Drawing.Size(145, 20)
        Me.etb_NewTargetQty.TabIndex = 319
        Me.etb_NewTargetQty.TabStop = False
        Me.etb_NewTargetQty.Text = "ETextBox7"
        Me.etb_NewTargetQty.ValidateRequiredField = True
        '
        'etb_CropCode
        '
        Me.etb_CropCode.Location = New System.Drawing.Point(448, 20)
        Me.etb_CropCode.Name = "etb_CropCode"
        '
        '
        '
        Me.etb_CropCode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_CropCode.Size = New System.Drawing.Size(145, 20)
        Me.etb_CropCode.TabIndex = 257
        Me.etb_CropCode.TabStop = False
        Me.etb_CropCode.Text = "ETextBox3"
        Me.etb_CropCode.ValidateRequiredField = True
        '
        'etb_ActualPlantPop
        '
        Me.etb_ActualPlantPop.Location = New System.Drawing.Point(189, 96)
        Me.etb_ActualPlantPop.Name = "etb_ActualPlantPop"
        '
        '
        '
        Me.etb_ActualPlantPop.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_ActualPlantPop.Size = New System.Drawing.Size(145, 20)
        Me.etb_ActualPlantPop.TabIndex = 318
        Me.etb_ActualPlantPop.TabStop = False
        Me.etb_ActualPlantPop.Text = "ETextBox7"
        Me.etb_ActualPlantPop.ValidateRequiredField = True
        '
        'etb_FarmersName
        '
        Me.etb_FarmersName.Location = New System.Drawing.Point(189, 45)
        Me.etb_FarmersName.Name = "etb_FarmersName"
        '
        '
        '
        Me.etb_FarmersName.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FarmersName.Size = New System.Drawing.Size(145, 20)
        Me.etb_FarmersName.TabIndex = 317
        Me.etb_FarmersName.TabStop = False
        Me.etb_FarmersName.Text = "ETextBox7"
        Me.etb_FarmersName.ValidateRequiredField = True
        '
        'etb_FBN
        '
        Me.etb_FBN.Location = New System.Drawing.Point(189, 19)
        Me.etb_FBN.Name = "etb_FBN"
        '
        '
        '
        Me.etb_FBN.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_FBN.Size = New System.Drawing.Size(145, 20)
        Me.etb_FBN.TabIndex = 316
        Me.etb_FBN.TabStop = False
        Me.etb_FBN.Text = "ETextBox6"
        Me.etb_FBN.ValidateRequiredField = True
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(324, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 36)
        Me.Label21.TabIndex = 314
        Me.Label21.Text = "Ave. # of seeds per 20 fruits/pod:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(324, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 36)
        Me.Label17.TabIndex = 312
        Me.Label17.Text = "Thousand seeds wts:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(324, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 23)
        Me.Label15.TabIndex = 309
        Me.Label15.Text = "Fruit Count:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 23)
        Me.Label9.TabIndex = 308
        Me.Label9.Text = "New Target Qty:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(229, 364)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 23)
        Me.Label16.TabIndex = 306
        Me.Label16.Text = "New Target Qty:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 24)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "End Date of Harvest:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 24)
        Me.Label13.TabIndex = 302
        Me.Label13.Text = "Start Date of Harvest:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 24)
        Me.Label7.TabIndex = 300
        Me.Label7.Text = "End Date of Pollination:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 24)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "Start Date of Pollination:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 23)
        Me.Label8.TabIndex = 296
        Me.Label8.Text = "Date Start of Flowering:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = "New Plan Yield:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(353, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 23)
        Me.Label14.TabIndex = 292
        Me.Label14.Text = "Actual Area:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(362, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 23)
        Me.Label12.TabIndex = 290
        Me.Label12.Text = "Crop Code:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 286
        Me.Label10.Text = "Actual plant pop:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 23)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Farmer's name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "Sowing Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(22, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 23)
        Me.Label18.TabIndex = 226
        Me.Label18.Text = "Farmer Batch Number:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_Cancel)
        Me.GroupBox2.Controls.Add(Me.rb_Save)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(296, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 97)
        Me.GroupBox2.TabIndex = 248
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
        Me.rb_Cancel.Location = New System.Drawing.Point(163, 22)
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
        Me.rb_Save.Location = New System.Drawing.Point(49, 22)
        Me.rb_Save.Name = "rb_Save"
        Me.rb_Save.SaveFunction = Nothing
        Me.rb_Save.Size = New System.Drawing.Size(95, 51)
        Me.rb_Save.TabIndex = 252
        Me.rb_Save.Text = "   Save"
        Me.rb_Save.UpdateID = Nothing
        Me.rb_Save.UserControl = Nothing
        '
        'YieldMasterDataEstimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(602, 416)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "YieldMasterDataEstimation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YieldMasterDataEstimation"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.etb_AveSeedsPerPod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ThousandSeedsWts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FruitCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_NewPlanYield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtp_EndDateOfHarvest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtp_StartDateOfHarvest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtp_EndDateOfPollination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtp_StartDateOfPollination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtp_DateStartOfFlowering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ActualArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_NewTargetQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_CropCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_ActualPlantPop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FarmersName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_FBN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etb_FarmersName As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_FBN As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_NewTargetQty As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ActualPlantPop As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ActualArea As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_CropCode As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents EDateTimePicker1 As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents edtp_EndDateOfHarvest As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents edtp_StartDateOfHarvest As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents edtp_EndDateOfPollination As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents edtp_StartDateOfPollination As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents edtp_DateStartOfFlowering As ETSSUtility.ETSSControls.EDateTimePicker
    Friend WithEvents etb_AveSeedsPerPod As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_ThousandSeedsWts As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_FruitCount As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_NewPlanYield As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton
End Class
