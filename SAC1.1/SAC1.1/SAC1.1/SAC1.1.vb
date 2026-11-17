'Name: Ethan Haberl
'Date: 18.03.2019
'Version: 1.4
'Description: A program which calculates the user's BMI and puts it into a category 
'             which can tell them if they are underweight, healthy, or obese.

Public Class Form1

    Function BMI(sinHeight As Single, sinWeight As Single) As Double

        'How to calculate the BMI (easier to change later if needed)
        BMI = sinWeight / sinHeight ^ 2

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            'The variables in the program
            Dim sinH, sinW, sinUnderweight, sinHealthy, sinOverweight, sinObese, sinSeverelyobese, sinAnswer, sinHeightM, sinWeightkg, sinImperialWeight, sinImperialHeight As Single
            Dim category, save As String
            Dim clrUnderweight, clrHealthy, clrOverweight, clrObese, clrSevOb, clrMorbOb As Color

            'the top end values for the weights (obese is not needed as it is all other values above overweight)
            'e.g. 18.5 is the lowest point before being underweight, 18.49 is the highest before becoming healthy
            sinUnderweight = 18.5
            sinHealthy = 26.5
            sinOverweight = 29.9
            sinObese = 34.9
            sinSeverelyobese = 39.9
            'Colors which you can set the categories as
            'Underweight
            clrUnderweight = Color.Gray
            'Healthy
            clrHealthy = Color.Green
            'Overweight
            clrOverweight = Color.Yellow
            'Obese
            clrObese = Color.Orange
            'Severely Obese
            clrSevOb = Color.Red
            'Morbidly Obese
            clrMorbOb = Color.Purple

            'Converting Data
            sinImperialHeight = 0.0254
            sinImperialWeight = 0.45359237


            'The input devices and imperial/metric sorting (text boxes)
            If cbUnits.Text = "Imperial" Then
                sinHeightM = Val(txtHeight.Text) * sinImperialHeight * 12
                sinWeightkg = Val(txtWeight.Text) * sinImperialWeight
            Else
                sinHeightM = Val(txtHeight.Text)
                sinWeightkg = Val(txtWeight.Text)
            End If
            sinH = sinHeightM
            sinW = sinWeightkg

            'Value that the category selection process uses
            sinAnswer = Decimal.Round(BMI(sinH, sinW), 2, MidpointRounding.AwayFromZero)

            'The category selection process
            If sinAnswer < sinUnderweight Then
                lblBMIAns.ForeColor = clrUnderweight
                category = "Underwieght"
            ElseIf sinAnswer < sinHealthy Then
                lblBMIAns.ForeColor = clrHealthy
                category = "Healthy"
            ElseIf sinAnswer < sinOverweight Then
                lblBMIAns.ForeColor = clrOverweight
                category = "Overwieght"
            ElseIf sinAnswer < sinObese Then
                lblBMIAns.ForeColor = clrObese
                category = "Obese"
            ElseIf sinAnswer < sinSeverelyobese Then
                lblBMIAns.ForeColor = clrSevOb
                category = "Severely Obese"
            Else
                lblBMIAns.ForeColor = clrMorbOb
                category = "Morbidly Obese"
            End If

            'Output to lblBMIAns
            lblBMIAns.Text = "Your BMI is " & sinAnswer & ". You are " & category


        Catch ex As Exception
        End Try
    End Sub
End Class
