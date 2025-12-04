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
        pbarTime = New ProgressBar()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtTimeInput = New TextBox()
        Label1 = New Label()
        CType(pboxDice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(-1, -1)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(62, 30)
        lblTime.TabIndex = 0
        lblTime.Text = "00:00"
        ' 
        ' GameTimer
        ' 
        GameTimer.Interval = 1000
        ' 
        ' btnDbgStart
        ' 
        btnDbgStart.Location = New Point(3, 82)
        btnDbgStart.Name = "btnDbgStart"
        btnDbgStart.Size = New Size(75, 23)
        btnDbgStart.TabIndex = 1
        btnDbgStart.Text = "Start"
        btnDbgStart.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x1
        ' 
        btnP1_1x1.FlatStyle = FlatStyle.Flat
        btnP1_1x1.Location = New Point(14, 241)
        btnP1_1x1.Name = "btnP1_1x1"
        btnP1_1x1.Size = New Size(64, 63)
        btnP1_1x1.TabIndex = 3
        btnP1_1x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x2
        ' 
        btnP1_1x2.FlatStyle = FlatStyle.Flat
        btnP1_1x2.Location = New Point(84, 241)
        btnP1_1x2.Name = "btnP1_1x2"
        btnP1_1x2.Size = New Size(64, 63)
        btnP1_1x2.TabIndex = 3
        btnP1_1x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1x3
        ' 
        btnP1_1x3.FlatStyle = FlatStyle.Flat
        btnP1_1x3.Location = New Point(154, 241)
        btnP1_1x3.Name = "btnP1_1x3"
        btnP1_1x3.Size = New Size(64, 63)
        btnP1_1x3.TabIndex = 3
        btnP1_1x3.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x3
        ' 
        btnP1_2x3.FlatStyle = FlatStyle.Flat
        btnP1_2x3.Location = New Point(154, 310)
        btnP1_2x3.Name = "btnP1_2x3"
        btnP1_2x3.Size = New Size(64, 63)
        btnP1_2x3.TabIndex = 3
        btnP1_2x3.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x2
        ' 
        btnP1_2x2.FlatStyle = FlatStyle.Flat
        btnP1_2x2.Location = New Point(84, 310)
        btnP1_2x2.Name = "btnP1_2x2"
        btnP1_2x2.Size = New Size(64, 63)
        btnP1_2x2.TabIndex = 3
        btnP1_2x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2x1
        ' 
        btnP1_2x1.FlatStyle = FlatStyle.Flat
        btnP1_2x1.Location = New Point(14, 310)
        btnP1_2x1.Name = "btnP1_2x1"
        btnP1_2x1.Size = New Size(64, 63)
        btnP1_2x1.TabIndex = 3
        btnP1_2x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x1
        ' 
        btnP1_3x1.FlatStyle = FlatStyle.Flat
        btnP1_3x1.Location = New Point(14, 379)
        btnP1_3x1.Name = "btnP1_3x1"
        btnP1_3x1.Size = New Size(64, 63)
        btnP1_3x1.TabIndex = 3
        btnP1_3x1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x2
        ' 
        btnP1_3x2.FlatStyle = FlatStyle.Flat
        btnP1_3x2.Location = New Point(84, 379)
        btnP1_3x2.Name = "btnP1_3x2"
        btnP1_3x2.Size = New Size(64, 63)
        btnP1_3x2.TabIndex = 3
        btnP1_3x2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3x3
        ' 
        btnP1_3x3.FlatStyle = FlatStyle.Flat
        btnP1_3x3.Location = New Point(154, 379)
        btnP1_3x3.Name = "btnP1_3x3"
        btnP1_3x3.Size = New Size(64, 63)
        btnP1_3x3.TabIndex = 3
        btnP1_3x3.UseVisualStyleBackColor = True
        ' 
        ' btnTMPDICE
        ' 
        btnTMPDICE.Location = New Point(658, 62)
        btnTMPDICE.Name = "btnTMPDICE"
        btnTMPDICE.Size = New Size(75, 23)
        btnTMPDICE.TabIndex = 4
        btnTMPDICE.Text = "dice test"
        btnTMPDICE.UseVisualStyleBackColor = True
        ' 
        ' lblDiceTemp
        ' 
        lblDiceTemp.AutoSize = True
        lblDiceTemp.Location = New Point(593, 66)
        lblDiceTemp.Name = "lblDiceTemp"
        lblDiceTemp.Size = New Size(41, 15)
        lblDiceTemp.TabIndex = 5
        lblDiceTemp.Text = "Label1"
        ' 
        ' pboxDice
        ' 
        pboxDice.Location = New Point(471, 44)
        pboxDice.Name = "pboxDice"
        pboxDice.Size = New Size(67, 67)
        pboxDice.TabIndex = 11
        pboxDice.TabStop = False
        ' 
        ' pbarTime
        ' 
        pbarTime.Location = New Point(5, 28)
        pbarTime.Name = "pbarTime"
        pbarTime.Size = New Size(225, 10)
        pbarTime.TabIndex = 7
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtTimeInput
        ' 
        txtTimeInput.Location = New Point(5, 44)
        txtTimeInput.Name = "txtTimeInput"
        txtTimeInput.Size = New Size(38, 23)
        txtTimeInput.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(2, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 15)
        Label1.TabIndex = 10
        Label1.Text = "Insert desired time limit in minutes."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtTimeInput)
        Controls.Add(pbarTime)
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
    Friend WithEvents pbarTime As ProgressBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtTimeInput As TextBox
    Friend WithEvents Label1 As Label

End Class
