Imports MySql.Data.MySqlClient

Public Class AmmendForm
    Public Sub Edit()
        Try
            SignInForm.conn.Open()
            Dim slot = Convert.ToInt32(Me.Tag.ToString)
            Dim query2 = "UPDATE  bookings set ParkingType='" & comboParkingType.Text & "', ParkingSLot=" & comboSpot.Text & ",Fee=" & txtFee.Text & ", CustomerName='" & txtOwner.Text & "', CustomerPhone='" & txtPhone.Text & "',at ammend NumberPlate='" & txtNumberPlate.Text & "' where parkingSLot='" & slot & "';"
            Dim cmd2 = New MySqlCommand(query2, SignInForm.conn)
            cmd2.ExecuteNonQuery()


            MessageBox.Show("Booking updated!")
            Me.Close()
            Dim home = New HomeForm
            home.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SignInForm.conn.Close()
    End Sub
    Private Sub btnAmmend_Click(sender As Object, e As EventArgs) Handles btnAmmend.Click
        Edit()

    End Sub

    Private Sub AmmendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignInForm.conn.Open()

        Dim slot = Convert.ToInt32(Me.Tag.ToString)
        Dim query1 = "select * from bookings where ParkingSLot= " & slot & ";"
        Dim da1 As New MySqlDataAdapter(query1, SignInForm.conn)
        Dim ds1 As New DataSet

        Try
            da1.Fill(ds1)
            txtOwner.Text = ds1.Tables(0).Rows(0).Item(6)
            txtPhone.Text = ds1.Tables(0).Rows(0).Item(7)
            txtFee.Text = ds1.Tables(0).Rows(0).Item(3)
            txtNumberPlate.Text = ds1.Tables(0).Rows(0).Item(5)
            comboSpot.Text = ds1.Tables(0).Rows(0).Item(2)
            comboParkingType.Text = ds1.Tables(0).Rows(0).Item(1)
            SignInForm.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            SignInForm.conn.Close()
        End Try
    End Sub
End Class