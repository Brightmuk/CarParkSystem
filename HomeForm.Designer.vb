<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtParkingType = New System.Windows.Forms.TextBox()
        Me.txtParkSpot = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumberPlate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabParkingSlots = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtParkingSpotView = New System.Windows.Forms.TextBox()
        Me.btnCheckoutForm = New System.Windows.Forms.Button()
        Me.lblTitleOne = New System.Windows.Forms.Label()
        Me.txtCustomerView = New System.Windows.Forms.TextBox()
        Me.txtNumberPlateView = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblParkingSpot = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnAmmend = New System.Windows.Forms.Button()
        Me.lblNumberPlate = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSlot7 = New System.Windows.Forms.Button()
        Me.btnSlot8 = New System.Windows.Forms.Button()
        Me.btnSlot9 = New System.Windows.Forms.Button()
        Me.btnSLot10 = New System.Windows.Forms.Button()
        Me.btnSlot6 = New System.Windows.Forms.Button()
        Me.btnSlot2 = New System.Windows.Forms.Button()
        Me.btnSLot3 = New System.Windows.Forms.Button()
        Me.btnSlot4 = New System.Windows.Forms.Button()
        Me.btnSlot5 = New System.Windows.Forms.Button()
        Me.btnSlot1 = New System.Windows.Forms.Button()
        Me.tbCtrlHome = New System.Windows.Forms.TabControl()
        Me.btnBackPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabParkingSlots.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tbCtrlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.Panel2)
        Me.tabSearch.Controls.Add(Me.btnInit)
        Me.tabSearch.Controls.Add(Me.Label7)
        Me.tabSearch.Controls.Add(Me.TextBox6)
        Me.tabSearch.Controls.Add(Me.Label6)
        Me.tabSearch.Location = New System.Drawing.Point(4, 24)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(864, 375)
        Me.tabSearch.TabIndex = 3
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtParkingType)
        Me.Panel2.Controls.Add(Me.txtParkSpot)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.btnCheckout)
        Me.Panel2.Controls.Add(Me.lblCustomerPhone)
        Me.Panel2.Controls.Add(Me.txtCustomerPhone)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblCustomerName)
        Me.Panel2.Controls.Add(Me.txtFee)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtNumberPlate)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtCustomerName)
        Me.Panel2.Location = New System.Drawing.Point(422, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 403)
        Me.Panel2.TabIndex = 44
        '
        'txtParkingType
        '
        Me.txtParkingType.Location = New System.Drawing.Point(239, 113)
        Me.txtParkingType.Name = "txtParkingType"
        Me.txtParkingType.Size = New System.Drawing.Size(100, 23)
        Me.txtParkingType.TabIndex = 48
        '
        'txtParkSpot
        '
        Me.txtParkSpot.Location = New System.Drawing.Point(239, 64)
        Me.txtParkSpot.Name = "txtParkSpot"
        Me.txtParkSpot.Size = New System.Drawing.Size(100, 23)
        Me.txtParkSpot.TabIndex = 47
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(239, 294)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 23)
        Me.txtDate.TabIndex = 46
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(357, 341)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 45
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerPhone.Location = New System.Drawing.Point(67, 202)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(115, 14)
        Me.lblCustomerPhone.TabIndex = 28
        Me.lblCustomerPhone.Text = "Customer Phone"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(239, 199)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerPhone.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(67, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Date"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(67, 116)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(94, 14)
        Me.lblType.TabIndex = 23
        Me.lblType.Text = "Parking Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(67, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 14)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Number Plate"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomerName.Location = New System.Drawing.Point(67, 161)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(112, 14)
        Me.lblCustomerName.TabIndex = 16
        Me.lblCustomerName.Text = "Customer Name"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(239, 248)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 23)
        Me.txtFee.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(72, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Parking Spot"
        '
        'txtNumberPlate
        '
        Me.txtNumberPlate.Location = New System.Drawing.Point(239, 18)
        Me.txtNumberPlate.Name = "txtNumberPlate"
        Me.txtNumberPlate.Size = New System.Drawing.Size(100, 23)
        Me.txtNumberPlate.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(67, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Fee"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(239, 158)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerName.TabIndex = 19
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(507, 348)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 10)
        Me.btnInit.TabIndex = 43
        Me.btnInit.Text = "Init"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(37, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Search"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(214, 194)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 23)
        Me.TextBox6.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(42, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 14)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Number Plate"
        '
        'tabParkingSlots
        '
        Me.tabParkingSlots.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabParkingSlots.Controls.Add(Me.Label5)
        Me.tabParkingSlots.Controls.Add(Me.txtParkingSpotView)
        Me.tabParkingSlots.Controls.Add(Me.btnCheckoutForm)
        Me.tabParkingSlots.Controls.Add(Me.lblTitleOne)
        Me.tabParkingSlots.Controls.Add(Me.txtCustomerView)
        Me.tabParkingSlots.Controls.Add(Me.txtNumberPlateView)
        Me.tabParkingSlots.Controls.Add(Me.btnLast)
        Me.tabParkingSlots.Controls.Add(Me.btnDisplay)
        Me.tabParkingSlots.Controls.Add(Me.btnNext)
        Me.tabParkingSlots.Controls.Add(Me.lblParkingSpot)
        Me.tabParkingSlots.Controls.Add(Me.btnPrevious)
        Me.tabParkingSlots.Controls.Add(Me.lblCustomer)
        Me.tabParkingSlots.Controls.Add(Me.btnAdd)
        Me.tabParkingSlots.Controls.Add(Me.btnDelete)
        Me.tabParkingSlots.Controls.Add(Me.btnFirst)
        Me.tabParkingSlots.Controls.Add(Me.btnAmmend)
        Me.tabParkingSlots.Controls.Add(Me.lblNumberPlate)
        Me.tabParkingSlots.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tabParkingSlots.Location = New System.Drawing.Point(4, 24)
        Me.tabParkingSlots.Name = "tabParkingSlots"
        Me.tabParkingSlots.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParkingSlots.Size = New System.Drawing.Size(864, 375)
        Me.tabParkingSlots.TabIndex = 1
        Me.tabParkingSlots.Text = "View"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(748, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Label5"
        '
        'txtParkingSpotView
        '
        Me.txtParkingSpotView.Enabled = False
        Me.txtParkingSpotView.Location = New System.Drawing.Point(496, 139)
        Me.txtParkingSpotView.Name = "txtParkingSpotView"
        Me.txtParkingSpotView.Size = New System.Drawing.Size(100, 22)
        Me.txtParkingSpotView.TabIndex = 76
        '
        'btnCheckoutForm
        '
        Me.btnCheckoutForm.Location = New System.Drawing.Point(748, 329)
        Me.btnCheckoutForm.Name = "btnCheckoutForm"
        Me.btnCheckoutForm.Size = New System.Drawing.Size(94, 23)
        Me.btnCheckoutForm.TabIndex = 75
        Me.btnCheckoutForm.Text = "Checkout"
        Me.btnCheckoutForm.UseVisualStyleBackColor = True
        '
        'lblTitleOne
        '
        Me.lblTitleOne.AutoSize = True
        Me.lblTitleOne.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitleOne.Location = New System.Drawing.Point(420, 18)
        Me.lblTitleOne.Name = "lblTitleOne"
        Me.lblTitleOne.Size = New System.Drawing.Size(98, 25)
        Me.lblTitleOne.TabIndex = 74
        Me.lblTitleOne.Text = "Actions"
        '
        'txtCustomerView
        '
        Me.txtCustomerView.Enabled = False
        Me.txtCustomerView.Location = New System.Drawing.Point(496, 186)
        Me.txtCustomerView.Name = "txtCustomerView"
        Me.txtCustomerView.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerView.TabIndex = 66
        '
        'txtNumberPlateView
        '
        Me.txtNumberPlateView.Enabled = False
        Me.txtNumberPlateView.Location = New System.Drawing.Point(496, 89)
        Me.txtNumberPlateView.Name = "txtNumberPlateView"
        Me.txtNumberPlateView.Size = New System.Drawing.Size(100, 22)
        Me.txtNumberPlateView.TabIndex = 67
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(534, 239)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(62, 23)
        Me.btnLast.TabIndex = 72
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(315, 329)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(79, 27)
        Me.btnDisplay.TabIndex = 73
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(462, 239)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(66, 23)
        Me.btnNext.TabIndex = 71
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblParkingSpot
        '
        Me.lblParkingSpot.AutoSize = True
        Me.lblParkingSpot.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblParkingSpot.Location = New System.Drawing.Point(324, 139)
        Me.lblParkingSpot.Name = "lblParkingSpot"
        Me.lblParkingSpot.Size = New System.Drawing.Size(92, 14)
        Me.lblParkingSpot.TabIndex = 65
        Me.lblParkingSpot.Text = "Parking Spot"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(381, 239)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 70
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCustomer.Location = New System.Drawing.Point(324, 189)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(70, 14)
        Me.lblCustomer.TabIndex = 64
        Me.lblCustomer.Text = "Customer"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 53)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Add "
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(512, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 27)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(315, 239)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 23)
        Me.btnFirst.TabIndex = 69
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnAmmend
        '
        Me.btnAmmend.Location = New System.Drawing.Point(410, 329)
        Me.btnAmmend.Name = "btnAmmend"
        Me.btnAmmend.Size = New System.Drawing.Size(87, 27)
        Me.btnAmmend.TabIndex = 62
        Me.btnAmmend.Text = "Ammend"
        Me.btnAmmend.UseVisualStyleBackColor = True
        '
        'lblNumberPlate
        '
        Me.lblNumberPlate.AutoSize = True
        Me.lblNumberPlate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNumberPlate.Location = New System.Drawing.Point(324, 92)
        Me.lblNumberPlate.Name = "lblNumberPlate"
        Me.lblNumberPlate.Size = New System.Drawing.Size(97, 14)
        Me.lblNumberPlate.TabIndex = 63
        Me.lblNumberPlate.Text = "Number Plate"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblTitle)
        Me.TabPage1.Controls.Add(Me.btnSlot7)
        Me.TabPage1.Controls.Add(Me.btnSlot8)
        Me.TabPage1.Controls.Add(Me.btnSlot9)
        Me.TabPage1.Controls.Add(Me.btnSLot10)
        Me.TabPage1.Controls.Add(Me.btnSlot6)
        Me.TabPage1.Controls.Add(Me.btnSlot2)
        Me.TabPage1.Controls.Add(Me.btnSLot3)
        Me.TabPage1.Controls.Add(Me.btnSlot4)
        Me.TabPage1.Controls.Add(Me.btnSlot5)
        Me.TabPage1.Controls.Add(Me.btnSlot1)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parking Slots"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lime
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(823, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = ".."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(823, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = ".."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(733, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Occupied"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(733, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Free"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(364, 78)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(164, 25)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Parking slots"
        '
        'btnSlot7
        '
        Me.btnSlot7.Location = New System.Drawing.Point(233, 271)
        Me.btnSlot7.Name = "btnSlot7"
        Me.btnSlot7.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot7.TabIndex = 20
        Me.btnSlot7.Text = "Slot 7"
        Me.btnSlot7.UseVisualStyleBackColor = True
        '
        'btnSlot8
        '
        Me.btnSlot8.Location = New System.Drawing.Point(385, 271)
        Me.btnSlot8.Name = "btnSlot8"
        Me.btnSlot8.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot8.TabIndex = 19
        Me.btnSlot8.Text = "Slot 8"
        Me.btnSlot8.UseVisualStyleBackColor = True
        '
        'btnSlot9
        '
        Me.btnSlot9.Location = New System.Drawing.Point(532, 271)
        Me.btnSlot9.Name = "btnSlot9"
        Me.btnSlot9.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot9.TabIndex = 18
        Me.btnSlot9.Text = "SLot 9"
        Me.btnSlot9.UseVisualStyleBackColor = True
        '
        'btnSLot10
        '
        Me.btnSLot10.Location = New System.Drawing.Point(673, 271)
        Me.btnSLot10.Name = "btnSLot10"
        Me.btnSLot10.Size = New System.Drawing.Size(112, 62)
        Me.btnSLot10.TabIndex = 17
        Me.btnSLot10.Text = "Slot 10"
        Me.btnSLot10.UseVisualStyleBackColor = True
        '
        'btnSlot6
        '
        Me.btnSlot6.Location = New System.Drawing.Point(79, 271)
        Me.btnSlot6.Name = "btnSlot6"
        Me.btnSlot6.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot6.TabIndex = 16
        Me.btnSlot6.Text = "Slot 6"
        Me.btnSlot6.UseVisualStyleBackColor = True
        '
        'btnSlot2
        '
        Me.btnSlot2.Location = New System.Drawing.Point(233, 134)
        Me.btnSlot2.Name = "btnSlot2"
        Me.btnSlot2.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot2.TabIndex = 15
        Me.btnSlot2.Text = "Slot 2"
        Me.btnSlot2.UseVisualStyleBackColor = True
        '
        'btnSLot3
        '
        Me.btnSLot3.Location = New System.Drawing.Point(385, 134)
        Me.btnSLot3.Name = "btnSLot3"
        Me.btnSLot3.Size = New System.Drawing.Size(112, 62)
        Me.btnSLot3.TabIndex = 14
        Me.btnSLot3.Text = "Slot 3"
        Me.btnSLot3.UseVisualStyleBackColor = True
        '
        'btnSlot4
        '
        Me.btnSlot4.Location = New System.Drawing.Point(532, 134)
        Me.btnSlot4.Name = "btnSlot4"
        Me.btnSlot4.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot4.TabIndex = 13
        Me.btnSlot4.Text = "Slot 4"
        Me.btnSlot4.UseVisualStyleBackColor = True
        '
        'btnSlot5
        '
        Me.btnSlot5.Location = New System.Drawing.Point(673, 134)
        Me.btnSlot5.Name = "btnSlot5"
        Me.btnSlot5.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot5.TabIndex = 12
        Me.btnSlot5.Text = "Slot 5"
        Me.btnSlot5.UseVisualStyleBackColor = True
        '
        'btnSlot1
        '
        Me.btnSlot1.Location = New System.Drawing.Point(79, 134)
        Me.btnSlot1.Name = "btnSlot1"
        Me.btnSlot1.Size = New System.Drawing.Size(112, 62)
        Me.btnSlot1.TabIndex = 11
        Me.btnSlot1.Text = "Slot 1"
        Me.btnSlot1.UseVisualStyleBackColor = True
        '
        'tbCtrlHome
        '
        Me.tbCtrlHome.Controls.Add(Me.TabPage1)
        Me.tbCtrlHome.Controls.Add(Me.tabParkingSlots)
        Me.tbCtrlHome.Controls.Add(Me.tabSearch)
        Me.tbCtrlHome.Location = New System.Drawing.Point(0, 0)
        Me.tbCtrlHome.Name = "tbCtrlHome"
        Me.tbCtrlHome.SelectedIndex = 0
        Me.tbCtrlHome.Size = New System.Drawing.Size(872, 403)
        Me.tbCtrlHome.TabIndex = 29
        '
        'btnBackPage
        '
        Me.btnBackPage.Location = New System.Drawing.Point(12, 409)
        Me.btnBackPage.Name = "btnBackPage"
        Me.btnBackPage.Size = New System.Drawing.Size(75, 23)
        Me.btnBackPage.TabIndex = 75
        Me.btnBackPage.Text = "Back"
        Me.btnBackPage.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.Location = New System.Drawing.Point(783, 415)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(75, 23)
        Me.btnNextPage.TabIndex = 76
        Me.btnNextPage.Text = "Next"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 450)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.btnBackPage)
        Me.Controls.Add(Me.tbCtrlHome)
        Me.Name = "HomeForm"
        Me.Text = "Form1"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        Me.tabSearch.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tabParkingSlots.ResumeLayout(False)
        Me.tabParkingSlots.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tbCtrlHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnBackPage As Button
    Friend WithEvents tbCtrlHome As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSlot7 As Button
    Friend WithEvents btnSlot8 As Button
    Friend WithEvents btnSlot9 As Button
    Friend WithEvents btnSLot10 As Button
    Friend WithEvents btnSlot6 As Button
    Friend WithEvents btnSlot2 As Button
    Friend WithEvents btnSLot3 As Button
    Friend WithEvents btnSlot4 As Button
    Friend WithEvents btnSlot5 As Button
    Friend WithEvents btnSlot1 As Button
    Friend WithEvents tabParkingSlots As TabPage
    Friend WithEvents lblTitleOne As Label
    Friend WithEvents txtCustomerView As TextBox
    Friend WithEvents txtNumberPlateView As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblParkingSpot As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblCustomer As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnAmmend As Button
    Friend WithEvents lblNumberPlate As Label
    Friend WithEvents tabSearch As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNumberPlate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents btnInit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCheckoutForm As Button
    Friend WithEvents txtParkingSpotView As TextBox
    Friend WithEvents txtParkingType As TextBox
    Friend WithEvents txtParkSpot As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
End Class
