Public Class WinLADDEREdit

  Sub NewLDEditTab(ByVal title As String)
    Dim tab As New TabPage With {
      .Text = title
      }
    Dim ld As New LDEditorGUI
    tab.Controls.Add(ld)
    ld.Dock = DockStyle.Fill
    TabControl1.TabPages.Add(tab)
  End Sub

  Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
    NewLDEditTab("Novo Diagrama")
  End Sub
End Class
