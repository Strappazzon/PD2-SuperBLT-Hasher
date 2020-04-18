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
Imports MatthiWare.CommandLine.Abstractions
Imports MatthiWare.CommandLine.Abstractions.Command
Imports MatthiWare.CommandLine.Abstractions.Usage

Public Class MessageBoxUsagePrinterDecorator
    Implements IUsagePrinter

    Private ReadOnly Printer As IUsagePrinter
    Private ReadOnly Text As String

    Public Sub New(printer As IUsagePrinter, text As String)
        If printer Is Nothing Then
            Throw New ArgumentNullException(NameOf(printer))
        End If

        Me.Printer = printer
        Me.Text = text
    End Sub

    Public Sub PrintUsage() Implements IUsagePrinter.PrintUsage
        'Use custom MessageBox instead of using underlying printer
        MessageBox.Show("Usage: " & Path.GetFileName(Application.ExecutablePath).Replace(".exe", "") & " [options]" & Environment.NewLine & Environment.NewLine &
                        "-p, --path         Path to folder or file you want to hash." & Environment.NewLine &
                        "-e, --export       Write computed hash to a text file." & Environment.NewLine &
                        "-c, --clipboard  Copy computed hash to the clipboard." & Environment.NewLine & Environment.NewLine &
                        "Please consult the Readme file for more information.",
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub PrintUsage(argument As IArgument) Implements IUsagePrinter.PrintUsage
        Printer.PrintUsage(argument)
    End Sub

    Public Sub PrintUsage(command As ICommandLineCommand) Implements IUsagePrinter.PrintUsage
        Printer.PrintUsage(command)
    End Sub

    Public Sub PrintUsage([option] As ICommandLineOption) Implements IUsagePrinter.PrintUsage
        Printer.PrintUsage([option])
    End Sub
End Class
