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

Imports System.IO
Imports IniParser
Imports IniParser.Model

Public Class Settings
    Private Shared ReadOnly SettingsFile As String = Directory.GetParent(Path.GetFileName(Application.ExecutablePath)).ToString() & "\user.cfg"
    Private Shared Config As IniData
    Private Shared ConfigData As IniData
    Private Shared ReadOnly ConfigParser As FileIniDataParser = New FileIniDataParser()

    Public Shared Sub Init()
        If Not File.Exists(SettingsFile) Then
            'Create default settings
            Config = New IniData()
            Config("config")("export") = "False"
            Config("config")("clipboard") = "False"
            Config("config")("checkupdates") = "False"

            'Write default settings to file
            File.WriteAllText(SettingsFile, Config.ToString())
        Else
            'Load settings
            Form1.CopyToHashTxtCheckBox.Checked = SaveToFile()
            Form1.CopyToClipboardCheckBox.Checked = CopyToClipboard()
            Form1.UpdatesCheckBox.Checked = CheckForUpdates()
        End If
    End Sub

    Public Shared Sub Save()
        'Save settings

        'Get settings
        Config = New IniData()
        Config("config")("export") = Form1.CopyToHashTxtCheckBox.Checked
        Config("config")("clipboard") = Form1.CopyToClipboardCheckBox.Checked
        Config("config")("checkupdates") = Form1.UpdatesCheckBox.Checked

        'Write settings to file
        File.WriteAllText(SettingsFile, Config.ToString())
    End Sub

    Private Shared Function SaveToFile() As Boolean
        ConfigData = ConfigParser.ReadFile(SettingsFile)

        Dim Value As String = ConfigData("config")("export")
        If Value <> Nothing Then
            Return Boolean.Parse(Value)
        Else
            Return False
        End If
    End Function

    Private Shared Function CopyToClipboard() As Boolean
        ConfigData = ConfigParser.ReadFile(SettingsFile)

        Dim Value As String = ConfigData("config")("clipboard")
        If Value <> Nothing Then
            Return Boolean.Parse(Value)
        Else
            Return False
        End If
    End Function

    Private Shared Function CheckForUpdates() As Boolean
        ConfigData = ConfigParser.ReadFile(SettingsFile)

        Dim Value As String = ConfigData("config")("checkupdates")
        If Value <> Nothing Then
            Return Boolean.Parse(Value)
        Else
            Return False
        End If
    End Function
End Class
