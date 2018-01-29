<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_SeedProductionList = New ETSSUtility.BLL.Radbutton()
        Me.rb_Crop = New ETSSUtility.BLL.Radbutton()
        Me.rb_SeedClass = New ETSSUtility.BLL.Radbutton()
        Me.rb_YieldEstimateMasterData = New ETSSUtility.BLL.Radbutton()
        Me.rb_FieldFormula = New ETSSUtility.BLL.Radbutton()
        Me.rb_SeedProductionDeliveryList = New ETSSUtility.BLL.Radbutton()
        Me.rb_ProductionArea = New ETSSUtility.BLL.Radbutton()
        Me.rb_ReferenceGeneration = New ETSSUtility.BLL.Radbutton()
        Me.rb_UserAccounts = New ETSSUtility.BLL.Radbutton()
        Me.Panel1.SuspendLayout()
        CType(Me.rb_SeedProductionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Crop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_SeedClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_YieldEstimateMasterData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_FieldFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_SeedProductionDeliveryList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_ProductionArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_ReferenceGeneration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_UserAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(748, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seed Production System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 44)
        Me.Panel1.TabIndex = 246
        '
        'rb_SeedProductionList
        '
        Me.rb_SeedProductionList.AddFunction = Nothing
        Me.rb_SeedProductionList.ButtonControl = Nothing
        Me.rb_SeedProductionList.Class = Nothing
        Me.rb_SeedProductionList.DataControl = Nothing
        Me.rb_SeedProductionList.FieldControl = Nothing
        Me.rb_SeedProductionList.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_SeedProductionList.Location = New System.Drawing.Point(106, 63)
        Me.rb_SeedProductionList.Name = "rb_SeedProductionList"
        Me.rb_SeedProductionList.SaveFunction = Nothing
        Me.rb_SeedProductionList.Size = New System.Drawing.Size(240, 68)
        Me.rb_SeedProductionList.TabIndex = 257
        Me.rb_SeedProductionList.Tag = "1"
        Me.rb_SeedProductionList.Text = "Seed Production Data"
        Me.rb_SeedProductionList.UpdateID = Nothing
        Me.rb_SeedProductionList.UserControl = Nothing
        '
        'rb_Crop
        '
        Me.rb_Crop.AddFunction = Nothing
        Me.rb_Crop.ButtonControl = Nothing
        Me.rb_Crop.Class = Nothing
        Me.rb_Crop.DataControl = Nothing
        Me.rb_Crop.FieldControl = Nothing
        Me.rb_Crop.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Crop.Location = New System.Drawing.Point(387, 63)
        Me.rb_Crop.Name = "rb_Crop"
        Me.rb_Crop.SaveFunction = Nothing
        Me.rb_Crop.Size = New System.Drawing.Size(240, 68)
        Me.rb_Crop.TabIndex = 258
        Me.rb_Crop.Tag = "6"
        Me.rb_Crop.Text = "Crop"
        Me.rb_Crop.UpdateID = Nothing
        Me.rb_Crop.UserControl = Nothing
        '
        'rb_SeedClass
        '
        Me.rb_SeedClass.AddFunction = Nothing
        Me.rb_SeedClass.ButtonControl = Nothing
        Me.rb_SeedClass.Class = Nothing
        Me.rb_SeedClass.DataControl = Nothing
        Me.rb_SeedClass.FieldControl = Nothing
        Me.rb_SeedClass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_SeedClass.Location = New System.Drawing.Point(387, 142)
        Me.rb_SeedClass.Name = "rb_SeedClass"
        Me.rb_SeedClass.SaveFunction = Nothing
        Me.rb_SeedClass.Size = New System.Drawing.Size(240, 68)
        Me.rb_SeedClass.TabIndex = 259
        Me.rb_SeedClass.Tag = "7"
        Me.rb_SeedClass.Text = "Seed Class"
        Me.rb_SeedClass.UpdateID = Nothing
        Me.rb_SeedClass.UserControl = Nothing
        '
        'rb_YieldEstimateMasterData
        '
        Me.rb_YieldEstimateMasterData.AddFunction = Nothing
        Me.rb_YieldEstimateMasterData.ButtonControl = Nothing
        Me.rb_YieldEstimateMasterData.Class = Nothing
        Me.rb_YieldEstimateMasterData.DataControl = Nothing
        Me.rb_YieldEstimateMasterData.FieldControl = Nothing
        Me.rb_YieldEstimateMasterData.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_YieldEstimateMasterData.Location = New System.Drawing.Point(106, 140)
        Me.rb_YieldEstimateMasterData.Name = "rb_YieldEstimateMasterData"
        Me.rb_YieldEstimateMasterData.SaveFunction = Nothing
        Me.rb_YieldEstimateMasterData.Size = New System.Drawing.Size(240, 68)
        Me.rb_YieldEstimateMasterData.TabIndex = 258
        Me.rb_YieldEstimateMasterData.Tag = "2"
        Me.rb_YieldEstimateMasterData.Text = "Yield Estimate Master Data"
        Me.rb_YieldEstimateMasterData.UpdateID = Nothing
        Me.rb_YieldEstimateMasterData.UserControl = Nothing
        '
        'rb_FieldFormula
        '
        Me.rb_FieldFormula.AddFunction = Nothing
        Me.rb_FieldFormula.ButtonControl = Nothing
        Me.rb_FieldFormula.Class = Nothing
        Me.rb_FieldFormula.DataControl = Nothing
        Me.rb_FieldFormula.FieldControl = Nothing
        Me.rb_FieldFormula.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_FieldFormula.Location = New System.Drawing.Point(387, 220)
        Me.rb_FieldFormula.Name = "rb_FieldFormula"
        Me.rb_FieldFormula.SaveFunction = Nothing
        Me.rb_FieldFormula.Size = New System.Drawing.Size(240, 68)
        Me.rb_FieldFormula.TabIndex = 259
        Me.rb_FieldFormula.Tag = "8"
        Me.rb_FieldFormula.Text = "Field Formula"
        Me.rb_FieldFormula.UpdateID = Nothing
        Me.rb_FieldFormula.UserControl = Nothing
        '
        'rb_SeedProductionDeliveryList
        '
        Me.rb_SeedProductionDeliveryList.AddFunction = Nothing
        Me.rb_SeedProductionDeliveryList.ButtonControl = Nothing
        Me.rb_SeedProductionDeliveryList.Class = Nothing
        Me.rb_SeedProductionDeliveryList.DataControl = Nothing
        Me.rb_SeedProductionDeliveryList.FieldControl = Nothing
        Me.rb_SeedProductionDeliveryList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_SeedProductionDeliveryList.Location = New System.Drawing.Point(106, 220)
        Me.rb_SeedProductionDeliveryList.Name = "rb_SeedProductionDeliveryList"
        Me.rb_SeedProductionDeliveryList.SaveFunction = Nothing
        Me.rb_SeedProductionDeliveryList.Size = New System.Drawing.Size(240, 68)
        Me.rb_SeedProductionDeliveryList.TabIndex = 259
        Me.rb_SeedProductionDeliveryList.Tag = "4"
        Me.rb_SeedProductionDeliveryList.Text = "Seed Production Delivery List"
        Me.rb_SeedProductionDeliveryList.UpdateID = Nothing
        Me.rb_SeedProductionDeliveryList.UserControl = Nothing
        '
        'rb_ProductionArea
        '
        Me.rb_ProductionArea.AddFunction = Nothing
        Me.rb_ProductionArea.ButtonControl = Nothing
        Me.rb_ProductionArea.Class = Nothing
        Me.rb_ProductionArea.DataControl = Nothing
        Me.rb_ProductionArea.FieldControl = Nothing
        Me.rb_ProductionArea.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ProductionArea.Location = New System.Drawing.Point(106, 298)
        Me.rb_ProductionArea.Name = "rb_ProductionArea"
        Me.rb_ProductionArea.SaveFunction = Nothing
        Me.rb_ProductionArea.Size = New System.Drawing.Size(240, 68)
        Me.rb_ProductionArea.TabIndex = 259
        Me.rb_ProductionArea.Tag = "5"
        Me.rb_ProductionArea.Text = "Production Area"
        Me.rb_ProductionArea.UpdateID = Nothing
        Me.rb_ProductionArea.UserControl = Nothing
        '
        'rb_ReferenceGeneration
        '
        Me.rb_ReferenceGeneration.AddFunction = Nothing
        Me.rb_ReferenceGeneration.ButtonControl = Nothing
        Me.rb_ReferenceGeneration.Class = Nothing
        Me.rb_ReferenceGeneration.DataControl = Nothing
        Me.rb_ReferenceGeneration.FieldControl = Nothing
        Me.rb_ReferenceGeneration.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_ReferenceGeneration.Location = New System.Drawing.Point(387, 298)
        Me.rb_ReferenceGeneration.Name = "rb_ReferenceGeneration"
        Me.rb_ReferenceGeneration.SaveFunction = Nothing
        Me.rb_ReferenceGeneration.Size = New System.Drawing.Size(240, 68)
        Me.rb_ReferenceGeneration.TabIndex = 259
        Me.rb_ReferenceGeneration.Tag = "9"
        Me.rb_ReferenceGeneration.Text = "Reference Generation"
        Me.rb_ReferenceGeneration.UpdateID = Nothing
        Me.rb_ReferenceGeneration.UserControl = Nothing
        '
        'rb_UserAccounts
        '
        Me.rb_UserAccounts.AddFunction = Nothing
        Me.rb_UserAccounts.ButtonControl = Nothing
        Me.rb_UserAccounts.Class = Nothing
        Me.rb_UserAccounts.DataControl = Nothing
        Me.rb_UserAccounts.FieldControl = Nothing
        Me.rb_UserAccounts.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_UserAccounts.Location = New System.Drawing.Point(246, 384)
        Me.rb_UserAccounts.Name = "rb_UserAccounts"
        Me.rb_UserAccounts.SaveFunction = Nothing
        Me.rb_UserAccounts.Size = New System.Drawing.Size(240, 68)
        Me.rb_UserAccounts.TabIndex = 259
        Me.rb_UserAccounts.Tag = "10"
        Me.rb_UserAccounts.Text = "User Accounts"
        Me.rb_UserAccounts.UpdateID = Nothing
        Me.rb_UserAccounts.UserControl = Nothing
        '
        'MainSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 473)
        Me.Controls.Add(Me.rb_UserAccounts)
        Me.Controls.Add(Me.rb_ReferenceGeneration)
        Me.Controls.Add(Me.rb_ProductionArea)
        Me.Controls.Add(Me.rb_SeedProductionDeliveryList)
        Me.Controls.Add(Me.rb_FieldFormula)
        Me.Controls.Add(Me.rb_YieldEstimateMasterData)
        Me.Controls.Add(Me.rb_SeedClass)
        Me.Controls.Add(Me.rb_Crop)
        Me.Controls.Add(Me.rb_SeedProductionList)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainSelection"
        Me.Panel1.ResumeLayout(False)
        CType(Me.rb_SeedProductionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Crop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_SeedClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_YieldEstimateMasterData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_FieldFormula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_SeedProductionDeliveryList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_ProductionArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_ReferenceGeneration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_UserAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rb_SeedProductionList As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Crop As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_SeedClass As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_YieldEstimateMasterData As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_FieldFormula As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_SeedProductionDeliveryList As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_ProductionArea As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_ReferenceGeneration As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_UserAccounts As ETSSUtility.BLL.Radbutton
End Class
