Imports MySql.Data.MySqlClient

Public Class HomeForm
    Private Const v As Integer = 1
    Dim isFilled = False

    Dim currentBooking = 0
    Dim bookingsCount As Integer
    Dim query1 = "select occupied, SlotNumber from parkingSlot"
    Dim da1 As New MySqlDataAdapter(query1, SignInForm.conn)
    Dim ds1 As New DataSet

    Dim query2 = "select * from bookings"
    Dim da2 As New MySqlDataAdapter(query2, SignInForm.conn)
    Dim ds2 As New DataSet


    Public Sub Checkout(btn)
        Dim val
        If btn = 1 Then
            val = txtParkSpot.Text
        Else
            val = txtParkingSpotView.Text
        End If
        Try
            SignInForm.conn.Open()
            Dim query4 = "UPDATE parkingSlot SET occupied=false WHERE slotNumber='" & val & "';"
            Dim cmd4 = New MySqlCommand(query4, SignInForm.conn)
            cmd4.ExecuteNonQuery()


            Dim bookingId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query5 = "UPDATE bookings set Paid=true where ParkingSLot=" & val & ""
            Dim cmd5 = New MySqlCommand(query5, SignInForm.conn)
            cmd5.ExecuteNonQuery()


            MessageBox.Show("The vehicle has been checked out, slot" & val & " is now available")
            Me.Close()
            Dim home = New HomeForm
            home.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SignInForm.conn.Close()

    End Sub
    Public Sub Search()

        Dim query3 = "select * from bookings where NumberPlate='" & txtSearch.Text & "';"
        Dim da3 As New MySqlDataAdapter(query3, SignInForm.conn)
        Dim ds3 As New DataSet
        Try
            SignInForm.conn.Open()
            da3.Fill(ds3)
            If (ds3.Tables(0).Rows.Count > 0) Then
                txtCustomerName.Text = ds3.Tables(0).Rows(0).Item(6)
                txtCustomerPhone.Text = ds3.Tables(0).Rows(0).Item(7)
                txtDate.Text = ds3.Tables(0).Rows(0).Item(4)
                txtFee.Text = ds3.Tables(0).Rows(0).Item(3)
                txtNumberPlate.Text = ds3.Tables(0).Rows(0).Item(5)
                txtParkSpot.Text = ds3.Tables(0).Rows(0).Item(2)
                txtParkingType.Text = ds3.Tables(0).Rows(0).Item(1)

                btnCheckout.Enabled = True
            Else
                MessageBox.Show("Record not found!")
            End If
            SignInForm.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            SignInForm.conn.Close()
        End Try

    End Sub
    Public Sub Delete()
        Try
            SignInForm.conn.Open()
            Dim slot = ds2.Tables(0).Rows(currentBooking).Item(2)
            Dim delQuery = "DELETE  from bookings where ParkingSLot=" & slot & ""
            Dim delCmd = New MySqlCommand(delQuery, SignInForm.conn)
            delCmd.ExecuteNonQuery()

            Dim freeQuery = "UPDATE  parkingSlot set occupied=false where SlotNumber='" & slot & "'"
            Dim freeCmd = New MySqlCommand(freeQuery, SignInForm.conn)
            freeCmd.ExecuteNonQuery()
            MessageBox.Show("Booking deleted!")
            Me.Close()

            Dim home = New HomeForm
            home.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        SignInForm.conn.Close()

    End Sub
    Function isOccpiedColor(Val)
        Dim finalColor
        If Val = True Then finalColor = Color.FromArgb(185, 22, 70) Else finalColor = Color.FromArgb(16, 86, 82)
        Return finalColor
    End Function

    Public Sub GetBookings()
        If Not isFilled Then
            da2.Fill(ds2)
        End If
        bookingsCount = ds2.Tables(0).Rows.Count
        txtCustomerView.Text = ds2.Tables(0).Rows(currentBooking).Item(6)
        txtNumberPlateView.Text = ds2.Tables(0).Rows(currentBooking).Item(5)
        txtParkingSpotView.Text = ds2.Tables(0).Rows(currentBooking).Item(2)

    End Sub
    Public Sub GetSLots()
        Try

            da1.Fill(ds1)
            btnSlot1.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(0).Item(0))
            btnSlot2.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(1).Item(0))
            btnSLot3.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(2).Item(0))
            btnSlot4.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(3).Item(0))
            btnSlot5.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(4).Item(0))
            btnSlot6.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(5).Item(0))
            btnSlot7.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(6).Item(0))
            btnSlot8.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(7).Item(0))
            btnSlot9.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(8).Item(0))
            btnSLot10.ForeColor = isOccpiedColor(ds1.Tables(0).Rows(9).Item(0))

            SignInForm.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SignInForm.conn.Close()
        End Try

    End Sub


    Private Sub ParkingSlotsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabParkingSlots_Click(sender As Object, e As EventArgs) Handles tabParkingSlots.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add = New AddBookingForm
        Me.Close()
        add.Show()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim display = New DisplayForm
        display.Tag = ds2.Tables(0).Rows(currentBooking).Item(2)
        display.Show()

    End Sub

    Private Sub btnAmmend_Click(sender As Object, e As EventArgs) Handles btnAmmend.Click
        Dim ammend = New AmmendForm
        ammend.Tag = ds2.Tables(0).Rows(currentBooking).Item(2)
        ammend.Show()

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSLots()

        GetBookings()
        isFilled = True

    End Sub

    Private Sub btnSlot1_Click(sender As Object, e As EventArgs) Handles btnSlot1.Click
        If ds1.Tables(0).Rows(0).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(0).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot2_Click(sender As Object, e As EventArgs) Handles btnSlot2.Click
        If ds1.Tables(0).Rows(1).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(1).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot3_Click(sender As Object, e As EventArgs) Handles btnSLot3.Click
        If ds1.Tables(0).Rows(2).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(2).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot4_Click(sender As Object, e As EventArgs) Handles btnSlot4.Click
        If ds1.Tables(0).Rows(3).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(3).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot5_Click(sender As Object, e As EventArgs) Handles btnSlot5.Click
        If ds1.Tables(0).Rows(4).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(4).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot6_Click(sender As Object, e As EventArgs) Handles btnSlot6.Click
        If ds1.Tables(0).Rows(5).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(5).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot7_Click(sender As Object, e As EventArgs) Handles btnSlot7.Click
        If ds1.Tables(0).Rows(6).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(6).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot8_Click(sender As Object, e As EventArgs) Handles btnSlot8.Click
        If ds1.Tables(0).Rows(7).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(7).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot9_Click(sender As Object, e As EventArgs) Handles btnSlot9.Click
        If ds1.Tables(0).Rows(8).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(8).Item(1)
            display.Show()
        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub
    Private Sub btnSlot10_Click(sender As Object, e As EventArgs) Handles btnSLot10.Click
        If ds1.Tables(0).Rows(9).Item(0) Then
            MessageBox.Show("Parking slot occupied")
            Dim display = New DisplayForm
            display.Tag = ds1.Tables(0).Rows(9).Item(1)
            display.Show()

        Else
            Dim add = New AddBookingForm
            Me.Close()
            add.Show()

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If (currentBooking + v) = bookingsCount Then
            MessageBox.Show("That is the last booking!")
        Else
            currentBooking += v
            GetBookings()


        End If

    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentBooking > 0 Then
            currentBooking -= v
            GetBookings()

        Else
            MessageBox.Show("That is the first booking!")
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        currentBooking = 0
        GetBookings()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        currentBooking = ds2.Tables(0).Rows.Count - 1
        GetBookings()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Checkout(1)
    End Sub

    Private Sub btnCheckoutForm_Click(sender As Object, e As EventArgs) Handles btnCheckoutForm.Click
        Checkout(0)
    End Sub

End Class