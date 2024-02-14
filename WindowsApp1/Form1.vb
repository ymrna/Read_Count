
Imports System.IO

Public Class Form1
    Dim fileName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                fileName = openFileDialog1.FileName
                TextBox2.Text = Path.GetFileName(fileName)
                Dim lines() As String = File.ReadAllLines(fileName)
                TextBox1.Lines = lines
            Catch Ex As Exception
                MessageBox.Show("Error loading file: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Lines.Length > 0 Then
            MessageBox.Show("Isi file:")
            For Each line As String In TextBox1.Lines
                MessageBox.Show(line)
            Next
        Else
            MessageBox.Show("File kosong.")
        End If

        ' Perulangan
        Dim sum As Integer = 0
        For Each line As String In TextBox1.Lines
            Dim number As Integer
            If Integer.TryParse(line, number) Then
                sum += number
            End If
        Next
        MessageBox.Show("Total: " & sum)
        ' Panggil procedure
        DisplayMessage("Proses selesai.")

    End Sub

    ' Procedure
    Sub DisplayMessage(message As String)
        MessageBox.Show(message)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menutup Program?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close() ' Menutup form
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
