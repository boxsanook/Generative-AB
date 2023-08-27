Module Programs
    Public Sub Main()
        'ProcessCount.Main_ProcessCount()
        If RegistryB.GetValueFromRegistry("Cliente_ID") IsNot Nothing Then
            ProcessCount.Main_ProcessCount()
            If RegistryB.Check_register_app("regit") = True Then
                Application.Run(New FRM_Main())
            Else
                Application.Run(New FRM_Register())
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
