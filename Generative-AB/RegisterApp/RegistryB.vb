Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports Newtonsoft.Json

Public Class RegistryB
    Public Shared ProductCode As String = "94608-a0d84-63ea3-4651b-a3110-a5271-f5e2d-fb78d"
    Public Shared userRoot As String = "Software\" & ProductCode
    Public Shared str_Cliente_ID As String = Nothing
    Public Shared str_sKey As String = Nothing
    Public Shared str_uKey As String = Nothing
    Public Shared str_ExpiryDate As String = Nothing
    Public Shared str_token As String = Nothing
    Public Shared str_projectCode As String = Nothing
    Public Shared str_accessToken As String = Nothing
    Public Shared str_accessTokenExpiresAt As String = Nothing

    Public Shared Sub SaveValueToRegistry(ByVal valueName As String, ByVal valueData As String, Optional SendRoot As String = Nothing)
        If SendRoot = Nothing Then
            SendRoot = userRoot
        End If
        Using registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SendRoot)
            registryKey.SetValue(valueName, valueData)
        End Using
    End Sub

    Public Shared Function GetValueFromRegistry(valueName As String, Optional SendRoot As String = Nothing) As String
        Dim defaultValue As String = Nothing
        Try
            If SendRoot = Nothing Then
                SendRoot = userRoot
            End If

            Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(SendRoot)
                If registryKey IsNot Nothing Then
                    Dim value As Object = registryKey.GetValue(valueName, defaultValue)
                    Return value.ToString()
                Else
                    Return defaultValue
                End If
            End Using
        Catch ex As Exception
            Return defaultValue
        End Try


    End Function

    Public Shared Sub Regit_run(get_by As String)

        If get_by.ToLower = "regit".ToLower Then
            str_Cliente_ID = GetValueFromRegistry("Cliente_ID")
            str_sKey = GetValueFromRegistry("sKey")
            str_uKey = GetValueFromRegistry("uKey")
            str_ExpiryDate = GetValueFromRegistry("Expiry_Date")
            str_token = GetValueFromRegistry("token")
            str_token = BB_Framework_Code.BCryptography.Decrypt(str_token)
            str_token = FilesInFolder.GetInt(str_token)

            str_ExpiryDate = BB_Framework_Code.BCryptography.Decrypt(str_ExpiryDate)
            str_ExpiryDate = str_ExpiryDate.Substring(0, 13)
        ElseIf get_by.ToLower = "new".ToLower Then
            Dim SerialNumber As String = Get_Object_OS.CIM_SystemWin32("CIM_BIOSElement", "SerialNumber")
            If SerialNumber = "" Then
                SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_DiskDrive", "SerialNumber")
            End If
            If SerialNumber = "" Then
                SerialNumber = Get_Object_OS.CIM_SystemWin32("CIM_PhysicalMemory", "SerialNumber")
            End If
            str_Cliente_ID = API_register.RegexCode(SerialNumber)
            str_sKey = API_register.RegexCode(API_register.random_code())
            str_uKey = API_register.RegexCode(API_register.random_code())
            str_token = 100
            Dim dateTime As DateTime = xTime.GetTimeBKK()
            Dim NextMonth As DateTime = dateTime.AddDays(Integer.Parse(15))
            str_ExpiryDate = xTime.tImeConvert(NextMonth.ToString("yyyy-MM-dd HH:mm:ss"))
        End If

    End Sub

    Public Shared Sub accessToken_app(Regit As String)
        Try
            RegistryB.Regit_run(Regit)
            Dim Product_Key1 As String = $"{ProductCode}|{ str_Cliente_ID }|{str_sKey }|"
            Dim Product_Key2 As String = $"{str_uKey}|{str_ExpiryDate}|{str_token}|"
            Product_Key1 = BB_Framework_Code.BCryptography.Encrypt(Product_Key1)
            Product_Key2 = BB_Framework_Code.BCryptography.Encrypt(Product_Key2)
            Dim table As New DataTable
            table.Columns.Add(New DataColumn("Product_Key1", GetType(String)))
            table.Columns.Add(New DataColumn("Product_Key2", GetType(String)))
            table.Rows.Add(Product_Key1, Product_Key2)
            Dim jsonb = API_register.post_api_app("accessToken/showToken.php/accessToken", table)

            Dim response As New With {
                .status = "",
                .message = "",
                .Product_Key1 = "",
                .Product_Key2 = ""
            }

            response = JsonConvert.DeserializeAnonymousType(jsonb, response)
            Console.WriteLine("register_app: " & jsonb.ToString)
            Dim delimiter As Char = "|"c
            If response.status.ToUpper() = "OK" Then
                Product_Key1 = BB_Framework_Code.BCryptography.Decrypt(response.Product_Key1)
                Product_Key2 = BB_Framework_Code.BCryptography.Decrypt(response.Product_Key2)
                Dim Product_Key_1 As String() = Product_Key1.Split(delimiter)
                Dim Product_Key_2 As String() = Product_Key2.Split(delimiter)


                str_projectCode = Product_Key_1(0)
                str_accessTokenExpiresAt = Product_Key_1(1)
                str_accessToken = Product_Key_2(0)



            Else

            End If
        Catch ex As Exception
            Console.WriteLine("ERROR register : " & ex.Message)
        End Try
    End Sub

    Public Shared Function Check_register_app(Regit As String) As Boolean
        Try
            RegistryB.Regit_run(Regit)
            Dim Product_Key1 As String = $"{ProductCode}|{ str_Cliente_ID }|{str_sKey }|"
            Dim Product_Key2 As String = $"{str_uKey}|{str_ExpiryDate}|{str_token}|"
            Product_Key1 = BB_Framework_Code.BCryptography.Encrypt(Product_Key1)
            Product_Key2 = BB_Framework_Code.BCryptography.Encrypt(Product_Key2)
            Dim table As New DataTable
            table.Columns.Add(New DataColumn("Product_Key1", GetType(String)))
            table.Columns.Add(New DataColumn("Product_Key2", GetType(String)))
            table.Rows.Add(Product_Key1, Product_Key2)
            Dim jsonb = API_register.register_app("Check_register_app", table)

            Dim response As New With {
                .status = "",
                .message = "",
                .Product_Key1 = "",
                .Product_Key2 = ""
            }

            response = JsonConvert.DeserializeAnonymousType(jsonb, response)
            Console.WriteLine("register_app: " & jsonb.ToString)
            Dim delimiter As Char = "|"c
            If response.status.ToUpper() = "OK" Then
                Product_Key1 = BB_Framework_Code.BCryptography.Decrypt(response.Product_Key1)
                Product_Key2 = BB_Framework_Code.BCryptography.Decrypt(response.Product_Key2)
                Dim Product_Key_1 As String() = Product_Key1.Split(delimiter)
                Dim Product_Key_2 As String() = Product_Key2.Split(delimiter)

                ProductCode = Product_Key_1(0)
                str_Cliente_ID = Product_Key_1(1)
                str_sKey = Product_Key_1(2)
                str_uKey = Product_Key_2(0)
                str_ExpiryDate = Product_Key_2(1)
                str_token = Product_Key_2(2)

                Console.WriteLine("message register : " & str_ExpiryDate)
                RegistryB.SaveValueToRegistry("Product_Code", Product_Key_1(0))
                RegistryB.SaveValueToRegistry("Cliente_ID", Product_Key_1(1))
                RegistryB.SaveValueToRegistry("sKey", Product_Key_1(2))
                RegistryB.SaveValueToRegistry("uKey", Product_Key_2(0))
                RegistryB.SaveValueToRegistry("Expiry_Date", BB_Framework_Code.BCryptography.Encrypt(str_ExpiryDate))
                RegistryB.SaveValueToRegistry("token", BB_Framework_Code.BCryptography.Encrypt(Product_Key_2(2)))
                'RegistryB.SaveValueToRegistry("Expiry_Date", str_ExpiryDate)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("ERROR register : " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function none_register_app(Regit As String) As Boolean
        Try

            RegistryB.Regit_run(Regit)
            Dim Product_Key1 As String = $"{ProductCode}|{ str_Cliente_ID }|{str_sKey }|"
            Dim Product_Key2 As String = $"{str_uKey}|{str_ExpiryDate}|{str_token}|"
            Product_Key1 = BB_Framework_Code.BCryptography.Encrypt(Product_Key1)
            Product_Key2 = BB_Framework_Code.BCryptography.Encrypt(Product_Key2)


            Dim table As New DataTable
            table.Columns.Add(New DataColumn("Product_Key1", GetType(String)))
            table.Columns.Add(New DataColumn("Product_Key2", GetType(String)))
            table.Rows.Add(Product_Key1, Product_Key2)
            Dim jsonb = API_register.register_app("update_register_app", table)

            Dim response As New With {
                .status = "",
                .message = "",
                .Product_Key1 = "",
                .Product_Key2 = ""
            }

            response = JsonConvert.DeserializeAnonymousType(jsonb, response)
            Console.WriteLine("update_register_app: " & jsonb.ToString)
            Dim delimiter As Char = "|"c
            If response.status.ToUpper() = "OK" Then

                RegistryB.SaveValueToRegistry("Product_Code", ProductCode)
                RegistryB.SaveValueToRegistry("Cliente_ID", str_Cliente_ID)
                RegistryB.SaveValueToRegistry("sKey", str_uKey)
                RegistryB.SaveValueToRegistry("uKey", str_uKey)
                RegistryB.SaveValueToRegistry("Expiry_Date", BB_Framework_Code.BCryptography.Encrypt(str_ExpiryDate))
                RegistryB.SaveValueToRegistry("token", BB_Framework_Code.BCryptography.Encrypt(str_token))
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("ERROR register : " & ex.Message)
            Return False
        End Try
    End Function
End Class
