Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub
    Private _connectionString As String = ConfigurationSettings.AppSettings("MyconnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter
    Private Function getdata(sqlQuerry As String) As DataTable
        Dim dTable As New DataTable
        conn = New SqlConnection(_connectionString)
        da = New SqlDataAdapter(sqlQuerry, conn)
        Try
            conn.Open()

            da.Fill(dTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            conn.Close()
        End Try
        Return dTable
    End Function

    Private Function check(user As String, pass As String)
        Dim sqlQuery As String = String.Format("select * from dbo.admin where username='{0}' and password ='{1}' ", user, pass)
        Dim dTable As DataTable = getdata(sqlQuery)
        Return dTable.Rows.Count > 0

    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(Me.acc.Text) OrElse String.IsNullOrEmpty(Me.pass.Text)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsEmpty() Then
            MessageBox.Show("Tài khảon, mật khẩu không được chống")
        Else
            If check(Me.acc.Text.ToLower, Me.pass.Text.ToLower) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("Đăng nhập thành công")
                Admin.Show()
                Me.Close()
            Else
                MessageBox.Show("Sai Tài khoản hoặc mật khẩu")
            End If
        End If
    End Sub
End Class