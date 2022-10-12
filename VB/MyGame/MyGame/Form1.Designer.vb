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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EnemyPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EnemyPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox11 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox10 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox5 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox6 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox7 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox8 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLabel = New System.Windows.Forms.Label()
        CType(Me.EnemyPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'EnemyPictureBox3
        '
        Me.EnemyPictureBox3.Image = Global.MyGame.My.Resources.Resources.Ark_player_3
        Me.EnemyPictureBox3.Location = New System.Drawing.Point(23, 201)
        Me.EnemyPictureBox3.Name = "EnemyPictureBox3"
        Me.EnemyPictureBox3.Size = New System.Drawing.Size(81, 89)
        Me.EnemyPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPictureBox3.TabIndex = 9
        Me.EnemyPictureBox3.TabStop = False
        Me.EnemyPictureBox3.Visible = False
        '
        'EnemyPictureBox2
        '
        Me.EnemyPictureBox2.Image = Global.MyGame.My.Resources.Resources.Ark_player_2
        Me.EnemyPictureBox2.Location = New System.Drawing.Point(27, 105)
        Me.EnemyPictureBox2.Name = "EnemyPictureBox2"
        Me.EnemyPictureBox2.Size = New System.Drawing.Size(60, 90)
        Me.EnemyPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPictureBox2.TabIndex = 8
        Me.EnemyPictureBox2.TabStop = False
        Me.EnemyPictureBox2.Visible = False
        '
        'EnemyPictureBox1
        '
        Me.EnemyPictureBox1.Image = Global.MyGame.My.Resources.Resources.Ark_Player
        Me.EnemyPictureBox1.Location = New System.Drawing.Point(27, 22)
        Me.EnemyPictureBox1.Name = "EnemyPictureBox1"
        Me.EnemyPictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.EnemyPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPictureBox1.TabIndex = 7
        Me.EnemyPictureBox1.TabStop = False
        Me.EnemyPictureBox1.Visible = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox3.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox3.Location = New System.Drawing.Point(481, 59)
        Me.WallPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(48, 71)
        Me.WallPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox3.TabIndex = 6
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox4.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox4.Location = New System.Drawing.Point(252, 201)
        Me.WallPictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(51, 48)
        Me.WallPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox4.TabIndex = 5
        Me.WallPictureBox4.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.MyGame.My.Resources.Resources.Dodo
        Me.Player.Location = New System.Drawing.Point(342, 201)
        Me.Player.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(49, 46)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'WallPictureBox11
        '
        Me.WallPictureBox11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox11.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox11.Location = New System.Drawing.Point(82, 328)
        Me.WallPictureBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox11.Name = "WallPictureBox11"
        Me.WallPictureBox11.Size = New System.Drawing.Size(36, 53)
        Me.WallPictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox11.TabIndex = 10
        Me.WallPictureBox11.TabStop = False
        '
        'WallPictureBox10
        '
        Me.WallPictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox10.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox10.Location = New System.Drawing.Point(718, 276)
        Me.WallPictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox10.Name = "WallPictureBox10"
        Me.WallPictureBox10.Size = New System.Drawing.Size(40, 59)
        Me.WallPictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox10.TabIndex = 11
        Me.WallPictureBox10.TabStop = False
        '
        'WallPictureBox2
        '
        Me.WallPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox2.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox2.Location = New System.Drawing.Point(326, 356)
        Me.WallPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox2.Name = "WallPictureBox2"
        Me.WallPictureBox2.Size = New System.Drawing.Size(49, 78)
        Me.WallPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox2.TabIndex = 12
        Me.WallPictureBox2.TabStop = False
        '
        'WallPictureBox1
        '
        Me.WallPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox1.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox1.Location = New System.Drawing.Point(686, 93)
        Me.WallPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox1.Name = "WallPictureBox1"
        Me.WallPictureBox1.Size = New System.Drawing.Size(30, 59)
        Me.WallPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox1.TabIndex = 13
        Me.WallPictureBox1.TabStop = False
        '
        'WallPictureBox5
        '
        Me.WallPictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox5.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox5.Location = New System.Drawing.Point(119, 125)
        Me.WallPictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox5.Name = "WallPictureBox5"
        Me.WallPictureBox5.Size = New System.Drawing.Size(45, 61)
        Me.WallPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox5.TabIndex = 14
        Me.WallPictureBox5.TabStop = False
        '
        'WallPictureBox6
        '
        Me.WallPictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox6.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox6.Location = New System.Drawing.Point(619, 405)
        Me.WallPictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox6.Name = "WallPictureBox6"
        Me.WallPictureBox6.Size = New System.Drawing.Size(33, 57)
        Me.WallPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox6.TabIndex = 15
        Me.WallPictureBox6.TabStop = False
        '
        'WallPictureBox7
        '
        Me.WallPictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox7.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox7.Location = New System.Drawing.Point(517, 201)
        Me.WallPictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox7.Name = "WallPictureBox7"
        Me.WallPictureBox7.Size = New System.Drawing.Size(42, 75)
        Me.WallPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox7.TabIndex = 16
        Me.WallPictureBox7.TabStop = False
        '
        'WallPictureBox8
        '
        Me.WallPictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox8.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox8.Location = New System.Drawing.Point(268, 34)
        Me.WallPictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox8.Name = "WallPictureBox8"
        Me.WallPictureBox8.Size = New System.Drawing.Size(44, 65)
        Me.WallPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox8.TabIndex = 17
        Me.WallPictureBox8.TabStop = False
        '
        'WallPictureBox9
        '
        Me.WallPictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WallPictureBox9.Image = Global.MyGame.My.Resources.Resources.Tree
        Me.WallPictureBox9.Location = New System.Drawing.Point(849, 238)
        Me.WallPictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPictureBox9.Name = "WallPictureBox9"
        Me.WallPictureBox9.Size = New System.Drawing.Size(39, 75)
        Me.WallPictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox9.TabIndex = 18
        Me.WallPictureBox9.TabStop = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Location = New System.Drawing.Point(370, 20)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(14, 16)
        Me.TimerLabel.TabIndex = 19
        Me.TimerLabel.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyGame.My.Resources.Resources.arkbeach
        Me.ClientSize = New System.Drawing.Size(900, 490)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.WallPictureBox9)
        Me.Controls.Add(Me.WallPictureBox8)
        Me.Controls.Add(Me.WallPictureBox7)
        Me.Controls.Add(Me.WallPictureBox6)
        Me.Controls.Add(Me.WallPictureBox5)
        Me.Controls.Add(Me.WallPictureBox1)
        Me.Controls.Add(Me.WallPictureBox2)
        Me.Controls.Add(Me.WallPictureBox10)
        Me.Controls.Add(Me.WallPictureBox11)
        Me.Controls.Add(Me.EnemyPictureBox3)
        Me.Controls.Add(Me.EnemyPictureBox2)
        Me.Controls.Add(Me.EnemyPictureBox1)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.EnemyPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents WallPictureBox4 As PictureBox
    Friend WithEvents WallPictureBox3 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents EnemyPictureBox1 As PictureBox
    Friend WithEvents EnemyPictureBox2 As PictureBox
    Friend WithEvents EnemyPictureBox3 As PictureBox
    Friend WithEvents WallPictureBox11 As PictureBox
    Friend WithEvents WallPictureBox10 As PictureBox
    Friend WithEvents WallPictureBox2 As PictureBox
    Friend WithEvents WallPictureBox1 As PictureBox
    Friend WithEvents WallPictureBox5 As PictureBox
    Friend WithEvents WallPictureBox6 As PictureBox
    Friend WithEvents WallPictureBox7 As PictureBox
    Friend WithEvents WallPictureBox8 As PictureBox
    Friend WithEvents WallPictureBox9 As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TimerLabel As Label
End Class
