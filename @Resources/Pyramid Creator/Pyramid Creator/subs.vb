Imports System.Math
Module subs
    Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            Return False
        End Try
        Return True
    End Function

    Public Sub resetTriPosition()
        triForm.Refresh()
        Dim middleHeight = -triForm.Height / 2
        Dim leftWidth = -triForm.Width / 2
        triPosition = New Point(leftWidth + shownImage.Width / 2, middleHeight + shownImage.Height / 2)
        triForm.Refresh()
    End Sub
    Public Function rotateBitmap(b As Bitmap, angle As Integer)
        Dim newWidth As Integer = Abs(b.Width * Cos(angle * PI / 180) + b.Height * Sin(angle * PI / 180))
        Dim newHeight As Integer = Abs(b.Width * Sin(angle * PI / 180) + b.Height * Cos(angle * PI / 180))
        Dim returnBitmap As New Bitmap(newWidth, newHeight)
        returnBitmap.SetResolution(b.HorizontalResolution, b.VerticalResolution)
        Dim g As Graphics = Graphics.FromImage(returnBitmap)
        g.TranslateTransform(CSng(newWidth) / 2, CSng(newHeight) / 2)
        g.RotateTransform(angle)
        g.TranslateTransform(-CSng(newWidth) / 2, -CSng(newHeight) / 2)
        g.DrawImage(b, New Point(newWidth - b.Width, newHeight - b.Height))
        g.ResetTransform()
        g.DrawRectangle(Pens.Red, New Rectangle(0, 0, newWidth, newHeight))
        Return returnBitmap
    End Function

    Public Sub imageDraw(e)
        Dim vertical As Integer = (TriSize * Tan(BaseAngle * PI / 180)) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim horizontal As Integer = (2 * TriSize) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim pointArray As PointF() = {New PointF(horizontal / 2, 0),
                                      New PointF(0, vertical),
                                      New PointF(horizontal, vertical)}

        shownImage = New Bitmap(horizontal, vertical)
        Dim g As Graphics = Graphics.FromImage(shownImage)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.FillPolygon(BrushColour, pointArray)

        'Works
        e.Graphics.TranslateTransform(triForm.Width / 2 + triPosition.X, triForm.Height / 2 + triPosition.Y)
        e.Graphics.RotateTransform(TriAngle)
        e.Graphics.DrawImage(shownImage, -CInt(shownImage.Width / 2), -CInt(shownImage.Height / 2), shownImage.Width, shownImage.Height)
        e.Graphics.ResetTransform()

        'NotWorking
        'shownImage = rotateBitmap(shownImage, TriAngle)
        'e.Graphics.DrawImage(shownImage, triPosition.X, triPosition.Y, shownImage.Width, shownImage.Height)

    End Sub

    Public Sub iconDraw(e As PaintEventArgs)
        If IsValidImage(Form1.iconText.Text()) Then
            shownIcon = Image.FromFile(Form1.iconText.Text())
            Dim horizontal = shownIcon.Width / shownIcon.Height * iconSize
            Dim vertical = shownIcon.Height / shownIcon.Width * iconSize

            e.Graphics.TranslateTransform(triForm.Width / 2 + iconPosition.X + triPosition.X, triForm.Height / 2 + iconPosition.Y + triPosition.Y)
            e.Graphics.RotateTransform(iconAngle)
            e.Graphics.DrawImage(shownIcon, -CInt(horizontal / 2 + iconPosition.X), -CInt(vertical / 2 + iconPosition.Y), CInt(horizontal), CInt(vertical))
            e.Graphics.ResetTransform()
        Else
            iconVisible = False
            Form1.iconText.Text() = ""
        End If
    End Sub
End Module
