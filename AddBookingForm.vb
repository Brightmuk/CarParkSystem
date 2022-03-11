Imports MySql.Data.MySqlClient

Public Class AddBookingForm
    Public Sub newBooking()
        Try
            SignInForm.conn.Open()
            Dim query1 = "UPDATE parkingSlot SET occupied=true WHERE slotNumber='" & comboSpot.Text & "';"
            Dim cmd1 = New MySqlCommand(query1, SignInForm.conn)
            cmd1.ExecuteNonQuery()


            Dim bookingId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query2 = "INSERT INTO bookings(BookingId, ParkingType, ParkingSLot, Fee, CustomerName, CustomerPhone, NumberPlate, CarColor) VALUES ('" & bookingId & "','" & comboParkingType.Text & "', '" & comboSpot.Text & "','" & Convert.ToInt32(txtFee.Text) & "','" & txtCustomerName.Text & "','" & txtCustomerPhone.Text & "','" & txtNumberPlate.Text & "','" & txtCarColor.Text & "');"
            Dim cmd2 = New MySqlCommand(query2, SignInForm.conn)
            cmd2.ExecuteNonQuery()


            MessageBox.Show("New booking added!")
            Me.Close()
            Dim home = New HomeForm
            home.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SignInForm.conn.Close()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        newBooking()

    End Sub

    Private Sub AddVehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignInForm.conn.Open()
        Try
            Dim query = "select * from parkingSlot where occupied=false"
            Dim da As New MySqlDataAdapter(query, SignInForm.conn)
            Dim dt As New DataTable("TableName")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                comboSpot.DataSource = dt
                comboSpot.DisplayMember = "SlotNumber"
                comboSpot.ValueMember = ""
            End If
            SignInForm.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SignInForm.conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Leave(sender As Object, e As EventArgs) Handles btnUpdate.Leave

    End Sub

    Private Sub AddBookingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim home = New HomeForm
        home.Show()

    End Sub
End Class