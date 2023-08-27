Imports System.Timers

Public Class CountdownTimer
    Private targetTimestamp As DateTime
    Private WithEvents timer As Timer

    Public Event CountdownTick(ByVal remainingTime As TimeSpan)
    Public Event CountdownFinished()

    Public Sub New(targetTime As DateTime)
        targetTimestamp = targetTime

        Dim timeDifference As TimeSpan = targetTime.Subtract(DateTime.Now)
        Dim initialInterval As Integer = CInt(timeDifference.TotalMilliseconds)

        timer = New Timer(initialInterval)
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As ElapsedEventArgs) Handles timer.Elapsed
        Dim remainingTime As TimeSpan = targetTimestamp.Subtract(DateTime.Now)

        If remainingTime.TotalMilliseconds <= 0 Then
            timer.Stop()
            RaiseEvent CountdownFinished()
            Application.Restart() ' Restart the application when countdown finishes

        Else
            RaiseEvent CountdownTick(remainingTime)
        End If
    End Sub
End Class
