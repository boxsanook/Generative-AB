Imports System
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography

Public Class TripleDES
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

    Public Function xDecrypt(ByVal strToDecrypt As String) As String
        Try
            'initialize our key
            'https://bytes.com/topic/php/answers/873350-encrypt-vb-net-decrypt-php-vice-versa
            Dim tripleDESKey As SymmetricAlgorithm = SymmetricAlgorithm.Create(tripleDESStr)
            tripleDESKey.Key = Convert.FromBase64String(Key64String)
            tripleDESKey.IV = Convert.FromBase64String(IV64String)

            'load our encrypted value into a memory stream
            Dim encryptedValue As String = strToDecrypt
            Dim encryptedStream As MemoryStream = New MemoryStream()
            encryptedStream.Write(Convert.FromBase64String(encryptedValue), 0, Convert.FromBase64String(encryptedValue).Length)
            encryptedStream.Position = 0

            'set up a stream to do the decryption
            Dim cs As CryptoStream = New CryptoStream(encryptedStream, tripleDESKey.CreateDecryptor, CryptoStreamMode.Read)
            Dim decryptedStream As MemoryStream = New MemoryStream()
            Dim buf() As Byte = New Byte(2048) {}
            Dim bytesRead As Integer

            'keep reading from encrypted stream via the crypto stream
            'and store that in the decrypted stream
            bytesRead = cs.Read(buf, 0, buf.Length)
            While (bytesRead > 0)
                decryptedStream.Write(buf, 0, bytesRead)
                bytesRead = cs.Read(buf, 0, buf.Length)
            End While
            'reassemble the decrypted stream into a string    
            Dim decryptedValue As String = Encoding.UTF8.GetString(decryptedStream.ToArray())
            Return (decryptedValue.ToString())
        Catch ex As Exception
            MsgBox(ex.Message)
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

        Return Convert.ToBase64String(mS.ToArray).ToString
    End Function


End Class