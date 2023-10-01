Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class recraft_ai

    Public Shared baseUrl As String = "https://api.recraft.ai/project"

    Public Shared Sub SurroundingSub()
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub
    Public Shared Function New_random() As String
        Dim randomDigit As Integer = New Random().Next(100000000, 999999999)
        Return randomDigit
    End Function


    Public Shared Function digital_illustration_80s(prompt As String, negative_prompt As String, random_seed As String, image_type As String, Optional jrgb As String = Nothing) As JObject
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
    Public Shared Function rgbx(jsonData As String) As JObject
        ' Assuming you have imported the required namespaces:
        ' Imports Newtonsoft.Json
        ' Imports Newtonsoft.Json.Linq

        ' Your JSON data
        If jsonData = "" Then
            jsonData = "
            [
                { ""rgb"": [246, 247, 235] },
                { ""rgb"": [2, 112, 4] },
                { ""rgb"": [245, 4, 4] },
                { ""rgb"": [255, 255, 255] },
                { ""rgb"": [255, 255, 255] }
            ]"
        End If

        Dim jsonArray As JArray = JArray.Parse(jsonData)
        Dim colorsArray As JArray = New JArray()

        For Each item As JObject In jsonArray
            Dim rgbArray As JArray = CType(item("rgb"), JArray)
            Dim colorObject As JObject = New JObject()
            colorObject.Add("rgb", rgbArray)
            colorsArray.Add(colorObject)
        Next

        Dim jsonObject As JObject = New JObject()
        Dim userControls As JObject = New JObject()

        userControls.Add("colors", colorsArray)

        jsonObject.Add("user_controls", userControls)

        Dim resultJson As String = jsonObject.ToString()

        Return userControls
        '' The resulting JSON object can be used as needed
        'Dim resultJson As String = jsonObject.ToString()
        'Console.WriteLine(resultJson)

    End Function

    Public Shared Function Main_Recraft(yourToken As String, yourProject As String, negative_prompt As String, prompt As String, random_seed As String, image_type As String, Optional jrgb As String = Nothing) As String
        SurroundingSub()
        Dim operationId As String = String.Empty
        Try

            Dim json_data As JObject = New JObject()
            json_data.Add("transform", "prompt_to_image")
            json_data.Add("prompt", prompt)
            json_data.Add("negative_prompt", "")
            If image_type = "digital_illustration_80s" Then
                json_data.Add("user_controls", {})
            Else
                If jrgb = Nothing Then
                    json_data.Add("user_controls", New JObject() From {
                       {"colors", New JArray(
                           New JObject() From {
                               {"rgb", New JArray(255, 255, 255)}
                           }
                       )}
                   })
                Else
                    json_data.Add("user_controls", rgbx(jrgb))

                End If

            End If

            json_data.Add("image_type", image_type)
            json_data.Add("layer_size", New JObject() From {
                {"height", 768},
                {"width", 768}
            })
            json_data.Add("style_refs", New JArray())
            json_data.Add("prompt_to_image_params", New JObject() From {
                {"styleRefs", New JArray()}
            })

            json_data.Add("random_seed", Convert.ToInt32(random_seed))
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl & "/" & yourProject & "/queue_recraft"), HttpWebRequest)
            request.Method = "POST"
            request.Headers.Add("Authorization", "Bearer " & yourToken)
            request.ContentType = "application/json"

            Using streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json_data.ToString())
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

    Public Shared Function Main_Recraft_new(yourToken As String, yourProject As String, negative_prompt As String, prompt As String, random_seed_01 As String, image_type As String, Optional jrgb As String = Nothing) As String
        SurroundingSub()

        Dim operationId As String = String.Empty
        Try
            Dim json_data As JObject = digital_illustration_80s(prompt, negative_prompt, random_seed_01, image_type, jrgb)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(baseUrl & "/" & yourProject & "/queue_recraft"), HttpWebRequest)
            request.Method = "POST"
            request.Headers.Add("Authorization", "Bearer " & yourToken)
            request.ContentType = "application/json"
            Using streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json_data.ToString())
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


    Public Shared Function api_poll_recraft(ByVal yourToken As String, ByVal yourProject As String, ByVal operationId As String) As String
        Dim responseJson As String = String.Empty
        Dim endpoint As String = $"{baseUrl}/{yourProject}/poll_recraft?operation_id={operationId}"

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(endpoint), HttpWebRequest)
        request.Method = "GET"
        ' Set headers
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        'request.Headers.Add("Referer", "https://app.recraft.ai/")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        'request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36")
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


    Public Shared Function send_remove_bg(ByVal yourToken As String, ByVal yourProject As String, ByVal base64_string As String) As String

        Dim image_id_result As String = String.Empty
        Dim json_data As JObject = New JObject()
        json_data.Add("image", New JObject() From {
            {"data_url", base64_string}
        })
        json_data.Add("return_vector", False)

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create($"{baseUrl}/{yourProject}/remove_background"), HttpWebRequest)
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer " & yourToken)
        request.ContentType = "application/json"

        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(json_data.ToString())
        End Using

        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New StreamReader(response.GetResponseStream())
                    Dim responseJson As String = streamReader.ReadToEnd()
                    Dim data As JObject = JObject.Parse(responseJson)
                    Console.WriteLine($"remove_bg: {data}")
                    image_id_result = data("result")("image_id").ToString()
                    Console.WriteLine(image_id_result)

                    'Dim file_url As String = $"https://api.recraft.ai/project/{yourProject}/image/{image_id_result}"
                    'download_file(yourToken, yourProject, file_url, output_path, filename)
                End Using
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
                Return String.Empty
            End If
            Return image_id_result
        Catch ex As Exception
            Console.WriteLine("Failed to execute remove_bg: " & ex.Message)
            Return image_id_result
        End Try
    End Function

    Public Shared Function save_image_svg(ByVal yourToken As String, ByVal yourProject As String, ByVal base64_string As String, ByVal image_id As String) As String

        Dim image_id_result As String = String.Empty
        Dim json_data As JObject = New JObject()
        json_data.Add("image", New JObject() From {
            {"data_url", base64_string}
        })
        json_data.Add("image_id", New JObject() From {
            {"image_id", image_id}
        })

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create($"{baseUrl}/{yourProject}/vectorize"), HttpWebRequest)
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer " & yourToken)
        request.ContentType = "application/json"

        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(json_data.ToString())
        End Using

        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Using streamReader As New StreamReader(response.GetResponseStream())
                    Dim responseJson As String = streamReader.ReadToEnd()
                    Dim data As JObject = JObject.Parse(responseJson)
                    'Console.WriteLine($"save_img_svg: {data}")
                    image_id_result = data("svg")("image_id").ToString()
                    Console.WriteLine(image_id_result)
                End Using
            Else
                Console.WriteLine(response.StatusCode & ": " & response.StatusDescription)
            End If
            Return image_id_result
        Catch ex As Exception
            Console.WriteLine("Failed to execute save_img_svg: " & ex.Message)
            Return image_id_result
        End Try
    End Function


    Public Shared Function download_svg(ByVal yourToken As String, ByVal url As String, ByVal output_path_svg As String) As HttpStatusCode

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.Headers.Add("Authorization", "Bearer " & yourToken)
        request.ContentType = "application/json"

        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then

                Using streamReader As New StreamReader(response.GetResponseStream())
                    Dim responseText As String = streamReader.ReadToEnd()
                    File.WriteAllText(output_path_svg, responseText)
                End Using

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

    Public Shared Function download_file_checkImage(ByVal yourToken As String, ByVal yourProject As String, ByVal url As String) As Stream

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        ' Set headers
        request.Headers.Add("sec-ch-ua", """Not.A/Brand"";v=""8"", ""Chromium"";v=""114"", ""Google Chrome"";v=""114""")
        request.Headers.Add("sec-ch-ua-mobile", "?0")
        request.Headers.Add("Authorization", $"Bearer {yourToken}")
        request.Headers.Add("sec-ch-ua-platform", """Windows""")
        request.ContentType = "application/json"
        Dim RTN_stream As Stream
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

    Public Shared Function download_file(ByVal yourToken As String, ByVal yourProject As String, ByVal url As String, ByVal output_path As String, ByVal filename As String) As HttpStatusCode

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

                Console.WriteLine($"File downloaded successfully: {filename}")
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
                Return "SVG"
            Else
                Console.WriteLine($"CheckImage_Format  IMG ")
                Return "IMG"
            End If

        Catch ex As Exception
            Console.WriteLine($"CheckImage_Format Error : {ex.Message}")
        End Try

    End Function

    Public Function CheckImageFormat(stream As Stream) As String
        Dim svgSignature As Byte() = New Byte() {60, 115, 118, 103} ' Signature for SVG: <svg
        Dim jpgSignature As Byte() = New Byte() {255, 216, 255, 224} ' Signature for JPG: ÿØÿà

        Dim buffer As Byte() = New Byte(3) {}
        stream.Read(buffer, 0, 4)

        If buffer.SequenceEqual(svgSignature) Then
            Console.WriteLine("Image format: SVG")
            ' Process SVG image
            Using reader As New StreamReader(stream)
                Dim svgContent As String = reader.ReadToEnd()
                ' Do something with the SVG content
                Console.WriteLine("SVG Content:")
                Console.WriteLine(svgContent)
            End Using
        ElseIf buffer.SequenceEqual(jpgSignature) Then
            Console.WriteLine("Image format: JPG")
            ' Process JPG image
            Using memoryStream As New MemoryStream()
                stream.CopyTo(memoryStream)
                Dim jpgBytes As Byte() = memoryStream.ToArray()
                ' Do something with the JPG bytes
                Console.WriteLine("JPG Image Size (bytes): " & jpgBytes.Length.ToString())
            End Using
        Else
            Console.WriteLine("Unsupported image format.")
        End If
    End Function


    Public Function image_2_base64(ByVal file_path As String) As String
        Using image_file As FileStream = File.OpenRead(file_path)
            Dim image_data(image_file.Length - 1) As Byte
            image_file.Read(image_data, 0, image_data.Length)
            Dim base64_data As String = Convert.ToBase64String(image_data)
            Dim base64_string As String = $"data:image/png;base64,{base64_data}"

            Return base64_string
        End Using
    End Function
End Class
