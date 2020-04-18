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

Imports System.Net.Http

Public Class Updater
    Private Shared ReadOnly VersionCode As Integer = 3
    Private Shared ReadOnly VersionURI As Uri = New Uri("https://raw.githubusercontent.com/Strappazzon/PD2-SuperBLT-Hasher/master/version")

    'Check for updates
    '//docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient
    Public Shared Async Sub CheckUpdates()
        If Form1.UpdatesCheckBox.Checked = True Then
            Try
                Using Updater As HttpClient = New HttpClient()
                    Updater.DefaultRequestHeaders.Add("User-Agent", "SuperBLT Hasher (+https://strappazzon.xyz/PD2-SuperBLT-Hasher)")
                    Dim FetchedVer As Integer = Integer.Parse(Await Updater.GetStringAsync(VersionURI))

                    'Compare downloaded SuperBLT hasher version number with the current one
                    If FetchedVer > VersionCode Then
                        Dim result = MessageBox.Show("A newer version of SuperBLT Hasher is available. Do you want to visit the download page now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        If result = DialogResult.Yes Then
                            Process.Start("https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest")
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while checking for updates: " & ex.Message(), Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
