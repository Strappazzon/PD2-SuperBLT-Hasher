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

Public Class Form1

#Region "Draw Events"
    Private Sub ToolTips_Draw(sender As Object, e As DrawToolTipEventArgs) Handles ToolTips.Draw
        'Draw tooltip with custom colors
        ToolTips.OwnerDraw = True
        ToolTips.ForeColor = Color.FromArgb(255, 153, 153, 153)
        ToolTips.BackColor = Color.FromArgb(255, 17, 17, 17)

        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub
#End Region

#Region "Form events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings
        Settings.Init()

        'Check for updates
        Updater.CheckUpdates()

        'Parse command line arguments
        If Environment.GetCommandLineArgs.Length > 1 Then
            Parser.ParseArguments()
        End If

        'Hash the input from command line argument
        If PathTextBox.Text <> "" Then
            HashTextBox.Text = "Computing..."
            Hash.HashInput(PathTextBox.Text)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Save settings
        Settings.Save()
    End Sub
#End Region

#Region "Controls"
    Private Sub DragDropPanel_DragEnter(sender As Object, e As DragEventArgs) Handles DragDropPanel.DragEnter
        'Accept only files and folders
        '//stackoverflow.com/a/11686880
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub DragDropPanel_DragDrop(sender As Object, e As DragEventArgs) Handles DragDropPanel.DragDrop
        Dim DroppedItems As String() = e.Data.GetData(DataFormats.FileDrop)

        'Allow only one folder or file
        If DroppedItems.Length <= 1 Then
            'Write the folder or file path
            PathTextBox.Text = DroppedItems.First

            'Hash the input
            HashTextBox.Text = "Computing..."
            Hash.HashInput(PathTextBox.Text)
        Else
            MessageBox.Show("Please drop one folder or file at a time.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region
End Class
