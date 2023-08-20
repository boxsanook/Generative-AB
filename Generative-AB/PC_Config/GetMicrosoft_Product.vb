Imports System.Management
Imports Microsoft.Win32

Class GetMicrosoft_Product


    Public Shared Function Object_query(_SELEC As String) As ManagementObjectSearcher
        Try
            Dim scope As New ManagementScope("\\.\root\CIMV2")
            ' Create a new ObjectQuery object with the printer query
            Dim query As New ObjectQuery(_SELEC)
            ' Create a new ManagementObjectSearcher object and set its scope and query
            Return New ManagementObjectSearcher(scope, query)
        Catch ex As Exception
            ' Create a new ManagementScope object for the root\CIMV2 namespace
            Return New ManagementObjectSearcher(_SELEC)

        End Try
    End Function

    Public Shared Function GetSelect(ByVal _SELEC As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim searcher = GetMicrosoft_Product.Object_query(_SELEC)
            For Each queryObj As ManagementObject In searcher.Get()
                If dataTable.Columns.Count = 0 Then
                    For Each prop As PropertyData In queryObj.Properties
                        dataTable.Columns.Add(prop.Name)
                    Next
                End If
                Dim row As DataRow = dataTable.NewRow()
                For Each prop As PropertyData In queryObj.Properties
                    If prop.Value IsNot Nothing Then
                        Dim obj As Object = prop.Value
                        If obj.GetType() Is GetType(String()) Then
                            Dim array() As String = prop.Value
                            Dim valuex As String = String.Join(",", array)
                            row(prop.Name) = valuex
                            ' do something with the array
                        ElseIf TypeOf obj Is Array AndAlso obj.GetType().GetElementType() Is GetType(UInt16) Then
                            Dim uint16Array() As UInt16 = prop.Value
                            Dim uint16String As String = String.Join(",", uint16Array.Select(Function(u) u.ToString("X4")))
                            row(prop.Name) = uint16String

                        Else
                            row(prop.Name) = prop.Value.ToString
                        End If
                    Else
                        row(prop.Name) = prop.Value.ToString
                    End If


                Next
                dataTable.Rows.Add(row)
            Next
            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return dataTable
        End Try
    End Function

    Public Shared Function GetWindowsProductKey() As String
        Dim productKey As String = String.Empty

        Try
            Dim query As New SelectQuery("SELECT * FROM SoftwareLicensingService")
            Dim searcher As New ManagementObjectSearcher(query)
            Dim managementObjects As ManagementObjectCollection = searcher.Get()
            For Each managementObject As ManagementObject In managementObjects
                productKey = managementObject("OA3xOriginalProductKey").ToString()
            Next
        Catch ex As Exception
            ' Handle any exceptions that occur during the process
            Console.WriteLine("Error retrieving Windows product key: " & ex.Message)
        End Try

        Return productKey
    End Function



End Class
