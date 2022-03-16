Imports MySql.Data.MySqlClient

Public Class DisplayForm

    Public Sub Checkout()

        Try
            SignInForm.conn.Open()
            Dim query4 = "UPDATE parkingSlot SET occupied=false WHERE slotNumber='" & txtParkingSpot.Text & "';"
            Dim cmd4 = New MySqlCommand(query4, SignInForm.conn)
            cmd4.ExecuteNonQuery()


            Dim bookingId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query5 = "UPDATE bookings set Paid=true where ParkingSLot=" & txtParkingSpot.Text & ""
            Dim cmd5 = New MySqlCommand(query5, SignInForm.conn)
            cmd5.ExecuteNonQuery()


            MessageBox.Show("The vehicle has been checked out, slot" & txtNumberPlate.Text & " is now available")
            Me.Close()
            Dim home = New HomeForm
            home.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SignInForm.conn.Close()

    End Sub
    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignInForm.conn.Open()

        Dim slot = Me.Tag
        Dim query1 = "select * from bookings where ParkingSLot= " & slot & ";"
        Dim da1 As New MySqlDataAdapter(query1, SignInForm.conn)
        Dim ds1 As New DataSet

        Try
            da1.Fill(ds1)
            txtCustomerName.Text = ds1.Tables(0).Rows(0).Item(6)
            txtCustomerPhone.Text = ds1.Tables(0).Rows(0).Item(7)
            txtDate.Text = ds1.Tables(0).Rows(0).Item(4)
            txtFee.Text = ds1.Tables(0).Rows(0).Item(3)
            txtNumberPlate.Text = ds1.Tables(0).Rows(0).Item(5)
            txtParkingSpot.Text = ds1.Tables(0).Rows(0).Item(2)
            txtParkingType.Text = ds1.Tables(0).Rows(0).Item(1)
            SignInForm.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SignInForm.conn.Close()
        End Try
    End Sub

    Private Sub txtNumberPlate_TextChanged(sender As Object, e As EventArgs) Handles txtNumberPlate.TextChanged

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Checkout()

    End Sub
End Class