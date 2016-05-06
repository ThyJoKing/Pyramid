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
End Module
