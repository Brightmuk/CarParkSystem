<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicleForm
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
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'datePicker
        '
        Me.datePicker.CustomFormat = "dd/ MM/yyyy"
        Me.datePicker.Location = New System.Drawing.Point(259, 289)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(100, 23)
        Me.datePicker.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(87, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Date"
        '
        'comboParkingType
        '
        Me.comboParkingType.FormattingEnabled = True
        Me.comboParkingType.Items.AddRange(New Object() {"Reserved", "Quick"})
        Me.comboParkingType.Location = New System.Drawing.Point(259, 191)
        Me.comboParkingType.Name = "comboParkingType"
        Me.comboParkingType.Size = New System.Drawing.Size(100, 23)
        Me.comboParkingType.TabIndex = 36
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(87, 194)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(94, 14)
        Me.lblType.TabIndex = 35
        Me.lblType.Text = "Parking Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(87, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Number Plate"
        '
        'comboSpot
        '
        Me.comboSpot.FormattingEnabled = True
        Me.comboSpot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.comboSpot.Location = New System.Drawing.Point(259, 146)
        Me.comboSpot.Name = "comboSpot"
        Me.comboSpot.Size = New System.Drawing.Size(100, 23)
        Me.comboSpot.TabIndex = 34
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(454, 112)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(112, 14)
        Me.lblCustomerName.TabIndex = 28
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(259, 244)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 23)
        Me.txtFee.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(87, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Parking Spot"
        '
        'txtNumberPlate
        '
        Me.txtNumberPlate.Location = New System.Drawing.Point(259, 106)
        Me.txtNumberPlate.Name = "txtNumberPlate"
        Me.txtNumberPlate.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberPlate.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(87, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fee"
        '
        'txtOwner
        '
        Me.txtOwner.Location = New System.Drawing.Point(626, 109)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(100, 23)
        Me.txtOwner.TabIndex = 31
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(348, 383)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(289, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Add car to parking"
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerPhone.Location = New System.Drawing.Point(454, 168)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(115, 14)
        Me.lblCustomerPhone.TabIndex = 41
        Me.lblCustomerPhone.Text = "Customer Phone"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(626, 165)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 42
        '
        'AddVehicleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCustomerPhone)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "AddVehicleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents Label5 As Label
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents TextBox1 As TextBox
End Class
