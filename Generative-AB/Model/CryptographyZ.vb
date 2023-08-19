
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Public Class CryptographyZ
    Public Shared Function MD5Hash(ByVal value As String) As String
        Return GetMD5Hash(value)
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        Try
            Dim iv As Byte() = New Byte(7) {}
            Using rng As New RNGCryptoServiceProvider()
                rng.GetBytes(iv)
            End Using

            Dim encryptedBytes As Byte() = EncryptData(stringToEncrypt, key, iv)
            Dim combinedData As Byte() = New Byte(iv.Length + encryptedBytes.Length - 1) {}
            iv.CopyTo(combinedData, 0)
            encryptedBytes.CopyTo(combinedData, iv.Length)

            Return Convert.ToBase64String(combinedData)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Try
            Dim combinedData As Byte() = Convert.FromBase64String(encryptedString)
            Dim iv As Byte() = New Byte(7) {}
            Array.Copy(combinedData, iv, iv.Length)
            Dim encryptedBytes As Byte() = New Byte(combinedData.Length - iv.Length - 1) {}
            Array.Copy(combinedData, iv.Length, encryptedBytes, 0, encryptedBytes.Length)

            Return DecryptData(encryptedBytes, key, iv)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function EncryptMD5(ByVal encryptedString As String) As String
        Try
            Return GetMD5Hash(encryptedString)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function GenerateSHA256String(ByVal inputString As String) As String
        Using sha256 As SHA256 = SHA256Managed.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim stringBuilder As New StringBuilder()

            For i As Integer = 0 To hash.Length - 1
                stringBuilder.Append(hash(i).ToString("x2"))
            Next

            Return stringBuilder.ToString()
        End Using
    End Function

    Public Shared Function GenerateSHA512String(ByVal inputString As String) As String
        Using sha512 As SHA512 = SHA512Managed.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
            Dim hash As Byte() = sha512.ComputeHash(bytes)
            Dim stringBuilder As New StringBuilder()

            For i As Integer = 0 To hash.Length - 1
                stringBuilder.Append(hash(i).ToString("x2"))
            Next

            Return stringBuilder.ToString()
        End Using
    End Function

    Public Shared Function GenerateMD5(ByVal inputString As String) As String
        Return GetMD5Hash(inputString)
    End Function

    Public Shared Function CheckMD5(ByVal Keyword1 As String, ByVal Keyword2 As String) As Boolean
        Dim inputHash As String = GetMD5Hash(Keyword1)
        Return String.Equals(inputHash, Keyword2)
    End Function

    Private Shared Function GetMD5Hash(ByVal input As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Dim stringBuilder As New StringBuilder()

            For i As Integer = 0 To hashBytes.Length - 1
                stringBuilder.Append(hashBytes(i).ToString("x2"))
            Next

            Return stringBuilder.ToString()
        End Using
    End Function

    Private Shared Function EncryptData(data As String, key As String, iv As Byte()) As Byte()
        Using desAlg As New TripleDESCryptoServiceProvider()
            desAlg.Key = GetMD5HashBytes(key)
            desAlg.IV = iv
            desAlg.Mode = CipherMode.CBC
            desAlg.Padding = PaddingMode.PKCS7

            Using encryptor As ICryptoTransform = desAlg.CreateEncryptor(desAlg.Key, desAlg.IV)
                Using msEncrypt As New MemoryStream()
                    Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                        Using swEncrypt As New StreamWriter(csEncrypt)
                            swEncrypt.Write(data)
                        End Using
                    End Using
                    Return msEncrypt.ToArray()
                End Using
            End Using
        End Using
    End Function

    Private Shared Function DecryptData(data As Byte(), key As String, iv As Byte()) As String
        Using desAlg As New TripleDESCryptoServiceProvider()
            desAlg.Key = GetMD5HashBytes(key)
            desAlg.IV = iv
            desAlg.Mode = CipherMode.CBC
            desAlg.Padding = PaddingMode.PKCS7

            Using decryptor As ICryptoTransform = desAlg.CreateDecryptor(desAlg.Key, desAlg.IV)
                Using msDecrypt As New MemoryStream(data)
                    Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                        Using srDecrypt As New StreamReader(csDecrypt)
                            Return srDecrypt.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Shared Function GetMD5HashBytes(ByVal input As String) As Byte()
        Using md5 As MD5 = MD5.Create()
            Return md5.ComputeHash(Encoding.UTF8.GetBytes(input))
        End Using
    End Function

End Class
