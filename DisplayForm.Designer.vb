<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayForm
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumberPlate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtParkingType = New System.Windows.Forms.TextBox()
        Me.txtParkingSpot = New System.Windows.Forms.TextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(228, 234)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerName.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(56, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fee"
        '
        'txtNumberPlate
        '
        Me.txtNumberPlate.BackColor = System.Drawing.Color.White
        Me.txtNumberPlate.Enabled = False
        Me.txtNumberPlate.Location = New System.Drawing.Point(228, 65)
        Me.txtNumberPlate.Name = "txtNumberPlate"
        Me.txtNumberPlate.ReadOnly = True
        Me.txtNumberPlate.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberPlate.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(56, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Parking Spot"
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFee.Enabled = False
        Me.txtFee.Location = New System.Drawing.Point(228, 333)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(100, 23)
        Me.txtFee.TabIndex = 21
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(56, 237)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(108, 14)
        Me.lblCustomerName.TabIndex = 16
        Me.lblCustomerName.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(56, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Number Plate"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(56, 180)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(87, 14)
        Me.lblType.TabIndex = 23
        Me.lblType.Text = "Parking Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(56, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Date"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(167, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 25)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "Display"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCustomerPhone.Enabled = False
        Me.txtCustomerPhone.Location = New System.Drawing.Point(228, 287)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.ReadOnly = True
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerPhone.TabIndex = 29
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerPhone.Location = New System.Drawing.Point(56, 290)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(112, 14)
        Me.lblCustomerPhone.TabIndex = 28
        Me.lblCustomerPhone.Text = "Customer Phone"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtParkingType)
        Me.Panel2.Controls.Add(Me.txtParkingSpot)
        Me.Panel2.Controls.Add(Me.lblCustomerPhone)
        Me.Panel2.Controls.Add(Me.txtCustomerPhone)
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblCustomerName)
        Me.Panel2.Controls.Add(Me.txtFee)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNumberPlate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCustomerName)
        Me.Panel2.Location = New System.Drawing.Point(191, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 438)
        Me.Panel2.TabIndex = 22
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(228, 378)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 23)
        Me.txtDate.TabIndex = 32
        '
        'txtParkingType
        '
        Me.txtParkingType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtParkingType.Enabled = False
        Me.txtParkingType.Location = New System.Drawing.Point(228, 177)
        Me.txtParkingType.Name = "txtParkingType"
        Me.txtParkingType.ReadOnly = True
        Me.txtParkingType.Size = New System.Drawing.Size(100, 23)
        Me.txtParkingType.TabIndex = 31
        '
        'txtParkingSpot
        '
        Me.txtParkingSpot.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtParkingSpot.Enabled = False
        Me.txtParkingSpot.Location = New System.Drawing.Point(228, 121)
        Me.txtParkingSpot.Name = "txtParkingSpot"
        Me.txtParkingSpot.ReadOnly = True
        Me.txtParkingSpot.Size = New System.Drawing.Size(100, 23)
        Me.txtParkingSpot.TabIndex = 30
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Black
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(687, 387)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(88, 51)
        Me.btnCheckout.TabIndex = 23
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'DisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "DisplayForm"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumberPlate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtParkingType As TextBox
    Friend WithEvents txtParkingSpot As TextBox
    Friend WithEvents btnCheckout As Button
End Class
