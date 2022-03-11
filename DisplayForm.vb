Imports MySql.Data.MySqlClient

Public Class DisplayForm
    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignInForm.conn.Open()

        Dim slot = Convert.ToInt32(Me.Tag.ToString)
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
End Class