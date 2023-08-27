Imports System
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Web

Public Class TripleDES_xBox
    Public tripleDESStr As String = "TripleDES"
    Public Key64String As String = "Taqz+rpX5TW1XGpXdWNA/PigxpP8zfgi"
    Public IV64String As String = "TXlJVjEyMwA="

    Public Sub New()

    End Sub
    Public Shared Function ConvertToKey64String(inputString As String) As String
        Dim Convert_key As String = Nothing
        Try
            Dim salt As Byte() = {1, 2, 3, 4, 5, 6, 7, 8} ' Example salt 
            Dim keyGenerator As New Rfc2898DeriveBytes(inputString, salt, 10000)
            Dim keyBytes24 As Byte() = keyGenerator.GetBytes(24) ' 24 bytes for 3DES key
            Convert_key = Convert.ToBase64String(keyBytes24)
            Console.WriteLine("Key Encoded String: " + Convert.ToBase64String(keyBytes24))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ConvertToKey64String", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Convert_key


    End Function
    Public Shared Function ConvertToIV64String(inputString As String, Optional length As Integer = 8) As String
        Dim Convert_IV As String = Nothing
        Try
            Dim encoding As Encoding = Encoding.UTF8
            Dim byteArray As Byte() = encoding.GetBytes(inputString)

            ' Ensure the byte array is the desired length
            If byteArray.Length < length Then
                Dim paddedBytes(length - 1) As Byte
                byteArray.CopyTo(paddedBytes, 0)
                byteArray = paddedBytes
            ElseIf byteArray.Length > length Then
                Array.Resize(byteArray, length)
            End If
            Convert_IV = Convert.ToBase64String(byteArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ConvertToIV64String", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Convert_IV
    End Function

    Public Function xDecrypt(ByVal encryptedData As String) As String

        ' URL Decoding
        Dim decodedString As String = HttpUtility.UrlDecode(encryptedData)
        Console.WriteLine(decodedString) ' Output: Hello World!
        encryptedData = decodedString
        Dim decryptedText As String = Nothing
        Try
            Dim key As Byte() = Convert.FromBase64String(Key64String)
            Dim iv As Byte() = Convert.FromBase64String(IV64String)

            Dim tripleDes As New TripleDESCryptoServiceProvider()
            tripleDes.Key = key
            tripleDes.IV = iv
            tripleDes.Padding = PaddingMode.PKCS7
            Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedData)
            Dim decryptor As ICryptoTransform = tripleDes.CreateDecryptor()
            Dim decryptedBytes As Byte() = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)

            decryptedText = Encoding.UTF8.GetString(decryptedBytes)
            Return decryptedText
        Catch ex As Exception
            MsgBox(ex.Message)
            Return decryptedText
        End Try
    End Function

    Public Function xEncrypt(ByVal strToEncrypt As String) As String
        Dim sa As SymmetricAlgorithm = SymmetricAlgorithm.Create(tripleDESStr)
        sa.Key = Convert.FromBase64String(Key64String)
        sa.IV = Convert.FromBase64String(IV64String)

        Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strToEncrypt)
        Dim mS As MemoryStream = New MemoryStream()

        Dim trans As ICryptoTransform = sa.CreateEncryptor
        Dim buf() As Byte = New Byte(2048) {}
        Dim cs As CryptoStream = New CryptoStream(mS, trans, CryptoStreamMode.Write)
        cs.Write(inputByteArray, 0, inputByteArray.Length)
        cs.FlushFinalBlock()
        ' URL Encoding
        Dim encodedString As String = HttpUtility.UrlEncode(Convert.ToBase64String(mS.ToArray).ToString)
        Console.WriteLine(encodedString) ' Output: Hello%20World%21

        Return encodedString
    End Function


End Class