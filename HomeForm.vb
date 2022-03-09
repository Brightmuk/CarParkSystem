Imports MySql.Data.MySqlClient

Public Class HomeForm
    Dim conn As New MySqlConnection

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        Dim databaseName As String = "mysqlconnector"
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = "beatsbydre"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & databaseName & ""

        Try
            conn.Open()
            MessageBox.Show("Mysql connected!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addForm = New AddVehicleForm
        addForm.Show()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search = New SearchForm
        search.Show()


    End Sub
End Class