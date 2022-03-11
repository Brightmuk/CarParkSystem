<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookingForm
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
        Me.comboParkingType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboSpot = New System.Windows.Forms.ComboBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumberPlate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.lblCarColor = New System.Windows.Forms.Label()
        Me.txtCarColor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'comboParkingType
        '
        Me.comboParkingType.FormattingEnabled = True
        Me.comboParkingType.Items.AddRange(New Object() {"Reserved", "Quick"})
        Me.comboParkingType.Location = New System.Drawing.Point(644, 107)
        Me.comboParkingType.Name = "comboParkingType"
        Me.comboParkingType.Size = New System.Drawing.Size(100, 23)
        Me.comboParkingType.TabIndex = 36
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(472, 110)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(94, 14)
        Me.lblType.TabIndex = 35
        Me.lblType.Text = "Parking Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(92, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Number Plate"
        '
        'comboSpot
        '
        Me.comboSpot.FormattingEnabled = True
        Me.comboSpot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboSpot.Location = New System.Drawing.Point(644, 159)
        Me.comboSpot.Name = "comboSpot"
        Me.comboSpot.Size = New System.Drawing.Size(100, 23)
        Me.comboSpot.TabIndex = 34
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(92, 209)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(112, 14)
        Me.lblCustomerName.TabIndex = 28
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(644, 209)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 23)
        Me.txtFee.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(472, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Parking Spot"
        '
        'txtNumberPlate
        '
        Me.txtNumberPlate.Location = New System.Drawing.Point(264, 113)
        Me.txtNumberPlate.Name = "txtNumberPlate"
        Me.txtNumberPlate.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberPlate.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(472, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fee"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(264, 206)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerName.TabIndex = 31
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(357, 388)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(289, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "New Booking"
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerPhone.Location = New System.Drawing.Point(92, 265)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(115, 14)
        Me.lblCustomerPhone.TabIndex = 41
        Me.lblCustomerPhone.Text = "Customer Phone"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(264, 262)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerPhone.TabIndex = 42
        '
        'lblCarColor
        '
        Me.lblCarColor.AutoSize = True
        Me.lblCarColor.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarColor.Location = New System.Drawing.Point(92, 159)
        Me.lblCarColor.Name = "lblCarColor"
        Me.lblCarColor.Size = New System.Drawing.Size(94, 14)
        Me.lblCarColor.TabIndex = 43
        Me.lblCarColor.Text = "Vehicle Color"
        '
        'txtCarColor
        '
        Me.txtCarColor.Location = New System.Drawing.Point(264, 156)
        Me.txtCarColor.Name = "txtCarColor"
        Me.txtCarColor.Size = New System.Drawing.Size(100, 23)
        Me.txtCarColor.TabIndex = 44
        '
        'AddBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCarColor)
        Me.Controls.Add(Me.txtCarColor)
        Me.Controls.Add(Me.lblCustomerPhone)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.comboParkingType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboSpot)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumberPlate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Name = "AddBookingForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboParkingType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboSpot As ComboBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumberPlate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents lblCarColor As Label
    Friend WithEvents txtCarColor As TextBox
End Class
