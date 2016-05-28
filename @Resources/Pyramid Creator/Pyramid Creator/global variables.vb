Public Module global_variables
    Public TriAngle = 0
    Public BaseAngle = 60
    Public TriSize = 100
    Public horBor = 0
    Public verBor = 0
    Public BrushColour As SolidBrush
    Public butName = "Test"
    Public butHor = 200
    Public butVer = 200
    Public iconFileName
    Public shownImage As New Bitmap(300, 300)
    Public triPosition As PointF

    Public iconVisible As Boolean = False
    Public shownIcon As Bitmap = New Bitmap(300, 300)
    Public iconPosition As PointF = New PointF(0, 0)
    Public iconSize As Integer = 100
    Public iconAngle As Integer = 60
End Module
