Public Class EditForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateForecast()
        GetData()
        Me.Close()
    End Sub

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class