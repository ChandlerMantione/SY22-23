<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From2DPlatformer
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
        Me.components = New System.ComponentModel.Container()
        Me.PlayerPictureBox = New System.Windows.Forms.PictureBox()
        Me.AirPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroundPictureBox = New System.Windows.Forms.PictureBox()
        Me.RightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LeftTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameLogicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GravityTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PlayerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroundPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerPictureBox
        '
        Me.PlayerPictureBox.BackColor = System.Drawing.Color.Chocolate
        Me.PlayerPictureBox.Location = New System.Drawing.Point(12, 371)
        Me.PlayerPictureBox.Name = "PlayerPictureBox"
        Me.PlayerPictureBox.Size = New System.Drawing.Size(53, 50)
        Me.PlayerPictureBox.TabIndex = 0
        Me.PlayerPictureBox.TabStop = False
        '
        'AirPictureBox
        '
        Me.AirPictureBox.BackColor = System.Drawing.SystemColors.HotTrack
        Me.AirPictureBox.Location = New System.Drawing.Point(-15, -10)
        Me.AirPictureBox.Name = "AirPictureBox"
        Me.AirPictureBox.Size = New System.Drawing.Size(826, 383)
        Me.AirPictureBox.TabIndex = 1
        Me.AirPictureBox.TabStop = False
        '
        'GroundPictureBox
        '
        Me.GroundPictureBox.BackColor = System.Drawing.Color.Lime
        Me.GroundPictureBox.Location = New System.Drawing.Point(-4, 421)
        Me.GroundPictureBox.Name = "GroundPictureBox"
        Me.GroundPictureBox.Size = New System.Drawing.Size(806, 50)
        Me.GroundPictureBox.TabIndex = 2
        Me.GroundPictureBox.TabStop = False
        '
        'RightTimer
        '
        Me.RightTimer.Interval = 10
        '
        'LeftTimer
        '
        Me.LeftTimer.Interval = 10
        '
        'UpTimer
        '
        Me.UpTimer.Interval = 10
        '
        'GameLogicTimer
        '
        '
        'GravityTimer
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.PictureBox1.Location = New System.Drawing.Point(334, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 19)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Bound"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score:"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ScoreLabel.Location = New System.Drawing.Point(61, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(0, 16)
        Me.ScoreLabel.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(83, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'From2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PlayerPictureBox)
        Me.Controls.Add(Me.GroundPictureBox)
        Me.Controls.Add(Me.AirPictureBox)
        Me.Name = "From2DPlatformer"
        Me.Text = "Form1"
        CType(Me.PlayerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroundPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerPictureBox As PictureBox
    Friend WithEvents AirPictureBox As PictureBox
    Friend WithEvents GroundPictureBox As PictureBox
    Friend WithEvents RightTimer As Timer
    Friend WithEvents LeftTimer As Timer
    Friend WithEvents UpTimer As Timer
    Friend WithEvents GameLogicTimer As Timer
    Friend WithEvents GravityTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
