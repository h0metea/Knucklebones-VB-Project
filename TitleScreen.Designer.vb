<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitleScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TitleScreen))
        btnStartTheGame = New Button()
        btnExit = New Button()
        btnImNewToThis = New Button()
        pboxCOTL = New PictureBox()
        pboxKB = New PictureBox()
        lblKnuckle = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        lblVisual = New Label()
        lblEdition = New Label()
        txtP1Name = New TextBox()
        txtP2Name = New TextBox()
        ttPlrNames = New ToolTip(components)
        lblP1Info = New Label()
        lblP2Info = New Label()
        txtTimeInput = New TextBox()
        lblTimerInputInfo = New Label()
        CType(pboxCOTL, ComponentModel.ISupportInitialize).BeginInit()
        CType(pboxKB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStartTheGame
        ' 
        btnStartTheGame.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        btnStartTheGame.FlatStyle = FlatStyle.Flat
        btnStartTheGame.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStartTheGame.ForeColor = Color.Purple
        btnStartTheGame.Location = New Point(229, 338)
        btnStartTheGame.Name = "btnStartTheGame"
        btnStartTheGame.Size = New Size(168, 50)
        btnStartTheGame.TabIndex = 0
        btnStartTheGame.Text = "Start..."
        btnStartTheGame.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.Maroon
        btnExit.Location = New Point(403, 394)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(168, 50)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnImNewToThis
        ' 
        btnImNewToThis.FlatStyle = FlatStyle.Flat
        btnImNewToThis.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImNewToThis.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        btnImNewToThis.Location = New Point(403, 338)
        btnImNewToThis.Name = "btnImNewToThis"
        btnImNewToThis.Size = New Size(168, 50)
        btnImNewToThis.TabIndex = 0
        btnImNewToThis.Text = "Tutorial"
        btnImNewToThis.UseVisualStyleBackColor = True
        ' 
        ' pboxCOTL
        ' 
        pboxCOTL.BackgroundImageLayout = ImageLayout.None
        pboxCOTL.Image = My.Resources.Logos.COTL
        pboxCOTL.Location = New Point(198, 12)
        pboxCOTL.Name = "pboxCOTL"
        pboxCOTL.Size = New Size(404, 155)
        pboxCOTL.SizeMode = PictureBoxSizeMode.Zoom
        pboxCOTL.TabIndex = 1
        pboxCOTL.TabStop = False
        ' 
        ' pboxKB
        ' 
        pboxKB.Image = My.Resources.Logos.VS
        pboxKB.Location = New Point(261, 173)
        pboxKB.Name = "pboxKB"
        pboxKB.Size = New Size(279, 159)
        pboxKB.SizeMode = PictureBoxSizeMode.Zoom
        pboxKB.TabIndex = 2
        pboxKB.TabStop = False
        ' 
        ' lblKnuckle
        ' 
        lblKnuckle.AutoSize = True
        lblKnuckle.Font = New Font("Engravers MT", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKnuckle.ForeColor = Color.Maroon
        lblKnuckle.ImageAlign = ContentAlignment.MiddleRight
        lblKnuckle.Location = New Point(22, 184)
        lblKnuckle.Name = "lblKnuckle"
        lblKnuckle.Size = New Size(230, 74)
        lblKnuckle.TabIndex = 3
        lblKnuckle.Text = "KNUCKLE" & vbCrLf & "BONES"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' lblVisual
        ' 
        lblVisual.AutoSize = True
        lblVisual.Font = New Font("Engravers MT", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVisual.ForeColor = Color.Maroon
        lblVisual.Location = New Point(609, 184)
        lblVisual.Name = "lblVisual"
        lblVisual.Size = New Size(179, 74)
        lblVisual.TabIndex = 3
        lblVisual.Text = "VISUAL" & vbCrLf & "BASIC" & vbCrLf
        lblVisual.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblEdition
        ' 
        lblEdition.AutoSize = True
        lblEdition.Font = New Font("Engravers MT", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEdition.ForeColor = Color.Maroon
        lblEdition.Location = New Point(702, 252)
        lblEdition.Name = "lblEdition"
        lblEdition.Size = New Size(76, 12)
        lblEdition.TabIndex = 3
        lblEdition.Text = "edition"
        lblEdition.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtP1Name
        ' 
        txtP1Name.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        txtP1Name.BorderStyle = BorderStyle.FixedSingle
        txtP1Name.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        txtP1Name.Location = New Point(52, 376)
        txtP1Name.Name = "txtP1Name"
        txtP1Name.Size = New Size(100, 23)
        txtP1Name.TabIndex = 4
        ' 
        ' txtP2Name
        ' 
        txtP2Name.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        txtP2Name.BorderStyle = BorderStyle.FixedSingle
        txtP2Name.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        txtP2Name.Location = New Point(635, 377)
        txtP2Name.Name = "txtP2Name"
        txtP2Name.Size = New Size(100, 23)
        txtP2Name.TabIndex = 5
        ' 
        ' lblP1Info
        ' 
        lblP1Info.AutoSize = True
        lblP1Info.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblP1Info.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblP1Info.Location = New Point(56, 358)
        lblP1Info.Name = "lblP1Info"
        lblP1Info.Size = New Size(92, 15)
        lblP1Info.TabIndex = 6
        lblP1Info.Text = "Player 1's Name"
        ' 
        ' lblP2Info
        ' 
        lblP2Info.AutoSize = True
        lblP2Info.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblP2Info.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        lblP2Info.Location = New Point(640, 359)
        lblP2Info.Name = "lblP2Info"
        lblP2Info.Size = New Size(92, 15)
        lblP2Info.TabIndex = 7
        lblP2Info.Text = "Player 2's Name"
        ' 
        ' txtTimeInput
        ' 
        txtTimeInput.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        txtTimeInput.BorderStyle = BorderStyle.FixedSingle
        txtTimeInput.ForeColor = SystemColors.Menu
        txtTimeInput.Location = New Point(364, 408)
        txtTimeInput.Name = "txtTimeInput"
        txtTimeInput.Size = New Size(33, 23)
        txtTimeInput.TabIndex = 8
        ' 
        ' lblTimerInputInfo
        ' 
        lblTimerInputInfo.AutoSize = True
        lblTimerInputInfo.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        lblTimerInputInfo.Location = New Point(229, 402)
        lblTimerInputInfo.Name = "lblTimerInputInfo"
        lblTimerInputInfo.Size = New Size(133, 30)
        lblTimerInputInfo.TabIndex = 9
        lblTimerInputInfo.Text = "Type the desired length " & vbCrLf & "of the game in minutes."
        lblTimerInputInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TitleScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 450)
        Controls.Add(lblTimerInputInfo)
        Controls.Add(txtTimeInput)
        Controls.Add(lblP2Info)
        Controls.Add(lblP1Info)
        Controls.Add(txtP2Name)
        Controls.Add(txtP1Name)
        Controls.Add(lblEdition)
        Controls.Add(lblVisual)
        Controls.Add(lblKnuckle)
        Controls.Add(pboxKB)
        Controls.Add(pboxCOTL)
        Controls.Add(btnImNewToThis)
        Controls.Add(btnExit)
        Controls.Add(btnStartTheGame)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(816, 489)
        MinimumSize = New Size(816, 489)
        Name = "TitleScreen"
        Text = "CotL Knucklebones: Visual Basic Edition"
        CType(pboxCOTL, ComponentModel.ISupportInitialize).EndInit()
        CType(pboxKB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStartTheGame As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnImNewToThis As Button
    Friend WithEvents pboxCOTL As PictureBox
    Friend WithEvents pboxKB As PictureBox
    Friend WithEvents lblKnuckle As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents lblVisual As Label
    Friend WithEvents lblEdition As Label
    Friend WithEvents txtP1Name As TextBox
    Friend WithEvents txtP2Name As TextBox
    Friend WithEvents ttPlrNames As ToolTip
    Friend WithEvents lblP1Info As Label
    Friend WithEvents lblP2Info As Label
    Friend WithEvents txtTimeInput As TextBox
    Friend WithEvents lblTimerInputInfo As Label
End Class
