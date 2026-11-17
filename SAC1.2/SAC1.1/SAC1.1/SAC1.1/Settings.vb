Imports System.IO

Public Class Settings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strUnits, strDOB, strInput As String
        Dim sinHeight As Single

        If rdImperial.Checked = True Then
            strUnits = "Imperial"
        Else
            strUnits = "Metric"
        End If

        strDOB = txtDOB.Text
        sinHeight = Val(txtHeight.Text)

        strInput = (strUnits & "," & strDOB & "," & sinHeight & Environment.NewLine)


        Dim lines As New List(Of String)(IO.File.ReadAllLines("Settings.text"))

        lines.RemoveAt(0)

        IO.File.WriteAllLines("Settings.text", lines.ToArray())

        My.Computer.FileSystem.WriteAllText("Settings.text", strInput, True)

        Form1.Show()

        Me.Hide()

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String
        Dim strarr() As String

        Dim readlines() As String = File.ReadAllLines("Settings.text")

        str = readlines(0)

        strarr = str.Split(",")

        If strarr(0) = "Imperial" Then

            rdImperial.Checked = True

        Else
            rdMetric.Checked = True
        End If

        txtDOB.Text = strarr(1)
        txtHeight.Text = strarr(2)

    End Sub
End Class