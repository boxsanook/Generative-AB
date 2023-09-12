Module xTime
    Public Function GetTimeBKK() As DateTime
        ' Get the current UTC time
        Dim currentUtcTime As DateTime = DateTime.UtcNow
        ' Add 7 hours to the current UTC time
        Dim hoursToAdd As Integer = 7
        Dim newDateTime As DateTime = currentUtcTime.AddHours(hoursToAdd)
        Return newDateTime

    End Function

    Public Function TimeStampToDateTime(ByVal TimeStampX As String) As String
        ' Assuming RegistryB.str_accessTokenExpiresAt is a Unix timestamp
        Dim unixTimestamp As Long = Long.Parse(RegistryB.str_accessTokenExpiresAt)
        ' Convert Unix timestamp to DateTimeOffset
        Dim expirationTime As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp)
        ' Add 7 seconds to the expiration time
        expirationTime = expirationTime.AddHours(7)
        Return expirationTime.ToString("yyyy-MM-dd HH:mm:ss")
    End Function
    Public Function UnixTimeStampToDateTime(ByVal unixTimeStamp As Double) As DateTime
        Try
            Dim dtDateTime As New System.DateTime
            dtDateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToString("yyyy-MM-dd HH:mm:ss")
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss")
            Return dtDateTime
        Catch ex As Exception
            'BB_Framework_Code.MessageB.ShowX(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 10)
        End Try

    End Function
    Public Function tImeConvert(dateString As String) As Long
        ' Define the string representation of the datetime
        'dateString = "2023-08-26 12:00:00" ' Replace with your datetime string

        ' Parse the string into a DateTime object
        Dim dt As DateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)

        ' Convert DateTime to timestamp in seconds (Unix epoch)
        Dim epoch As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim timeSpan As TimeSpan = dt - epoch
        Dim timestampSeconds As Long = CType(timeSpan.TotalSeconds, Long)
        Console.WriteLine("Timestamp in seconds: " & timestampSeconds)

        ' Convert DateTime to timestamp in milliseconds (Unix epoch)
        Dim timestampMilliseconds As Long = timestampSeconds * 1000
        Console.WriteLine("Timestamp in milliseconds: " & timestampMilliseconds)
        Return timestampMilliseconds

    End Function
    Public Function DiffTime(timestamp1 As Long, timestamp2 As Long) As String

        ' Define two timestamps in seconds
        timestamp1 = 1679808000 ' Replace with your timestamp 1
        timestamp2 = 1679809000 ' Replace with your timestamp 2 

        ' Calculate the time difference in seconds
        Dim timeDifferenceSeconds As Long = timestamp2 - timestamp1
        Console.WriteLine("Time difference in seconds: " & timeDifferenceSeconds)

        ' Convert time difference to a TimeSpan object
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(timeDifferenceSeconds)
        Console.WriteLine("Time difference as TimeSpan: " & timeSpan.ToString())
        Return timeSpan.ToString()
    End Function

End Module
