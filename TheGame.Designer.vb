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
        ContextMenuStrip1 = New ContextMenuStrip(components)
        lblP1Score = New Label()
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
        lblP2Score = New Label()
        btnForfeit = New Button()
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
        ' btnP1_1
        ' 
        btnP1_1.FlatStyle = FlatStyle.Flat
        btnP1_1.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_2.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_3.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_6.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_5.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_4.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_7.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_8.Font = New Font("Segoe UI", 14.25F)
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
        btnP1_9.Font = New Font("Segoe UI", 14.25F)
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
        btnRollTheDice.Location = New Point(338, 185)
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
        lblInfoDice.Location = New Point(361, 47)
        lblInfoDice.Name = "lblInfoDice"
        lblInfoDice.Size = New Size(78, 15)
        lblInfoDice.TabIndex = 5
        lblInfoDice.Text = "You rolled a..."
        ' 
        ' pboxDice
        ' 
        pboxDice.BackgroundImageLayout = ImageLayout.Zoom
        pboxDice.Location = New Point(367, 110)
        pboxDice.Name = "pboxDice"
        pboxDice.Size = New Size(67, 67)
        pboxDice.SizeMode = PictureBoxSizeMode.Zoom
        pboxDice.TabIndex = 11
        pboxDice.TabStop = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' lblP1Score
        ' 
        lblP1Score.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblP1Score.ForeColor = Color.Red
        lblP1Score.Location = New Point(130, 211)
        lblP1Score.Name = "lblP1Score"
        lblP1Score.Size = New Size(94, 30)
        lblP1Score.TabIndex = 13
        lblP1Score.Text = "0"
        lblP1Score.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPlayer1
        ' 
        lblPlayer1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayer1.ForeColor = Color.Red
        lblPlayer1.ImageAlign = ContentAlignment.MiddleLeft
        lblPlayer1.Location = New Point(12, 218)
        lblPlayer1.Name = "lblPlayer1"
        lblPlayer1.Size = New Size(112, 21)
        lblPlayer1.TabIndex = 14
        lblPlayer1.Text = "Player 1"
        lblPlayer1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDiceNumber
        ' 
        lblDiceNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiceNumber.ForeColor = SystemColors.Control
        lblDiceNumber.Location = New Point(375, 67)
        lblDiceNumber.Name = "lblDiceNumber"
        lblDiceNumber.Size = New Size(50, 37)
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
        lblIndicator.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIndicator.ForeColor = SystemColors.Control
        lblIndicator.Location = New Point(294, 255)
        lblIndicator.Name = "lblIndicator"
        lblIndicator.Size = New Size(213, 91)
        lblIndicator.TabIndex = 17
        lblIndicator.Text = "Roll the dice!"
        lblIndicator.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnP2_1
        ' 
        btnP2_1.FlatStyle = FlatStyle.Flat
        btnP2_1.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_2.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_3.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_6.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_5.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_4.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_7.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_8.Font = New Font("Segoe UI", 14.25F)
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
        btnP2_9.Font = New Font("Segoe UI", 14.25F)
        btnP2_9.ForeColor = Color.Purple
        btnP2_9.Location = New Point(724, 379)
        btnP2_9.Name = "btnP2_9"
        btnP2_9.Size = New Size(64, 63)
        btnP2_9.TabIndex = 3
        btnP2_9.UseVisualStyleBackColor = True
        ' 
        ' lblPlayer2
        ' 
        lblPlayer2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayer2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        lblPlayer2.ImageAlign = ContentAlignment.MiddleRight
        lblPlayer2.Location = New Point(677, 218)
        lblPlayer2.Name = "lblPlayer2"
        lblPlayer2.Size = New Size(114, 21)
        lblPlayer2.TabIndex = 14
        lblPlayer2.Text = "Player 2"
        lblPlayer2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblP2Score
        ' 
        lblP2Score.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblP2Score.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        lblP2Score.Location = New Point(579, 211)
        lblP2Score.Name = "lblP2Score"
        lblP2Score.Size = New Size(92, 30)
        lblP2Score.TabIndex = 13
        lblP2Score.Text = "0"
        lblP2Score.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnForfeit
        ' 
        btnForfeit.FlatStyle = FlatStyle.Flat
        btnForfeit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForfeit.ForeColor = Color.Gray
        btnForfeit.Location = New Point(316, 393)
        btnForfeit.Name = "btnForfeit"
        btnForfeit.Size = New Size(168, 49)
        btnForfeit.TabIndex = 18
        btnForfeit.Text = "Forfeit"
        btnForfeit.UseVisualStyleBackColor = True
        ' 
        ' TheGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 450)
        Controls.Add(btnForfeit)
        Controls.Add(lblIndicator)
        Controls.Add(lblTimerTxt)
        Controls.Add(lblDiceNumber)
        Controls.Add(lblPlayer2)
        Controls.Add(lblPlayer1)
        Controls.Add(lblP2Score)
        Controls.Add(lblP1Score)
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblP1Score As Label
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
    Friend WithEvents lblP2Score As Label
    Friend WithEvents btnForfeit As Button

End Class
