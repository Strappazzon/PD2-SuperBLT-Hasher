Imports System.Runtime.InteropServices

Public Class Theme

    <DllImport("UXTheme.dll", EntryPoint:="#138", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function ShouldSystemUseDarkMode() As Boolean
    End Function

    Public Class Colors
        Public Shared ReadOnly Foreground As Color = If(ShouldSystemUseDarkMode(), Color.FromArgb(255, 153, 153, 153), Color.Black)
        Public Shared ReadOnly Background As Color = If(ShouldSystemUseDarkMode(), Color.FromArgb(255, 20, 20, 20), Color.FromArgb(255, 240, 240, 240))
    End Class

#Region "Methods"
    Public Shared Sub SetTheme()
        Form1.PathTextBox.BackColor = Colors.Background
        Form1.HashTextBox.BackColor = Colors.Background
        Form1.DragDropPanel.BackColor = Colors.Background
        Form1.DragDropHelpLabel.BackColor = Colors.Background

        If ShouldSystemUseDarkMode() Then
            Form1.Theme = MetroFramework.MetroThemeStyle.Dark

            Form1.PathLabel.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.PathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.HashLabel.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.HashTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.DragDropPanel.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.DragDropHelpLabel.Theme = MetroFramework.MetroThemeStyle.Dark
            Form1.AboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark

            Form1.CopyBtn.BackgroundImage = My.Resources.Clipboard
            Form1.DragDropPicture.BackgroundImage = My.Resources.Drop
            Form1.UpdateBtn.BackgroundImage = My.Resources.Update
        Else
            Form1.Theme = MetroFramework.MetroThemeStyle.Light

            Form1.PathLabel.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.PathTextBox.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.HashLabel.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.HashTextBox.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.DragDropPanel.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.DragDropHelpLabel.Theme = MetroFramework.MetroThemeStyle.Light
            Form1.AboutLabel.Theme = MetroFramework.MetroThemeStyle.Light

            Form1.CopyBtn.BackgroundImage = My.Resources.Clipboard_Dark
            Form1.DragDropPicture.BackgroundImage = My.Resources.Drop_Dark
            Form1.UpdateBtn.BackgroundImage = My.Resources.Update_Dark
        End If
    End Sub
#End Region
End Class
