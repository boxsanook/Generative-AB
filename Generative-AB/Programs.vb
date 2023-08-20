Module Programs
    Public Sub Main()

        'Dim dateTimeValue As DateTime = DateTime.Now

        'Dim unixTimestamp1 As Long = TimeServer_API.Get_Server_time() ' Replace with your first Unix timestamp
        'Dim unixTimestamp2 As Long = TimeServer_API.unix_Timestamp(dateTimeValue) ' Replace with your second Unix timestamp
        'Dim twelveHoursInSeconds As Long = 12 * 60 * 60 ' 12 hours in seconds 
        'Dim timeDifference As Long = Math.Abs(unixTimestamp2 - unixTimestamp1)

        ''Console.WriteLine($"Unix timestamp 1: {unixTimestamp1}")
        ''Console.WriteLine($"Unix timestamp 2: {unixTimestamp2}")
        ''Console.WriteLine($"Time difference (seconds): {timeDifference}")

        'If timeDifference < twelveHoursInSeconds Then
        '    Console.WriteLine("Time difference is less than 12 hours.")
        '    ProcessCount.Main_ProcessCount()
        '    Application.Run(New FRM_Main())
        'Else
        '    MessageBox.Show("Time difference is 12 hours or more.")
        '    Application.Exit()
        'End If


        If RegistryB.GetValueFromRegistry("Cliente_ID") IsNot Nothing Then
            ProcessCount.Main_ProcessCount()
            Application.Run(New FRM_Main())
        Else
            Application.Run(New FRM_Register())
        End If


    End Sub
End Module
