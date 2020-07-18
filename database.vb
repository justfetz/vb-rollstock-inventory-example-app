Imports System.Data.SqlClient

Module database
    Dim connection As String
    Dim sqlCon As New SqlConnection

    Sub DeleteItem()
        Dim q As String = "DELETE FROM ROLLSTOCKFORECAST " &
            " WHERE FORECASTID = " & Form1.lstTargetID.SelectedItem.ToString()
        Try
            Dim objCmd As New SqlCommand(q, sqlCon)
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Sub GetEditInformation()
        Dim q As String = "SELECT  * FROM RollstockForecast R" &
     " JOIN RollstockTarget T on T.targetID = R.TargetID " &
     "where YEAR(ForecastDate) = 2020 and r.forecastid = " & Form1.lstTargetID.SelectedItem.ToString()

        Try
            Dim objCmd As New SqlCommand(q, sqlCon)

            Dim reader As SqlDataReader = objCmd.ExecuteReader

            reader.Read()

            EditForm.idTextDetail.Text = reader("TargetID")
            EditForm.monthTextDetail.Text = reader("ForecastDate")
            EditForm.TonsTextDetail.Text = reader("ForecastTons")
            EditForm.DaysTextDetail.Text = reader("WorkingDays")

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Sub UpdateForecast()
        Dim q As String = "UPDATE RollstockForecast SET " &
        "[TargetID] = '" & EditForm.idTextDetail.Text & "'
      , [ForecastDate] = '" & EditForm.monthTextDetail.Text & "'
      , [ForecastTons] = '" & EditForm.TonsTextDetail.Text & "'
      , [WorkingDays]  = '" & EditForm.DaysTextDetail.Text & "' " &
      " WHERE forecastID = " & Form1.lstTargetID.Text

        Try
            Dim objCmd As New SqlCommand(q, sqlCon)
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Sub AddForecast()

        Dim q As String = "INSERT INTO RollstockForecast([TargetID]
      ,[ForecastDate]
      ,[ForecastTons]
      ,[WorkingDays]) " &
      "VALUES
('" & AddForm.idTextDetail.Text & "', '" & Convert.ToDateTime(AddForm.monthTextDetail.Text) & "', '" & AddForm.TonsTextDetail.Text & "','" & AddForm.DaysTextDetail.Text & "')"
        Try
            Dim objCmd As New SqlCommand(q, sqlCon)

            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Sub GetDetailData()
        Dim q As String = "SELECT  * FROM RollstockForecast R" &
        " JOIN RollstockTarget T on T.targetID = R.TargetID " &
        "where YEAR(ForecastDate) = 2020 and r.forecastid =" & Form1.lstTargetID.SelectedItem

        Try
            Dim objCmd As New SqlCommand(q, sqlCon)

            Dim reader As SqlDataReader = objCmd.ExecuteReader

            reader.Read()

            DetailForm.idTextDetail.Text = reader("TargetID")
            DetailForm.monthTextDetail.Text = reader("ForecastDate")
            DetailForm.TonsTextDetail.Text = reader("ForecastTons")
            DetailForm.DaysTextDetail.Text = reader("WorkingDays")

            If reader("TargetID") > 0 Then
                q = "Select  * FROM RollstockForecast R" &
                " JOIN RollstockTarget T On T.targetID = R.TargetID " &
                " JOIN PaperGrade p on p.papergradeid = t.papergradeid " &
                "where YEAR(ForecastDate) = 2020 And t.targetid = " & reader("TargetID")

                objCmd = New SqlCommand(q, sqlCon)
                'Dim objCmd As New SqlCommand(q, sqlCon)
                reader = objCmd.ExecuteReader
                'Dim reader As SqlDataReader = objCmd.ExecuteReader

                reader.Read()

                DetailForm.paperIdText.Text = reader("PaperGradeID")
                DetailForm.paperTypeText.Text = reader("Grade")
                DetailForm.PaperUsageText.Text = reader("WeeklyUsage")
                DetailForm.PaperForecastText.Text = reader("ForecastTons")

            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            'sqlCon.Close()
        End Try
    End Sub
    Sub GetData()

        Form1.lstTargetID.Items.Clear()
        Form1.lstDate.Items.Clear()
        Form1.lstWorkDays.Items.Clear()
        Form1.lstTons.Items.Clear()

        Dim q As String = "SELECT  * FROM RollstockForecast R" &
        " JOIN RollstockTarget T on T.targetID = R.TargetID " &
        "where YEAR(ForecastDate) = 2020"

        Dim objCmd As New SqlCommand(q, sqlCon)

        objCmd.ExecuteNonQuery()
        Dim reader As SqlDataReader = objCmd.ExecuteReader

        While reader.Read

            Form1.lstTargetID.Items.Add(reader("ForecastID"))
            Form1.lstDate.Items.Add(reader("ForecastDate"))
            Form1.lstWorkDays.Items.Add(reader("WorkingDays"))
            Form1.lstTons.Items.Add(reader("ForecastTons"))

        End While
        reader.Close()
        'sqlCon.Close()
    End Sub
    Sub connectToDatabase()

        connection = "INSERT CONNECTION STRING HERE"

        sqlCon = New SqlConnection(connection)

        sqlCon.Open()

    End Sub

    Sub disconnectFromDatabase()
        connection = Nothing
    End Sub
End Module
