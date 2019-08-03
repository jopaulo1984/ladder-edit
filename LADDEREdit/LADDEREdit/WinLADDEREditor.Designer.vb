<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinLADDEREdit
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinLADDEREdit))
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 401)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(721, 22)
    Me.StatusStrip1.TabIndex = 0
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(721, 25)
    Me.ToolStrip1.TabIndex = 2
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'TabControl1
    '
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(721, 352)
    Me.TabControl1.TabIndex = 3
    '
    'NewToolStripButton
    '
    Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
    Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.NewToolStripButton.Name = "NewToolStripButton"
    Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.NewToolStripButton.Text = "&New"
    '
    'OpenToolStripButton
    '
    Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
    Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.OpenToolStripButton.Name = "OpenToolStripButton"
    Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.OpenToolStripButton.Text = "&Open"
    '
    'SaveToolStripButton
    '
    Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
    Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.SaveToolStripButton.Name = "SaveToolStripButton"
    Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.SaveToolStripButton.Text = "&Save"
    '
    'PrintToolStripButton
    '
    Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
    Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.PrintToolStripButton.Name = "PrintToolStripButton"
    Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.PrintToolStripButton.Text = "&Print"
    '
    'toolStripSeparator
    '
    Me.toolStripSeparator.Name = "toolStripSeparator"
    Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
    '
    'CutToolStripButton
    '
    Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
    Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.CutToolStripButton.Name = "CutToolStripButton"
    Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.CutToolStripButton.Text = "C&ut"
    '
    'CopyToolStripButton
    '
    Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
    Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.CopyToolStripButton.Name = "CopyToolStripButton"
    Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.CopyToolStripButton.Text = "&Copy"
    '
    'PasteToolStripButton
    '
    Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
    Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.PasteToolStripButton.Name = "PasteToolStripButton"
    Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.PasteToolStripButton.Text = "&Paste"
    '
    'toolStripSeparator1
    '
    Me.toolStripSeparator1.Name = "toolStripSeparator1"
    Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'HelpToolStripButton
    '
    Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
    Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.HelpToolStripButton.Name = "HelpToolStripButton"
    Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.HelpToolStripButton.Text = "He&lp"
    '
    'WinLADDEREdit
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(721, 423)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "WinLADDEREdit"
    Me.Text = "LADDER Editor"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton

End Class
