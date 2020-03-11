Imports MatthiWare.CommandLine.Core.Attributes

Public Class Arguments
    <Required, Name("p", "path"), Description("Path to folder or file you want to hash.")>
    Public Property InputPath As String

    <DefaultValue(False), Name("e", "export"), Description("Write computed hash to a text file.")>
    Public Property ExportHash As Boolean

    <DefaultValue(False), Name("c", "clipboard"), Description("Copy computed hash to the clipboard.")>
    Public Property ClipboardCopy As Boolean
End Class
