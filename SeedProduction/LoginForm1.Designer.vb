<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etb_Password = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.etb_Login = New ETSSUtility.ETSSControls.ETextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_Cancel = New ETSSUtility.BLL.Radbutton()
        Me.rb_Save = New ETSSUtility.BLL.Radbutton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.etb_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etb_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 48)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etb_Password)
        Me.GroupBox1.Controls.Add(Me.etb_Login)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 84)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'etb_Password
        '
        Me.etb_Password.Location = New System.Drawing.Point(105, 45)
        Me.etb_Password.Name = "etb_Password"
        '
        '
        '
        Me.etb_Password.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Password.Size = New System.Drawing.Size(145, 20)
        Me.etb_Password.TabIndex = 321
        Me.etb_Password.TabStop = False
        Me.etb_Password.Text = "ETextBox7"
        Me.etb_Password.ValidateRequiredField = True
        '
        'etb_Login
        '
        Me.etb_Login.Location = New System.Drawing.Point(105, 19)
        Me.etb_Login.Name = "etb_Login"
        '
        '
        '
        Me.etb_Login.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.etb_Login.ShortcutsEnabled = False
        Me.etb_Login.Size = New System.Drawing.Size(145, 20)
        Me.etb_Login.TabIndex = 320
        Me.etb_Login.TabStop = False
        Me.etb_Login.Text = "ETextBox6"
        Me.etb_Login.ValidateRequiredField = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 319
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 23)
        Me.Label18.TabIndex = 318
        Me.Label18.Text = "Login:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_Cancel)
        Me.GroupBox2.Controls.Add(Me.rb_Save)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 66)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'rb_Cancel
        '
        Me.rb_Cancel.AddFunction = Nothing
        Me.rb_Cancel.ButtonControl = Nothing
        Me.rb_Cancel.Class = Nothing
        Me.rb_Cancel.DataControl = Nothing
        Me.rb_Cancel.FieldControl = Nothing
        Me.rb_Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Cancel.Image = CType(resources.GetObject("rb_Cancel.Image"), System.Drawing.Image)
        Me.rb_Cancel.Location = New System.Drawing.Point(154, 4)
        Me.rb_Cancel.Name = "rb_Cancel"
        Me.rb_Cancel.SaveFunction = Nothing
        Me.rb_Cancel.Size = New System.Drawing.Size(95, 51)
        Me.rb_Cancel.TabIndex = 255
        Me.rb_Cancel.Text = "    &Cancel"
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
        Me.rb_Save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Save.Image = CType(resources.GetObject("rb_Save.Image"), System.Drawing.Image)
        Me.rb_Save.Location = New System.Drawing.Point(40, 4)
        Me.rb_Save.Name = "rb_Save"
        Me.rb_Save.SaveFunction = Nothing
        Me.rb_Save.Size = New System.Drawing.Size(95, 51)
        Me.rb_Save.TabIndex = 254
        Me.rb_Save.Text = "    &Submit"
        Me.rb_Save.UpdateID = Nothing
        Me.rb_Save.UserControl = Nothing
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 203)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.etb_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etb_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.rb_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_Save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents etb_Password As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents etb_Login As ETSSUtility.ETSSControls.ETextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Cancel As ETSSUtility.BLL.Radbutton
    Friend WithEvents rb_Save As ETSSUtility.BLL.Radbutton

End Class
