Imports MySql.Data.MySqlClient

Public Class HomeForm
    Dim query1 = "select occupied, SlotNumber from parkingSlot"
    Dim da1 As New MySqlDataAdapter(query1, SignInForm.conn)
    Dim ds1 As New DataSet

    Dim query2 = "select * from bookings"
    Dim da2 As New MySqlDataAdapter(query2, SignInForm.conn)
    Dim ds2 As New DataSet

    Public Sub Delete()
        Try
            SignInForm.conn.Open()
            Dim query2 = "DELETE  from where ParkingSLot='" & currentBooking & "'"
            Dim cmd2 = New MySqlCommand(query2, SignInForm.conn)
            cmd2.ExecuteNonQuery()

            Dim query3 = "UPDATE  parkingSlot set occupied=false where SlotNumber='" & currentBooking & "'"
            Dim cmd3 = New MySqlCommand(query2, SignInForm.conn)
            cmd3.ExecuteNonQuery()
            MessageBox.Show("Booking deleted!")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        SignInForm.conn.Close()

    End Sub
    Function isOccpiedColor(Val)
        Dim finalColor
        If Val = True Then finalColor = Color.Red Else finalColor = Color.Lime
        Return finalColor
    End Function
    Dim currentBooking = 0
    Public Sub GetBookings()
        da2.Fill(ds2)
        txtCustomerView.Text = ds2.Tables(0).Rows(currentBooking).Item(6)
        txtNumberPlateView.Text = ds2.Tables(0).Rows(currentBooking).Item(5)
        txtParkingSpotView.Text = ds2.Tables(0).Rows(currentBooking).Item(2)

    End Sub
    Public Sub GetSLots()
        Try

            da1.Fill(ds1)
            btnSlot1.BackColor = isOccpiedColor(ds1.Tables(0).Rows(0).Item(0))
            btnSlot2.BackColor = isOccpiedColor(ds1.Tables(0).Rows(1).Item(0))
            btnSLot3.BackColor = isOccpiedColor(ds1.Tables(0).Rows(2).Item(0))
            btnSlot4.BackColor = isOccpiedColor(ds1.Tables(0).Rows(3).Item(0))
            btnSlot5.BackColor = isOccpiedColor(ds1.Tables(0).Rows(4).Item(0))
            btnSlot6.BackColor = isOccpiedColor(ds1.Tables(0).Rows(5).Item(0))
            btnSlot7.BackColor = isOccpiedColor(ds1.Tables(0).Rows(6).Item(0))
            btnSlot8.BackColor = isOccpiedColor(ds1.Tables(0).Rows(7).Item(0))
            btnSlot9.BackColor = isOccpiedColor(ds1.Tables(0).Rows(8).Item(0))
            btnSLot10.BackColor = isOccpiedColor(ds1.Tables(0).Rows(9).Item(0))

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
        display.Tag = ds1.Tables(0).Rows(currentBooking).Item(1)
        display.Show()

    End Sub

    Private Sub btnAmmend_Click(sender As Object, e As EventArgs) Handles btnAmmend.Click
        Dim ammend = New AmmendForm
        ammend.Tag = ds1.Tables(0).Rows(currentBooking).Item(1)
        ammend.Show()

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSLots()
        GetBookings()


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
        If currentBooking = ds2.Tables(0).Rows.Count - 1 Then
            MessageBox.Show("That is the last booking!")
        Else
            currentBooking += 1
            GetBookings()
            Label5.Text = currentBooking

        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentBooking > 0 Then
            currentBooking -= 1
            Label5.Text = currentBooking
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
End Class