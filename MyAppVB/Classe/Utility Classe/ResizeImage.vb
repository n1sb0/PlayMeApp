
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class ResizeImage

    Public Shared Function ResizeImage(img As Image, width As Integer, height As Integer) As Image
        Dim newImage = New Bitmap(width, height)
        Using gr = Graphics.FromImage(newImage)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            gr.DrawImage(img, New Rectangle(0, 0, width, height))
        End Using
        Return newImage
    End Function

    Public Shared Function ResizeImage(img As Image, size As Size) As Image
        Return ResizeImage(img, size.Width, size.Height)
    End Function

    Public Shared Function ResizeImage(bmp As Bitmap, width As Integer, height As Integer) As Image
        Return ResizeImage(DirectCast(bmp, Image), width, height)
    End Function

    Public Shared Function ResizeImage(bmp As Bitmap, size As Size) As Image
        Return ResizeImage(DirectCast(bmp, Image), size.Width, size.Height)
    End Function


    Public Function ConvertImage(ByVal myImage As Image) As Byte()

        Dim mstream As New MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0

        mstream.Read(myBytes, 0, mstream.Length)

        Return myBytes

    End Function
End Class
