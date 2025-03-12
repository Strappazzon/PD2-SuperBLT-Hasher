<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.DragDropHelpLabel = New MetroFramework.Controls.MetroLabel()
        Me.HashTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PathLabel = New MetroFramework.Controls.MetroLabel()
        Me.HashLabel = New MetroFramework.Controls.MetroLabel()
        Me.AboutLabel = New MetroFramework.Controls.MetroLabel()
        Me.ToolTips = New MetroFramework.Components.MetroToolTip()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DragDropPicture = New System.Windows.Forms.PictureBox()
        Me.DragDropPanel.SuspendLayout()
        CType(Me.DragDropPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PathTextBox
        '
        Me.PathTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PathTextBox.CustomBackground = True
        Me.PathTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PathTextBox.Location = New System.Drawing.Point(16, 90)
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
        Me.DragDropPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DragDropPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.DragDropPanel.Controls.Add(Me.DragDropPicture)
        Me.DragDropPanel.Controls.Add(Me.DragDropHelpLabel)
        Me.DragDropPanel.CustomBackground = True
        Me.DragDropPanel.HorizontalScrollbarBarColor = True
        Me.DragDropPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.DragDropPanel.HorizontalScrollbarSize = 10
        Me.DragDropPanel.Location = New System.Drawing.Point(16, 190)
        Me.DragDropPanel.Name = "DragDropPanel"
        Me.DragDropPanel.Size = New System.Drawing.Size(500, 150)
        Me.DragDropPanel.TabIndex = 7
        Me.DragDropPanel.TabStop = True
        Me.DragDropPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DragDropPanel.VerticalScrollbarBarColor = True
        Me.DragDropPanel.VerticalScrollbarHighlightOnWheel = False
        Me.DragDropPanel.VerticalScrollbarSize = 10
        '
        'DragDropHelpLabel
        '
        Me.DragDropHelpLabel.AutoSize = True
        Me.DragDropHelpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
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
        Me.HashTextBox.Location = New System.Drawing.Point(16, 150)
        Me.HashTextBox.Name = "HashTextBox"
        Me.HashTextBox.ReadOnly = True
        Me.HashTextBox.Size = New System.Drawing.Size(469, 25)
        Me.HashTextBox.TabIndex = 3
        Me.HashTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HashTextBox.UseStyleColors = True
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.CustomBackground = True
        Me.PathLabel.Location = New System.Drawing.Point(12, 65)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(34, 19)
        Me.PathLabel.TabIndex = 0
        Me.PathLabel.Text = "Path"
        Me.PathLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'HashLabel
        '
        Me.HashLabel.AutoSize = True
        Me.HashLabel.CustomBackground = True
        Me.HashLabel.Location = New System.Drawing.Point(12, 125)
        Me.HashLabel.Name = "HashLabel"
        Me.HashLabel.Size = New System.Drawing.Size(37, 19)
        Me.HashLabel.TabIndex = 2
        Me.HashLabel.Text = "Hash"
        Me.HashLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.CustomBackground = True
        Me.AboutLabel.FontSize = MetroFramework.MetroLabelSize.Small
        Me.AboutLabel.Location = New System.Drawing.Point(18, 362)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(34, 15)
        Me.AboutLabel.TabIndex = 10
        Me.AboutLabel.Text = "v2.1.0"
        Me.AboutLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ToolTips
        '
        Me.ToolTips.AutoPopDelay = 5000
        Me.ToolTips.InitialDelay = 200
        Me.ToolTips.ReshowDelay = 100
        Me.ToolTips.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CopyBtn
        '
        Me.CopyBtn.BackgroundImage = Global.SuperBLTHasher.My.Resources.Resources.Clipboard
        Me.CopyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CopyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CopyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.CopyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyBtn.Location = New System.Drawing.Point(491, 150)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(25, 25)
        Me.CopyBtn.TabIndex = 12
        Me.ToolTips.SetToolTip(Me.CopyBtn, "Copy hash to clipboard.")
        Me.CopyBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackgroundImage = Global.SuperBLTHasher.My.Resources.Resources.Update
        Me.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBtn.Location = New System.Drawing.Point(485, 355)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(26, 26)
        Me.UpdateBtn.TabIndex = 11
        Me.ToolTips.SetToolTip(Me.UpdateBtn, "Check for updates.")
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DragDropPicture
        '
        Me.DragDropPicture.Image = Global.SuperBLTHasher.My.Resources.Resources.Drop
        Me.DragDropPicture.Location = New System.Drawing.Point(218, 25)
        Me.DragDropPicture.Name = "DragDropPicture"
        Me.DragDropPicture.Size = New System.Drawing.Size(64, 64)
        Me.DragDropPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DragDropPicture.TabIndex = 3
        Me.DragDropPicture.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 395)
        Me.Controls.Add(Me.CopyBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.HashLabel)
        Me.Controls.Add(Me.PathLabel)
        Me.Controls.Add(Me.HashTextBox)
        Me.Controls.Add(Me.DragDropPanel)
        Me.Controls.Add(Me.PathTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Blue
        Me.Text = "SuperBLT Hasher"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
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
    Friend WithEvents AboutLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToolTips As MetroFramework.Components.MetroToolTip
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents CopyBtn As Button
End Class
