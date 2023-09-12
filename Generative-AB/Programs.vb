

Imports System.Deployment.Application
Imports System.Reflection

Module Programs
    Public Sub Main()
        Try
            If ApplicationDeployment.IsNetworkDeployed Then
                Dim publishedVersion As Version = ApplicationDeployment.CurrentDeployment.CurrentVersion
                Dim versionString As String = publishedVersion.ToString()
                Console.WriteLine("Published Version: " & versionString)

            Else
                Dim version As Version = Assembly.GetEntryAssembly().GetName().Version
                Dim publishedVersion As String = version.ToString()
                Console.WriteLine("Published Version: " & publishedVersion)
                Console.WriteLine("This application is not ClickOnce deployed.")
                'If Get_Object_OS.CIM_SystemWin32("CIM_BIOSElement", "SerialNumber") = "M4NRCX002458134" Then
                '    API_register.WEB_Register = "http://127.0.0.1/My_API/"
                'End If

            End If


            'ProcessCount.Main_ProcessCount()
            If RegistryB.GetValueFromRegistry("Cliente_ID") IsNot Nothing Then
                ProcessCount.Main_ProcessCount()

                If RegistryB.Check_register_app("regit") = True Then

                    If RegistryB.GetValueFromRegistry("ConfigName") IsNot Nothing Then
                        ModuleSQLconfig.GetSQLSetting()
                        Application.Run(New FRM_Main())
                    Else
                        Application.Run(New FRM_Main_SettingSQL())
                    End If

                Else
                    If RegistryB.none_register_app("regit") = True Then

                        If RegistryB.GetValueFromRegistry("ConfigName") IsNot Nothing Then
                            ModuleSQLconfig.GetSQLSetting()
                            Application.Run(New FRM_Main())
                        Else
                            Application.Run(New FRM_Main_SettingSQL())
                        End If
                    Else
                        MessageBox.Show("ไม่สามารถลงทะเบียนได้โปรดติดต่อ ผู้ให้บริการ" & vbNewLine & "Unable to register, please contact service provider.", "Unable to register !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Application.Run(New AboutBoxMe())
                    End If
                End If
            Else
                If RegistryB.none_register_app("New") = True Then
                    MessageBox.Show("service Not Active.", "Unable to register !!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Process.Start(Application.StartupPath)
                    Application.Restart()
                Else
                    Application.Run(New FRM_Register())
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "service Not Active.!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Process.Start(Application.StartupPath)
        End Try



    End Sub
End Module
