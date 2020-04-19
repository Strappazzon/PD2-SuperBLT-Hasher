#Region "Copyright (c) 2019 - 2020 Alberto Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher"
''
'' SuperBLT Hasher - VB.Net implementation of SuperBLT Hashing Library
''
'' Copyright (c) 2020 Alberto Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher
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

    Public Shared Sub HashInput(ByVal inputPath As String)
        AsyncHasher.RunWorkerAsync(inputPath)
    End Sub

#Region "Async subroutines"
    Private Shared Sub AsyncHasher_DoWork(sender As Object, e As DoWorkEventArgs) Handles AsyncHasher.DoWork
        Try
            'Check whether the specified/dropped path is a folder or a file
            '//stackoverflow.com/a/439478
            Dim IsDir As Boolean = (File.GetAttributes(e.Argument()) And FileAttributes.Directory) = FileAttributes.Directory
            If IsDir = True Then
                'Hash the selected folder
                Dim Hash As String = Hasher.HashDirectory(e.Argument())
                e.Result = Hash
            Else
                'Hash the selected file
                Dim Hash As String = Hasher.HashFile(e.Argument())
                e.Result = Hash
            End If
        Catch ex As Exception
            ErrorMessage = ex.Message()
        End Try
    End Sub

    Private Shared Sub AsyncHasher_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles AsyncHasher.RunWorkerCompleted
        If ErrorMessage = Nothing Then
            'Write the result
            Form1.HashTextBox.Text = e.Result()

            'Write the hash to a text file
            If Form1.CopyToHashTxtCheckBox.Checked = True Then
                Using S As SaveFileDialog = New SaveFileDialog() With {
                    .FileName = "hash",
                    .Filter = "Text file|.txt",
                    .InitialDirectory = Form1.PathTextBox.Text,
                    .Title = "Save hash as..."
                }
                    If S.ShowDialog = DialogResult.OK Then
                        File.AppendAllText(S.FileName, e.Result())
                    End If
                End Using
            End If

            'Copy the hash to clipboard
            If Form1.CopyToClipboardCheckBox.Checked = True Then
                Clipboard.SetText(e.Result())
            End If
        Else
            Form1.HashTextBox.Text = "Error."
            MessageBox.Show("An error occurred while attempting to compute the hash: " & ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorMessage = Nothing
        End If
    End Sub
#End Region
End Class
