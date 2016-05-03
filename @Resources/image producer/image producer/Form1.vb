Imports System.Math
Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    'Form Stuff
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        triForm.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        If MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Have You Saved?") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    'Triangle Stuff
    Private Sub upArrow_Click(sender As Object, e As EventArgs) Handles upArrow.Click, downArrow.Click, rightArrow.Click, leftArrow.Click
        If sender.name = "upArrow" Then
            TriAngleNum.Value = 0
        ElseIf sender.name = "downArrow" Then
            TriAngleNum.Value = 180
        ElseIf sender.name = "leftArrow" Then
            TriAngleNum.Value = -90
        Else
            TriAngleNum.Value = 90
        End If
        triForm.Refresh()
    End Sub
    Private Sub TrackBarScroll(sender As Object, e As EventArgs) Handles TriSizeBar.Scroll, BaseAngleBar.Scroll, TriAngleBar.Scroll, rBar.Scroll, gBar.Scroll, bBar.Scroll, oBar.Scroll
        Dim barNumReference As Dictionary(Of TrackBar, NumericUpDown) = New Dictionary(Of TrackBar, NumericUpDown) From {
        {TriSizeBar, TriSizeNum},
        {BaseAngleBar, BaseAngleNum},
        {TriAngleBar, TriAngleNum},
        {rBar, rNum},
        {gBar, gNum},
        {bBar, bNum},
        {oBar, oNum}
    }
        If sender Is rBar Or sender Is gBar Or sender Is bBar Or sender Is oBar Then
            barNumReference.Item(sender).Value() = sender.value()
        ElseIf sender Is TriSizeBar Then
            barNumReference.Item(sender).Value() = Round(sender.value / 10) * 10
        ElseIf sender Is BaseAngleBar Or sender Is TriAngleBar Then
            barNumReference.Item(sender).Value() = Round(sender.value / 5) * 5
        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles TriAngleNum.ValueChanged, TriSizeNum.ValueChanged, BaseAngleNum.ValueChanged
        If sender Is TriSizeNum Then
            TriSize = sender.value()
            TriSizeBar.Value = sender.value()
        ElseIf sender Is BaseAngleNum Then
            BaseAngle = sender.value()
            BaseAngleBar.Value = sender.value()
        ElseIf sender Is TriAngleNum Then
            TriAngle = sender.value()
            TriAngleBar.Value = sender.value()
        End If
        triForm.Refresh()
    End Sub
    Private Sub colourNumChanged(sender As Object, e As EventArgs) Handles rNum.ValueChanged, bNum.ValueChanged, gNum.ValueChanged, oNum.ValueChanged
        Dim tempColour As Color = Color.FromArgb(255, rNum.Value, gNum.Value, bNum.Value)
        BrushColour = New SolidBrush(tempColour)
        triForm.Refresh()
        triForm.Opacity = oNum.Value() / 100
        rBar.Value = rNum.Value
        gBar.Value = gNum.Value
        bBar.Value = bNum.Value
        oBar.Value = oNum.Value
    End Sub
    Private Sub rLabel_Click(sender As Object, e As EventArgs) Handles rLabel.Click
        rNum.Value = 255
        bNum.Value = 0
        gNum.Value = 0
    End Sub
    Private Sub gLabel_Click(sender As Object, e As EventArgs) Handles gLabel.Click
        rNum.Value = 0
        bNum.Value = 0
        gNum.Value = 255
    End Sub
    Private Sub bLabel_Click(sender As Object, e As EventArgs) Handles bLabel.Click
        rNum.Value = 0
        bNum.Value = 255
        gNum.Value = 0
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles TriResetButton.Click
        BaseAngleNum.Value = 60
        TriAngleNum.Value = 0
        TriSizeNum.Value = 100
        rNum.Value = 128
        gNum.Value = 128
        bNum.Value = 128
        oNum.Value = 100
        TriSizeCheck.Checked = False
        resetTriPosition()

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles TriSizeCheck.CheckedChanged
        Dim sizeMax
        If TriSizeCheck.Checked Then
            sizeMax = 500
            triSizeCheck2.Visible = True
        Else
            sizeMax = 200
            triSizeCheck2.Checked = False
            triSizeCheck2.Visible = False
        End If
        SetTriSize(sizeMax)
    End Sub
    Private Sub triSizeCheck2_CheckedChanged(sender As Object, e As EventArgs) Handles triSizeCheck2.CheckedChanged
        Dim sizeMax
        If triSizeCheck2.Checked Then
            sizeMax = 1000
            TriSizeCheck3.Visible = True
        Else
            sizeMax = 500
            TriSizeCheck3.Checked = False
            TriSizeCheck3.Visible = False
        End If
        SetTriSize(sizeMax)
    End Sub
    Private Sub TriSizeCheck3_CheckedChanged(sender As Object, e As EventArgs) Handles TriSizeCheck3.CheckedChanged
        Dim sizeMax
        If TriSizeCheck3.Checked Then
            sizeMax = Screen.FromControl(Me).Bounds.Height * 5
        Else
            sizeMax = 1000
        End If
        SetTriSize(sizeMax)
        Me.Refresh()
    End Sub
    Private Sub SetTriSize(max)
        If max < TriSizeNum.Value Then
            TriSizeNum.Value = max
        End If
        TriSizeNum.Maximum = max
        TriSizeBar.Maximum = max
    End Sub

    'Icon Stuff
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles IconCheck.CheckedChanged
        iconPanel.Visible = Not iconPanel.Visible
        If Not IconCheck.Checked Then
            iconVisible = False
        End If
    End Sub
    Private Sub filename_DragEnter(sender As Object, e As DragEventArgs) Handles iconText.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub filename_DragDrop(sender As Object, e As DragEventArgs) Handles iconText.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files.Length = 1 Then
            If IsValidImage(files(0)) Then
                iconText.Text = files(0)
                iconVisible = True
                triForm.Refresh()
            Else
                MsgBox("Error: Not Valid Image.")
            End If
        Else
            MsgBox("Error: Multiple Files Detected")
        End If
    End Sub
    Private Sub fileGet_Click(sender As Object, e As EventArgs) Handles fileGet.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        iconFileName = OpenFileDialog1.FileName.ToString()
        If IsValidImage(iconFileName) Then
            iconText.Text = iconFileName
            iconVisible = True
            triForm.Refresh()
        Else
            MsgBox("Incompatible Image")
            iconText.Text = ""
        End If
    End Sub

    'Skin Stuff
    Private Sub SkinName_TextChanged(sender As Object, e As EventArgs) Handles SkinName.TextChanged
        butName = SkinName.Text()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles createButton.Click
        Dim vertical As Integer = (TriSize * Tan(BaseAngle * PI / 180)) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim horizontal As Integer = (2 * TriSize) / (Sqrt(Tan(BaseAngle * PI / 180) + 4))
        Dim pointArray As PointF() = {New PointF(horizontal / 2, 0),
                                      New PointF(0, vertical),
                                      New PointF(horizontal, vertical)}

        Dim exportImage = New Bitmap(horizontal, vertical)
        Dim g As Graphics = Graphics.FromImage(exportImage)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.FillPolygon(New SolidBrush(Color.White), pointArray)
        exportImage.Save("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\@Resources\Images\" + butName + "triangle.png", Imaging.ImageFormat.Png)
        IO.Directory.CreateDirectory("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\" + butName)

        Using sw As New IO.StreamWriter("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\" + butName + "\" + butName + ".ini", False)
            sw.WriteLine("[Rainmeter]")
            sw.WriteLine("Update = 1000")
            sw.WriteLine()
            sw.WriteLine("[Variables]")
            sw.WriteLine("H = " + Convert.ToString(horizontal))
            sw.WriteLine("W = " + Convert.ToString(vertical))
            sw.WriteLine()
            sw.WriteLine("[" + butName + "]")
            sw.WriteLine("Meter = Image")
            sw.WriteLine("ImageName =#@#Images\" + Convert.ToString(BaseAngle) + "triangle.png")
            sw.WriteLine("imageRotate = " + Convert.ToString(TriAngle))
            sw.WriteLine("LeftMouseUpAction =[""" + UrlText.Text + """]")
            sw.WriteLine("ImageTint = " + Convert.ToString(rNum.Value) + "," _
                                        + Convert.ToString(gNum.Value) + "," _
                                        + Convert.ToString(bNum.Value) + "," _
                                        + Convert.ToString(1 - oNum.Value * 2.58))
            sw.WriteLine()
            sw.WriteLine("[Metadata]")
            sw.WriteLine("Name = " + butName)
            sw.WriteLine("Author = JoKing")
            sw.WriteLine("Info = Created using Pyramid Skin Maker: Version 0.2")
        End Using
        Me.Close()
    End Sub
End Class
