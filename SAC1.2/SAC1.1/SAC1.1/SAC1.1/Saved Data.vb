Imports System.IO
Public Class Saved_Data

    Dim count = 0

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        If count >= 1 Then

            count = count - 1

        End If

        Dim str As String
        Dim strarr() As String

        Dim readlines() As String = File.ReadAllLines("SavedData.text")

        str = readlines(count)

        strarr = str.Split(",")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        Dim linecount = File.ReadAllLines("SavedData.text").Length

        If count < (linecount - 1) Then

            count = count + 1

        End If

        Dim str As String
        Dim strarr() As String

        Dim readlines() As String = File.ReadAllLines("SavedData.text")

        str = readlines(count)

        strarr = str.Split(",")



    End Sub

    Private Sub Saved_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim str As String
        Dim strarr() As String

        Dim readlines() As String = File.ReadAllLines("SavedData.text")

        str = readlines(count)

        strarr = str.Split(",")

        txtHeight.Text = strarr(0)
        txtWeight.Text = strarr(1)
        lblBMIAns.Text = strarr(2)
        txtDate.Text = strarr(3)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        Dim lines As New List(Of String)(IO.File.ReadAllLines("SavedData.text"))

        lines.RemoveAt(count)

        IO.File.WriteAllLines("SavedData.text", lines.ToArray())

    End Sub
End Class