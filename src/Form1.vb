Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports MatthiWare.CommandLine
Imports ZNix.SuperBLT

Public Class Form1
    Private Const VersionCode As Short = 3
    Private WithEvents HashInput As New BackgroundWorker()

    Private Sub ParseCmdArgs()
        'Parse command line arguments
        '//www.youtube.com/watch?v=mObWcaigMTU
        Dim Parser = New CommandLineParser(Of Arguments)()

        'Decorate the printer so it can show the usages using a messagebox
        Parser.Printer = New MessageBoxUsagePrinterDecorator(Parser.Printer, Text)

        Dim CmdArguments = Parser.Parse(Environment.GetCommandLineArgs)

        If Not CmdArguments.HasErrors Then
            PathTextBox.Text = (CmdArguments.Result.InputPath).Trim(""""c) 'Trim quotation marks
            CopyToHashTxtCheckBox.Checked = CmdArguments.Result.ExportHash
            CopyToClipboardCheckBox.Checked = CmdArguments.Result.ClipboardCopy
        End If
    End Sub

    Private Sub UpgradeSettings()
        'Migrate settings to the new version
        'Unfortunately, settings migrate only if the new version is installed in the same directory as the old version
        '//bytes.com/topic/visual-basic-net/answers/854235-my-settings-upgrade-doesnt-upgrade#post3426232
        If My.Settings.MustUpgrade = True Then
            My.Settings.Upgrade()
            My.Settings.MustUpgrade = False
        End If
    End Sub

    Private Sub HashInput_DoWork(sender As Object, e As DoWorkEventArgs) Handles HashInput.DoWork
        Try
            'Check whether the specified/dropped path is a folder or a file
            '//stackoverflow.com/a/439478
            Dim IsDir As Boolean = (File.GetAttributes(PathTextBox.Text) And FileAttributes.Directory) = FileAttributes.Directory

            If IsDir = True Then
                'Hash the selected folder
                Dim Hash As String = Hasher.HashDirectory(PathTextBox.Text)
                e.Result = Hash
            Else
                'Hash the selected file
                Dim Hash As String = Hasher.HashFile(PathTextBox.Text)
                e.Result = Hash
            End If
        Catch ex As Exception
            e.Result = "Error"
            MessageBox.Show("An error occurred while attempting to compute the hash: " & ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HashInput_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles HashInput.RunWorkerCompleted
        'Write the computed hash
        HashTextBox.Text = e.Result()

        'Write the hash to a text file
        If e.Result <> "Error" AndAlso CopyToHashTxtCheckBox.Checked = True Then
            Using S As New SaveFileDialog
                S.Title = "Save hash as..."
                S.InitialDirectory = PathTextBox.Text
                S.FileName = "hash"
                S.Filter = "Text file|.txt"
                If S.ShowDialog = DialogResult.OK Then
                    File.AppendAllText(S.FileName, e.Result())
                End If
            End Using
        End If

        'Copy the hash to clipboard
        If e.Result <> "Error" AndAlso CopyToClipboardCheckBox.Checked = True Then
            Clipboard.SetText(e.Result())
        End If
    End Sub

    Private Sub Updater_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        If e.Error Is Nothing Then
            Dim FetchedVer As Short = e.Result()

            'Compare downloaded SuperBLT Hasher version number with the current one
            If FetchedVer > VersionCode Then
                Dim result = MessageBox.Show("A newer version of SuperBLT Hasher is available. Do you want to visit the download page now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.Yes Then
                    Process.Start("https://github.com/Strappazzon/PD2-SuperBLT-Hasher/releases/latest")
                End If
            End If
        End If
    End Sub

    Private Sub ToolTips_Draw(sender As Object, e As DrawToolTipEventArgs) Handles ToolTips.Draw
        'Draw tooltip with custom colors
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings
        CopyToHashTxtCheckBox.Checked = My.Settings.WriteHashToFile
        CopyToClipboardCheckBox.Checked = My.Settings.CopyHashToClipboard
        UpdatesCheckBox.Checked = My.Settings.CheckUpdates

        'Parse command line arguments
        'Only if the user starts SuperBLT Hasher via the command line
        If (Environment.GetCommandLineArgs).Length > 1 Then
            ParseCmdArgs()
        End If

        'Check for updates
        If UpdatesCheckBox.Checked = True Then
            Using Updater As New WebClient
                Updater.Headers.Add("User-Agent", "SuperBLT Hasher (+https://strappazzon.xyz/PD2-SuperBLT-Hasher)")
                Dim VersionURI As New Uri("https://raw.githubusercontent.com/Strappazzon/PD2-SuperBLT-Hasher/master/version")
                Updater.DownloadStringAsync(VersionURI)
                'Call updater_DownloadStringCompleted when the download completes
                AddHandler Updater.DownloadStringCompleted, AddressOf Updater_DownloadStringCompleted
            End Using
        End If

        'Customize tooltips
        ToolTips.OwnerDraw = True
        ToolTips.ForeColor = Color.FromArgb(255, 153, 153, 153)
        ToolTips.BackColor = Color.FromArgb(255, 17, 17, 17)

        'Hash the input from command line argument
        If PathTextBox.Text <> "" Then
            HashTextBox.Text = "Computing..."
            HashInput.RunWorkerAsync()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Save settings
        My.Settings.WriteHashToFile = CopyToHashTxtCheckBox.CheckState
        My.Settings.CopyHashToClipboard = CopyToClipboardCheckBox.CheckState
        My.Settings.CheckUpdates = UpdatesCheckBox.CheckState
    End Sub

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
            HashInput.RunWorkerAsync()
        Else
            MessageBox.Show("Please drop one folder or file at a time.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
