Public Class AddForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddForecast()
        GetData()

        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class