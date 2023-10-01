Imports System.Deployment.Application
Imports System.Net
Imports System.Reflection

Class ProcessCount
    Shared assembly As Assembly = Assembly.GetEntryAssembly()
    Shared appName As String = assembly.GetName().Name
    Public Shared Sub Main_ProcessCount()
        Dim processes As Process() = Process.GetProcessesByName(appName)
        Dim processCount As Integer = processes.Length
        Dim CountP As Integer = 1
        If ApplicationDeployment.IsNetworkDeployed Then
            CountP = 1
        Else
            CountP = 3
        End If
        If processCount > CountP Then
            MessageBox.Show($"Application is already running. {vbNewLine}Please press the ok button to exit the system.", "Already running.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If
        Console.WriteLine($"Number of running processes with name '{appName}': {processCount}")
        Console.ReadLine()
    End Sub

End Class
