Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Knucklebones_Port_Project.My.Resources

' Notes: btw this whole thing is gonna either be 1. really inefficient or 2. be really bad (interchangeable)
' If ... Is Nothing Then could be useful for checking open slots after first turn
' Val statement could be useful to retrieve values from the buttons fr
' Ctrl K + Ctrl U to uncomment ez

Public Class TheGame
    Dim Dice As Integer
    Dim DiceImg As Integer
    Dim tspn As New TimeSpan()
    Dim Turn As Integer

    Public Function Roll() ' dice rolling heck yea!!!
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
        Return Dice
    End Function

    Private Sub UpdateDiceImage(value As Integer)
        Dim rm As New System.Resources.ResourceManager("Knucklebones_Port_Project.TheDice", GetType(TheGame).Assembly)
        Dim imgObj As Object = rm.GetObject($"Dice{value}")
        If imgObj IsNot Nothing Then
            pboxDice.Image = CType(imgObj, Drawing.Image)
        Else
            pboxDice.Image = Nothing
        End If
    End Sub

    Private Function IncrementTurn()
        Turn += 1
        If Turn Mod 2 = 0 Then
            lblIndicator.Text = "Player 2
place your dice!"
            lblIndicator.ForeColor = Color.FromArgb(192, 0, 192)
        Else
            lblIndicator.Text = "Player 1
place your dice! " & Turn
            lblIndicator.ForeColor = Color.Red
        End If

    End Function

    Private Function DisableBoards()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = False
            End If
        Next
        btnRollTheDice.Enabled = True
    End Function

    Private Function ReenableBoard() ' yeah this causes a memory leak but i cant care anymore
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
            End If
        Next
    End Function

    Public Function PlayerNames()
        lblPlayer1.Text = CStr(TitleScreen.txtP1Name.Text)
        lblPlayer2.Text = CStr(TitleScreen.txtP2Name.Text)
    End Function

    Private Sub P1ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP1_1.Click,
                               btnP1_2.Click, btnP1_3.Click, btnP1_3.Click, btnP1_4.Click,
                               btnP1_5.Click, btnP1_6.Click, btnP1_7.Click, btnP1_8.Click,
                               btnP1_9.Click


        sender.Text = Dice
        sender.Enabled = False
        DisableBoards()
    End Sub

    Private Sub P2ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP2_1.Click,
                               btnP2_2.Click, btnP2_3.Click, btnP2_3.Click, btnP2_4.Click,
                               btnP2_5.Click, btnP2_6.Click, btnP2_7.Click, btnP2_8.Click,
                               btnP2_9.Click


        sender.Text = Dice
        sender.Enabled = False
        DisableBoards()
    End Sub

    Public Sub TimerStart()
        If IsNumeric(TitleScreen.txtTimeInput.Text) AndAlso CInt(TitleScreen.txtTimeInput.Text) > 0 Then
            tspn = New TimeSpan(0, CInt(TitleScreen.txtTimeInput.Text), 0)
            GameTimer.Enabled = True
            lblTime.Text = String.Format(" {0}:{1}", tspn.Minutes, tspn.Seconds) ' maybe it makes it start with its time instead of 1s cooldown
        Else
            MsgBox("Invalid entry. Please enter a numeric value.")
        End If
    End Sub

    ' ok below is where all the double clicking happens

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        tspn = tspn.Subtract(New TimeSpan(0, 0, 1))

        lblTime.Text = String.Format(" {0}:{1}", tspn.Minutes, tspn.Seconds)
        If tspn.Minutes = 0 AndAlso tspn.Seconds = 0 Then
            GameTimer.Stop()
            MsgBox("Game over!!! (Add player winning info when that stuff is done)")
            ' Disable all button function then show an exit button?
        End If
    End Sub

    Private Sub btnRollTheDice_Click(sender As Object, e As EventArgs) Handles btnRollTheDice.Click
        ' highkey disable this until the next players turn

        Roll()
        lblDiceNumber.Text = Dice.ToString()
        UpdateDiceImage(Dice)
        lblIndicator.Text = ""
        ReenableBoard()
        IncrementTurn()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' could be used to distinctly load turn 0

    End Sub


    Private Sub dbgTestButton_Click(sender As Object, e As EventArgs)
        ' BoardCalc()
    End Sub


End Class
