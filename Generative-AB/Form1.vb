Imports System.Reflection
Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataToEncrypt As String = "This is the data to encrypt."
        Dim encryptionKey As String = "MyEncryptionKey" ' Replace this with your actual encryption key


        Dim combinedDataBase64 As String = CryptographyZ.Encrypt(dataToEncrypt, encryptionKey)

        TextBox1.Text = combinedDataBase64
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim encryptionKey As String = "MyEncryptionKey" ' Replace this with your actual encryption key


        TextBox1.Text = CryptographyZ.Decrypt(TextBox1.Text, encryptionKey)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mutexName As String = "MyAppMutex" ' Choose a unique name for your mutex
        Dim mutex As Mutex = Nothing
        Dim isAnotherInstanceRunning As Boolean = False

        Try
            mutex = New Mutex(True, mutexName, isAnotherInstanceRunning)

            If isAnotherInstanceRunning Then
                Console.WriteLine("Another instance of the application is already running.")
            Else
                Console.WriteLine("This is the first instance of the application.")
                ' Your application logic goes here
            End If
        Finally
            If mutex IsNot Nothing Then
                mutex.ReleaseMutex()
                mutex.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim assembly As Assembly = Assembly.GetEntryAssembly()
        Dim appName As String = assembly.GetName().Name
        Console.WriteLine("Application Name: " & appName)
        Console.ReadLine()
        Dim mutexName As String = appName ' Choose a unique name for your mutex
        Dim mutex As Mutex = Nothing
        Dim isAnotherInstanceRunning As Boolean = False

        Try
            mutex = New Mutex(True, mutexName, isAnotherInstanceRunning)

            If isAnotherInstanceRunning Then
                Console.WriteLine("Another instance of the application is already running.")
            Else
                Console.WriteLine("This is the first instance of the application.")
                ' Your application logic goes here
            End If
        Finally
            If mutex IsNot Nothing Then
                mutex.ReleaseMutex()
                mutex.Close()
            End If
        End Try
    End Sub
End Class
