Imports Microsoft.Web.WebView2
Imports Microsoft.Web.WebView2.Core

Public Class UserControl1
    'Button events
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Navi.GoBack()
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        Navi.GoForward()
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Navi.Reload()
        RefreshButton.SendToBack()
        StopButton.BringToFront()
    End Sub
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Navi.Stop()
        RefreshButton.BringToFront()
        StopButton.SendToBack()
    End Sub
    Private Sub BingButton_Click(sender As Object, e As EventArgs) Handles BingButton.Click
        Navi.CoreWebView2.Navigate("https://www.bing.com/search?q=" & SearchBox.Text)
    End Sub
    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Navi.CoreWebView2.Navigate("https://www." & SearchBox.Text)
        End If
    End Sub
    'Navi events
    Private Sub Navi_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles Navi.NavigationStarting
        RefreshButton.SendToBack()
        StopButton.BringToFront()
    End Sub
    Private Sub Navi_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles Navi.NavigationCompleted
        RefreshButton.BringToFront()
        StopButton.SendToBack()
        Form1.TabControl1.SelectedTab.Text = Navi.CoreWebView2.DocumentTitle.ToString()
        SearchBox.Text = Navi.CoreWebView2.Source.ToString()
        If Navi.CanGoForward = True Then
            ForwardButton.Enabled = True
        Else
            ForwardButton.Enabled = False
        End If
        If Navi.CanGoBack = True Then
            BackButton.Enabled = True
        Else
            BackButton.Enabled = False
        End If
        Dim url As Uri = New Uri(SearchBox.Text)
        If url.HostNameType = UriHostNameType.Dns Then
            ' NOTE: This will only work for websites *WITH* a favicon under Google's favicon service. Otherwise, an exception may be thrown. Be aware of that.
            Dim iconURL = "http://www.google.com/s2/favicons?domain=" & url.Host
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim stream As System.IO.Stream = response.GetResponseStream()
            Dim favicon = Image.FromStream(stream)
            PictureBox1.BackgroundImage = favicon
        End If
    End Sub
End Class