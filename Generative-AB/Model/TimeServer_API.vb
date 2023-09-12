
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class TimeServer_API
    Public Shared Function Get_Server_time() As Long
        Dim location As String = "Asia/Bangkok" ' Replace with the desired location/time zone
        Dim unixTimestamp As Long = Nothing
        Try
            Dim apiUrl As String = $"http://worldtimeapi.org/api/timezone/{location}"
            Dim jsonResponse As String = SendHttpRequest(apiUrl)
            Dim timeData As JObject = JObject.Parse(jsonResponse)
            'Dim currentTime As String = timeData("unixtime")
            unixTimestamp = timeData("unixtime") ' Replace with your Unix timestamp
            Dim timeZoneOffset As Integer = 7 * 60 * 60 ' UTC+7 in seconds
            Dim unixEpoch As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)

            Dim dateTimeUtc As DateTime = unixEpoch.AddSeconds(unixTimestamp)
            Dim dateTimeWithOffset As DateTime = dateTimeUtc.AddSeconds(timeZoneOffset)
            Console.WriteLine($"Unix timestamp: {unixTimestamp}")
            Console.WriteLine($"Converted DateTime (UTC): {dateTimeUtc}")
            Console.WriteLine($"Converted DateTime (UTC+7): {dateTimeWithOffset}")
            ' Convert to a specific time zone
            Dim timeZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time") ' Adjust to your time zone
            Dim dateTimeInTimeZone As DateTime = TimeZoneInfo.ConvertTime(dateTimeWithOffset, timeZone)
            Console.WriteLine($"Converted DateTime in Time Zone: {dateTimeInTimeZone}")
            Console.WriteLine($"Current time in {location}: {dateTimeWithOffset  }")
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Time Server Error")
        End Try
        Return unixTimestamp
    End Function
    Public Shared Function unix_Timestamp(dateTimeValue As DateTime) As Long
        'Dim dateTimeValue As DateTime = DateTime.Now ' Replace with your DateTime value
        Dim unixEpoch As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim unixTimestamp As Long = CLng((dateTimeValue - unixEpoch).TotalSeconds)
        Console.WriteLine($"Original DateTime: {dateTimeValue}")
        Console.WriteLine($"Converted Unix timestamp: {unixTimestamp}")
        Return unixTimestamp
    End Function
    Public Shared Function getTimestamp() As String
        Dim dateTimeValue As DateTime = DateTime.UtcNow
        'Dim dateTimeValue As DateTime = DateTime.Now ' Replace with your DateTime value
        Dim unixEpoch As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim unixTimestamp As Long = CLng((dateTimeValue - unixEpoch).TotalSeconds)
        Console.WriteLine($"Original DateTime: {dateTimeValue}")
        Console.WriteLine($"Converted Unix timestamp: {unixTimestamp}")
        Return unixTimestamp.ToString
    End Function

    Private Shared Function SendHttpRequest(url As String) As String
        Using client As New WebClient()
            Return client.DownloadString(url)
        End Using
    End Function
End Class
