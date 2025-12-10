Public Class TitleScreen

    Private Sub Start(sender As Object, e As EventArgs) Handles btnStartTheGame.Click
        TheGame.PlayerNames()
        TheGame.Show()
        Me.Hide()

    End Sub

    Private Sub Cya(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnImNewToThis_Click(sender As Object, e As EventArgs) Handles btnImNewToThis.Click
        MsgBox("The game is pretty simple!
                
Roll the dice and place what you rolled on your board.
If you have two of the same dice on the same row, they multiply each other.
If you're somehow lucky enough to have three of the same dice in a row, they ALL multiply with eachother!

Be careful though, your opponent could place their dice in the same space on their board, which means you lose
your dice that was there!

Whoever has the highest score when both boards are full or the timer runs out, wins!!!")


    End Sub
End Class