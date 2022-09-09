Imports Microsoft.Web.WebView2.Core

Public Class LightbrowseControl
    ''Button subroutines
    Private Sub BackButtonTS_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Navi.GoBack()
    End Sub
    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        Navi.CoreWebView2.OpenDefaultDownloadDialog()
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        Navi.GoForward()
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Navi.CoreWebView2.Navigate("https://tecartabible.com/home")
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
    Private Sub SearchBingButton_Click(sender As Object, e As EventArgs) Handles SearchBingButton.Click
        Navi.CoreWebView2.Navigate("https://www.bing.com/search?q=" & SearchBox.Text)
    End Sub
    ''DeveloperOptionsDropdownButtonSS subroutines
    Private Sub DeveloperToosButtonSS_Click(sender As Object, e As EventArgs) Handles DeveloperToosButtonSS.Click
        Navi.CoreWebView2.OpenDevToolsWindow()
    End Sub
    Private Sub TaskManagerButtonSS_Click(sender As Object, e As EventArgs) Handles TaskManagerButtonSS.Click
        Navi.CoreWebView2.OpenTaskManagerWindow()
    End Sub
    ''Navi subroutines
    Private Sub Navi_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles Navi.NavigationStarting
        RefreshButton.SendToBack()
        StopButton.BringToFront()
    End Sub
    Private Sub Navi_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles Navi.NavigationCompleted
        DownloadButton.Enabled = True
        HomeButton.Enabled = True
        SearchBingButton.Enabled = True
        RefreshButton.BringToFront()
        StopButton.SendToBack()
        LightbrowseMain.LightbrowseTabControl.SelectedTab.Text = Navi.CoreWebView2.DocumentTitle.ToString()
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
        Dim URL As New Uri(SearchBox.Text)
        If URL.HostNameType = 2 Then
            ''NOTE: This will only work for websites *WITH* a favicon under Google's favicon service. Otherwise, an exception may be thrown. Be aware of that.
            Dim IconURL = "http://www.google.com/s2/favicons?domain=" & URL.Host
            Dim Request As Net.WebRequest = Net.WebRequest.Create(IconURL)
            Dim Response As Net.HttpWebResponse = Request.GetResponse()
            Dim Stream As IO.Stream = Response.GetResponseStream()
            Dim Favicon = Image.FromStream(Stream)
            FaviconBox.BackgroundImage = Favicon
        End If
    End Sub
    ''SearchBox subroutine
    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Navi.CoreWebView2.Navigate("https://" & SearchBox.Text)
        End If
    End Sub
End Class