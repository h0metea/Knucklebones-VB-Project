Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Knucklebones_Port_Project.My.Resources

' Notes: btw this whole thing is gonna either be 1. really inefficient or 2. be really bad (interchangeable)
' If ... Is Nothing Then could be useful for checking open slots after first turn
' Val statement could be useful to retrieve values from the buttons fr
' Ctrl K + Ctrl U to uncomment ez

''' <summary>
'''  CHANGE LSAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
'''  qdsqwdwd2d2d32322332423
''' </summary>

Public Class TheGame
    Dim Dice As Integer
    Dim DiceImg As Integer
    Dim tspn As New TimeSpan()
    Dim Turn As Integer

    Public Function GetPlayerNames()
        lblPlayer1.Text = CStr(TitleScreen.txtP1Name.Text)
        lblPlayer2.Text = CStr(TitleScreen.txtP2Name.Text)
    End Function

    Public Function Roll() ' dice rolling heck yea!!!
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
        Return Dice
    End Function

    Private Sub btnForfeit_Click(sender As Object, e As EventArgs) Handles btnForfeit.Click
        EndGame()
    End Sub

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
place your dice!"
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
        lblIndicator.Text = "Roll the dice!"
        lblIndicator.ForeColor = Color.White
    End Function

    Private Function ReenableBoard() ' yeah this causes a memory leak but i cant care anymore
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
            End If
        Next
    End Function

    Private Sub P1ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP1_1.Click,
                               btnP1_2.Click, btnP1_3.Click, btnP1_3.Click, btnP1_4.Click,
                               btnP1_5.Click, btnP1_6.Click, btnP1_7.Click, btnP1_8.Click,
                               btnP1_9.Click

        sender.Text = Dice
        sender.Enabled = False
        DisableBoards()
        lblP1Score.Text = "Score: " & CalculatePlayerScore(1)

        If AreBothBoardsFull() Then
            EndGame()
        End If
    End Sub

    Private Sub P2ButtonClicked(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnP2_1.Click,
                               btnP2_2.Click, btnP2_3.Click, btnP2_3.Click, btnP2_4.Click,
                               btnP2_5.Click, btnP2_6.Click, btnP2_7.Click, btnP2_8.Click,
                               btnP2_9.Click

        sender.Text = Dice
        sender.Enabled = False
        DisableBoards()
        lblP2Score.Text = "Score: " & CalculatePlayerScore(2)

        If AreBothBoardsFull() Then
            EndGame()
        End If
    End Sub

    Private Sub EndGame()
        If GameTimer.Enabled Then
            GameTimer.Stop()
        End If

        ' old code coming in clutch!!
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = False
            End If
        Next

        Dim finalScoreP1 As Integer = CalculatePlayerScore(1)
        Dim finalScoreP2 As Integer = CalculatePlayerScore(2)

        Dim resultMessage As String
        If finalScoreP1 > finalScoreP2 Then
            resultMessage = lblPlayer1.Text & " wins! (" & finalScoreP1 & " - " & finalScoreP2 & ")"
        ElseIf finalScoreP2 > finalScoreP1 Then
            resultMessage = lblPlayer2.Text & " wins! (" & finalScoreP2 & " — " & finalScoreP1 & ")"
        Else
            resultMessage = "You got lucky! It's somehow a tie?!?!?! (" & finalScoreP1 & " — " & finalScoreP2 & ")"
        End If

        MsgBox("Game over! " & resultMessage & " | GGs and Thanks for playing!!", Title:="Game Over!!!")
        Application.Exit()
    End Sub

    Public Sub TimerStart()
        If IsNumeric(TitleScreen.txtTimeInput.Text) AndAlso CInt(TitleScreen.txtTimeInput.Text) > 0 Then
            tspn = New TimeSpan(0, CInt(TitleScreen.txtTimeInput.Text), 0)
            GameTimer.Enabled = True
            lblTime.Text = String.Format(" {0}:{1:00}", tspn.Minutes, tspn.Seconds) ' maybe it makes it start with its time instead of 1s cooldown
        Else
            MsgBox("Invalid entry. Please enter a numeric value.")
        End If
    End Sub

    ' ok below is where all the double clicking happens

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        tspn = tspn.Subtract(New TimeSpan(0, 0, 1))

        lblTime.Text = String.Format(" {0}:{1:00}", tspn.Minutes, tspn.Seconds)
        If tspn.Minutes = 0 AndAlso tspn.Seconds = 0 Then
            EndGame()
        End If
    End Sub

    Private Sub btnRollTheDice_Click(sender As Object, e As EventArgs) Handles btnRollTheDice.Click
        ' highkey disable this until the next players turn

        Roll()
        lblDiceNumber.Text = Dice.ToString()
        UpdateDiceImage(Dice)
        ReenableBoard()
        IncrementTurn()

    End Sub

    Private Function CalculateRowScore(rowButtons As List(Of Button)) As Integer
        Dim rowValues As New List(Of Integer)

        For Each btn As Button In rowButtons
            If btn.Text <> "" AndAlso IsNumeric(btn.Text) Then
                rowValues.Add(CInt(btn.Text))
            End If
        Next

        If rowValues.Count = 0 Then Return 0

        Dim score As Integer = 0
        Dim processedIndices As New HashSet(Of Integer)

        For i As Integer = 0 To rowValues.Count - 1
            If processedIndices.Contains(i) Then Continue For

            Dim currentValue As Integer = rowValues(i)
            Dim duplicateCount As Integer = 1

            For j As Integer = i + 1 To rowValues.Count - 1
                If rowValues(j) = currentValue Then
                    duplicateCount += 1
                    processedIndices.Add(j)
                End If
            Next

            If duplicateCount > 1 Then
                score += currentValue ^ duplicateCount
            Else
                score += currentValue
            End If

            processedIndices.Add(i)
        Next

        Return score
    End Function

    Public Function CalculatePlayerScore(playerNumber As Integer) As Integer
        Dim totalScore As Integer = 0
        Dim allButtons As New List(Of Button)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = CType(ctrl, Button)
                If (playerNumber = 1 AndAlso btn.Name.StartsWith("btnP1_")) OrElse
                   (playerNumber = 2 AndAlso btn.Name.StartsWith("btnP2_")) Then
                    allButtons.Add(btn)
                End If
            End If
        Next

        For rowIndex As Integer = 0 To 2
            Dim rowStart As Integer = rowIndex * 3
            Dim rowButtons As New List(Of Button) From {
                allButtons(rowStart),
                allButtons(rowStart + 1),
                allButtons(rowStart + 2)
            }
            totalScore += CalculateRowScore(rowButtons)
        Next

        Return totalScore
    End Function

    Private Function AreBothBoardsFull() As Boolean
        Dim p1Count As Integer = 0
        Dim p2Count As Integer = 0

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)

                If btn.Name.StartsWith("btnP1_") Then
                    If btn.Text <> "" AndAlso IsNumeric(btn.Text) Then
                        p1Count += 1
                    End If
                ElseIf btn.Name.StartsWith("btnP2_") Then
                    If btn.Text <> "" AndAlso IsNumeric(btn.Text) Then
                        p2Count += 1
                    End If
                End If

                If p1Count = 9 AndAlso p2Count = 9 Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    ' funniest way to close the entire app while hiding the main form.
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub
End Class
