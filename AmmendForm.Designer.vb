<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmmendForm
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
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAmmend = New System.Windows.Forms.Button()
        Me.comboParkingType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboSpot = New System.Windows.Forms.ComboBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumberPlate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerPhone.Location = New System.Drawing.Point(264, 291)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(115, 14)
        Me.lblCustomerPhone.TabIndex = 55
        Me.lblCustomerPhone.Text = "Customer Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(436, 288)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtPhone.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(309, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 25)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Edit booking"
        '
        'btnAmmend
        '
        Me.btnAmmend.Location = New System.Drawing.Point(368, 388)
        Me.btnAmmend.Name = "btnAmmend"
        Me.btnAmmend.Size = New System.Drawing.Size(75, 23)
        Me.btnAmmend.TabIndex = 53
        Me.btnAmmend.Text = "Ammend"
        Me.btnAmmend.UseVisualStyleBackColor = True
        '
        'comboParkingType
        '
        Me.comboParkingType.FormattingEnabled = True
        Me.comboParkingType.Items.AddRange(New Object() {"Reserved", "Quick"})
        Me.comboParkingType.Location = New System.Drawing.Point(436, 181)
        Me.comboParkingType.Name = "comboParkingType"
        Me.comboParkingType.Size = New System.Drawing.Size(100, 23)
        Me.comboParkingType.TabIndex = 52
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(264, 184)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(94, 14)
        Me.lblType.TabIndex = 51
        Me.lblType.Text = "Parking Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(264, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 14)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Number Plate"
        '
        'comboSpot
        '
        Me.comboSpot.FormattingEnabled = True
        Me.comboSpot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboSpot.Location = New System.Drawing.Point(436, 136)
        Me.comboSpot.Name = "comboSpot"
        Me.comboSpot.Size = New System.Drawing.Size(100, 23)
        Me.comboSpot.TabIndex = 50
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(264, 235)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(112, 14)
        Me.lblCustomerName.TabIndex = 44
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(436, 336)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 23)
        Me.txtFee.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(264, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Parking Spot"
        '
        'txtNumberPlate
        '
        Me.txtNumberPlate.Location = New System.Drawing.Point(436, 96)
        Me.txtNumberPlate.Name = "txtNumberPlate"
        Me.txtNumberPlate.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberPlate.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(264, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Fee"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(436, 232)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(100, 23)
        Me.txtOwner.TabIndex = 47
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCustomerPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAmmend)
        Me.Controls.Add(Me.comboParkingType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboSpot)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumberPlate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOwner)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAmmend As Button
    Friend WithEvents comboParkingType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboSpot As ComboBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumberPlate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOwner As TextBox
End Class
