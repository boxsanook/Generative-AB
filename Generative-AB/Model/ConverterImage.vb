Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml
Imports ImageMagick
Public Class ConverterImage
    Public Shared Function ConvertImageToBase64(ByVal imagePath As String) As String
        Dim base64String As String = Nothing
        Try
            Using image As New MagickImage(imagePath)
                image.Resize(150, 150)
                ' Convert the image to a MemoryStream
                Using stream As New MemoryStream()
                    image.Write(stream)
                    ' Convert the MemoryStream to a byte array
                    Dim imageBytes As Byte() = stream.ToArray()
                    ' Convert the byte array to a Base64-encoded string
                    base64String = Convert.ToBase64String(imageBytes)

                End Using
            End Using
        Catch ex As Exception

        End Try

        Return base64String
    End Function

    Public Shared Function ConvertSvgTobase64(svgFilePath As String) As String
        Dim base64String As String = Nothing
        ' Create a new MagickImage object from an SVG file
        Using svgImage As New MagickImage(svgFilePath)
            svgImage.Resize(100, 100)
            ' Set the format to PNG (or any other desired format)
            svgImage.Format = MagickFormat.Png
            ' Convert the SVG image to PNG
            Using pngImage As New MagickImage(svgImage)
                ' Encode the PNG image as a base64 string
                base64String = pngImage.ToBase64()
            End Using
        End Using
        Return base64String
    End Function

    Public Shared Function ResizeImage(image As Image, width As Integer, height As Integer) As Image
        ' Create a new bitmap with the desired dimensions
        Dim resizedImage As New Bitmap(width, height)
        ' Create a Graphics object to work with the new bitmap
        Using g As Graphics = Graphics.FromImage(resizedImage)
            ' Set the interpolation mode for smoother resizing
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            ' Draw the original image onto the new bitmap with the specified dimensions
            g.DrawImage(image, 0, 0, width, height)
        End Using
        Return resizedImage
    End Function

    Public Shared Function ConvertImageToBase64(image As Image) As String
        Using ms As New MemoryStream()
            ' Save the image to a memory stream
            image.Save(ms, Imaging.ImageFormat.Jpeg) ' Change the format as needed
            ' Convert the image to a byte array
            Dim imageBytes As Byte() = ms.ToArray()
            ' Convert the byte array to a base64 string
            Return Convert.ToBase64String(imageBytes)
        End Using
    End Function

    Private Sub FindCroppingAreaX(sourcePath As String, outputPath As String, minAlpha As Integer, maxAlpha As Integer, margin As Integer)
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

            croppedImage.Save(outputPath, Imaging.ImageFormat.Png)
            croppedImage.Dispose()
        Else
            MessageBox.Show("No suitable non-transparent regions found.")
        End If

        sourceImage.Dispose()
    End Sub
    Private Sub ButtonSetBitDepth_TEST()
        ' Load the image
        Dim imagePath As String = "your_image_path_here.jpg" ' Replace with your image path
        Dim image As New Bitmap(imagePath)
        ' Set the desired bit depth (color depth)
        Dim newPixelFormat As PixelFormat = PixelFormat.Max ' Change to your desired bit depth 
        ' Convert the image to the new bit depth
        Dim convertedImage As Bitmap = ChangeImageBitDepth(image, newPixelFormat)
        ' Save the converted image
        Dim outputPath As String = "output_image.jpg" ' Replace with your output path
        convertedImage.Save(outputPath, ImageFormat.Jpeg)
        ' Clean up
        image.Dispose()
        convertedImage.Dispose()
    End Sub
    Private Function ChangeImageBitDepth(sourceImage As Bitmap, newPixelFormat As PixelFormat) As Bitmap
        ' Create a new bitmap with the desired pixel format
        Dim newImage As New Bitmap(sourceImage.Width, sourceImage.Height, newPixelFormat)
        ' Copy the source image to the new image, effectively converting it to the new bit depth
        Using g As Graphics = Graphics.FromImage(newImage)
            g.DrawImage(sourceImage, New Rectangle(0, 0, sourceImage.Width, sourceImage.Height))
        End Using
        Return newImage
    End Function

    Public Shared Function GetSvgDimensions_Size(svgFilePath As String) As Size
        Dim Size As Size = New Size(768, 768)
        Try
            ' Create a new MagickImage object from the SVG file
            Using image As New MagickImage(svgFilePath)
                ' Get the width and height of the SVG image
                Dim width As Integer = image.Width
                Dim height As Integer = image.Height
                Size = New Size(Convert.ToInt32(width), Convert.ToInt32(height))
                ' Do whatever you want with the width and height (e.g., display them or use them in your application)
                'MessageBox.Show($"SVG Width: {width}, Height: {height}")
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during the process
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return Size
    End Function

    ''Install the Magick.NET-Q16-AnyCPU NuGet package In your VB.NET project.
    ''Use the MagickImage Class from the Magick.NET Namespace To load And manipulate the SVG file.
    ''Set the output format To JPG Or PNG Using the Format Property Of the MagickImage.
    ''Save the image To the desired location With the appropriate file extension.
    Public Shared Sub ConvertSvgToImage(svgFilePath As String, outputFilePath As String, Resize As Integer, image_Format As MagickFormat)
        ' Load the SVG image using Magick.NET
        Using image As New MagickImage(svgFilePath)
            ' Resize the SVG image to the specified dimensions
            Dim newWidth As Integer = image.Width * Resize
            Dim newHeight As Integer = image.Height * Resize
            image.Resize(newWidth, newHeight)
            image.Format = image_Format
            ' Save the resized image to the output file
            image.Write(outputFilePath)
        End Using
        Console.WriteLine($"SVG resized to {outputFilePath}")
    End Sub
    Public Shared Sub ResizeSvg(svgFilePath As String, Resize As Integer)
        ' Load the SVG image using Magick.NET
        Using image As New MagickImage(svgFilePath)
            ' Resize the SVG image to the specified dimensions
            Dim newWidth As Integer = 1000 'image.Width * Resize
            Dim newHeight As Integer = 1000 'image.Height * Resize
            image.Resize(newWidth, newHeight)
            ' Save the resized image to the output file
            image.Write(svgFilePath)
        End Using

        Console.WriteLine($"SVG resized to {svgFilePath}")
    End Sub

    Public Shared Sub ConvertSvgToPng(svgFilePath As String, outputFolderPath As String)
        Using image As New MagickImage(svgFilePath)
            ' Convert to PNG
            Dim pngFilePath As String = outputFolderPath
            image.Format = MagickFormat.Png
            image.Write(pngFilePath)
        End Using
    End Sub


    Public Shared Sub ConvertSvgToJpgAndPng2(svgFilePath As String, outputFolderPath As String, width As Integer, height As Integer)
        Using image As New MagickImage(svgFilePath)
            ' Get the original SVG image size
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height

            ' Calculate the new size to maintain the original aspect ratio
            Dim newWidth As Integer
            Dim newHeight As Integer

            If originalWidth > originalHeight Then
                newWidth = width
                newHeight = originalHeight * width / originalWidth
            Else
                newHeight = height
                newWidth = originalWidth * height / originalHeight
            End If
            ' Resize the image to the new dimensions
            image.Resize(newWidth, newHeight)

            ' Convert to JPG
            Dim jpgFilePath As String = System.IO.Path.Combine(outputFolderPath, "output.jpg")
            image.Format = MagickFormat.Jpg
            image.Quality = 100 ' Adjust the quality level as needed (0 to 100)
            image.Write(jpgFilePath)
            ' Convert to PNG
            Dim pngFilePath As String = System.IO.Path.Combine(outputFolderPath, "output.png")
            image.Format = MagickFormat.Png
            image.Write(pngFilePath)
        End Using
    End Sub


    Public Shared Function GetBackgroundColor(svgFilePath As String) As Color
        Dim backgroundColor As Color = Color.Transparent

        Dim doc As New XmlDocument()
        doc.Load(svgFilePath)

        ' Define the custom namespace manager to handle namespaces
        Dim nsManager As New XmlNamespaceManager(doc.NameTable)
        nsManager.AddNamespace("svg", "http://www.w3.org/2000/svg")

        ' Find the first "rect" element in the SVG file (if any)
        Dim rectNode As XmlNode = doc.SelectSingleNode("//svg:path", nsManager)

        If rectNode IsNot Nothing Then
            ' Check if the "rect" element has a "fill" attribute
            If rectNode.Attributes("fill") IsNot Nothing Then
                Dim fillColor As String = rectNode.Attributes("fill").Value
                If fillColor.StartsWith("rgb(") Then
                    ' Extract the RGB values and create a Color object
                    Dim rgbValues = fillColor.Replace("rgb(", "").Replace(")", "").Split(","c)
                    Dim r As Integer = Integer.Parse(rgbValues(0).Trim())
                    Dim g As Integer = Integer.Parse(rgbValues(1).Trim())
                    Dim b As Integer = Integer.Parse(rgbValues(2).Trim())
                    backgroundColor = Color.FromArgb(r, g, b)
                End If
            End If
        End If

        Return backgroundColor
    End Function
    Public Shared Sub ConvertSvgTo_Png(svgFilePath As String, pngFilePath As String, width As Integer, height As Integer, image_Format As MagickFormat)
        Dim newDpi As New Density(300, 300) ' Set the new DPI value, 300 DPI in this example

        Using image As New MagickImage(svgFilePath)
            ' Get the original SVG image size
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height

            ' Set the resolution (DPI) value, for example, 300 DPI

            image.Density = newDpi

            ' Optionally, you can also set the quality for JPEG images
            image.Quality = 90
            ' Calculate the new size to maintain the original aspect ratio
            Dim newWidth As Integer
            Dim newHeight As Integer

            If originalWidth > originalHeight Then
                newWidth = width
                newHeight = originalHeight * width / originalWidth
            Else
                newHeight = height
                newWidth = originalWidth * height / originalHeight
            End If

            ' Resize the image to the new dimensions
            image.Resize(newWidth, newHeight)

            ' Convert to JPG 
            image.Format = image_Format
            image.Write(pngFilePath)
        End Using
    End Sub

    Public Shared Sub ReplaceBackgroundColor(svgFilePath As String, outputFilePath As String, newBackgroundColor As Color)
        Dim doc As New XmlDocument()
        doc.Load(svgFilePath)

        ' Define the custom namespace manager to handle namespaces
        Dim nsManager As New XmlNamespaceManager(doc.NameTable)
        nsManager.AddNamespace("svg", "http://www.w3.org/2000/svg")
        ' Find the first "rect" element in the SVG file (if any)
        Dim rectNode As XmlNode = doc.SelectSingleNode("//svg:path", nsManager)

        If rectNode IsNot Nothing Then
            ' Update the "fill" attribute with the new background color
            Dim newFillColor As String = $"rgb({newBackgroundColor.R} {newBackgroundColor.G} {newBackgroundColor.B})"
            rectNode.Attributes("fill").Value = newFillColor
        End If

        ' Save the updated SVG content to a new file
        doc.Save(outputFilePath)
    End Sub

    Public Shared Function ColorToHtmlCode(color As Color) As String
        Return "#" & color.R.ToString("X2") & color.G.ToString("X2") & color.B.ToString("X2")
    End Function

    Public Shared Sub RemoveBackground_Png(imagePath As String, outputFilePath As String, backgroundColor As MagickColor)
        Using image As New MagickImage(imagePath)
            ' Set the color to be replaced (background color)
            Dim targetColor As New MagickColor($"rgb({backgroundColor.R}, {backgroundColor.G}, {backgroundColor.B})") ' Replace with your background color
            Dim replacementColor As New MagickColor("transparent") ' Set the replacement color to transparent

            ' Replace the background color with transparency
            image.ColorFuzz = New Percentage(10) ' Adjust the fuzziness as needed
            image.Opaque(targetColor, replacementColor)

            ' Save the result as PNG
            image.Format = MagickFormat.Png
            image.Write(outputFilePath)
        End Using
    End Sub

    Public Shared Sub ConvertImage_RemoveBackground(svgFilePath As String, pngFilePath As String, width As Integer, height As Integer, image_Format As MagickFormat, backgroundColor As MagickColor)
        Dim newDpi As New Density(300, 300) ' Set the new DPI value, 300 DPI in this example

        Using image As New MagickImage(svgFilePath)
            ' Get the original SVG image size
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            ' Set the color to be replaced (background color)
            Dim targetColor As New MagickColor($"rgb({backgroundColor.R}, {backgroundColor.G}, {backgroundColor.B})") ' Replace with your background color
            Dim replacementColor As New MagickColor("transparent") ' Set the replacement color to transparent

            ' Replace the background color with transparency
            image.ColorFuzz = New Percentage(10) ' Adjust the fuzziness as needed
            image.Opaque(targetColor, replacementColor)

            ' Set the resolution (DPI) value, for example, 300 DPI

            image.Density = newDpi

            ' Optionally, you can also set the quality for JPEG images
            image.Quality = 90
            ' Calculate the new size to maintain the original aspect ratio
            Dim newWidth As Integer
            Dim newHeight As Integer

            If originalWidth > originalHeight Then
                newWidth = width
                newHeight = originalHeight * width / originalWidth
            Else
                newHeight = height
                newWidth = originalWidth * height / originalHeight
            End If

            ' Resize the image to the new dimensions
            image.Resize(newWidth, newHeight)

            ' Convert to JPG 
            image.Format = image_Format
            image.Write(pngFilePath)
        End Using
    End Sub

End Class
