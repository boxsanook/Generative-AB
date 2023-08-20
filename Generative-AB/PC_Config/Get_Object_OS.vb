Imports System.Management
Imports Microsoft.Win32

Public Class Get_Object_OS


    Public Shared Function CIM_SystemWin32(Win32_x As String, xvalue As String) As String
        Try

            Dim values_rtn As String = Nothing

            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM " & Win32_x)
            Dim ix As Integer = 0
            For Each queryObj As ManagementObject In searcher.Get()
                For Each item As PropertyData In queryObj.Properties()
                    Try
                        If item.Name = xvalue Then
                            values_rtn = item.Value
                            Exit For
                        End If
                    Catch ex As Exception

                    End Try
                Next
                If values_rtn <> Nothing Then
                    Exit For
                End If
            Next
            Return values_rtn

        Catch ex As Exception
            Return ""
        End Try

    End Function


    Public Shared Function FN_LocalMachine(HKEY As String, LocalMachine_key As String) As DataTable
        Dim FileDirectory As New DataTable
        FileDirectory.Columns.Add(New DataColumn("Value_Name", GetType(String)))
        FileDirectory.Columns.Add(New DataColumn("Data", GetType(String)))
        Try
            Dim key As RegistryKey
            If HKEY = "HKEY_CURRENT_USER" Then
                key = Registry.CurrentUser.OpenSubKey(LocalMachine_key)
            ElseIf HKEY = "HKEY_LOCAL_MACHINE" Then
                key = Registry.LocalMachine.OpenSubKey(LocalMachine_key)
            ElseIf HKEY = "HKEY_USERS" Then
                key = Registry.Users.OpenSubKey(LocalMachine_key)
            Else
                Return FileDirectory
            End If


            If key IsNot Nothing Then
                For Each _skName As String In key.GetValueNames
                    Dim o_value As Object = key.GetValue(_skName.ToString)
                    If o_value IsNot Nothing Then
                        FileDirectory.Rows.Add(_skName.ToString, o_value)
                    End If
                Next
            End If

            Return FileDirectory
        Catch ex As Exception
            Return FileDirectory
        End Try

    End Function
    Public Shared Function SystemWin32(Win32_x As String, xvalue As String) As String
        Try
            Dim value As String = ""
            Dim baseBoard As ManagementClass = New ManagementClass(Win32_x)
            Dim board As ManagementObjectCollection = baseBoard.GetInstances()
            If board.Count > 0 Then
                value = board(0)(xvalue)
                If value.Length > 0 Then
                    value = value.ToString
                End If
            End If
            Return value

        Catch ex As Exception
            Return ""
        End Try

    End Function
    Public Shared Function Get_CIMV2_Object(Searcher_Obj As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM " & Searcher_Obj)
            For Each queryObj As ManagementObject In searcher.Get()
                For Each item As PropertyData In queryObj.Properties()
                    Try
                        dt.Columns.Add(item.Name)
                    Catch ex As Exception
                    End Try
                Next
                Exit For
            Next
            Dim ix As Integer = 0
            For Each queryObj As ManagementObject In searcher.Get()
                Dim dr As DataRow = dt.NewRow
                For Each item As PropertyData In queryObj.Properties()
                    Try
                        dr(item.Name) = item.Value

                    Catch ex As Exception

                    End Try
                Next

                dt.Rows.Add(dr)
            Next
            Return dt
        Catch ex As Exception
            Return dt
        End Try

    End Function

End Class
