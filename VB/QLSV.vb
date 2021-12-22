Public Class QLSV
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub QLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.DMSV' table. You can move, or remove it, as needed.
        Me.DMSVTableAdapter.Fill(Me.DataSet11.DMSV)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gt As String = ""
        If rdNam.Checked = True Then
            gt = "Nam"
        Else
            rdNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO DMSV
                         (MaSV, HoTenSV, Phai, NgaySinh, NoiSinh, Lop)
VALUES        (N'" & txtMaSV.Text & "',N'" & txtTenSV.Text & "',N'" & gt & "',N'" & txtNgaySinh.Text & "',N'" & txtNoiSinh.Text & "',N'" & txtLop.Text & "')"
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
        Dim gt As String = ""
        If rdNam.Checked = True Then
            gt = "Nam"
        Else
            rdNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE       [DMSV]
SET                [MaSV] = N'" & txtMaSV.Text & "', [HoTenSV] = N'" & txtTenSV.Text & "', [Phai] = N'" & gt & "', [NgaySinh] = N'" & txtNgaySinh.Text & "', [NoiSinh] = N'" & txtNoiSinh.Text & "', [Lop] = N'" & txtLop.Text & "'
WHERE        [MaSV] = N'" & txtMaSV.Text & "'"
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
            Dim sql As String = "DELETE FROM [DMSV]
WHERE        [MaSV] = N'" & txtMaSV.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet11.Clear()
            loaddata()
            OleDbConnection1.Close()
            'loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class