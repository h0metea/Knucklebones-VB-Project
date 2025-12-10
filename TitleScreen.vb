Public Class TitleScreen

    Private Sub Start(sender As Object, e As EventArgs) Handles btnStartTheGame.Click
        TheGame.GetPlayerNames()
        TheGame.TimerStart()
        TheGame.Show()
        Me.Hide()

    End Sub

    Private Sub Cya(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnImNewToThis_Click(sender As Object, e As EventArgs) Handles btnImNewToThis.Click
        MsgBox("The game is pretty simple!
                
Roll the dice and place what you rolled on your board.
You can place them anywhere you want in this version of the game!

Lone dice simply add on to your score but...
If you have two of the same dice on the same row, they get exponentiated by how many are on the board!!
For example, if you had two 4 dice in the same row, you get 16 score!
If there were three of the same numbered dice in a row, it would cube!!

Whoever has the highest score when both boards are full or the timer runs out, wins.
With the timer, we recommend a maximum playtime of 5 minutes.

Good luck and have fun. :D", Title:="How it Works")


    End Sub
End Class