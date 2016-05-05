﻿Imports System.Math
Public Class triForm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim vertical As Integer = (TriSize * Tan(BaseAngle * PI / 180)) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim horizontal As Integer = (2 * TriSize) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim pointArray As PointF() = {New PointF(horizontal / 2, 0),
                                      New PointF(0, vertical),
                                      New PointF(horizontal, vertical)}
        Try
            shownImage = New Bitmap(horizontal, vertical)
            Dim g As Graphics = Graphics.FromImage(shownImage)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.FillPolygon(BrushColour, pointArray)

            e.Graphics.TranslateTransform(Me.Width / 2 + triPosition.X, Me.Height / 2 + triPosition.Y)
            e.Graphics.RotateTransform(TriAngle)
            e.Graphics.DrawImage(shownImage, -CInt(shownImage.Width / 2), -CInt(shownImage.Height / 2), shownImage.Width, shownImage.Height)
            e.Graphics.ResetTransform()

            If iconVisible Then
                If IsValidImage(Form1.iconText.Text()) Then
                    shownIcon = Image.FromFile(Form1.iconText.Text())
                    horizontal = shownIcon.Width / shownIcon.Height * iconSize
                    vertical = shownIcon.Height / shownIcon.Width * iconSize
                    e.Graphics.DrawImage(shownIcon, CInt(Me.Width / 2 + triPosition.X - horizontal / 2 + iconPosition.X), CInt(Me.Height / 2 + triPosition.Y - vertical / 2 + iconPosition.Y), CInt(horizontal), CInt(vertical))
                Else
                    iconVisible = False
                    Form1.iconText.Text() = ""
                End If
            End If

        Catch generatedExceptionName As ArgumentException
            Form1.TriSizeNum.Value() = 100
            drag = False
            resetTriPosition()
            Form1.TriSizeCheck.Checked = False
            MsgBox("Why.")
        End Try
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - triPosition.X
        mousey = Cursor.Position.Y - triPosition.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            triPosition.X = Cursor.Position.X - mousex
            triPosition.Y = Cursor.Position.Y - mousey
            Me.Refresh()
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub triForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim screenWidth = Screen.FromControl(Form1).Bounds.Width
        Dim screenHeight = Screen.FromControl(Form1).Bounds.Height

        Size = New Size(screenWidth, screenHeight)
        If Screen.AllScreens.Length > 1 Then
            Location = New Point(Screen.AllScreens(1).Bounds.X, Screen.AllScreens(1).Bounds.Y)
        Else
            Location = New Point(0, 0)
        End If
        resetTriPosition()
        DoubleBuffered = True
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

End Class