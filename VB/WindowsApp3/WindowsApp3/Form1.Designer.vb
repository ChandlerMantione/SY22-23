<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CCLabel = New System.Windows.Forms.Label()
        Me.EXPDateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.EXPDateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.VisaPictureBox = New System.Windows.Forms.PictureBox()
        Me.FeeLabel = New System.Windows.Forms.Label()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        CType(Me.VisaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'CCLabel
        '
        Me.CCLabel.AutoSize = True
        Me.CCLabel.Location = New System.Drawing.Point(12, 37)
        Me.CCLabel.Name = "CCLabel"
        Me.CCLabel.Size = New System.Drawing.Size(28, 13)
        Me.CCLabel.TabIndex = 1
        Me.CCLabel.Text = "CC#"
        '
        'EXPDateLabel
        '
        Me.EXPDateLabel.AutoSize = True
        Me.EXPDateLabel.Location = New System.Drawing.Point(12, 59)
        Me.EXPDateLabel.Name = "EXPDateLabel"
        Me.EXPDateLabel.Size = New System.Drawing.Size(63, 13)
        Me.EXPDateLabel.TabIndex = 2
        Me.EXPDateLabel.Text = "EXP Date"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(12, 85)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(28, 13)
        Me.ZipLabel.TabIndex = 3
        Me.ZipLabel.Text = "Zip"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(12, 110)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(49, 13)
        Me.AmountLabel.TabIndex = 4
        Me.AmountLabel.Text = "Amount"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(81, 9)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(81, 34)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CCTextBox.TabIndex = 6
        '
        'EXPDateTextBox
        '
        Me.EXPDateTextBox.Location = New System.Drawing.Point(81, 59)
        Me.EXPDateTextBox.Name = "EXPDateTextBox"
        Me.EXPDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EXPDateTextBox.TabIndex = 7
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(81, 82)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipTextBox.TabIndex = 8
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(81, 110)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 9
        '
        'BuyButton
        '
        Me.BuyButton.Location = New System.Drawing.Point(12, 182)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(75, 23)
        Me.BuyButton.TabIndex = 10
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(106, 182)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'VisaPictureBox
        '
        Me.VisaPictureBox.Image = Global.WindowsApp3.My.Resources.Resources.Visa_svg
        Me.VisaPictureBox.Location = New System.Drawing.Point(209, 12)
        Me.VisaPictureBox.Name = "VisaPictureBox"
        Me.VisaPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.VisaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VisaPictureBox.TabIndex = 12
        Me.VisaPictureBox.TabStop = False
        '
        'FeeLabel
        '
        Me.FeeLabel.AutoSize = True
        Me.FeeLabel.Location = New System.Drawing.Point(12, 154)
        Me.FeeLabel.Name = "FeeLabel"
        Me.FeeLabel.Size = New System.Drawing.Size(28, 13)
        Me.FeeLabel.TabIndex = 13
        Me.FeeLabel.Text = "Fee"
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(81, 147)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FeeTextBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 366)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.FeeLabel)
        Me.Controls.Add(Me.VisaPictureBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.BuyButton)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.EXPDateTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.EXPDateLabel)
        Me.Controls.Add(Me.CCLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Font = New System.Drawing.Font("MS Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "My Application"
        CType(Me.VisaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents CCLabel As Label
    Friend WithEvents EXPDateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents EXPDateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents BuyButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents VisaPictureBox As PictureBox
    Friend WithEvents FeeLabel As Label
    Friend WithEvents FeeTextBox As TextBox
End Class
