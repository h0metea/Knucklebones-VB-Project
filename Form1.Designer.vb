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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDbgStop)
        Controls.Add(btnDbgStart)
        Controls.Add(lblTime)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents btnDbgStart As Button
    Friend WithEvents btnDbgStop As Button

End Class
