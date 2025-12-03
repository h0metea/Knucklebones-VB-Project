Imports Knucklebones_Port_Project.My.Resources

Public Class Form1
    Dim Dice As Integer

    Public Function Rand() ' dice rolling fuck yea!!! also this might be how 2 write a function LOL
        Dice = Int((6 - 1 + 1) * Rnd() + 1)
    End Function

    Private P1intButtonID As Integer = 0


    Private Sub Reset()
        For Each ctl In Controls
            If TypeOf ctl Is Button Then
                ctl.BackgroundImage
                ctl.Enabled = True
            End If
        Next ctl
        btnDbgStart.Text = "Start / Restart"
    End Sub

    ' ok below is where all the double clicking happens
    Private Sub btnDbgStart_Click(sender As Object, e As EventArgs) Handles btnDbgStart.Click
        ' move this to the starter screen after its made
        Reset()

        btnP1_1x1
        P1intButtonID = 1
        GameTimer.Start()


    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick



    End Sub

    Private Sub btnTMPDICE_Click(sender As Object, e As EventArgs) Handles btnTMPDICE.Click
        Rand()
        lblDiceTemp.Text = Dice
        pboxDice.Image = Resources.Dice1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' oops misclick, does this do smth when the form opens?
        ' maybe could wrap this entire shit around it xDDD
    End Sub

End Class
