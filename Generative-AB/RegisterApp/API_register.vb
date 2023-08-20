Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Text.RegularExpressions

Public Class API_register
    Public urlx As String
    Public Shared WEB_Register As String = "http://localhost/My_API/"
    Public Shared random As New Random()

    Public Function ValidateRemoteCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Public Shared Function RegexCode(Code As String) As String
        Dim formatted As String = Regex.Replace(BB_Framework_Code.Crypto.EncryptMD5(Code), "(.{5})", "$1-")
        Return formatted.TrimEnd("-"c)
    End Function
    Public Shared Function random_code() As String
        Return Convert.ToString(random.Next(10000000, 99999999))
    End Function


    Public Shared Sub ProtocolType()
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
    End Sub

    Public Shared Function DataTableToJSONWithStringBuilder(ByVal table As DataTable) As String
        Dim JSONString = New StringBuilder()
        If table.Rows.Count > 0 Then
            JSONString.Append("[")
            For i As Integer = 0 To table.Rows.Count - 1
                JSONString.Append("{")
                For j As Integer = 0 To table.Columns.Count - 1
                    If j < table.Columns.Count - 1 Then
                        JSONString.Append("""" & table.Columns(j).ColumnName.ToString() & """:" & """" + table.Rows(i)(j).ToString() & """,")
                    ElseIf j = table.Columns.Count - 1 Then
                        JSONString.Append("""" & table.Columns(j).ColumnName.ToString() & """:" & """" + table.Rows(i)(j).ToString() & """")
                    End If
                Next
                If i = table.Rows.Count - 1 Then
                    JSONString.Append("}")
                Else
                    JSONString.Append("},")
                End If
            Next
            JSONString.Append("]")
        End If
        Return JSONString.ToString()
    End Function

    Public Shared Function NewPostDataAPI(ByVal payload As String, httpWebRequest1 As HttpWebRequest) As String
        Try

            Dim body As String = payload
            Dim httpWebRequest As HttpWebRequest
            httpWebRequest = httpWebRequest1
            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
                streamWriter.Write(body)
            End Using
            Dim httpResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                Dim result = streamReader.ReadToEnd()
                streamReader.Close()
                Return result.Replace(vbCr, "").Replace(vbLf, "")
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Server API Error")
            Return "{""status"":""error"",""message"":""" & ex.Message & """,""code"":""404""}"
        End Try

    End Function


    Public Shared Function register_app(table As DataTable) As String
        Try
            'http://localhost:801/bot/register.php

            Dim UrlAPI As String = WEB_Register & "windows.php/register_app"
            Dim body = DataTableToJSONWithStringBuilder(table)
            Dim httpWebRequest = CType(WebRequest.Create(UrlAPI), HttpWebRequest)
            httpWebRequest.ContentType = "application/json"
            httpWebRequest.Method = "POST"
            Dim Contentx = NewPostDataAPI(body, httpWebRequest)
            Return Contentx
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error register app", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "{""status"":""error"",""message"":""" & ex.Message & """,""code"":""404""}"
        End Try

    End Function


    'Public Function GenKey(ByVal key As String) As String
    '    Try
    '        ProtocolType()
    '        Dim getAPIX As String = ""
    '        If key IsNot Nothing Then
    '            getAPIX = "GenKey.php?key=" & key
    '            Dim UrlAPI As String = WEB_Register & getAPIX
    '            Dim Contentx = NewGetDataAPI(UrlAPI)
    '            If Contentx = "" Then
    '                Return "{""status"":""error"",""message"":""Server Down Pls Contact Administrator"",""code"":""99""}"
    '            Else
    '                Return Contentx
    '            End If
    '        Else
    '            Return "{""status"":""error"",""message"":""Server Down Pls Contact Administrator"",""code"":""99""}"
    '        End If

    '    Catch ex As Exception
    '        Return "{""status"":""error"",""message"":""" & ex.Message & """,""code"":""404""}"
    '    End Try
    'End Function
    Public Function show_register(table As DataTable) As String
        Try
            'http://localhost:801/bot/register.php 
            Dim UrlAPI As String = WEB_Register & "/show_register.php"
            'Dim client = New RestClient(UrlAPI)
            'client.Timeout = -1
            'Dim request = New RestRequest(Method.POST)

            Dim body = DataTableToJSONWithStringBuilder(table)
            Dim httpWebRequest = CType(WebRequest.Create(UrlAPI), HttpWebRequest)
            httpWebRequest.ContentType = "application/json"
            httpWebRequest.Method = "POST"
            Dim Contentx = NewPostDataAPI(body, httpWebRequest)
            Return Contentx

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GetUser")

        End Try

    End Function

End Class
