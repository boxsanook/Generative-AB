Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class API_AI
    Private Shared baseUrl As String = "https://api.recraft.ai/project"
    Public Shared Function Post_Request(baseUrl As String, yourToken As String, json_data As JObject) As String
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl), HttpWebRequest)
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer " & yourToken)
        request.ContentType = "application/json"
        Dim RTN_Result As String = String.Empty
        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(json_data.ToString())
        End Using
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New StreamReader(response.GetResponseStream())
                    RTN_Result = streamReader.ReadToEnd()
                End Using
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
                Return String.Empty
            End If
            Return RTN_Result
        Catch ex As Exception
            Console.WriteLine("Failed to execute remove_bg: " & ex.Message)
            Return String.Empty
        End Try
    End Function


    Public Shared Function Get_Request(baseUrl As String, yourToken As String, json_data As JObject) As String
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl), HttpWebRequest)
        request.Method = "GET"
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        request.Headers.Add("sec-ch-ua-platform", """Windows""")
        request.ContentType = "application/json"
        Dim RTN_Result As String = String.Empty
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New StreamReader(response.GetResponseStream())
                    RTN_Result = streamReader.ReadToEnd()
                End Using
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
            End If
            Return RTN_Result
        Catch ex As Exception
            Console.WriteLine("Failed to execute poll_recraft: " & ex.Message)
            Return RTN_Result
        End Try
    End Function




    Public Shared Function digital_Json(prompt As String, negative_prompt As String, random_seed As String, image_type As String, Optional jrgb As String = Nothing) As JObject
        Dim json_data As JObject = New JObject()
        json_data.Add("transform", "prompt_to_image")
        json_data.Add("prompt", prompt)
        json_data.Add("negative_prompt", negative_prompt)
        json_data.Add("user_controls", New JObject())
        json_data.Add("image_type", image_type)
        json_data.Add("layer_size", New JObject() From {
                {"height", 768},
                {"width", 768}
            })
        json_data.Add("style_refs", New JArray())
        json_data.Add("prompt_to_image_params", New JObject() From {
                {"styleRefs", New JArray()}
            })
        json_data.Add("edit_params", New JObject())
        json_data.Add("random_seed", Convert.ToInt32(random_seed))

        ' Add the colors array to user_controls
        'json_data.Add("user_controls", New JObject From {JArray.Parse(jrgb)})


        Return json_data
    End Function

    Public Shared Function CreateJsonObject(
    ByVal prompt As String,
    ByVal negativePrompt As String,
    ByVal complexities As String,
    ByVal mixedPresets As List(Of KeyValuePair(Of String, Double)),
    ByVal colors As List(Of Integer()),
    ByVal backgroundColor As List(Of Integer()), ' Change the parameter to accept a list of backgrounds
    ByVal imageType As String,
    ByVal layerHeight As Integer,
    ByVal layerWidth As Integer,
    ByVal randomSeed As Long
) As JObject
        ' Create a JObject for the entire data structure
        Dim jsonObject As New JObject()

        ' Add values for transform, prompt, and negative_prompt
        jsonObject.Add("transform", "prompt_to_image")
        jsonObject.Add("prompt", prompt)
        jsonObject.Add("negative_prompt", negativePrompt)

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
        jsonObject.Add("prompt_to_image_params", New JObject() From {
        {"styleRefs", New JArray()}
    })

        ' Add the random_seed
        jsonObject.Add("random_seed", randomSeed)

        ' Return the fully constructed JObject
        Return jsonObject
    End Function


    Public Shared Function Recraft_remove_from_history(yourToken As String, ByVal image_id As String)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create($"https://api.recraft.ai/images/{image_id}/reactions"), HttpWebRequest)
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer " & yourToken)
        request.ContentType = "application/json"

        Dim json_data As New JObject
        json_data.Add("reaction", "remove_from_history")
        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(json_data.ToString())
        End Using
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using streamWriter As New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json_data.ToString())
            End Using
            If response.StatusCode = HttpStatusCode.OK Then
                Console.WriteLine($"File downloaded successfully ")
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
            End If
            Return response.StatusCode
        Catch ex As Exception
            Console.WriteLine("Failed to execute download_svg: " & ex.Message)
            Return HttpStatusCode.InternalServerError
        End Try
    End Function


    Public Shared Function Main_Recraft_new(yourToken As String, yourProject As String, json_data As String) As String

        Dim operationId As String = String.Empty
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl & "/" & yourProject & "/queue_recraft"), HttpWebRequest)
            request.Method = "POST"
            request.Headers.Add("Authorization", "Bearer " & yourToken)
            request.ContentType = "application/json"

            Using streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json_data)
            End Using

            Try
                Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

                If response.StatusCode = HttpStatusCode.OK Then
                    Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                        Dim responseJson As String = streamReader.ReadToEnd()
                        Dim data As JObject = JObject.Parse(responseJson)
                        operationId = data("operationId").ToString()
                        Console.WriteLine(operationId)
                    End Using
                Else
                    Using streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                        Dim responseJson As String = streamReader.ReadToEnd()
                        Console.WriteLine(responseJson)
                    End Using
                End If
            Catch ex As WebException
                Using streamReader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
                    Dim responseJson As String = streamReader.ReadToEnd()
                    Console.WriteLine(responseJson)
                End Using

            End Try
            Return operationId
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return operationId
        End Try
    End Function

End Class
