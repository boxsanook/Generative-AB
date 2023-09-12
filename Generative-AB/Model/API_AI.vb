Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class API_AI
    Private Shared baseUrl As String = "https://api.recraft.ai/project"
    Public Shared Sub SurroundingSub()
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub
    Public Shared Function Main_Post_AI(yourToken As String, baseSetUrl As String, json_data As String) As String
        SurroundingSub()
        Dim responseJson As String = String.Empty
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseSetUrl), HttpWebRequest)
            request.Method = "POST"
            request.Headers.Add("Authorization", "Bearer " & yourToken)
            request.ContentType = "application/json"

            json_data = json_data.Replace("'", "")
            Using streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json_data)
            End Using
            Try
                Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                        responseJson = streamReader.ReadToEnd()
                    End Using
                Else
                    Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                        responseJson = streamReader.ReadToEnd()
                        Console.WriteLine(responseJson)
                    End Using
                End If
            Catch ex As WebException
                Using streamReader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
                    responseJson = String.Empty
                    Console.WriteLine(responseJson)
                End Using
            End Try

            Return responseJson
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return responseJson
        End Try

    End Function




    Public Shared Function Main_Get_AI(ByVal yourToken As String, ByVal baseSetUrl As String) As String
        Dim responseJson As String = String.Empty
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseSetUrl), HttpWebRequest)
        request.Method = "GET"
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        request.Headers.Add("sec-ch-ua-platform", """Windows""")
        request.ContentType = "application/json"
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New StreamReader(response.GetResponseStream())
                    responseJson = streamReader.ReadToEnd()
                End Using
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
            End If
            Return responseJson
        Catch ex As Exception
            Console.WriteLine("Failed to execute poll_recraft: " & ex.Message)
            Return responseJson
        End Try
    End Function

    Public Shared Function Recraft_remove_from_history(yourToken As String, ByVal image_id As String) As Boolean
        Dim baseSetUrl As String = $"https://api.recraft.ai/images/{image_id}/reactions"
        Dim json_data As New JObject
        json_data.Add("reaction", "remove_from_history")
        Try
            Main_Post_AI(yourToken, baseSetUrl, json_data.ToString())
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function Main_Recraft_new(yourToken As String, yourProject As String, json_data As String) As String
        Dim operationId As String = String.Empty
        Dim baseSetUrl As String = $"https://api.recraft.ai/project/{yourProject}/queue_recraft"
        Dim responseJson As String = String.Empty
        Try
            'Console.WriteLine(json_data)
            responseJson = Main_Post_AI(yourToken, baseSetUrl, json_data.ToString)
            If responseJson IsNot String.Empty Then
                Dim data As JObject = JObject.Parse(responseJson)
                Try
                    operationId = data("operationId").ToString()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
                Console.WriteLine(operationId)
            End If
            Return operationId
        Catch ex As WebException
            Return operationId
        End Try

    End Function

    Public Shared Function api_poll_recraft(ByVal yourToken As String, ByVal yourProject As String, ByVal operationId As String) As String

        Dim endpoint As String = $"{baseUrl}/{yourProject}/poll_recraft?operation_id={operationId}"
        Return Main_Get_AI(yourToken, endpoint)

    End Function



    'Public Shared Function Main_Recraft_new(yourToken As String, yourProject As String, json_data As String) As String
    '    Dim operationId As String = String.Empty
    '    Try
    '        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl & "/" & yourProject & "/queue_recraft"), HttpWebRequest)
    '        request.Method = "POST"
    '        request.Headers.Add("Authorization", "Bearer " & yourToken)
    '        request.ContentType = "application/json"
    '        Using streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
    '            streamWriter.Write(json_data)
    '        End Using
    '        Try
    '            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
    '            If response.StatusCode = HttpStatusCode.OK Then
    '                Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
    '                    Dim responseJson As String = streamReader.ReadToEnd()
    '                    Dim data As JObject = JObject.Parse(responseJson)
    '                    operationId = data("operationId").ToString()
    '                    Console.WriteLine(operationId)
    '                End Using
    '            Else
    '                Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
    '                    Dim responseJson As String = streamReader.ReadToEnd()
    '                    Console.WriteLine(responseJson)
    '                End Using
    '            End If
    '        Catch ex As WebException
    '            Using streamReader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
    '                Dim responseJson As String = streamReader.ReadToEnd()
    '                Console.WriteLine(responseJson)
    '            End Using

    '        End Try
    '        Return operationId
    '        Console.ReadLine()
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '        Return operationId
    '    End Try
    'End Function


    Public Shared Function download_file(ByVal yourToken As String, ByVal yourProject As String, ByVal url As String) As Stream

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        ' Set headers
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        request.Headers.Add("sec-ch-ua-platform", """Windows""")
        request.ContentType = "application/json"
        Dim RTN_stream As Stream = Nothing
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            RTN_stream = response.GetResponseStream()
            If response.StatusCode = HttpStatusCode.OK Then
                Return response.GetResponseStream()
            Else
                Return response.GetResponseStream()
            End If
        Catch ex As Exception
            Console.WriteLine($"download_file_check Error : {ex.Message}")
            Return RTN_stream
        End Try

    End Function


    Public Shared Function download_file(ByVal yourToken As String, ByVal yourProject As String, ByVal url As String, ByVal output_path As String) As HttpStatusCode

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        ' Set headers
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        request.Headers.Add("sec-ch-ua-platform", """Windows""")
        request.ContentType = "application/json"

        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New BinaryReader(response.GetResponseStream())
                    Using fileWriter As New FileStream(output_path, FileMode.Create)
                        Dim buffer(4096) As Byte
                        Dim bytesRead As Integer
                        Do
                            bytesRead = streamReader.Read(buffer, 0, buffer.Length)
                            If bytesRead > 0 Then
                                fileWriter.Write(buffer, 0, bytesRead)
                            End If
                        Loop While bytesRead > 0
                    End Using
                End Using
                Return HttpStatusCode.OK
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
                Return HttpStatusCode.InternalServerError
            End If
        Catch ex As Exception
            Console.WriteLine($"File Error : {ex.Message}")
            Return HttpStatusCode.InternalServerError
        End Try

    End Function

    Public Shared Function CheckImage_Format(stream As Stream) As String
        Try
            Dim svgSignature As Byte() = New Byte() {60, 115, 118, 103} ' Signature for SVG: <svg
            Dim jpgSignature As Byte() = New Byte() {255, 216, 255, 224} ' Signature for JPG: ÿØÿà

            Dim buffer As Byte() = New Byte(3) {}
            stream.Read(buffer, 0, 4)

            If buffer.SequenceEqual(svgSignature) Then
                Console.WriteLine($"CheckImage_Format  SVG  ")
                Return "svg"
            Else
                Console.WriteLine($"CheckImage_Format  IMG ")
                Return "png"
            End If

        Catch ex As Exception
            Console.WriteLine($"CheckImage_Format Error : {ex.Message}")
        End Try
        Return "png"
    End Function


    Public Shared Function find_recraft_images(type As String, filter As String, imageTypes As List(Of String), limit As Integer, offset As Integer) As JObject
        ' Define the JSON data
        Dim requestData As New JObject()
        requestData.Add("type", type)
        requestData.Add("filter", filter)
        If imageTypes.Count > 0 Then
            Dim imageTypesArray As New JArray()
            For Each imageType In imageTypes
                imageTypesArray.Add(imageType)
            Next
            requestData.Add("image_types", imageTypesArray)
        End If

        requestData.Add("limit", limit)
        requestData.Add("offset", offset)

        'Dim type As String = "community"
        'Dim filter As String = "capital"
        'Dim imageTypes As New List(Of String)()
        'imageTypes.Add("digital_illustration_glow")
        'imageTypes.Add("digital_illustration")
        'Dim limit As Integer = 50
        'Dim offset As Integer = 0
        ' Return the created JObject
        Return requestData
    End Function

    Public Shared Function CreateJsonObject(
                                           ByVal prompt As String, ByVal negativePrompt As String,
                                           ByVal complexities As String,
                                           ByVal mixedPresets As List(Of KeyValuePair(Of String, Double)),
                                           ByVal colors As List(Of Integer()),
                                           ByVal backgroundColor As List(Of Integer()),
                                           ByVal imageType As String, ByVal layerHeight As Integer,
                                           ByVal layerWidth As Integer, ByVal randomSeed As Long
                                           ) As String

        ' Create a JObject for the entire data structure
        Dim jsonObject As New JObject()
        ' Add values for transform, prompt, and negative_prompt
        jsonObject.Add("transform", "prompt_to_image")
        jsonObject.Add("prompt", prompt)
        'If negativePrompt IsNot String.Empty Then
        '    jsonObject.Add("negative_prompt", negativePrompt)
        'Else
        '    jsonObject.Add("negative_prompt", "")
        'End If

        jsonObject.Add("negative_prompt", "")
        ' Create a JObject for user_controls
        Dim userControls As New JObject()
        If complexities IsNot Nothing Then
            userControls.Add("complexity", Integer.Parse(complexities))
        End If
        ' Create a JObject for mixed_presets
        Dim mixedPresetsObject As New JObject()
        ' Check and add mixed_presets if not null
        If mixedPresets IsNot Nothing AndAlso mixedPresets.Count > 0 Then
            For Each preset In mixedPresets
                mixedPresetsObject.Add(preset.Key, preset.Value)
            Next
        End If
        ' Check if mixedPresetsObject is not empty before adding it
        If mixedPresetsObject.HasValues Then
            userControls.Add("mixed_presets", mixedPresetsObject)
        End If

        ' Create a JArray for colors
        Dim colorsArray As New JArray()
        ' Check and add colors if not null
        If colors IsNot Nothing AndAlso colors.Count > 0 Then
            For Each colorRgb In colors
                Dim color As New JObject()
                color.Add("rgb", New JArray(colorRgb))
                colorsArray.Add(color)
            Next
        End If

        ' Check if colorsArray is not empty before adding it
        If colorsArray.Count > 0 Then
            userControls.Add("colors", colorsArray)
        End If
        ' Create a JArray for background_color
        Dim backgroundColorArray As New JArray()
        ' Check and add background_color if not null
        If backgroundColor IsNot Nothing AndAlso backgroundColor.Count > 0 Then
            Dim color As New JObject()
            color.Add("rgb", New JArray(backgroundColor))
            userControls.Add("background_color", color)
            Console.WriteLine(userControls.ToString)
        End If
        ' Add user_controls to the main jsonObject
        jsonObject.Add("user_controls", userControls)
        ' Add the remaining properties
        jsonObject.Add("image_type", imageType)
        ' Create a JObject for layer_size
        Dim layerSize As New JObject()
        layerSize.Add("height", layerHeight)
        layerSize.Add("width", layerWidth)
        jsonObject.Add("layer_size", layerSize)

        jsonObject.Add("style_refs", New JArray())
        jsonObject.Add("prompt_to_image_params", New JObject() From {{"styleRefs", New JArray()}})
        ' Add the random_seed
        jsonObject.Add("random_seed", randomSeed)

        ' Return the fully constructed JObject
        Return jsonObject.ToString
    End Function




End Class
