Module Programs
    Public Sub Main()

        If Get_Object_OS.CIM_SystemWin32("CIM_BIOSElement", "SerialNumber") = "M4NRCX002458134" Then
            API_register.WEB_Register = "http://127.0.0.1/My_API/"
        End If
        'ProcessCount.Main_ProcessCount()
        If RegistryB.GetValueFromRegistry("Cliente_ID") IsNot Nothing Then
            ProcessCount.Main_ProcessCount()
            If RegistryB.Check_register_app("regit") = True Then
                Application.Run(New FRM_Main())
            Else
                If RegistryB.none_register_app("regit") = True Then
                    Application.Run(New FRM_Main())
                Else
                    MessageBox.Show("ไม่สามารถลงทะเบียนได้โปรดติดต่อ ผู้ให้บริการ" & vbNewLine & "Unable to register, please contact service provider.", "Unable to register !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Run(New AboutBoxMe())
                End If
            End If
        Else
            If RegistryB.none_register_app("New") = True Then
                Application.Restart()
            Else
                Application.Run(New FRM_Register())
            End If
        End If


    End Sub
End Module
