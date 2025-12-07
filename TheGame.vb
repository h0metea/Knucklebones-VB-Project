Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Knucklebones_Port_Project.My.Resources

' Notes: btw this whole thing is gonna either be 1. really inefficient or 2. be really shit (interchangeable)
' If ... Is Nothing Then could be useful for checking open slots after first turn
' Val statement could be useful to retrieve values from the buttons fr
' Ctrl K + Ctrl U to uncomment ez

Public Class TheGame
    Dim Dice As Integer
    Dim DiceImg As Integer
    Dim tspn As New TimeSpan()

    Public Function Roll() ' dice rolling fuck yea!!!
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
    End Function

    Public Sub Board1Col1Calc()


        ' array solution if needed
        Dim TestArray(2) As Integer
        TestArray(0) = btnP1_3.Text
        TestArray(1) = btnP1_2.Text
        TestArray(2) = btnP1_1.Text

        For i As Integer = 0 To 2

        Next


        'Col1 = btnP1_1.Text
        'Col2 = btnP1_2.Text
        'Col3 = btnP1_3.Text

    End Sub

    Private Sub ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP1_1.Click,
                               btnP1_2.Click, btnP1_3.Click, btnP1_3.Click, btnP1_4.Click,
                               btnP1_5.Click, btnP1_6.Click, btnP1_7.Click, btnP1_8.Click,
                               btnP1_9.Click

        Roll()
        sender.Text = Dice
        sender.Enabled = False

    End Sub

    Private Sub ResetBoardDisabler()
        btnP1_1.Enabled = False
        btnP1_2.Enabled = False
        btnP1_4.Enabled = False
        btnP1_5.Enabled = False
        btnP1_7.Enabled = False
        btnP1_8.Enabled = False
    End Sub

    ' future reset thingy when game ends, resets all buttons
    Private Sub Reset()
        For Each ctl In Controls
            If TypeOf ctl Is Button Then
                ctl.Text = ""
                ctl.Enabled = True
            End If
        Next ctl
        ResetBoardDisabler()
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
        lblDiceNumber.Text = Dice
        pboxDice.Image = My.Resources.DiceFaces.

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
