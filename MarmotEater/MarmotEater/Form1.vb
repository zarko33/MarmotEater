Imports System.IO

Public Class Form1
    Dim startupdirectory As String = Path.GetFullPath(System.Windows.Forms.Application.StartupPath)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = startupdirectory + "\images\default.jpg"
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        For i As Integer = 0 To CommandLineArgs.Count - 1
            Dim result As Integer = MessageBox.Show("Give " + CommandLineArgs(i) + " to the marmots?", "MarmotEater", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.No Then
                End
            ElseIf result = DialogResult.Yes Then
                Try
                    Timer1.Start()
                    My.Computer.FileSystem.DeleteFile(CommandLineArgs(i))f
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+1)
        Try
            If ProgressBar1.Value = 15 Then
                PictureBox1.ImageLocation = startupdirectory + "\images\1.jpg"
            End If
        Catch ex As Exception
            MessageBox.Show("Images are missing! Please re-download MarmotEater from http://hgcommunity.net", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        
        Try
            If ProgressBar1.Value = 35 Then
                PictureBox1.ImageLocation = startupdirectory + "\images\2.jpg"
            End If
        Catch ex As Exception
            MessageBox.Show("Images are missing! Please re-download MarmotEater from http://hgcommunity.net", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        
        Try
            If ProgressBar1.Value = 55 Then
                PictureBox1.ImageLocation = startupdirectory + "\images\3.jpg"
            End If
        Catch ex As Exception
            MessageBox.Show("Images are missing! Please re-download MarmotEater from http://hgcommunity.net", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        
        Try
            If ProgressBar1.Value = 75 Then
                PictureBox1.ImageLocation = startupdirectory + "\images\4.jpg"
            End If
        Catch ex As Exception
            MessageBox.Show("Images are missing! Please re-download MarmotEater from http://hgcommunity.net", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        
        Try
            If ProgressBar1.Value = 95 Then
                PictureBox1.ImageLocation = startupdirectory + "\images\5.jpg"
            End If
        Catch ex As Exception
            MessageBox.Show("Images are missing! Please re-download MarmotEater from http://hgcommunity.net", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("The File has been eaten!", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("MarmotEater Made by knackrack615", "MarmotEater", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
