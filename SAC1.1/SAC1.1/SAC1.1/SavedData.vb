'Name: Ethan
'Date: 16.03.2019
'Version: 1.2
'Description: The form which stores all of the BMI data


Imports System.IO

Public Class SavedData

    Dim count As Integer = 0

    Private Sub SavedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String
        Dim strArr() As String

        Dim readlines() As String = File.ReadAllLines("BmiData.txt")

        str = readlines(count)

        strArr = str.Split(",")

        txtHeight.Text = strArr(0)
        txtWeight.Text = strArr(1)
        txtBMI.Text = strArr(2)
        txtCategory.Text = strArr(3)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim lines As New List(Of String)(IO.File.ReadAllLines("BmiData.txt"))

        lines.RemoveAt(count)

        IO.File.WriteAllLines("BmiData.txt", lines.ToArray())

        txtHeight.Clear()
        txtWeight.Clear()
        txtBMI.Clear()
        txtCategory.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If count >= 1 Then

            count = count - 1

        End If

        Dim str As String
        Dim strArr() As String

        Dim readlines() As String = File.ReadAllLines("BmiData.txt")

        str = readlines(count)

        strArr = str.Split(",")

        txtHeight.Text = strArr(0)
        txtWeight.Text = strArr(1)
        txtBMI.Text = strArr(2)
        txtCategory.Text = strArr(3)

    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click

        Dim linecount = File.ReadAllLines("BmiData.txt").Length

        If count < (linecount - 1) Then

            count = count + 1

        End If

        Dim str As String
        Dim strArr() As String

        Dim readlines() As String = File.ReadAllLines("BmiData.txt")

        str = readlines(count)

        strArr = str.Split(",")

        txtHeight.Text = strArr(0)
        txtWeight.Text = strArr(1)
        txtBMI.Text = strArr(2)
        txtCategory.Text = strArr(3)

    End Sub
End Class