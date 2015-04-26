Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text.Length < 3 Then
            Try
                My.Computer.Registry.ClassesRoot.OpenSubKey("*\shell", True).CreateSubKey("Give it to the marmots")
                My.Computer.Registry.ClassesRoot.OpenSubKey("*\shell\Give it to the marmots", True).CreateSubKey("command")
                Dim autoshell = My.Computer.Registry.ClassesRoot.OpenSubKey("*\shell\Give it to the marmots\command", True)
                Dim regvalue As String = """" & TextBox1.Text & """" + " " + """" & "%1" & """"
                autoshell.SetValue("", regvalue)
                autoshell.Close()

                Dim autoshell2 = My.Computer.Registry.ClassesRoot.OpenSubKey("*\shell\Give it to the marmots", True)
                Dim regvalue2 As String = """" & TextBox1.Text & """"
                autoshell2.SetValue("Icon", regvalue2)
                autoshell2.Close()
                MessageBox.Show("Patched! Option 'Give it to the marmots' will appear in context menu", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occured while patching... is it already patched?", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MessageBox.Show("Please locate and select 'MarmotEater.exe' file!", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.Registry.ClassesRoot.OpenSubKey("*\shell", True).DeleteSubKeyTree("Give it to the marmots")
            MessageBox.Show("Removed! Option 'Give it to the marmots' will no longer appear in context menu", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occured while removing... Does it even exists?", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("MarmotEater Registry Patch Made by knackrack615", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OpenFileDialog1.Filter = "Executable Files (*.exe*)|*.exe"
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
                TextBox1.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to set the path!", "MarmotEater Registry Patch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
