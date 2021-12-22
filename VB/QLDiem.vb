Public Class QLDiem
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub QLDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Diem' table. You can move, or remove it, as needed.
        Me.DiemTableAdapter.Fill(Me.DataSet1.Diem)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Diem
                         (MaSV, MaMH, DiemChu, DiemT4,DiemT10)
VALUES        (N'" & txtMaSV.Text & "',N'" & txtMaMon.Text & "',N'" & txtDiemChu.Text & "',N'" & txtDiemT4.Text & "',N'" & txtDiemT10.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [Diem]
WHERE        [MaSV] = N'" & txtMaSV.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet1.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE       [Diem]
SET                [MaSV] = N'" & txtMaSV.Text & "', [MaMH] = N'" & txtMaMon.Text & "', [DiemChu] = N'" & txtDiemChu.Text & "', [DiemT4] = N'" & txtDiemT4.Text & "', [DiemT10] = N'" & txtDiemT10.Text & "'
WHERE        [MaSV] = N'" & txtMaSV.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet1.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Admin.Show()

    End Sub
End Class
