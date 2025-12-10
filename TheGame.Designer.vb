<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TheGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheGame))
        lblTime = New Label()
        GameTimer = New Timer(components)
        btnDbgStart = New Button()
        btnP1_1 = New Button()
        btnP1_2 = New Button()
        btnP1_3 = New Button()
        btnP1_6 = New Button()
        btnP1_5 = New Button()
        btnP1_4 = New Button()
        btnP1_7 = New Button()
        btnP1_8 = New Button()
        btnP1_9 = New Button()
        btnRollTheDice = New Button()
        lblInfoDice = New Label()
        pboxDice = New PictureBox()
        pbarTime = New ProgressBar()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtTimeInput = New TextBox()
        Label1 = New Label()
        lblDbgScore = New Label()
        lblPlayer1 = New Label()
        lblDiceNumber = New Label()
        lblTimerTxt = New Label()
        lblIndicator = New Label()
        btnP2_1 = New Button()
        btnP2_2 = New Button()
        btnP2_3 = New Button()
        btnP2_6 = New Button()
        btnP2_5 = New Button()
        btnP2_4 = New Button()
        btnP2_7 = New Button()
        btnP2_8 = New Button()
        btnP2_9 = New Button()
        lblPlayer2 = New Label()
        CType(pboxDice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = SystemColors.Control
        lblTime.Location = New Point(365, 15)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(71, 32)
        lblTime.TabIndex = 0
        lblTime.Text = "00:00"
        ' 
        ' GameTimer
        ' 
        GameTimer.Interval = 1000
        ' 
        ' btnDbgStart
        ' 
        btnDbgStart.Location = New Point(3, 73)
        btnDbgStart.Name = "btnDbgStart"
        btnDbgStart.Size = New Size(75, 23)
        btnDbgStart.TabIndex = 1
        btnDbgStart.Text = "Start"
        btnDbgStart.UseVisualStyleBackColor = True
        ' 
        ' btnP1_1
        ' 
        btnP1_1.FlatStyle = FlatStyle.Flat
        btnP1_1.ForeColor = Color.Maroon
        btnP1_1.Location = New Point(14, 241)
        btnP1_1.Name = "btnP1_1"
        btnP1_1.Size = New Size(64, 63)
        btnP1_1.TabIndex = 3
        btnP1_1.UseVisualStyleBackColor = True
        ' 
        ' btnP1_2
        ' 
        btnP1_2.FlatStyle = FlatStyle.Flat
        btnP1_2.ForeColor = Color.Maroon
        btnP1_2.Location = New Point(84, 241)
        btnP1_2.Name = "btnP1_2"
        btnP1_2.Size = New Size(64, 63)
        btnP1_2.TabIndex = 3
        btnP1_2.UseVisualStyleBackColor = True
        ' 
        ' btnP1_3
        ' 
        btnP1_3.BackgroundImageLayout = ImageLayout.Zoom
        btnP1_3.FlatStyle = FlatStyle.Flat
        btnP1_3.ForeColor = Color.Maroon
        btnP1_3.Location = New Point(154, 241)
        btnP1_3.Name = "btnP1_3"
        btnP1_3.Size = New Size(64, 63)
        btnP1_3.TabIndex = 3
        btnP1_3.UseVisualStyleBackColor = True
        ' 
        ' btnP1_6
        ' 
        btnP1_6.FlatStyle = FlatStyle.Flat
        btnP1_6.ForeColor = Color.Maroon
        btnP1_6.Location = New Point(154, 310)
        btnP1_6.Name = "btnP1_6"
        btnP1_6.Size = New Size(64, 63)
        btnP1_6.TabIndex = 3
        btnP1_6.UseVisualStyleBackColor = True
        ' 
        ' btnP1_5
        ' 
        btnP1_5.FlatStyle = FlatStyle.Flat
        btnP1_5.ForeColor = Color.Maroon
        btnP1_5.Location = New Point(84, 310)
        btnP1_5.Name = "btnP1_5"
        btnP1_5.Size = New Size(64, 63)
        btnP1_5.TabIndex = 3
        btnP1_5.UseVisualStyleBackColor = True
        ' 
        ' btnP1_4
        ' 
        btnP1_4.FlatStyle = FlatStyle.Flat
        btnP1_4.ForeColor = Color.Maroon
        btnP1_4.Location = New Point(14, 310)
        btnP1_4.Name = "btnP1_4"
        btnP1_4.Size = New Size(64, 63)
        btnP1_4.TabIndex = 3
        btnP1_4.UseVisualStyleBackColor = True
        ' 
        ' btnP1_7
        ' 
        btnP1_7.FlatStyle = FlatStyle.Flat
        btnP1_7.ForeColor = Color.Maroon
        btnP1_7.Location = New Point(14, 379)
        btnP1_7.Name = "btnP1_7"
        btnP1_7.Size = New Size(64, 63)
        btnP1_7.TabIndex = 3
        btnP1_7.UseVisualStyleBackColor = True
        ' 
        ' btnP1_8
        ' 
        btnP1_8.FlatStyle = FlatStyle.Flat
        btnP1_8.ForeColor = Color.Maroon
        btnP1_8.Location = New Point(84, 379)
        btnP1_8.Name = "btnP1_8"
        btnP1_8.Size = New Size(64, 63)
        btnP1_8.TabIndex = 3
        btnP1_8.UseVisualStyleBackColor = True
        ' 
        ' btnP1_9
        ' 
        btnP1_9.FlatStyle = FlatStyle.Flat
        btnP1_9.ForeColor = Color.Maroon
        btnP1_9.Location = New Point(154, 379)
        btnP1_9.Name = "btnP1_9"
        btnP1_9.Size = New Size(64, 63)
        btnP1_9.TabIndex = 3
        btnP1_9.UseVisualStyleBackColor = True
        ' 
        ' btnRollTheDice
        ' 
        btnRollTheDice.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnRollTheDice.FlatStyle = FlatStyle.Flat
        btnRollTheDice.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRollTheDice.ForeColor = Color.DarkGray
        btnRollTheDice.Location = New Point(338, 200)
        btnRollTheDice.Name = "btnRollTheDice"
        btnRollTheDice.Size = New Size(124, 50)
        btnRollTheDice.TabIndex = 4
        btnRollTheDice.Text = "Roll!"
        btnRollTheDice.UseVisualStyleBackColor = False
        ' 
        ' lblInfoDice
        ' 
        lblInfoDice.AutoSize = True
        lblInfoDice.ForeColor = SystemColors.Control
        lblInfoDice.Location = New Point(361, 62)
        lblInfoDice.Name = "lblInfoDice"
        lblInfoDice.Size = New Size(78, 15)
        lblInfoDice.TabIndex = 5
        lblInfoDice.Text = "You rolled a..."
        ' 
        ' pboxDice
        ' 
        pboxDice.BackgroundImageLayout = ImageLayout.Zoom
        pboxDice.Location = New Point(367, 125)
        pboxDice.Name = "pboxDice"
        pboxDice.Size = New Size(67, 67)
        pboxDice.SizeMode = PictureBoxSizeMode.Zoom
        pboxDice.TabIndex = 11
        pboxDice.TabStop = False
        ' 
        ' pbarTime
        ' 
        pbarTime.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        pbarTime.Location = New Point(288, 46)
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
        Label1.Location = New Point(84, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 15)
        Label1.TabIndex = 10
        Label1.Text = "Insert desired time limit in minutes."
        ' 
        ' lblDbgScore
        ' 
        lblDbgScore.AutoSize = True
        lblDbgScore.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDbgScore.ForeColor = SystemColors.Control
        lblDbgScore.Location = New Point(143, 218)
        lblDbgScore.Name = "lblDbgScore"
        lblDbgScore.Size = New Size(79, 21)
        lblDbgScore.TabIndex = 13
        lblDbgScore.Text = "Score Test"
        ' 
        ' lblPlayer1
        ' 
        lblPlayer1.AutoSize = True
        lblPlayer1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayer1.ForeColor = Color.Red
        lblPlayer1.ImageAlign = ContentAlignment.MiddleLeft
        lblPlayer1.Location = New Point(12, 218)
        lblPlayer1.Name = "lblPlayer1"
        lblPlayer1.Size = New Size(64, 21)
        lblPlayer1.TabIndex = 14
        lblPlayer1.Text = "Player 1"
        lblPlayer1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDiceNumber
        ' 
        lblDiceNumber.AutoSize = True
        lblDiceNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiceNumber.ForeColor = SystemColors.Control
        lblDiceNumber.Location = New Point(384, 82)
        lblDiceNumber.Name = "lblDiceNumber"
        lblDiceNumber.Size = New Size(0, 37)
        lblDiceNumber.TabIndex = 15
        lblDiceNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTimerTxt
        ' 
        lblTimerTxt.AutoSize = True
        lblTimerTxt.ForeColor = SystemColors.Control
        lblTimerTxt.Location = New Point(380, 5)
        lblTimerTxt.Name = "lblTimerTxt"
        lblTimerTxt.Size = New Size(40, 15)
        lblTimerTxt.TabIndex = 16
        lblTimerTxt.Text = "Timer:"
        ' 
        ' lblIndicator
        ' 
        lblIndicator.AutoSize = True
        lblIndicator.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIndicator.ForeColor = SystemColors.Control
        lblIndicator.Location = New Point(332, 310)
        lblIndicator.Name = "lblIndicator"
        lblIndicator.Size = New Size(136, 30)
        lblIndicator.TabIndex = 17
        lblIndicator.Text = "Roll the dice!"
        lblIndicator.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnP2_1
        ' 
        btnP2_1.FlatStyle = FlatStyle.Flat
        btnP2_1.ForeColor = Color.Purple
        btnP2_1.Location = New Point(584, 241)
        btnP2_1.Name = "btnP2_1"
        btnP2_1.Size = New Size(64, 63)
        btnP2_1.TabIndex = 3
        btnP2_1.UseVisualStyleBackColor = True
        ' 
        ' btnP2_2
        ' 
        btnP2_2.FlatStyle = FlatStyle.Flat
        btnP2_2.ForeColor = Color.Purple
        btnP2_2.Location = New Point(654, 241)
        btnP2_2.Name = "btnP2_2"
        btnP2_2.Size = New Size(64, 63)
        btnP2_2.TabIndex = 3
        btnP2_2.UseVisualStyleBackColor = True
        ' 
        ' btnP2_3
        ' 
        btnP2_3.FlatStyle = FlatStyle.Flat
        btnP2_3.ForeColor = Color.Purple
        btnP2_3.Location = New Point(724, 241)
        btnP2_3.Name = "btnP2_3"
        btnP2_3.Size = New Size(64, 63)
        btnP2_3.TabIndex = 3
        btnP2_3.UseVisualStyleBackColor = True
        ' 
        ' btnP2_6
        ' 
        btnP2_6.FlatStyle = FlatStyle.Flat
        btnP2_6.ForeColor = Color.Purple
        btnP2_6.Location = New Point(724, 310)
        btnP2_6.Name = "btnP2_6"
        btnP2_6.Size = New Size(64, 63)
        btnP2_6.TabIndex = 3
        btnP2_6.UseVisualStyleBackColor = True
        ' 
        ' btnP2_5
        ' 
        btnP2_5.FlatStyle = FlatStyle.Flat
        btnP2_5.ForeColor = Color.Purple
        btnP2_5.Location = New Point(654, 310)
        btnP2_5.Name = "btnP2_5"
        btnP2_5.Size = New Size(64, 63)
        btnP2_5.TabIndex = 3
        btnP2_5.UseVisualStyleBackColor = True
        ' 
        ' btnP2_4
        ' 
        btnP2_4.FlatStyle = FlatStyle.Flat
        btnP2_4.ForeColor = Color.Purple
        btnP2_4.Location = New Point(584, 310)
        btnP2_4.Name = "btnP2_4"
        btnP2_4.Size = New Size(64, 63)
        btnP2_4.TabIndex = 3
        btnP2_4.UseVisualStyleBackColor = True
        ' 
        ' btnP2_7
        ' 
        btnP2_7.FlatStyle = FlatStyle.Flat
        btnP2_7.ForeColor = Color.Purple
        btnP2_7.Location = New Point(584, 379)
        btnP2_7.Name = "btnP2_7"
        btnP2_7.Size = New Size(64, 63)
        btnP2_7.TabIndex = 3
        btnP2_7.UseVisualStyleBackColor = True
        ' 
        ' btnP2_8
        ' 
        btnP2_8.FlatStyle = FlatStyle.Flat
        btnP2_8.ForeColor = Color.Purple
        btnP2_8.Location = New Point(654, 379)
        btnP2_8.Name = "btnP2_8"
        btnP2_8.Size = New Size(64, 63)
        btnP2_8.TabIndex = 3
        btnP2_8.UseVisualStyleBackColor = True
        ' 
        ' btnP2_9
        ' 
        btnP2_9.FlatStyle = FlatStyle.Flat
        btnP2_9.ForeColor = Color.Purple
        btnP2_9.Location = New Point(724, 379)
        btnP2_9.Name = "btnP2_9"
        btnP2_9.Size = New Size(64, 63)
        btnP2_9.TabIndex = 3
        btnP2_9.UseVisualStyleBackColor = True
        ' 
        ' lblPlayer2
        ' 
        lblPlayer2.AutoSize = True
        lblPlayer2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayer2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        lblPlayer2.ImageAlign = ContentAlignment.MiddleRight
        lblPlayer2.Location = New Point(724, 218)
        lblPlayer2.Name = "lblPlayer2"
        lblPlayer2.Size = New Size(67, 21)
        lblPlayer2.TabIndex = 14
        lblPlayer2.Text = "Player 2"
        lblPlayer2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TheGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 450)
        Controls.Add(lblIndicator)
        Controls.Add(lblTimerTxt)
        Controls.Add(lblDiceNumber)
        Controls.Add(lblPlayer2)
        Controls.Add(lblPlayer1)
        Controls.Add(lblDbgScore)
        Controls.Add(Label1)
        Controls.Add(txtTimeInput)
        Controls.Add(pbarTime)
        Controls.Add(pboxDice)
        Controls.Add(lblInfoDice)
        Controls.Add(btnRollTheDice)
        Controls.Add(btnP2_9)
        Controls.Add(btnP1_9)
        Controls.Add(btnP2_8)
        Controls.Add(btnP1_8)
        Controls.Add(btnP2_7)
        Controls.Add(btnP1_7)
        Controls.Add(btnP2_4)
        Controls.Add(btnP1_4)
        Controls.Add(btnP2_5)
        Controls.Add(btnP1_5)
        Controls.Add(btnP2_6)
        Controls.Add(btnP1_6)
        Controls.Add(btnP2_3)
        Controls.Add(btnP2_2)
        Controls.Add(btnP1_3)
        Controls.Add(btnP2_1)
        Controls.Add(btnP1_2)
        Controls.Add(btnP1_1)
        Controls.Add(btnDbgStart)
        Controls.Add(lblTime)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "TheGame"
        Text = "CotL Knucklebones: Visual Basic Edition"
        CType(pboxDice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents btnDbgStart As Button
    Friend WithEvents btnP1_1 As Button
    Friend WithEvents btnP1_2 As Button
    Friend WithEvents btnP1_3 As Button
    Friend WithEvents btnP1_6 As Button
    Friend WithEvents btnP1_5 As Button
    Friend WithEvents btnP1_4 As Button
    Friend WithEvents btnP1_7 As Button
    Friend WithEvents btnP1_8 As Button
    Friend WithEvents btnP1_9 As Button
    Friend WithEvents btnRollTheDice As Button
    Friend WithEvents lblInfoDice As Label
    Friend WithEvents pboxDice As PictureBox
    Friend WithEvents pbarTime As ProgressBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtTimeInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDbgScore As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblDiceNumber As Label
    Friend WithEvents lblTimerTxt As Label
    Friend WithEvents lblIndicator As Label
    Friend WithEvents btnP2_1 As Button
    Friend WithEvents btnP2_2 As Button
    Friend WithEvents btnP2_3 As Button
    Friend WithEvents btnP2_6 As Button
    Friend WithEvents btnP2_5 As Button
    Friend WithEvents btnP2_4 As Button
    Friend WithEvents btnP2_7 As Button
    Friend WithEvents btnP2_8 As Button
    Friend WithEvents btnP2_9 As Button
    Friend WithEvents lblPlayer2 As Label

End Class
