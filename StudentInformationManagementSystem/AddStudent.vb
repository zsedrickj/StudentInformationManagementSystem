Public Class AddStudent
    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        Dim Dashboard As New Form1()
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class