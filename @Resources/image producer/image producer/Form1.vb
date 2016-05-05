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
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles iconSizeBar.Scroll, IconAngleBar.Scroll
        IconSizeNum.Value = iconSizeBar.Value
        IconAngleNum.Value = IconAngleBar.Value
    End Sub
    Private Sub IconSizeNum_ValueChanged(sender As Object, e As EventArgs) Handles IconSizeNum.ValueChanged, IconAngleBar.Scroll
        iconSizeBar.Value = IconSizeNum.Value
        IconAngleBar.Value = IconAngleNum.Value
    End Sub

    'Graphics
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles graphicsCheck.CheckedChanged
        Panel1.Visible = Not Panel1.Visible
    End Sub
    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles spinCheck.CheckedChanged
        spinClickRadio.Checked = spinCheck.Checked
        If spinClickRadio.Checked = False Then
            spinMouseOverRadio.Checked = False
        End If
    End Sub

    'Skin Stuff
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
        exportImage.Save("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\@Resources\Images\" + SkinName.Text() + "Triangle.png", Imaging.ImageFormat.Png)
        IO.Directory.CreateDirectory("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\" + SkinName.Text())

        Using sw As New IO.StreamWriter("C:\Users\Joshua King\Documents\Rainmeter\Skins\Pyramid\" + SkinName.Text() + "\" + SkinName.Text() + ".ini", False)
            sw.WriteLine("[Rainmeter]")
            sw.WriteLine("Update = 10")
            sw.WriteLine("LeftMouseUpAction =[""" + UrlText.Text + """]")
            sw.WriteLine()
            sw.WriteLine("[Variables]")
            sw.WriteLine("ImageH = " + CStr(horizontal))
            sw.WriteLine("ImageW = " + CStr(vertical))
            sw.WriteLine("IntTriAngle = " + CStr(TriAngle))
            If spinCheck.Checked Then
                sw.WriteLine("RotationNum = " + CStr(spinNum.Value))
                sw.WriteLine("Angle = " + CStr(TriAngle))
                sw.WriteLine("SpinSpeed = " + CStr(spinSpeedNum.Value / 100))
                If iconVisible Then
                    sw.WriteLine("IntIconAngle = " + CStr(iconAngle))
                End If
            End If
            sw.WriteLine()
            If Not spinCheck.Checked Then
                sw.WriteLine("[Triangle]")
                sw.WriteLine("Meter = Image")
                sw.WriteLine("ImageName =#@#Images\" + SkinName.Text() + "#triangle.png")
                sw.WriteLine("imageRotate = #IntTriAngle#")
                If iconVisible Then
                    sw.WriteLine("[Triangle]")
                    sw.WriteLine("Meter = Image")
                    sw.WriteLine("ImageName =#@#Images\" + SkinName.Text() + "#triangle.png")
                    sw.WriteLine("imageRotate = #IntTriAngle#")
                End If
            Else
                sw.WriteLine("[AngleCount]")
                sw.WriteLine("Measure = Calc")
                sw.WriteLine("Formula = #Angle#")
                sw.WriteLine("OnUpdateAction = !SetVariable Angle ""((#Angle# + #SpinSpeed#/#RotationNum#)%90)""")
                sw.WriteLine("IfCondition = (AngleCount%(#RotationNum#*90) >= 90 -#SpinSpeed#/#RotationNum#)")
                sw.WriteLine("IfTrueAction = [!DisableMeasure AngleCount]")
                sw.WriteLine("DynamicVariables = 1")
                sw.WriteLine("MaxValue = 90")
                sw.WriteLine()
                sw.WriteLine("[TriAngleCount]")
                sw.WriteLine("Measure = Calc")
                sw.WriteLine("Formula = (360 + #IntTriAngle# + (Sin(Rad(AngleCount)) * (360*#RotationNum#)%360))%360")
                sw.WriteLine("MaxValue = 360")
                sw.WriteLine()
                sw.WriteLine("[TriRotator]")
                sw.WriteLine("Meter = Rotator")
                sw.WriteLine("MeasureName = TriAngleCount")
                sw.WriteLine("ImageName =#@#Images\" + SkinName.Text() + "Triangle.png")
                sw.WriteLine("OffsetX = (#ImageW# / 2)")
                sw.WriteLine("OffsetY = (#ImageH# / 2)")
                sw.WriteLine("W = (Sqrt(#ImageW# ** 2 + #ImageH# ** 2))")
                sw.WriteLine("H = (Sqrt(#ImageW# ** 2 + #ImageH# ** 2))")
                sw.WriteLine("MouseOverAction = [!EnableMeasure AngleCount]")
                If iconVisible Then
                    sw.WriteLine("[IconAngleCount]")
                    sw.WriteLine("Measure = Calc")
                    sw.WriteLine("Formula = (360 + #IntIconAngle# + (Sin(Rad(AngleCount)) * (360*#RotationNum#)%360))%360")
                    sw.WriteLine("MaxValue = 360")
                    sw.WriteLine()
                    sw.WriteLine("[IconRotator]")
                    sw.WriteLine("Meter = Rotator")
                    sw.WriteLine("MeasureName = IconAngleCount")
                    sw.WriteLine("ImageName =#@#Images\" + SkinName.Text() + "Triangle.png")
                    sw.WriteLine("OffsetX = (#ImageW# / 2)")
                    sw.WriteLine("OffsetY = (#ImageH# / 2)")
                    sw.WriteLine("W = (Sqrt(#ImageW# ** 2 + #ImageH# ** 2))")
                    sw.WriteLine("H = (Sqrt(#ImageW# ** 2 + #ImageH# ** 2))")
                    If spinMouseOverRadio.Checked Then
                        sw.WriteLine("MouseOverAction = [!EnableMeasure AngleCount]")
                    End If
                End If
            End If
            sw.WriteLine("LeftMouseUpAction =[""" + UrlText.Text + """]")
            sw.WriteLine("ImageTint = " + Convert.ToString(rNum.Value) + "," _
                                        + Convert.ToString(gNum.Value) + "," _
                                        + Convert.ToString(bNum.Value) + "," _
                                        + Convert.ToString(1 - oNum.Value * 2.58))
            sw.WriteLine()
            sw.WriteLine("[Metadata]")
            sw.WriteLine("Name = " + SkinName.Text())
            sw.WriteLine("Author = JoKing")
            sw.WriteLine("Info = Created using Pyramid Skin Maker: Version 0.25")
        End Using
        Me.Close()
    End Sub

    Private Sub soinSpeedBar_Scroll(sender As Object, e As EventArgs) Handles spinSpeedBar.Scroll, spinBar.Scroll
        spinNum.Value = spinBar.Value
        spinSpeedNum.Value = spinSpeedBar.Value
    End Sub

    Private Sub spinSpeedNum_ValueChanged(sender As Object, e As EventArgs) Handles spinSpeedNum.ValueChanged, spinNum.ValueChanged
        spinBar.Value = spinNum.Value
        spinSpeedBar.Value = spinSpeedNum.Value
    End Sub
End Class
