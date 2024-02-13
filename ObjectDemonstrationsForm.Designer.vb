<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ObjectDemonstrationsForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BoldItalicStyleCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoldStyleCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItalicStyleCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RedColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FontTahomaRadioButton = New System.Windows.Forms.RadioButton()
        Me.FontMagnetoRadioButton = New System.Windows.Forms.RadioButton()
        Me.FontGaramondRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(810, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Object Demonstrations"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(64, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 207)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Load Picture"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(515, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 33)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BoldItalicStyleCheckBox)
        Me.GroupBox1.Controls.Add(Me.BoldStyleCheckBox)
        Me.GroupBox1.Controls.Add(Me.ItalicStyleCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 207)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font Style"
        '
        'BoldItalicStyleCheckBox
        '
        Me.BoldItalicStyleCheckBox.AutoSize = True
        Me.BoldItalicStyleCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoldItalicStyleCheckBox.Location = New System.Drawing.Point(22, 159)
        Me.BoldItalicStyleCheckBox.Name = "BoldItalicStyleCheckBox"
        Me.BoldItalicStyleCheckBox.Size = New System.Drawing.Size(132, 29)
        Me.BoldItalicStyleCheckBox.TabIndex = 2
        Me.BoldItalicStyleCheckBox.Text = "Bold Italic"
        Me.BoldItalicStyleCheckBox.UseVisualStyleBackColor = True
        '
        'BoldStyleCheckBox
        '
        Me.BoldStyleCheckBox.AutoSize = True
        Me.BoldStyleCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoldStyleCheckBox.Location = New System.Drawing.Point(22, 95)
        Me.BoldStyleCheckBox.Name = "BoldStyleCheckBox"
        Me.BoldStyleCheckBox.Size = New System.Drawing.Size(81, 29)
        Me.BoldStyleCheckBox.TabIndex = 1
        Me.BoldStyleCheckBox.Text = "Bold"
        Me.BoldStyleCheckBox.UseVisualStyleBackColor = True
        '
        'ItalicStyleCheckBox
        '
        Me.ItalicStyleCheckBox.AutoSize = True
        Me.ItalicStyleCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalicStyleCheckBox.Location = New System.Drawing.Point(22, 34)
        Me.ItalicStyleCheckBox.Name = "ItalicStyleCheckBox"
        Me.ItalicStyleCheckBox.Size = New System.Drawing.Size(77, 29)
        Me.ItalicStyleCheckBox.TabIndex = 0
        Me.ItalicStyleCheckBox.Text = "Italic"
        Me.ItalicStyleCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RedColorRadioButton)
        Me.GroupBox2.Controls.Add(Me.BlueColorRadioButton)
        Me.GroupBox2.Controls.Add(Me.GreenColorRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(593, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 207)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font Color"
        '
        'RedColorRadioButton
        '
        Me.RedColorRadioButton.AutoSize = True
        Me.RedColorRadioButton.Location = New System.Drawing.Point(16, 159)
        Me.RedColorRadioButton.Name = "RedColorRadioButton"
        Me.RedColorRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.RedColorRadioButton.TabIndex = 2
        Me.RedColorRadioButton.TabStop = True
        Me.RedColorRadioButton.Text = "Red"
        Me.RedColorRadioButton.UseVisualStyleBackColor = True
        '
        'BlueColorRadioButton
        '
        Me.BlueColorRadioButton.AutoSize = True
        Me.BlueColorRadioButton.Location = New System.Drawing.Point(16, 95)
        Me.BlueColorRadioButton.Name = "BlueColorRadioButton"
        Me.BlueColorRadioButton.Size = New System.Drawing.Size(66, 24)
        Me.BlueColorRadioButton.TabIndex = 1
        Me.BlueColorRadioButton.TabStop = True
        Me.BlueColorRadioButton.Text = "Blue"
        Me.BlueColorRadioButton.UseVisualStyleBackColor = True
        '
        'GreenColorRadioButton
        '
        Me.GreenColorRadioButton.AutoSize = True
        Me.GreenColorRadioButton.Location = New System.Drawing.Point(16, 34)
        Me.GreenColorRadioButton.Name = "GreenColorRadioButton"
        Me.GreenColorRadioButton.Size = New System.Drawing.Size(79, 24)
        Me.GreenColorRadioButton.TabIndex = 0
        Me.GreenColorRadioButton.TabStop = True
        Me.GreenColorRadioButton.Text = "Green"
        Me.GreenColorRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FontTahomaRadioButton)
        Me.GroupBox3.Controls.Add(Me.FontMagnetoRadioButton)
        Me.GroupBox3.Controls.Add(Me.FontGaramondRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 67)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font"
        '
        'FontTahomaRadioButton
        '
        Me.FontTahomaRadioButton.AutoSize = True
        Me.FontTahomaRadioButton.Location = New System.Drawing.Point(276, 24)
        Me.FontTahomaRadioButton.Name = "FontTahomaRadioButton"
        Me.FontTahomaRadioButton.Size = New System.Drawing.Size(92, 24)
        Me.FontTahomaRadioButton.TabIndex = 2
        Me.FontTahomaRadioButton.TabStop = True
        Me.FontTahomaRadioButton.Text = "Tahoma"
        Me.FontTahomaRadioButton.UseVisualStyleBackColor = True
        '
        'FontMagnetoRadioButton
        '
        Me.FontMagnetoRadioButton.AutoSize = True
        Me.FontMagnetoRadioButton.Location = New System.Drawing.Point(137, 24)
        Me.FontMagnetoRadioButton.Name = "FontMagnetoRadioButton"
        Me.FontMagnetoRadioButton.Size = New System.Drawing.Size(97, 24)
        Me.FontMagnetoRadioButton.TabIndex = 1
        Me.FontMagnetoRadioButton.TabStop = True
        Me.FontMagnetoRadioButton.Text = "Magneto"
        Me.FontMagnetoRadioButton.UseVisualStyleBackColor = True
        '
        'FontGaramondRadioButton
        '
        Me.FontGaramondRadioButton.AutoSize = True
        Me.FontGaramondRadioButton.Location = New System.Drawing.Point(6, 24)
        Me.FontGaramondRadioButton.Name = "FontGaramondRadioButton"
        Me.FontGaramondRadioButton.Size = New System.Drawing.Size(110, 24)
        Me.FontGaramondRadioButton.TabIndex = 0
        Me.FontGaramondRadioButton.TabStop = True
        Me.FontGaramondRadioButton.Text = "Garamond"
        Me.FontGaramondRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(64, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 83)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Display Text"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(265, 26)
        Me.TextBox2.TabIndex = 0
        '
        'ObjectDemonstrationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ObjectDemonstrationsForm"
        Me.Text = "ObjectDemonstrationsForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BoldItalicStyleCheckBox As CheckBox
    Friend WithEvents BoldStyleCheckBox As CheckBox
    Friend WithEvents ItalicStyleCheckBox As CheckBox
    Friend WithEvents FontTahomaRadioButton As RadioButton
    Friend WithEvents FontMagnetoRadioButton As RadioButton
    Friend WithEvents FontGaramondRadioButton As RadioButton
    Friend WithEvents RedColorRadioButton As RadioButton
    Friend WithEvents BlueColorRadioButton As RadioButton
    Friend WithEvents GreenColorRadioButton As RadioButton
End Class
