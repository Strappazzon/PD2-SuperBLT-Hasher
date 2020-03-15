<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PathTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.DragDropPanel = New MetroFramework.Controls.MetroPanel()
        Me.DragDropPicture = New System.Windows.Forms.PictureBox()
        Me.DragDropHelpLabel = New MetroFramework.Controls.MetroLabel()
        Me.HashTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PathLabel = New MetroFramework.Controls.MetroLabel()
        Me.HashLabel = New MetroFramework.Controls.MetroLabel()
        Me.CopyToHashTxtCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.UpdatesCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.AboutLabel = New MetroFramework.Controls.MetroLabel()
        Me.CopyToClipboardCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.ToolTips = New MetroFramework.Components.MetroToolTip()
        Me.DragDropPanel.SuspendLayout()
        CType(Me.DragDropPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PathTextBox
        '
        Me.PathTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PathTextBox.CustomBackground = True
        Me.PathTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PathTextBox.Location = New System.Drawing.Point(16, 45)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.ReadOnly = True
        Me.PathTextBox.Size = New System.Drawing.Size(500, 25)
        Me.PathTextBox.TabIndex = 1
        Me.PathTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PathTextBox.UseStyleColors = True
        '
        'DragDropPanel
        '
        Me.DragDropPanel.AllowDrop = True
        Me.DragDropPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.DragDropPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.DragDropPanel.Controls.Add(Me.DragDropPicture)
        Me.DragDropPanel.Controls.Add(Me.DragDropHelpLabel)
        Me.DragDropPanel.CustomBackground = True
        Me.DragDropPanel.HorizontalScrollbarBarColor = True
        Me.DragDropPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.DragDropPanel.HorizontalScrollbarSize = 10
        Me.DragDropPanel.Location = New System.Drawing.Point(16, 145)
        Me.DragDropPanel.Name = "DragDropPanel"
        Me.DragDropPanel.Size = New System.Drawing.Size(500, 150)
        Me.DragDropPanel.TabIndex = 7
        Me.DragDropPanel.TabStop = True
        Me.DragDropPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DragDropPanel.VerticalScrollbarBarColor = True
        Me.DragDropPanel.VerticalScrollbarHighlightOnWheel = False
        Me.DragDropPanel.VerticalScrollbarSize = 10
        '
        'DragDropPicture
        '
        Me.DragDropPicture.Image = CType(resources.GetObject("DragDropPicture.Image"), System.Drawing.Image)
        Me.DragDropPicture.Location = New System.Drawing.Point(218, 25)
        Me.DragDropPicture.Name = "DragDropPicture"
        Me.DragDropPicture.Size = New System.Drawing.Size(64, 64)
        Me.DragDropPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DragDropPicture.TabIndex = 3
        Me.DragDropPicture.TabStop = False
        '
        'DragDropHelpLabel
        '
        Me.DragDropHelpLabel.AutoSize = True
        Me.DragDropHelpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.DragDropHelpLabel.CustomBackground = True
        Me.DragDropHelpLabel.Location = New System.Drawing.Point(166, 100)
        Me.DragDropHelpLabel.Name = "DragDropHelpLabel"
        Me.DragDropHelpLabel.Size = New System.Drawing.Size(167, 19)
        Me.DragDropHelpLabel.TabIndex = 8
        Me.DragDropHelpLabel.Text = "Drag a folder or a file here"
        Me.DragDropHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DragDropHelpLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'HashTextBox
        '
        Me.HashTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.HashTextBox.CustomBackground = True
        Me.HashTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.HashTextBox.Location = New System.Drawing.Point(16, 105)
        Me.HashTextBox.Name = "HashTextBox"
        Me.HashTextBox.ReadOnly = True
        Me.HashTextBox.Size = New System.Drawing.Size(500, 25)
        Me.HashTextBox.TabIndex = 3
        Me.HashTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HashTextBox.UseStyleColors = True
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PathLabel.CustomBackground = True
        Me.PathLabel.Location = New System.Drawing.Point(12, 20)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(34, 19)
        Me.PathLabel.TabIndex = 0
        Me.PathLabel.Text = "Path"
        Me.PathLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'HashLabel
        '
        Me.HashLabel.AutoSize = True
        Me.HashLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HashLabel.CustomBackground = True
        Me.HashLabel.Location = New System.Drawing.Point(12, 80)
        Me.HashLabel.Name = "HashLabel"
        Me.HashLabel.Size = New System.Drawing.Size(37, 19)
        Me.HashLabel.TabIndex = 2
        Me.HashLabel.Text = "Hash"
        Me.HashLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CopyToHashTxtCheckBox
        '
        Me.CopyToHashTxtCheckBox.AutoSize = True
        Me.CopyToHashTxtCheckBox.CustomBackground = True
        Me.CopyToHashTxtCheckBox.Location = New System.Drawing.Point(20, 310)
        Me.CopyToHashTxtCheckBox.Name = "CopyToHashTxtCheckBox"
        Me.CopyToHashTxtCheckBox.Size = New System.Drawing.Size(112, 15)
        Me.CopyToHashTxtCheckBox.TabIndex = 8
        Me.CopyToHashTxtCheckBox.Text = "Write hash to file"
        Me.CopyToHashTxtCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.CopyToHashTxtCheckBox, "Write the computed hash to a text file. You'll be asked where you want to save it" &
        ".")
        Me.CopyToHashTxtCheckBox.UseStyleColors = True
        Me.CopyToHashTxtCheckBox.UseVisualStyleBackColor = True
        '
        'UpdatesCheckBox
        '
        Me.UpdatesCheckBox.AutoSize = True
        Me.UpdatesCheckBox.CustomBackground = True
        Me.UpdatesCheckBox.Location = New System.Drawing.Point(20, 350)
        Me.UpdatesCheckBox.Name = "UpdatesCheckBox"
        Me.UpdatesCheckBox.Size = New System.Drawing.Size(119, 15)
        Me.UpdatesCheckBox.TabIndex = 9
        Me.UpdatesCheckBox.Text = "Check for updates"
        Me.UpdatesCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.UpdatesCheckBox, "Check if the current version is up to date next time you open SuperBLT Hasher.")
        Me.UpdatesCheckBox.UseStyleColors = True
        Me.UpdatesCheckBox.UseVisualStyleBackColor = True
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AboutLabel.CustomBackground = True
        Me.AboutLabel.FontSize = MetroFramework.MetroLabelSize.Small
        Me.AboutLabel.Location = New System.Drawing.Point(262, 305)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(256, 60)
        Me.AboutLabel.TabIndex = 10
        Me.AboutLabel.Text = "SuperBLT Hasher v1.0.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (c) 2020 Alberto Strappazzon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This software is " &
    "licensed under the MIT license" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Drop Shipping"" icon by Icons8 https://icons8.co" &
    "m"
        Me.AboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CopyToClipboardCheckBox
        '
        Me.CopyToClipboardCheckBox.AutoSize = True
        Me.CopyToClipboardCheckBox.CustomBackground = True
        Me.CopyToClipboardCheckBox.Location = New System.Drawing.Point(20, 330)
        Me.CopyToClipboardCheckBox.Name = "CopyToClipboardCheckBox"
        Me.CopyToClipboardCheckBox.Size = New System.Drawing.Size(146, 15)
        Me.CopyToClipboardCheckBox.TabIndex = 11
        Me.CopyToClipboardCheckBox.Text = "Copy hash to clipboard"
        Me.CopyToClipboardCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.CopyToClipboardCheckBox, "Copy the computed hash to the clipboard.")
        Me.CopyToClipboardCheckBox.UseStyleColors = True
        Me.CopyToClipboardCheckBox.UseVisualStyleBackColor = True
        '
        'ToolTips
        '
        Me.ToolTips.AutoPopDelay = 5000
        Me.ToolTips.InitialDelay = 200
        Me.ToolTips.ReshowDelay = 100
        Me.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 386)
        Me.Controls.Add(Me.CopyToClipboardCheckBox)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.UpdatesCheckBox)
        Me.Controls.Add(Me.CopyToHashTxtCheckBox)
        Me.Controls.Add(Me.HashLabel)
        Me.Controls.Add(Me.PathLabel)
        Me.Controls.Add(Me.HashTextBox)
        Me.Controls.Add(Me.DragDropPanel)
        Me.Controls.Add(Me.PathTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperBLT Hasher"
        Me.DragDropPanel.ResumeLayout(False)
        Me.DragDropPanel.PerformLayout()
        CType(Me.DragDropPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PathTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DragDropPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents DragDropHelpLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents DragDropPicture As PictureBox
    Friend WithEvents HashTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PathLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents HashLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CopyToHashTxtCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents UpdatesCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents AboutLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CopyToClipboardCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ToolTips As MetroFramework.Components.MetroToolTip
End Class
