Imports System.IO

Public Class FilesInFolder
    Public Shared Function CheckFile(filePath As String) As Boolean
        If File.Exists(filePath) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Sub CheckNewDirectory(output_folder As String)
        If Not Directory.Exists(output_folder) Then
            Directory.CreateDirectory(output_folder)
        End If
    End Sub


    Public Shared Function ReadImageFilesInFolder(folderPath As String) As List(Of String)
        Dim allowedExtensions As String() = {".jpg", ".jpeg", ".png", ".svg"}
        Dim imageFiles As New List(Of String)()

        If Directory.Exists(folderPath) Then
            Dim directoryInfo As New DirectoryInfo(folderPath)

            For Each fileInfo As FileInfo In directoryInfo.GetFiles()
                Dim extension As String = fileInfo.Extension.ToLower()
                If allowedExtensions.Contains(extension) Then
                    imageFiles.Add(fileInfo.FullName)
                End If
            Next
        End If

        Return imageFiles
    End Function

    Private Function GetImageFilesFromDirectory(directoryPath As String) As List(Of String)
        Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".svg", ".webp", ".heic", ".raw", ".psd", ".ai", ".eps"}

        Dim imageFiles As New List(Of String)()

        Try
            Dim files As String() = Directory.GetFiles(directoryPath, "*.*")
            For Each file As String In files
                Dim extension As String = Path.GetExtension(file)
                If imageExtensions.Contains(extension.ToLower()) Then
                    imageFiles.Add(file)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return imageFiles
    End Function

End Class
