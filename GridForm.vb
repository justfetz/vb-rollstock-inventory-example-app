Public Class GridForm
    Private Sub C1Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RsData.RollstockForecast' table. You can move, or remove it, as needed.
        Me.RollstockForecastTableAdapter.Fill(Me.RsData.RollstockForecast)
        'TODO: This line of code loads data into the 'RsData.RollstockForecast' table. You can move, or remove it, as needed.
        Me.RollstockForecastTableAdapter.Fill(Me.RsData.RollstockForecast)
        'TODO: This line of code loads data into the 'RsData.RollstockForecast' table. You can move, or remove it, as needed.
        Me.RollstockForecastTableAdapter.Fill(Me.RsData.RollstockForecast)
        'TODO: This line of code loads data into the 'RsData.RollstockForecast' table. You can move, or remove it, as needed.
        Me.RollstockForecastTableAdapter.Fill(Me.RsData.RollstockForecast)
        'TODO: This line of code loads data into the 'RsData.RollstockForecast' table. You can move, or remove it, as needed.
        Me.RollstockForecastTableAdapter.Fill(Me.RsData.RollstockForecast)
        'TODO: This line of code loads data into the 'BQMESILBP132DataSet.RollstockTarget' table. You can move, or remove it, as needed.
        Me.RollstockTargetTableAdapter.Fill(Me.BQMESILBP132DataSet.RollstockTarget)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.RollstockForecastTableAdapter.FillBy(Me.RsData.RollstockForecast)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.RollstockForecastTableAdapter.FillBy(Me.RsData.RollstockForecast)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_2(sender As Object, e As EventArgs)
        Try
            Me.RollstockForecastTableAdapter.FillBy(Me.RsData.RollstockForecast)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub C1Button1_Click_1(sender As Object, e As EventArgs) Handles C1Button1.Click
        Me.Close()
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.RollstockForecastTableAdapter.FillBy1(Me.RsData.RollstockForecast)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_3(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.RollstockForecastTableAdapter.FillBy(Me.RsData.RollstockForecast)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class