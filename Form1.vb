Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Knucklebones_Port_Project.My.Resources

' Notes: btw this whole thing is gonna either be 1. really inefficient or 2. be really shit (interchangeable)
' If ... Is Nothing Then could be useful for checking open slots after first turn
' Val statement could be useful to retrieve values from the buttons fr
' Ctrl K + Ctrl U to uncomment ez
Public Class Form1
    Dim Dice As Integer
    Dim DiceImg As Integer
    Dim tspn As New TimeSpan()

    Public Function Roll() ' dice rolling fuck yea!!!
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
    End Function

    Public Sub BoardCalc()
        Dim Col1x1 As Integer
        Dim Col1x2 As Integer
        Dim Col1x3 As Integer
        Dim Column1Sum As Integer
        Dim Product As Integer = 0
        Dim Remainder As Integer = 0
        ' since wrapping in CInt() crashes for some reason :DDDD

        Col1x1 = btnP1_1x1.Text
        Col1x2 = btnP1_1x2.Text
        Col1x3 = btnP1_1x3.Text

        ' YandereDev ass code LMFAOOOOOOOOOO
        If Col1x1 = Col1x2 Then
            Product = Col1x1 * Col1x2
            Remainder = Col1x3 + Product
        ElseIf Col1x2 = Col1x3 Then
            Product = Col1x2 * Col1x3
            Remainder = Col1x1 + Product
        ElseIf Col1x1 = Col1x3 Then
            Product = Col1x1 * Col1x3
            Remainder = Col1x2 + Product
        End If

        If Product = 0 Then
            Column1Sum = Col1x1 + Col1x2 + Col1x3
        ElseIf Product > 1 Then
            Column1Sum = Remainder
        End If

        lblDbgScore.Text = Column1Sum

        ' array solution if needed
        'Dim Column1Sum() As Integer = {Col1x1, Col1x2, Col1x3}


    End Sub

    Private Sub ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP1_1x1.Click,
                               btnP1_1x2.Click, btnP1_1x3.Click, btnP1_1x3.Click, btnP1_2x1.Click,
                               btnP1_2x2.Click, btnP1_2x3.Click, btnP1_3x1.Click, btnP1_3x2.Click,
                               btnP1_3x3.Click

        Roll()
        sender.Text = Dice
        sender.Enabled = False

    End Sub


    ' future reset thingy when game ends, resets all buttons
    Private Sub Reset()
        For Each ctl In Controls
            If TypeOf ctl Is Button Then
                ctl.Text = ""
                ctl.Enabled = True
            End If
        Next ctl
        btnDbgStart.Text = "Start / Restart"
    End Sub



    ' ok below is where all the double clicking happens
    Private Sub btnDbgStart_Click(sender As Object, e As EventArgs) Handles btnDbgStart.Click
        ' move this to the starter form after its made
        If IsNumeric(txtTimeInput.Text) AndAlso CInt(txtTimeInput.Text) > 0 Then
            tspn = New TimeSpan(0, CInt(txtTimeInput.Text), 0)
            GameTimer.Enabled = True
        Else
            MsgBox("Invalid entry. Please enter a numeric value.")
        End If

    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        ' tsk tsk rewrite this so its not skidded lol
        tspn = tspn.Subtract(New TimeSpan(0, 0, 1))

        lblTime.Text = String.Format(" {0}:{1}", tspn.Minutes, tspn.Seconds)
        If tspn.Minutes = 0 AndAlso tspn.Seconds = 0 Then
            GameTimer.Stop()
            MsgBox("Game over!!! (Add player winning info when that stuff is done)")
        End If
    End Sub

    Private Sub btnRollTheDice_Click(sender As Object, e As EventArgs) Handles btnRollTheDice.Click
        ' highkey disable this shit until the next players turn
        Roll()
        lblInfoDice.Text = Roll()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' oops misclick, does this do smth when the form opens?
        ' maybe could wrap this entire shit around it xDDD
    End Sub

    Private Sub pboxDice_Click(sender As Object, e As EventArgs) Handles pboxDice.Click

    End Sub

    Private Sub btnDbgStop_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dbgTestButton_Click(sender As Object, e As EventArgs) Handles dbgTestButton.Click
        BoardCalc()
    End Sub


End Class
