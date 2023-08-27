Imports System.Xml
Imports ImageMagick
Public Class ConverterImage


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
    Public Shared Sub ConvertSvgToJpg(svgFilePath As String, outputFolderPath As String)
        Using image As New MagickImage(svgFilePath)
            ' Convert to JPG
            Dim jpgFilePath As String = outputFolderPath
            image.Format = MagickFormat.Jpg
            image.Quality = 100 ' Adjust the quality level as needed (0 to 100)
            image.Write(jpgFilePath)
        End Using
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

End Class
