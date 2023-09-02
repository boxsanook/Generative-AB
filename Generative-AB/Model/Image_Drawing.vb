Public Class Image_Drawing
    Public Shared Sub DisplayUniqueColors(imagePath As String)
        Dim image As New Bitmap(imagePath)
        Dim uniqueColors As New HashSet(Of Color)

        For y As Integer = 0 To image.Height - 1
            For x As Integer = 0 To image.Width - 1
                Dim pixelColor As Color = image.GetPixel(x, y)
                uniqueColors.Add(pixelColor)
            Next
        Next


        For Each color In uniqueColors
            'ListBox1.Items.Add(color)
        Next

        image.Dispose()
    End Sub

    Public Sub New()

    End Sub

    Public Shared Sub RemoveColorFromImage(inputPath As String, outputPath As String, targetColor As Color)
        Dim image As New Bitmap(inputPath)

        For y As Integer = 0 To image.Height - 1
            For x As Integer = 0 To image.Width - 1
                Dim pixelColor As Color = image.GetPixel(x, y)
                Dim colorDifference As Double = CalculateColorDifferenceLab(pixelColor, targetColor)

                If colorDifference <= 10 Then
                    image.SetPixel(x, y, Color.Transparent)
                End If
            Next
        Next

        image.Save(outputPath, Imaging.ImageFormat.Png)
        image.Dispose()
    End Sub

    Private Shared Function CalculateColorDifferenceLab(color1 As Color, color2 As Color) As Double
        Dim lab1 As LabColor = LabColor.FromColor(color1)
        Dim lab2 As LabColor = LabColor.FromColor(color2)

        Dim deltaL As Double = lab1.L - lab2.L
        Dim deltaA As Double = lab1.A - lab2.A
        Dim deltaB As Double = lab1.B - lab2.B

        Return Math.Sqrt(deltaL * deltaL + deltaA * deltaA + deltaB * deltaB)
    End Function

    Public Shared Sub CroppingSizeDPI(sourcePath As String, outputPath As String, Image_Format As Imaging.ImageFormat, minAlpha As Integer, maxAlpha As Integer, margin As Integer, enlargementFactor As Double, dpi As Integer)
        Dim sourceImage As New Bitmap(sourcePath)
        Dim sourceWidth As Integer = sourceImage.Width
        Dim sourceHeight As Integer = sourceImage.Height

        Dim leftCrop As Integer = sourceWidth
        Dim topCrop As Integer = sourceHeight
        Dim rightCrop As Integer = 0
        Dim bottomCrop As Integer = 0

        Dim foundNonTransparentRegion As Boolean = False

        For y As Integer = 0 To sourceHeight - 1
            For x As Integer = 0 To sourceWidth - 1
                Dim pixelColor As Color = sourceImage.GetPixel(x, y)
                Dim alphaValue As Integer = pixelColor.A
                If alphaValue > 0 AndAlso alphaValue >= minAlpha AndAlso alphaValue <= maxAlpha Then
                    foundNonTransparentRegion = True
                    leftCrop = Math.Min(leftCrop, x)
                    rightCrop = Math.Max(rightCrop, x)
                    topCrop = Math.Min(topCrop, y)
                    bottomCrop = Math.Max(bottomCrop, y)
                End If
            Next
        Next

        If foundNonTransparentRegion Then
            leftCrop = Math.Max(0, leftCrop - margin)
            topCrop = Math.Max(0, topCrop - margin)
            rightCrop = Math.Min(sourceWidth - 1, rightCrop + margin)
            bottomCrop = Math.Min(sourceHeight - 1, bottomCrop + margin)

            Dim croppedWidth As Integer = rightCrop - leftCrop + 1
            Dim croppedHeight As Integer = bottomCrop - topCrop + 1

            Dim croppedImage As New Bitmap(croppedWidth, croppedHeight)
            Using g As Graphics = Graphics.FromImage(croppedImage)
                g.DrawImage(sourceImage, New Rectangle(0, 0, croppedWidth, croppedHeight), New Rectangle(leftCrop, topCrop, croppedWidth, croppedHeight), GraphicsUnit.Pixel)
            End Using

            Dim enlargedImageWidth As Integer = CInt(croppedWidth * enlargementFactor)
            Dim enlargedImageHeight As Integer = CInt(croppedHeight * enlargementFactor)

            Dim enlargedImage As New Bitmap(enlargedImageWidth, enlargedImageHeight)
            enlargedImage.SetResolution(dpi, dpi)

            Using g As Graphics = Graphics.FromImage(enlargedImage)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(croppedImage, New Rectangle(0, 0, enlargedImageWidth, enlargedImageHeight))
            End Using
            sourceImage.Dispose()
            enlargedImage.Save(outputPath, Image_Format) 
            enlargedImage.Dispose()
            croppedImage.Dispose()
        Else
            MessageBox.Show("No suitable non-transparent regions found.")
        End If


    End Sub

    Public Shared Sub CroppingSize(sourcePath As String, outputPath As String, Image_Format As Imaging.ImageFormat, minAlpha As Integer, maxAlpha As Integer, margin As Integer, enlargementFactor As Double)
        Dim sourceImage As New Bitmap(sourcePath)
        Dim sourceWidth As Integer = sourceImage.Width
        Dim sourceHeight As Integer = sourceImage.Height

        Dim leftCrop As Integer = sourceWidth
        Dim topCrop As Integer = sourceHeight
        Dim rightCrop As Integer = 0
        Dim bottomCrop As Integer = 0

        Dim foundNonTransparentRegion As Boolean = False

        For y As Integer = 0 To sourceHeight - 1
            For x As Integer = 0 To sourceWidth - 1
                Dim pixelColor As Color = sourceImage.GetPixel(x, y)
                Dim alphaValue As Integer = pixelColor.A
                If alphaValue > 0 AndAlso alphaValue >= minAlpha AndAlso alphaValue <= maxAlpha Then
                    foundNonTransparentRegion = True
                    leftCrop = Math.Min(leftCrop, x)
                    rightCrop = Math.Max(rightCrop, x)
                    topCrop = Math.Min(topCrop, y)
                    bottomCrop = Math.Max(bottomCrop, y)
                End If
            Next
        Next

        If foundNonTransparentRegion Then
            leftCrop = Math.Max(0, leftCrop - margin)
            topCrop = Math.Max(0, topCrop - margin)
            rightCrop = Math.Min(sourceWidth - 1, rightCrop + margin)
            bottomCrop = Math.Min(sourceHeight - 1, bottomCrop + margin)

            Dim croppedWidth As Integer = rightCrop - leftCrop + 1
            Dim croppedHeight As Integer = bottomCrop - topCrop + 1

            Dim croppedImage As New Bitmap(croppedWidth, croppedHeight)
            Using g As Graphics = Graphics.FromImage(croppedImage)
                g.DrawImage(sourceImage, New Rectangle(0, 0, croppedWidth, croppedHeight), New Rectangle(leftCrop, topCrop, croppedWidth, croppedHeight), GraphicsUnit.Pixel)
            End Using

            Dim enlargedImageWidth As Integer = CInt(croppedWidth * enlargementFactor)
            Dim enlargedImageHeight As Integer = CInt(croppedHeight * enlargementFactor)

            Dim enlargedImage As New Bitmap(enlargedImageWidth, enlargedImageHeight)
            Using g As Graphics = Graphics.FromImage(enlargedImage)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(croppedImage, New Rectangle(0, 0, enlargedImageWidth, enlargedImageHeight))
            End Using

            enlargedImage.Save(outputPath, Image_Format)

            enlargedImage.Dispose()
            croppedImage.Dispose()
        Else
            MessageBox.Show("No suitable non-transparent regions found.")
        End If

        sourceImage.Dispose()
    End Sub

    Public Shared Sub CroppingArea(sourcePath As String, outputPath As String, Image_Format As Imaging.ImageFormat, minAlpha As Integer, maxAlpha As Integer, margin As Integer)
        Dim sourceImage As New Bitmap(sourcePath)
        Dim sourceWidth As Integer = sourceImage.Width
        Dim sourceHeight As Integer = sourceImage.Height

        Dim leftCrop As Integer = sourceWidth
        Dim topCrop As Integer = sourceHeight
        Dim rightCrop As Integer = 0
        Dim bottomCrop As Integer = 0

        Dim foundNonTransparentRegion As Boolean = False

        For y As Integer = 0 To sourceHeight - 1
            For x As Integer = 0 To sourceWidth - 1
                Dim pixelColor As Color = sourceImage.GetPixel(x, y)
                Dim alphaValue As Integer = pixelColor.A
                If alphaValue > 0 AndAlso alphaValue >= minAlpha AndAlso alphaValue <= maxAlpha Then
                    foundNonTransparentRegion = True
                    leftCrop = Math.Min(leftCrop, x)
                    rightCrop = Math.Max(rightCrop, x)
                    topCrop = Math.Min(topCrop, y)
                    bottomCrop = Math.Max(bottomCrop, y)
                End If
            Next
        Next

        If foundNonTransparentRegion Then
            leftCrop = Math.Max(0, leftCrop - margin)
            topCrop = Math.Max(0, topCrop - margin)
            rightCrop = Math.Min(sourceWidth - 1, rightCrop + margin)
            bottomCrop = Math.Min(sourceHeight - 1, bottomCrop + margin)

            Dim croppedWidth As Integer = rightCrop - leftCrop + 1
            Dim croppedHeight As Integer = bottomCrop - topCrop + 1

            Dim croppedImage As New Bitmap(croppedWidth, croppedHeight)
            Using g As Graphics = Graphics.FromImage(croppedImage)
                g.DrawImage(sourceImage, New Rectangle(0, 0, croppedWidth, croppedHeight), New Rectangle(leftCrop, topCrop, croppedWidth, croppedHeight), GraphicsUnit.Pixel)
            End Using

            croppedImage.Save(outputPath, Image_Format)

            croppedImage.Dispose()
        Else
            MessageBox.Show("No suitable non-transparent regions found.")
        End If

        sourceImage.Dispose()
    End Sub

    Public Shared Sub ResizeEnlargeImage(sourcePath As String, outputPath As String, Image_Format As Imaging.ImageFormat, enlargementFactor As Double, dpi As Integer)
        Dim sourceImage As New Bitmap(sourcePath)

        Dim sourceWidth As Integer = sourceImage.Width
        Dim sourceHeight As Integer = sourceImage.Height

        Dim newWidth As Integer = CInt(sourceWidth * enlargementFactor)
        Dim newHeight As Integer = CInt(sourceHeight * enlargementFactor)

        Dim enlargedImage As New Bitmap(newWidth, newHeight)
        enlargedImage.SetResolution(dpi, dpi)

        Using g As Graphics = Graphics.FromImage(enlargedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(sourceImage, New Rectangle(0, 0, newWidth, newHeight))
        End Using

        enlargedImage.Save(outputPath, Image_Format)

        sourceImage.Dispose()
        enlargedImage.Dispose()
    End Sub

End Class

