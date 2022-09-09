Imports System.Drawing.Printing

Public Class LightbrowseMain
    Dim MI As Bitmap
    ''LightbrowseToolStrip subroutines
    Private Sub AddTabButtonTS_Click_1(sender As Object, e As EventArgs) Handles AddTabButtonTS.Click
        Dim NPC As New LightbrowseControl With {.Dock = 5, .BackColor = Color.White}
        Dim NTP As New TabPage With {.Text = "New Tab"}
        NTP.Controls.Add(NPC)
        LightbrowseTabControl.TabPages.Add(NTP)
        LightbrowseTabControl.SelectedTab = NTP
        TabCountLabel.Text = "Tabs: " & LightbrowseTabControl.TabPages.Count.ToString()
        Text = "Lightbrowse (" & LightbrowseTabControl.TabPages.Count.ToString() & " Tabs)"
        RemoveTabButtonTS.Enabled = True
    End Sub
    Private Sub RemoveTabButtonTS_Click(sender As Object, e As EventArgs) Handles RemoveTabButtonTS.Click
        LightbrowseTabControl.TabPages.Remove(LightbrowseTabControl.SelectedTab)
        TabCountLabel.Text = "Tabs: " & LightbrowseTabControl.TabPages.Count.ToString()
        Text = "Lightbrowse (" & LightbrowseTabControl.TabPages.Count.ToString() & " Tabs)"
        If LightbrowseTabControl.TabPages.Count = 1 Then
            TabCountLabel.Text = "Tabs: 1"
            Text = "Lightbrowse (1 Tab)"
            RemoveTabButtonTS.Enabled = False
        End If
    End Sub
    Private Sub NewWindowButtonTS_Click(sender As Object, e As EventArgs) Handles NewWindowButtonTS.Click
        Dim NW As New LightbrowseMain
        NW.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(MI, 0, 0)
    End Sub
    Private Sub PrintButtonTS_Click(sender As Object, e As EventArgs) Handles PrintButtonTS.Click
        Dim MG As Graphics = CreateGraphics()
        Dim S As Size = Size
        MI = New Bitmap(S.Width, S.Height, MG)
        Dim MEMG As Graphics = Graphics.FromImage(MI)
        MEMG.CopyFromScreen(Location.X, Location.Y, 0, 0, S)
        PrintDocument1.Print()
    End Sub
End Class