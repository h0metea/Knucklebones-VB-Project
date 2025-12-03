<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTime = New Label()
        GameTimer = New Timer(components)
        btnDbgStart = New Button()
        btnDbgStop = New Button()
        btnP1_1x1 = New Button()
        btnP1_1x2 = New Button()
        btnP1_1x3 = New Button()
        btnP1_2x3 = New Button()
        btnP1_2x2 = New Button()
        btnP1_2x1 = New Button()
        btnP1_3x1 = New Button()
        btnP1_3x2 = New Button()
        btnP1_3x3 = New Button()
        btnTMPDICE = New Button()
        lblDiceTemp = New Label()
        pboxDice = New PictureBox()
        CType(pboxDice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(688, 9)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(100, 30)
        lblTime.TabIndex = 0
        lblTime.Text = "00:00.000"
        ' 
        ' GameTimer
        ' 
        GameTimer.Interval = 25
        ' 
        ' btnDbgStart
        ' 
        btnDbgStart.Location = New Point(526, 16)
        btnDbgStart.Name = "btnDbgStart"
        btnDbgStart.Size = New Size(75, 23)
        btnDbgStart.TabIndex = 1
        btnDbgStart.Text = "Start"
        btnDbgStart.UseVisualStyleBackColor = True
        ' 
        ' btnDbgStop
        ' 
        btnDbgStop.Location = New Point(607, 16)
        btnDbgStop.Name = "btnDbgStop"
        btnDbgStop.Size = New Size(75, 23)
        btnDbgStop.TabIndex = 2
        btnDbgStop.Text = "Stop / Skip"
        btnDbgStop.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x1
        ' 
        btnP1_1x1.FlatStyle = FlatStyle.Flat
        btnP1_1x1.Location = New Point(60, 152)
        btnP1_1x1.Name = "btnP1_1x1"
        btnP1_1x1.Size = New Size(64, 63)
        btnP1_1x1.TabIndex = 3
        btnP1_1x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x2
        ' 
        btnP1_1x2.FlatStyle = FlatStyle.Flat
        btnP1_1x2.Location = New Point(130, 152)
        btnP1_1x2.Name = "btnP1_1x2"
        btnP1_1x2.Size = New Size(64, 63)
        btnP1_1x2.TabIndex = 3
        btnP1_1x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x3
        ' 
        btnP1_1x3.FlatStyle = FlatStyle.Flat
        btnP1_1x3.Location = New Point(200, 152)
        btnP1_1x3.Name = "btnP1_1x3"
        btnP1_1x3.Size = New Size(64, 63)
        btnP1_1x3.TabIndex = 3
        btnP1_1x3.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x3
        ' 
        btnP1_2x3.FlatStyle = FlatStyle.Flat
        btnP1_2x3.Location = New Point(200, 221)
        btnP1_2x3.Name = "btnP1_2x3"
        btnP1_2x3.Size = New Size(64, 63)
        btnP1_2x3.TabIndex = 3
        btnP1_2x3.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x2
        ' 
        btnP1_2x2.FlatStyle = FlatStyle.Flat
        btnP1_2x2.Location = New Point(130, 221)
        btnP1_2x2.Name = "btnP1_2x2"
        btnP1_2x2.Size = New Size(64, 63)
        btnP1_2x2.TabIndex = 3
        btnP1_2x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x1
        ' 
        btnP1_2x1.FlatStyle = FlatStyle.Flat
        btnP1_2x1.Location = New Point(60, 221)
        btnP1_2x1.Name = "btnP1_2x1"
        btnP1_2x1.Size = New Size(64, 63)
        btnP1_2x1.TabIndex = 3
        btnP1_2x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x1
        ' 
        btnP1_3x1.FlatStyle = FlatStyle.Flat
        btnP1_3x1.Location = New Point(60, 290)
        btnP1_3x1.Name = "btnP1_3x1"
        btnP1_3x1.Size = New Size(64, 63)
        btnP1_3x1.TabIndex = 3
        btnP1_3x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x2
        ' 
        btnP1_3x2.FlatStyle = FlatStyle.Flat
        btnP1_3x2.Location = New Point(130, 290)
        btnP1_3x2.Name = "btnP1_3x2"
        btnP1_3x2.Size = New Size(64, 63)
        btnP1_3x2.TabIndex = 3
        btnP1_3x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x3
        ' 
        btnP1_3x3.FlatStyle = FlatStyle.Flat
        btnP1_3x3.Location = New Point(200, 290)
        btnP1_3x3.Name = "btnP1_3x3"
        btnP1_3x3.Size = New Size(64, 63)
        btnP1_3x3.TabIndex = 3
        btnP1_3x3.UseVisualStyleBackColor = True
        ' 
        ' btnTMPDICE
        ' 
        btnTMPDICE.Location = New Point(642, 183)
        btnTMPDICE.Name = "btnTMPDICE"
        btnTMPDICE.Size = New Size(75, 23)
        btnTMPDICE.TabIndex = 4
        btnTMPDICE.Text = "dice test"
        btnTMPDICE.UseVisualStyleBackColor = True
        ' 
        ' lblDiceTemp
        ' 
        lblDiceTemp.AutoSize = True
        lblDiceTemp.Location = New Point(577, 187)
        lblDiceTemp.Name = "lblDiceTemp"
        lblDiceTemp.Size = New Size(41, 15)
        lblDiceTemp.TabIndex = 5
        lblDiceTemp.Text = "Label1"
        ' 
        ' pboxDice
        ' 
        pboxDice.Location = New Point(450, 166)
        pboxDice.Name = "pboxDice"
        pboxDice.Size = New Size(77, 81)
        pboxDice.TabIndex = 6
        pboxDice.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pboxDice)
        Controls.Add(lblDiceTemp)
        Controls.Add(btnTMPDICE)
        Controls.Add(btnP1_3x3)
        Controls.Add(btnP1_3x2)
        Controls.Add(btnP1_3x1)
        Controls.Add(btnP1_2x1)
        Controls.Add(btnP1_2x2)
        Controls.Add(btnP1_2x3)
        Controls.Add(btnP1_1x3)
        Controls.Add(btnP1_1x2)
        Controls.Add(btnP1_1x1)
        Controls.Add(btnDbgStop)
        Controls.Add(btnDbgStart)
        Controls.Add(lblTime)
        Name = "Form1"
        Text = "Form1"
        CType(pboxDice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents btnDbgStart As Button
    Friend WithEvents btnDbgStop As Button
    Friend WithEvents btnP1_1x1 As Button
    Friend WithEvents btnP1_1x2 As Button
    Friend WithEvents btnP1_1x3 As Button
    Friend WithEvents btnP1_2x3 As Button
    Friend WithEvents btnP1_2x2 As Button
    Friend WithEvents btnP1_2x1 As Button
    Friend WithEvents btnP1_3x1 As Button
    Friend WithEvents btnP1_3x2 As Button
    Friend WithEvents btnP1_3x3 As Button
    Friend WithEvents btnTMPDICE As Button
    Friend WithEvents lblDiceTemp As Label
    Friend WithEvents pboxDice As PictureBox

End Class
