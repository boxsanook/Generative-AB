Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class TEST
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Function PerformCryptography(input As Byte(), transform As ICryptoTransform) As Byte()
        Using ms As New MemoryStream()
            Using cryptoStream As New CryptoStream(ms, transform, CryptoStreamMode.Write)
                cryptoStream.Write(input, 0, input.Length)
            End Using
            Return ms.ToArray()
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tdes As New TripleDES()
        Dim vbEncrypted = tdes.xEncrypt(TextBox1.Text)
        TextBox2.Text = vbEncrypted

        Dim phpEncrypted = TextBox3.Text
        TextBox4.Text = tdes.xDecrypt(phpEncrypted)

        Debug.Print("PHP Encrypted: " & phpEncrypted)
        Debug.Print("VB Encrypted: " & vbEncrypted)
        Debug.Print("PHP Encrypted (decrypted result): " & tdes.xDecrypt(phpEncrypted))
        Debug.Print("VB Encrypted (decrypted result): " & tdes.xDecrypt(vbEncrypted))

        'Dim inputString As String = "Hello, World!"
        '' Convert the string to a byte array using a specific encoding (e.g., UTF-8)
        'Dim encoding As Encoding = Encoding.UTF8
        'Dim byteArray As Byte() = encoding.GetBytes(inputString)
        '' Print the byte array
        'Console.WriteLine("Byte Array: " + BitConverter.ToString(byteArray))

        'Dim base64String As String = Convert.ToBase64String(byteArray)
        'Console.WriteLine("Base64 Encoded String: " + base64String)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim ivString As String = "Iboxs.Me" ' Example IV string

        '' Convert the string to bytes using a specific encoding (e.g., UTF-8)
        'Dim encoding As Encoding = Encoding.UTF8
        'Dim ivBytes As Byte() = encoding.GetBytes(ivString)

        '' Ensure the byte array is 8 bytes long
        'If ivBytes.Length < 8 Then
        '    Dim paddedBytes(7) As Byte
        '    ivBytes.CopyTo(paddedBytes, 0)
        '    ivBytes = paddedBytes
        'ElseIf ivBytes.Length > 8 Then
        '    Array.Resize(ivBytes, 8)
        'End If

        '' Print the byte array
        'Console.WriteLine("IV Byte Array: " + BitConverter.ToString(ivBytes))
        'Dim base64String As String = Convert.ToBase64String(ivBytes)
        'Console.WriteLine("Base64 Encoded String: " + base64String)


        Dim keyString As String = "MyKey456" ' Example key string
        Dim ivString As String = "MyIV123"   ' Example IV string

        ' Convert key and IV strings to 8-byte arrays
        Dim keyBytes As String = TripleDES.ConvertToKey64String(keyString)
        Dim ivBytes As String = TripleDES.ConvertToIV64String(ivString)

        Console.WriteLine("Key Encoded String: " + keyBytes)
        Console.WriteLine("IV Encoded String: " + ivBytes)
        'If keyBytes IsNot Nothing AndAlso ivBytes IsNot Nothing Then
        '    Try
        '        ' Create a TripleDES instance
        '        Using tripleDesAlg As SymmetricAlgorithm = SymmetricAlgorithm.Create("TripleDES")
        '            ' Set the key and IV
        '            tripleDesAlg.Key = keyBytes
        '            tripleDesAlg.IV = ivBytes

        '            ' Now you can use tripleDesAlg for your encryption/decryption logic
        '            Console.WriteLine("TripleDES Algorithm: " + tripleDesAlg.ToString())
        '        End Using
        '    Catch ex As Exception
        '        Console.WriteLine("Error: " + ex.Message)
        '    End Try
        'End If

        'Dim password As String = "MySecretPassword"
        'Dim salt As Byte() = {1, 2, 3, 4, 5, 6, 7, 8} ' Example salt

        'Dim keyGenerator As New Rfc2898DeriveBytes(ivString, salt, 10000)
        'Dim keyBytes24 As Byte() = keyGenerator.GetBytes(24) ' 24 bytes for 3DES key
        'Console.WriteLine("Key Encoded String: " + Convert.ToBase64String(keyBytes24))
    End Sub
End Class