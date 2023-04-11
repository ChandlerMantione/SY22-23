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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.PokemonTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.GenerationTextBox = New System.Windows.Forms.TextBox()
        Me.EvolutionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.PokemonComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(351, 12)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(437, 426)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'PokemonTextBox
        '
        Me.PokemonTextBox.Location = New System.Drawing.Point(104, 82)
        Me.PokemonTextBox.Name = "PokemonTextBox"
        Me.PokemonTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PokemonTextBox.TabIndex = 1
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(104, 122)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TypeTextBox.TabIndex = 2
        '
        'GenerationTextBox
        '
        Me.GenerationTextBox.Location = New System.Drawing.Point(104, 168)
        Me.GenerationTextBox.Name = "GenerationTextBox"
        Me.GenerationTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GenerationTextBox.TabIndex = 3
        '
        'EvolutionTextBox
        '
        Me.EvolutionTextBox.Location = New System.Drawing.Point(104, 208)
        Me.EvolutionTextBox.Name = "EvolutionTextBox"
        Me.EvolutionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.EvolutionTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pokemon:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Generation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Evolution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Id #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Region:"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(104, 244)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 11
        '
        'RegionTextBox
        '
        Me.RegionTextBox.Location = New System.Drawing.Point(104, 284)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RegionTextBox.TabIndex = 12
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(15, 37)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(75, 23)
        Me.FirstButton.TabIndex = 13
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(94, 37)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 14
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(175, 37)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 15
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(256, 37)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(75, 23)
        Me.LastButton.TabIndex = 16
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(86, 381)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(167, 381)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 18
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(248, 381)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 19
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(5, 381)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 23)
        Me.NewButton.TabIndex = 20
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'PokemonComboBox
        '
        Me.PokemonComboBox.FormattingEnabled = True
        Me.PokemonComboBox.Location = New System.Drawing.Point(210, 80)
        Me.PokemonComboBox.Name = "PokemonComboBox"
        Me.PokemonComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PokemonComboBox.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PokemonComboBox)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EvolutionTextBox)
        Me.Controls.Add(Me.GenerationTextBox)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.PokemonTextBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents PokemonTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents GenerationTextBox As TextBox
    Friend WithEvents EvolutionTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents FirstButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents PokemonComboBox As ComboBox
End Class
