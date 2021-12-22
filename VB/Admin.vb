Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QLSV.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        QLMon.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        QLDiem.Show()
        Me.Hide()
    End Sub
End Class