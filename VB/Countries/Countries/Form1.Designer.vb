﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NewButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.CapitalTextBox = New System.Windows.Forms.TextBox()
        Me.PopulationTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DebugTextBox = New System.Windows.Forms.TextBox()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CountrysComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(209, 17)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 26)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Text = "NewButton"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(291, 16)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 26)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitButton.Location = New System.Drawing.Point(453, 16)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 26)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Location = New System.Drawing.Point(322, 92)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CountryTextBox.TabIndex = 3
        '
        'CapitalTextBox
        '
        Me.CapitalTextBox.Location = New System.Drawing.Point(322, 136)
        Me.CapitalTextBox.Name = "CapitalTextBox"
        Me.CapitalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CapitalTextBox.TabIndex = 4
        '
        'PopulationTextBox
        '
        Me.PopulationTextBox.Location = New System.Drawing.Point(322, 177)
        Me.PopulationTextBox.Name = "PopulationTextBox"
        Me.PopulationTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PopulationTextBox.TabIndex = 5
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(322, 221)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SizeTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Capital:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Population:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Size:"
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DisplayPictureBox.Location = New System.Drawing.Point(187, 249)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(382, 189)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 11
        Me.DisplayPictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DebugTextBox
        '
        Me.DebugTextBox.Location = New System.Drawing.Point(713, 12)
        Me.DebugTextBox.Multiline = True
        Me.DebugTextBox.Name = "DebugTextBox"
        Me.DebugTextBox.Size = New System.Drawing.Size(75, 70)
        Me.DebugTextBox.TabIndex = 12
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(209, 49)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(75, 23)
        Me.FirstButton.TabIndex = 13
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(372, 49)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 14
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(451, 49)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(75, 23)
        Me.LastButton.TabIndex = 15
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(291, 48)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 16
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(372, 17)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 26)
        Me.DeleteButton.TabIndex = 17
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CountrysComboBox
        '
        Me.CountrysComboBox.FormattingEnabled = True
        Me.CountrysComboBox.Location = New System.Drawing.Point(54, 19)
        Me.CountrysComboBox.Name = "CountrysComboBox"
        Me.CountrysComboBox.Size = New System.Drawing.Size(121, 24)
        Me.CountrysComboBox.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CountrysComboBox)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.DebugTextBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(Me.PopulationTextBox)
        Me.Controls.Add(Me.CapitalTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NewButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents CapitalTextBox As TextBox
    Friend WithEvents PopulationTextBox As TextBox
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DebugTextBox As TextBox
    Friend WithEvents FirstButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CountrysComboBox As ComboBox
End Class
