Imports Knucklebones_Port_Project.My.Resources

' Notes: btw this whole thing is gonna either be 1. really inefficient or 2. be really shit (interchangeable)
' If ... Is Nothing Then could be useful for checking open slots after first turn
' Val statement could be useful to retrieve values from the buttons fr
Public Class Form1
    Dim Dice As Integer
    Dim DiceImg As Integer
    Dim tspn As New TimeSpan()

    Public Function Roll() ' dice rolling fuck yea!!!
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
    End Function

    Private Sub GrabNumbers()

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

    Private Sub btnTMPDICE_Click(sender As Object, e As EventArgs) Handles btnTMPDICE.Click
        Roll()
        lblDiceTemp.Text = Roll

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' oops misclick, does this do smth when the form opens?
        ' maybe could wrap this entire shit around it xDDD
    End Sub

    Private Sub pboxDice_Click(sender As Object, e As EventArgs) Handles pboxDice.Click

    End Sub

    Private Sub btnDbgStop_Click(sender As Object, e As EventArgs)

    End Sub
End Class
