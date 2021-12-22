Public Class QLMon
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub QLMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.DMMH' table. You can move, or remove it, as needed.
        Me.DMMHTableAdapter.Fill(Me.DataSet11.DMMH)
        'TODO: This line of code loads data into the 'DataSet11.DMMH' table. You can move, or remove it, as needed.
        Me.DMMHTableAdapter.Fill(Me.DataSet11.DMMH)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO DMMH
                         (MaMH, TenMH,SoTiet)
VALUES        (N'" & txtMaMon.Text & "',N'" & txtTenMon.Text & "',N'" & txtSoTiet.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE       [DMMH]
SET                [MaMH] = N'" & txtMaMon.Text & "', [TenMH] = N'" & txtTenMon.Text & "', [SoTiet] = N'" & txtSoTiet.Text & "'
WHERE        [MaMH] = N'" & txtMaMon.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet11.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [DMMH]
WHERE        [MaMH] = N'" & txtMaMon.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet11.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class