Imports System.IO
Imports MatthiWare.CommandLine.Abstractions
Imports MatthiWare.CommandLine.Abstractions.Command
Imports MatthiWare.CommandLine.Abstractions.Usage

Public Class MessageBoxUsagePrinterDecorator
    Implements IUsagePrinter

    Private ReadOnly printer As IUsagePrinter
    Private ReadOnly text As String

    Public Sub New(printer As IUsagePrinter, text As String)
        If printer Is Nothing Then
            Throw New ArgumentNullException(printer.ToString())
        End If

        Me.printer = printer
        Me.text = text
    End Sub

    Public Sub PrintUsage() Implements IUsagePrinter.PrintUsage
        '' Use custom messagebox instead of using underlying printer
        MessageBox.Show("Usage: " & Path.GetFileName(Application.ExecutablePath).Replace(".exe", "") & " [options]" & Environment.NewLine & Environment.NewLine &
                            "-p, --path         Path to folder or file you want to hash." & Environment.NewLine &
                            "-e, --export       Write computed hash to a text file." & Environment.NewLine &
                            "-c, --clipboard  Copy computed hash to the clipboard." & Environment.NewLine & Environment.NewLine &
                            "Please consult the Readme file for more information.",
                            text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub PrintUsage(argument As IArgument) Implements IUsagePrinter.PrintUsage
        printer.PrintUsage(argument)
    End Sub

    Public Sub PrintUsage(command As ICommandLineCommand) Implements IUsagePrinter.PrintUsage
        printer.PrintUsage(command)
    End Sub

    Public Sub PrintUsage([option] As ICommandLineOption) Implements IUsagePrinter.PrintUsage
        printer.PrintUsage([option])
    End Sub
End Class
