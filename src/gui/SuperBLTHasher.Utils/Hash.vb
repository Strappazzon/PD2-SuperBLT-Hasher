﻿#Region "Copyright (c) 2020 Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher"
''
'' SuperBLT Hasher - Calculate PAYDAY 2 mods hashes
''
'' Copyright (c) 2020 Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher
''
'' Permission is hereby granted, free of charge, to any person obtaining a copy
'' of this software and associated documentation files (the "Software"), to deal
'' in the Software without restriction, including without limitation the rights
'' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
'' copies of the Software, and to permit persons to whom the Software is
'' furnished to do so, subject to the following conditions:
''
'' The above copyright notice and this permission notice shall be included in all
'' copies or substantial portions of the Software.
''
'' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
'' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
'' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
'' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
'' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
'' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
'' SOFTWARE.
''
#End Region

Imports System.ComponentModel
Imports System.IO
Imports ZNix.SuperBLT

Public Class Hash
    Private Shared WithEvents AsyncHasher As BackgroundWorker = New BackgroundWorker()
    Private Shared Property ErrorMessage As String = Nothing
    Public Shared ReadOnly ErrorText As String = "Error."

    Public Shared Sub HashInput(inputPath As String)
        AsyncHasher.RunWorkerAsync(inputPath)
    End Sub

#Region "Async subroutines"
    Private Shared Sub AsyncHasher_DoWork(sender As Object, e As DoWorkEventArgs) Handles AsyncHasher.DoWork
        Try
            'Check whether path is a folder or a file
            '//stackoverflow.com/a/439478
            Dim IsDir As Boolean = (File.GetAttributes(e.Argument()) And FileAttributes.Directory) = FileAttributes.Directory
            If IsDir = True Then
                Dim Hash As String = Hasher.HashDirectory(e.Argument())
                e.Result = Hash
            Else
                Dim Hash As String = Hasher.HashFile(e.Argument())
                e.Result = Hash
            End If
        Catch ex As Exception
            ErrorMessage = ex.Message()
        End Try
    End Sub

    Private Shared Sub AsyncHasher_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles AsyncHasher.RunWorkerCompleted
        If ErrorMessage = Nothing Then
            Form1.HashTextBox.Text = e.Result()
        Else
            Form1.HashTextBox.Text = ErrorText
            MessageBox.Show("An error occurred while attempting to compute the hash: " & ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorMessage = Nothing
        End If
    End Sub
#End Region
End Class
