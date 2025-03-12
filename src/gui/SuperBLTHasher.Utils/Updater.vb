#Region "Copyright (c) 2020 Strappazzon, https://strappazzon.xyz/PD2-SuperBLT-Hasher"
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

Imports System.Net.Http

Public Class Updater
    Public Shared ReadOnly VersionString As String = My.Application.Info.Version.ToString().Remove(5)
    Private Shared ReadOnly VersionCode As Integer = My.Application.Info.Version.Revision
    Private Shared ReadOnly VersionURI As Uri = New Uri("https://raw.githubusercontent.com/Strappazzon/PD2-SuperBLT-Hasher/master/version")

    'Check for updates
    '//docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient
    Public Shared Async Sub CheckUpdates()
        Try
            Using Updater As HttpClient = New HttpClient()
                Updater.DefaultRequestHeaders.Add("User-Agent", "SuperBLT Hasher (+https://strappazzon.xyz/PD2-SuperBLT-Hasher)")
                Dim FetchedVer As Integer = Integer.Parse(Await Updater.GetStringAsync(VersionURI))

                'Compare downloaded SuperBLT Hasher version number with the current one
                Select Case FetchedVer
                    Case VersionCode
                        MessageBox.Show("SuperBLT Hasher is up to date.", Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case > VersionCode
                        Dim Response = MessageBox.Show(
                            "A newer version of SuperBLT Hasher is available. Do you want to visit the download page now?",
                            Form1.Text,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1
                        )
                        If Response = DialogResult.Yes Then
                            Process.Start("https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest")
                        End If
                    Case < VersionCode
                        MessageBox.Show("The version in use is greater than the one currently available.", Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case Else
                        Exit Select
                End Select
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to check for updates: " & ex.Message(), Form1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
