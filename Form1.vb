Public Class Form1
    Dim mgametimer As Double, PlaceholderEnd As Integer

    Private Sub btnDbgStart_Click(sender As Object, e As EventArgs) Handles btnDbgStart.Click
        lblTime.Caption = "10"
        GameTimer.Interval = 1000
        mgametimer = Now
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        PlaceholderEnd

    End Sub
End Class
