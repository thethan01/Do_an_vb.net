Public Class SV
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub SV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.XemDiem' table. You can move, or remove it, as needed.
        Me.XemDiemTableAdapter.Fill(Me.DataSet2.XemDiem)

    End Sub
End Class