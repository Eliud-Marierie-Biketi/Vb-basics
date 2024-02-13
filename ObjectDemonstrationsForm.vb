Public Class ObjectDemonstrationsForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ObjectDemonstrationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BoldStyleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldStyleCheckBox.CheckedChanged
        ' Check if the checkbox is checked
        If BoldStyleCheckBox.Checked Then
            ' Apply bold style to the text in TextBox2
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Bold)
        Else
            ' Remove bold style if the checkbox is unchecked
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Regular)
        End If
    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FontTahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FontTahomaRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If FontTahomaRadioButton.Checked Then
            ' Change the font of the text in TextBox2 to Tahoma
            TextBox2.Font = New Font("Tahoma", 10, FontStyle.Regular) ' Change the font to Tahoma with size 10 and regular style
        End If
    End Sub

    Private Sub FontGaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FontGaramondRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If FontGaramondRadioButton.Checked Then
            ' Change the font of the text in TextBox2 to Garamond
            TextBox2.Font = New Font("Garamond", 12, FontStyle.Regular) ' Change the font to Garamond with size 12 and regular style
        End If
    End Sub

    Private Sub FontMagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FontMagnetoRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If FontMagnetoRadioButton.Checked Then
            ' Change the font of the text in TextBox2 to Magneto
            TextBox2.Font = New Font("Magneto", 12, FontStyle.Regular) ' Change the font to Magneto with size 12 and regular style
        End If
    End Sub

    Private Sub ItalicStyleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicStyleCheckBox.CheckedChanged
        ' Check if the checkbox is checked
        If ItalicStyleCheckBox.Checked Then
            ' Apply italic style to the text in TextBox2
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Italic)
        Else
            ' Remove italic style if the checkbox is unchecked
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub BoldItalicStyleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicStyleCheckBox.CheckedChanged
        ' Check if the checkbox is checked
        If BoldItalicStyleCheckBox.Checked Then
            ' Apply bold and italic style to the text in TextBox2
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Bold Or FontStyle.Italic)
        Else
            ' Remove bold and italic style if the checkbox is unchecked
            TextBox2.Font = New Font(TextBox2.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub GreenColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenColorRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If GreenColorRadioButton.Checked Then
            ' Change the color of the text in TextBox2 to green
            TextBox2.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueColorRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If BlueColorRadioButton.Checked Then
            ' Change the color of the text in TextBox2 to blue
            TextBox2.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedColorRadioButton.CheckedChanged
        ' Check if the radio button is checked
        If RedColorRadioButton.Checked Then
            ' Change the color of the text in TextBox2 to red
            TextBox2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the current form
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties of the dialog
        openFileDialog.Title = "Select an Image File"
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"
        openFileDialog.Multiselect = False

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into PictureBox1
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

End Class