Public Class Form1
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home Internet speed user number."
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Enter a numeric value of Mbps to your home Internet computer."
        Dim negErrMsg As String = "Error - Enter a valid number."

        Dim intMaxEntries As Integer = 10
        Dim intMinEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & strIBoxTitle)

        Do Until intMinEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
            End If
            If decSpeed > 0 Then
                listSpeed.Items.Add(decSpeed)
                decSumOfSpeeds += decSpeed
                intMinEntries += 1
                strIBoxMsg = strIBoxMsg
            Else
                strIBoxMsg = strNotNumericErrMsg
            End If
            If intMinEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & strIBoxTitle)

            End If

        Loop

        lblAvg.Visible = True
        If intMinEntries > 1 Then
            decAverage = decSumOfSpeeds / (intMinEntries - 1)
            lblAvg.Text = "Average Internet Speed:     " &
            decAverage.ToString("F2") & " Mbps "
        Else
            lblAvg.Text = "No Speed Values Entered"


        End If
        btnSpeed.Enabled = False


    End Sub
End Class
