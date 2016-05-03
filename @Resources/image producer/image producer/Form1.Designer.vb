<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.createButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.trianglePanel = New System.Windows.Forms.Panel()
        Me.TriSizeCheck3 = New System.Windows.Forms.CheckBox()
        Me.triSizeCheck2 = New System.Windows.Forms.CheckBox()
        Me.TriResetButton = New System.Windows.Forms.Button()
        Me.TriSizeCheck = New System.Windows.Forms.CheckBox()
        Me.bLabel = New System.Windows.Forms.Label()
        Me.gLabel = New System.Windows.Forms.Label()
        Me.rLabel = New System.Windows.Forms.Label()
        Me.TriAngleNum = New System.Windows.Forms.NumericUpDown()
        Me.TriAngleBar = New System.Windows.Forms.TrackBar()
        Me.angleLabel = New System.Windows.Forms.Label()
        Me.oBar = New System.Windows.Forms.TrackBar()
        Me.bBar = New System.Windows.Forms.TrackBar()
        Me.gBar = New System.Windows.Forms.TrackBar()
        Me.rBar = New System.Windows.Forms.TrackBar()
        Me.rightArrow = New System.Windows.Forms.Button()
        Me.downArrow = New System.Windows.Forms.Button()
        Me.leftArrow = New System.Windows.Forms.Button()
        Me.upArrow = New System.Windows.Forms.Button()
        Me.oLabel = New System.Windows.Forms.Label()
        Me.oNum = New System.Windows.Forms.NumericUpDown()
        Me.rgbLabel = New System.Windows.Forms.Label()
        Me.gNum = New System.Windows.Forms.NumericUpDown()
        Me.bNum = New System.Windows.Forms.NumericUpDown()
        Me.rNum = New System.Windows.Forms.NumericUpDown()
        Me.BaseAngleNum = New System.Windows.Forms.NumericUpDown()
        Me.baseAngleLabel = New System.Windows.Forms.Label()
        Me.BaseAngleBar = New System.Windows.Forms.TrackBar()
        Me.TriSizeNum = New System.Windows.Forms.NumericUpDown()
        Me.triSizeLabel = New System.Windows.Forms.Label()
        Me.TriSizeBar = New System.Windows.Forms.TrackBar()
        Me.iconPanel = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.fileGet = New System.Windows.Forms.Button()
        Me.iconLabel = New System.Windows.Forms.Label()
        Me.iconText = New System.Windows.Forms.TextBox()
        Me.skinPanel = New System.Windows.Forms.Panel()
        Me.urlLabel = New System.Windows.Forms.Label()
        Me.UrlText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SkinName = New System.Windows.Forms.TextBox()
        Me.IconCheck = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.trianglePanel.SuspendLayout()
        CType(Me.TriAngleNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriAngleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseAngleNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseAngleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriSizeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TriSizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.iconPanel.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.skinPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'createButton
        '
        Me.createButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createButton.Location = New System.Drawing.Point(317, 205)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(75, 66)
        Me.createButton.TabIndex = 0
        Me.createButton.Text = "Create"
        Me.createButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(12, 529)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 66)
        Me.closeButton.TabIndex = 8
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        '
        'trianglePanel
        '
        Me.trianglePanel.Controls.Add(Me.TriSizeCheck3)
        Me.trianglePanel.Controls.Add(Me.triSizeCheck2)
        Me.trianglePanel.Controls.Add(Me.TriResetButton)
        Me.trianglePanel.Controls.Add(Me.TriSizeCheck)
        Me.trianglePanel.Controls.Add(Me.bLabel)
        Me.trianglePanel.Controls.Add(Me.gLabel)
        Me.trianglePanel.Controls.Add(Me.rLabel)
        Me.trianglePanel.Controls.Add(Me.TriAngleNum)
        Me.trianglePanel.Controls.Add(Me.TriAngleBar)
        Me.trianglePanel.Controls.Add(Me.angleLabel)
        Me.trianglePanel.Controls.Add(Me.oBar)
        Me.trianglePanel.Controls.Add(Me.bBar)
        Me.trianglePanel.Controls.Add(Me.gBar)
        Me.trianglePanel.Controls.Add(Me.rBar)
        Me.trianglePanel.Controls.Add(Me.rightArrow)
        Me.trianglePanel.Controls.Add(Me.downArrow)
        Me.trianglePanel.Controls.Add(Me.leftArrow)
        Me.trianglePanel.Controls.Add(Me.upArrow)
        Me.trianglePanel.Controls.Add(Me.oLabel)
        Me.trianglePanel.Controls.Add(Me.oNum)
        Me.trianglePanel.Controls.Add(Me.rgbLabel)
        Me.trianglePanel.Controls.Add(Me.gNum)
        Me.trianglePanel.Controls.Add(Me.bNum)
        Me.trianglePanel.Controls.Add(Me.rNum)
        Me.trianglePanel.Controls.Add(Me.BaseAngleNum)
        Me.trianglePanel.Controls.Add(Me.baseAngleLabel)
        Me.trianglePanel.Controls.Add(Me.BaseAngleBar)
        Me.trianglePanel.Controls.Add(Me.TriSizeNum)
        Me.trianglePanel.Controls.Add(Me.triSizeLabel)
        Me.trianglePanel.Controls.Add(Me.TriSizeBar)
        Me.trianglePanel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trianglePanel.Location = New System.Drawing.Point(12, 26)
        Me.trianglePanel.Name = "trianglePanel"
        Me.trianglePanel.Size = New System.Drawing.Size(697, 204)
        Me.trianglePanel.TabIndex = 37
        '
        'TriSizeCheck3
        '
        Me.TriSizeCheck3.AutoSize = True
        Me.TriSizeCheck3.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriSizeCheck3.Location = New System.Drawing.Point(34, 180)
        Me.TriSizeCheck3.Name = "TriSizeCheck3"
        Me.TriSizeCheck3.Size = New System.Drawing.Size(85, 21)
        Me.TriSizeCheck3.TabIndex = 66
        Me.TriSizeCheck3.Text = "Seriously?"
        Me.ToolTip1.SetToolTip(Me.TriSizeCheck3, "Warning: Program will probably crash.")
        Me.TriSizeCheck3.UseVisualStyleBackColor = True
        Me.TriSizeCheck3.Visible = False
        '
        'triSizeCheck2
        '
        Me.triSizeCheck2.AutoSize = True
        Me.triSizeCheck2.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.triSizeCheck2.Location = New System.Drawing.Point(34, 155)
        Me.triSizeCheck2.Name = "triSizeCheck2"
        Me.triSizeCheck2.Size = New System.Drawing.Size(106, 21)
        Me.triSizeCheck2.TabIndex = 65
        Me.triSizeCheck2.Text = "EVEN BIGGER!"
        Me.triSizeCheck2.UseVisualStyleBackColor = True
        Me.triSizeCheck2.Visible = False
        '
        'TriResetButton
        '
        Me.TriResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TriResetButton.Location = New System.Drawing.Point(560, 155)
        Me.TriResetButton.Name = "TriResetButton"
        Me.TriResetButton.Size = New System.Drawing.Size(134, 33)
        Me.TriResetButton.TabIndex = 64
        Me.TriResetButton.Text = "Reset Triangle"
        Me.TriResetButton.UseVisualStyleBackColor = True
        '
        'TriSizeCheck
        '
        Me.TriSizeCheck.AutoSize = True
        Me.TriSizeCheck.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriSizeCheck.Location = New System.Drawing.Point(34, 128)
        Me.TriSizeCheck.Name = "TriSizeCheck"
        Me.TriSizeCheck.Size = New System.Drawing.Size(72, 21)
        Me.TriSizeCheck.TabIndex = 63
        Me.TriSizeCheck.Text = "BIGGER"
        Me.TriSizeCheck.UseVisualStyleBackColor = True
        '
        'bLabel
        '
        Me.bLabel.AutoSize = True
        Me.bLabel.ForeColor = System.Drawing.Color.Blue
        Me.bLabel.Location = New System.Drawing.Point(291, 107)
        Me.bLabel.Name = "bLabel"
        Me.bLabel.Size = New System.Drawing.Size(19, 21)
        Me.bLabel.TabIndex = 62
        Me.bLabel.Text = "B"
        '
        'gLabel
        '
        Me.gLabel.AutoSize = True
        Me.gLabel.ForeColor = System.Drawing.Color.Green
        Me.gLabel.Location = New System.Drawing.Point(291, 75)
        Me.gLabel.Name = "gLabel"
        Me.gLabel.Size = New System.Drawing.Size(21, 21)
        Me.gLabel.TabIndex = 61
        Me.gLabel.Text = "G"
        '
        'rLabel
        '
        Me.rLabel.AutoSize = True
        Me.rLabel.ForeColor = System.Drawing.Color.Red
        Me.rLabel.Location = New System.Drawing.Point(291, 43)
        Me.rLabel.Name = "rLabel"
        Me.rLabel.Size = New System.Drawing.Size(20, 21)
        Me.rLabel.TabIndex = 60
        Me.rLabel.Text = "R"
        '
        'TriAngleNum
        '
        Me.TriAngleNum.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.TriAngleNum.Location = New System.Drawing.Point(635, 12)
        Me.TriAngleNum.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.TriAngleNum.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.TriAngleNum.Name = "TriAngleNum"
        Me.TriAngleNum.Size = New System.Drawing.Size(58, 29)
        Me.TriAngleNum.TabIndex = 59
        '
        'TriAngleBar
        '
        Me.TriAngleBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TriAngleBar.LargeChange = 1
        Me.TriAngleBar.Location = New System.Drawing.Point(636, 44)
        Me.TriAngleBar.Maximum = 180
        Me.TriAngleBar.Minimum = -180
        Me.TriAngleBar.Name = "TriAngleBar"
        Me.TriAngleBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TriAngleBar.Size = New System.Drawing.Size(69, 98)
        Me.TriAngleBar.TabIndex = 58
        Me.TriAngleBar.TickFrequency = 10
        Me.TriAngleBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'angleLabel
        '
        Me.angleLabel.AutoSize = True
        Me.angleLabel.Location = New System.Drawing.Point(559, 14)
        Me.angleLabel.Name = "angleLabel"
        Me.angleLabel.Size = New System.Drawing.Size(53, 21)
        Me.angleLabel.TabIndex = 57
        Me.angleLabel.Text = "Angle:"
        '
        'oBar
        '
        Me.oBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oBar.LargeChange = 1
        Me.oBar.Location = New System.Drawing.Point(380, 157)
        Me.oBar.Maximum = 100
        Me.oBar.Minimum = 1
        Me.oBar.Name = "oBar"
        Me.oBar.Size = New System.Drawing.Size(151, 69)
        Me.oBar.TabIndex = 56
        Me.oBar.TickFrequency = 10
        Me.oBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.oBar.Value = 100
        '
        'bBar
        '
        Me.bBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBar.LargeChange = 1
        Me.bBar.Location = New System.Drawing.Point(379, 105)
        Me.bBar.Maximum = 255
        Me.bBar.Name = "bBar"
        Me.bBar.Size = New System.Drawing.Size(151, 69)
        Me.bBar.TabIndex = 55
        Me.bBar.TickFrequency = 10
        Me.bBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.bBar.Value = 127
        '
        'gBar
        '
        Me.gBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gBar.LargeChange = 1
        Me.gBar.Location = New System.Drawing.Point(379, 73)
        Me.gBar.Maximum = 255
        Me.gBar.Name = "gBar"
        Me.gBar.Size = New System.Drawing.Size(151, 69)
        Me.gBar.TabIndex = 54
        Me.gBar.TickFrequency = 10
        Me.gBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.gBar.Value = 127
        '
        'rBar
        '
        Me.rBar.BackColor = System.Drawing.Color.DarkGray
        Me.rBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rBar.LargeChange = 1
        Me.rBar.Location = New System.Drawing.Point(379, 37)
        Me.rBar.Maximum = 255
        Me.rBar.Name = "rBar"
        Me.rBar.Size = New System.Drawing.Size(151, 69)
        Me.rBar.TabIndex = 53
        Me.rBar.TickFrequency = 10
        Me.rBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.rBar.Value = 127
        '
        'rightArrow
        '
        Me.rightArrow.Location = New System.Drawing.Point(604, 71)
        Me.rightArrow.Name = "rightArrow"
        Me.rightArrow.Size = New System.Drawing.Size(26, 27)
        Me.rightArrow.TabIndex = 52
        Me.rightArrow.Text = "▶"
        Me.rightArrow.UseVisualStyleBackColor = True
        '
        'downArrow
        '
        Me.downArrow.Location = New System.Drawing.Point(577, 104)
        Me.downArrow.Name = "downArrow"
        Me.downArrow.Size = New System.Drawing.Size(26, 27)
        Me.downArrow.TabIndex = 51
        Me.downArrow.Text = "▼"
        Me.downArrow.UseVisualStyleBackColor = True
        '
        'leftArrow
        '
        Me.leftArrow.Location = New System.Drawing.Point(549, 71)
        Me.leftArrow.Name = "leftArrow"
        Me.leftArrow.Size = New System.Drawing.Size(26, 27)
        Me.leftArrow.TabIndex = 50
        Me.leftArrow.Text = "◀"
        Me.leftArrow.UseVisualStyleBackColor = True
        '
        'upArrow
        '
        Me.upArrow.Location = New System.Drawing.Point(577, 37)
        Me.upArrow.Name = "upArrow"
        Me.upArrow.Size = New System.Drawing.Size(26, 27)
        Me.upArrow.TabIndex = 37
        Me.upArrow.Text = "▲"
        Me.upArrow.UseVisualStyleBackColor = True
        '
        'oLabel
        '
        Me.oLabel.AutoSize = True
        Me.oLabel.Location = New System.Drawing.Point(311, 134)
        Me.oLabel.Name = "oLabel"
        Me.oLabel.Size = New System.Drawing.Size(66, 21)
        Me.oLabel.TabIndex = 49
        Me.oLabel.Text = "Opacity:"
        '
        'oNum
        '
        Me.oNum.Location = New System.Drawing.Point(315, 157)
        Me.oNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.oNum.Name = "oNum"
        Me.oNum.Size = New System.Drawing.Size(58, 29)
        Me.oNum.TabIndex = 48
        Me.oNum.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'rgbLabel
        '
        Me.rgbLabel.AutoSize = True
        Me.rgbLabel.Location = New System.Drawing.Point(296, 14)
        Me.rgbLabel.Name = "rgbLabel"
        Me.rgbLabel.Size = New System.Drawing.Size(104, 21)
        Me.rgbLabel.TabIndex = 47
        Me.rgbLabel.Text = "Colour (RGB):"
        '
        'gNum
        '
        Me.gNum.Location = New System.Drawing.Point(315, 73)
        Me.gNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.gNum.Name = "gNum"
        Me.gNum.Size = New System.Drawing.Size(58, 29)
        Me.gNum.TabIndex = 46
        Me.gNum.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'bNum
        '
        Me.bNum.Location = New System.Drawing.Point(315, 105)
        Me.bNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.bNum.Name = "bNum"
        Me.bNum.Size = New System.Drawing.Size(58, 29)
        Me.bNum.TabIndex = 45
        Me.bNum.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'rNum
        '
        Me.rNum.Location = New System.Drawing.Point(315, 41)
        Me.rNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.rNum.Name = "rNum"
        Me.rNum.Size = New System.Drawing.Size(58, 29)
        Me.rNum.TabIndex = 44
        Me.rNum.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'BaseAngleNum
        '
        Me.BaseAngleNum.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.BaseAngleNum.Location = New System.Drawing.Point(186, 87)
        Me.BaseAngleNum.Maximum = New Decimal(New Integer() {80, 0, 0, 0})
        Me.BaseAngleNum.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.BaseAngleNum.Name = "BaseAngleNum"
        Me.BaseAngleNum.Size = New System.Drawing.Size(78, 29)
        Me.BaseAngleNum.TabIndex = 43
        Me.BaseAngleNum.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'baseAngleLabel
        '
        Me.baseAngleLabel.AutoSize = True
        Me.baseAngleLabel.Location = New System.Drawing.Point(150, 14)
        Me.baseAngleLabel.Name = "baseAngleLabel"
        Me.baseAngleLabel.Size = New System.Drawing.Size(89, 21)
        Me.baseAngleLabel.TabIndex = 42
        Me.baseAngleLabel.Text = "Base Angle:"
        '
        'BaseAngleBar
        '
        Me.BaseAngleBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BaseAngleBar.Location = New System.Drawing.Point(154, 37)
        Me.BaseAngleBar.Maximum = 80
        Me.BaseAngleBar.Minimum = 30
        Me.BaseAngleBar.Name = "BaseAngleBar"
        Me.BaseAngleBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.BaseAngleBar.Size = New System.Drawing.Size(69, 151)
        Me.BaseAngleBar.SmallChange = 5
        Me.BaseAngleBar.TabIndex = 41
        Me.BaseAngleBar.TickFrequency = 5
        Me.BaseAngleBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.BaseAngleBar.Value = 60
        '
        'TriSizeNum
        '
        Me.TriSizeNum.Location = New System.Drawing.Point(40, 87)
        Me.TriSizeNum.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.TriSizeNum.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TriSizeNum.Name = "TriSizeNum"
        Me.TriSizeNum.Size = New System.Drawing.Size(78, 29)
        Me.TriSizeNum.TabIndex = 40
        Me.TriSizeNum.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'triSizeLabel
        '
        Me.triSizeLabel.AutoSize = True
        Me.triSizeLabel.Location = New System.Drawing.Point(5, 14)
        Me.triSizeLabel.Name = "triSizeLabel"
        Me.triSizeLabel.Size = New System.Drawing.Size(100, 21)
        Me.triSizeLabel.TabIndex = 39
        Me.triSizeLabel.Text = "Triangle Size:"
        '
        'TriSizeBar
        '
        Me.TriSizeBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TriSizeBar.LargeChange = 20
        Me.TriSizeBar.Location = New System.Drawing.Point(9, 37)
        Me.TriSizeBar.Maximum = 200
        Me.TriSizeBar.Minimum = 10
        Me.TriSizeBar.Name = "TriSizeBar"
        Me.TriSizeBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TriSizeBar.Size = New System.Drawing.Size(69, 151)
        Me.TriSizeBar.TabIndex = 38
        Me.TriSizeBar.TickFrequency = 10
        Me.TriSizeBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TriSizeBar.Value = 100
        '
        'iconPanel
        '
        Me.iconPanel.Controls.Add(Me.NumericUpDown1)
        Me.iconPanel.Controls.Add(Me.Label1)
        Me.iconPanel.Controls.Add(Me.TrackBar1)
        Me.iconPanel.Controls.Add(Me.NumericUpDown2)
        Me.iconPanel.Controls.Add(Me.Label2)
        Me.iconPanel.Controls.Add(Me.TrackBar2)
        Me.iconPanel.Controls.Add(Me.fileGet)
        Me.iconPanel.Controls.Add(Me.iconLabel)
        Me.iconPanel.Controls.Add(Me.iconText)
        Me.iconPanel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconPanel.Location = New System.Drawing.Point(12, 267)
        Me.iconPanel.Name = "iconPanel"
        Me.iconPanel.Size = New System.Drawing.Size(313, 256)
        Me.iconPanel.TabIndex = 38
        Me.iconPanel.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(195, 151)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {80, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(78, 29)
        Me.NumericUpDown1.TabIndex = 49
        Me.NumericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Icon Angle:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(163, 101)
        Me.TrackBar1.Maximum = 80
        Me.TrackBar1.Minimum = 30
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(69, 151)
        Me.TrackBar1.SmallChange = 5
        Me.TrackBar1.TabIndex = 47
        Me.TrackBar1.TickFrequency = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 60
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(49, 151)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(78, 29)
        Me.NumericUpDown2.TabIndex = 46
        Me.NumericUpDown2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Icon Size:"
        '
        'TrackBar2
        '
        Me.TrackBar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar2.LargeChange = 20
        Me.TrackBar2.Location = New System.Drawing.Point(18, 101)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Minimum = -100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(69, 151)
        Me.TrackBar2.TabIndex = 44
        Me.TrackBar2.TickFrequency = 10
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'fileGet
        '
        Me.fileGet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileGet.Location = New System.Drawing.Point(188, 29)
        Me.fileGet.Name = "fileGet"
        Me.fileGet.Size = New System.Drawing.Size(107, 30)
        Me.fileGet.TabIndex = 28
        Me.fileGet.Text = "Browse"
        Me.fileGet.UseVisualStyleBackColor = True
        '
        'iconLabel
        '
        Me.iconLabel.AutoSize = True
        Me.iconLabel.Location = New System.Drawing.Point(92, 7)
        Me.iconLabel.Name = "iconLabel"
        Me.iconLabel.Size = New System.Drawing.Size(81, 21)
        Me.iconLabel.TabIndex = 27
        Me.iconLabel.Text = "Image File"
        '
        'iconText
        '
        Me.iconText.AllowDrop = True
        Me.iconText.Location = New System.Drawing.Point(13, 30)
        Me.iconText.Name = "iconText"
        Me.iconText.ReadOnly = True
        Me.iconText.Size = New System.Drawing.Size(168, 29)
        Me.iconText.TabIndex = 26
        '
        'skinPanel
        '
        Me.skinPanel.Controls.Add(Me.urlLabel)
        Me.skinPanel.Controls.Add(Me.UrlText)
        Me.skinPanel.Controls.Add(Me.Label5)
        Me.skinPanel.Controls.Add(Me.SkinName)
        Me.skinPanel.Controls.Add(Me.createButton)
        Me.skinPanel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skinPanel.Location = New System.Drawing.Point(343, 248)
        Me.skinPanel.Name = "skinPanel"
        Me.skinPanel.Size = New System.Drawing.Size(392, 275)
        Me.skinPanel.TabIndex = 39
        '
        'urlLabel
        '
        Me.urlLabel.AutoSize = True
        Me.urlLabel.Location = New System.Drawing.Point(13, 79)
        Me.urlLabel.Name = "urlLabel"
        Me.urlLabel.Size = New System.Drawing.Size(211, 21)
        Me.urlLabel.TabIndex = 22
        Me.urlLabel.Text = "Url (Internet link or local file):"
        '
        'UrlText
        '
        Me.UrlText.Location = New System.Drawing.Point(17, 103)
        Me.UrlText.Name = "UrlText"
        Me.UrlText.Size = New System.Drawing.Size(250, 29)
        Me.UrlText.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Skin Name:"
        '
        'SkinName
        '
        Me.SkinName.Location = New System.Drawing.Point(17, 35)
        Me.SkinName.Name = "SkinName"
        Me.SkinName.Size = New System.Drawing.Size(100, 29)
        Me.SkinName.TabIndex = 19
        Me.SkinName.Text = "Test"
        '
        'IconCheck
        '
        Me.IconCheck.AutoSize = True
        Me.IconCheck.Location = New System.Drawing.Point(21, 236)
        Me.IconCheck.Name = "IconCheck"
        Me.IconCheck.Size = New System.Drawing.Size(66, 24)
        Me.IconCheck.TabIndex = 40
        Me.IconCheck.Text = "Icon"
        Me.IconCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(747, 600)
        Me.Controls.Add(Me.IconCheck)
        Me.Controls.Add(Me.skinPanel)
        Me.Controls.Add(Me.iconPanel)
        Me.Controls.Add(Me.trianglePanel)
        Me.Controls.Add(Me.closeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.trianglePanel.ResumeLayout(False)
        Me.trianglePanel.PerformLayout()
        CType(Me.TriAngleNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriAngleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseAngleNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseAngleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriSizeNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TriSizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.iconPanel.ResumeLayout(False)
        Me.iconPanel.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.skinPanel.ResumeLayout(False)
        Me.skinPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents createButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents trianglePanel As Panel
    Friend WithEvents bLabel As Label
    Friend WithEvents gLabel As Label
    Friend WithEvents rLabel As Label
    Friend WithEvents TriAngleNum As NumericUpDown
    Friend WithEvents TriAngleBar As TrackBar
    Friend WithEvents angleLabel As Label
    Friend WithEvents oBar As TrackBar
    Friend WithEvents bBar As TrackBar
    Friend WithEvents gBar As TrackBar
    Friend WithEvents rBar As TrackBar
    Friend WithEvents rightArrow As Button
    Friend WithEvents downArrow As Button
    Friend WithEvents leftArrow As Button
    Friend WithEvents upArrow As Button
    Friend WithEvents oLabel As Label
    Friend WithEvents oNum As NumericUpDown
    Friend WithEvents rgbLabel As Label
    Friend WithEvents gNum As NumericUpDown
    Friend WithEvents bNum As NumericUpDown
    Friend WithEvents rNum As NumericUpDown
    Friend WithEvents BaseAngleNum As NumericUpDown
    Friend WithEvents baseAngleLabel As Label
    Friend WithEvents BaseAngleBar As TrackBar
    Friend WithEvents TriSizeNum As NumericUpDown
    Friend WithEvents triSizeLabel As Label
    Friend WithEvents TriSizeBar As TrackBar
    Friend WithEvents iconPanel As Panel
    Friend WithEvents fileGet As Button
    Friend WithEvents iconLabel As Label
    Friend WithEvents iconText As TextBox
    Friend WithEvents skinPanel As Panel
    Friend WithEvents urlLabel As Label
    Friend WithEvents UrlText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SkinName As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents IconCheck As CheckBox
    Friend WithEvents TriSizeCheck As CheckBox
    Friend WithEvents TriResetButton As Button
    Friend WithEvents triSizeCheck2 As CheckBox
    Friend WithEvents TriSizeCheck3 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
