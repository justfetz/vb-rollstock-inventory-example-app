Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BQMESILBP132DataSet.RollstockTarget' table. You can move, or remove it, as needed.
        'Me.RollstockTargetTableAdapter.Fill(Me.BQMESILBP132DataSet.RollstockTarget)
        connectToDatabase()
        GetData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDeleteForm1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "DELETE RECORD", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("No problem")
        ElseIf result = DialogResult.Yes Then
            DeleteItem()
            GetData()
            'Me.Close()
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        disconnectFromDatabase()
        'Me.Close()
    End Sub

    Private Sub lstTargetID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTargetID.SelectedIndexChanged
        lstDate.SelectedIndex = lstTargetID.SelectedIndex
        lstWorkDays.SelectedIndex = lstTargetID.SelectedIndex
        lstTons.SelectedIndex = lstTargetID.SelectedIndex
    End Sub

    Private Sub lstTargetID_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstTargetID.MouseDoubleClick
        DetailForm.Show()
        GetDetailData()
    End Sub

    Private Sub btnAddForm1_Click(sender As Object, e As EventArgs) Handles btnAddForm1.Click
        AddForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditForm.Show()
        GetEditInformation()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub lstTargetID_MouseDown(sender As Object, e As MouseEventArgs) Handles lstTargetID.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "DELETE RECORD", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            MessageBox.Show("No problem")
        ElseIf result = DialogResult.Yes Then
            DeleteItem()
            GetData()
            'Me.Close()
        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles gridButton.Click
        GridForm.Show()
    End Sub
End Class
