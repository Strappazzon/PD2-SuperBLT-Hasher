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

Imports MatthiWare.CommandLine

Public Class Parser

    'Parse command line arguments
    '//www.youtube.com/watch?v=mObWcaigMTU
    Public Shared Sub ParseArguments()
        Dim Parser = New CommandLineParser(Of Arguments)()
        'Decorate the printer so it can show the usages using a messagebox
        Parser.Printer = New MessageBoxUsagePrinterDecorator(Parser.Printer, Form1.Text)

        Dim Arguments = Parser.Parse(Environment.GetCommandLineArgs)
        If Not Arguments.HasErrors Then
            Form1.PathTextBox.Text = Arguments.Result.InputPath.Trim(""""c) 'Trim quotation marks
            Form1.CopyToHashTxtCheckBox.Checked = Arguments.Result.ExportHash
            Form1.CopyToClipboardCheckBox.Checked = Arguments.Result.ClipboardCopy
        End If
    End Sub
End Class
