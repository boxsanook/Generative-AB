Imports Microsoft.Win32
Public Class RegistryB
    Public Shared ProductCode As String = "94608-a0d84-63ea3-4651b-a3110-a5271-f5e2d-fb78d"
    Public Shared userRoot As String = "Software\" & ProductCode

    Public Shared Sub SaveValueToRegistry(ByVal valueName As String, ByVal valueData As String)
        Using registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(userRoot)
            registryKey.SetValue(valueName, valueData)
        End Using
    End Sub

    Public Shared Function GetValueFromRegistry(valueName As String) As String
        Dim defaultValue As String = Nothing
        Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(userRoot)
            If registryKey IsNot Nothing Then
                Dim value As Object = registryKey.GetValue(valueName, defaultValue)
                Return value.ToString()
            Else
                Return defaultValue
            End If
        End Using
    End Function

End Class
