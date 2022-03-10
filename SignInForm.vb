Imports MySql.Data.MySqlClient
Public Class SignInForm
    Public Shared Property conn As New MySqlConnection(connectionString:="server=localhost;user id=root;password=beatsbydre;database=atmdb")

    Public Shared Property username As String

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If Not conn Is Nothing Then conn.Close()

        Try
            conn.Open()
            Dim query = "SELECT * FROM users WHERE username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "';"
            Dim cmd = New MySqlCommand(query, conn)
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim result As DataTable = New DataTable()
            adapter.Fill(result)

            Dim count As Integer
            count = result.Rows.Count
            If count = 0 Then
                MessageBox.Show("Wrong Id number or Pin code!")
            Else
                username = txtUsername.Text
                Me.Visible = False
                Dim home As New HomeForm
                home.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub
End Class