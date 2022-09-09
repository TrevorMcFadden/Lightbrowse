<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LightbrowseControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightbrowseControl))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.SearchBingButton = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Navi = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.FaviconBox = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.LightbrowseToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LightbrowseStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.DeveloperOptionsDropdownButtonSS = New System.Windows.Forms.ToolStripSplitButton()
        Me.DeveloperToosButtonSS = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerButtonSS = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaviconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LightbrowseStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Enabled = False
        Me.BackButton.Location = New System.Drawing.Point(3, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "🡠"
        Me.LightbrowseToolTip.SetToolTip(Me.BackButton, "Go backward")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.Enabled = False
        Me.ForwardButton.Location = New System.Drawing.Point(49, 5)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(40, 23)
        Me.ForwardButton.TabIndex = 1
        Me.ForwardButton.Text = "🡢"
        Me.LightbrowseToolTip.SetToolTip(Me.ForwardButton, "Go forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(95, 5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(40, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "⭯"
        Me.LightbrowseToolTip.SetToolTip(Me.RefreshButton, "Refresh")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(95, 5)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(40, 23)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "⨉"
        Me.LightbrowseToolTip.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SearchBingButton
        '
        Me.SearchBingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBingButton.Enabled = False
        Me.SearchBingButton.Location = New System.Drawing.Point(638, 5)
        Me.SearchBingButton.Name = "SearchBingButton"
        Me.SearchBingButton.Size = New System.Drawing.Size(40, 23)
        Me.SearchBingButton.TabIndex = 6
        Me.SearchBingButton.Text = "🔭"
        Me.LightbrowseToolTip.SetToolTip(Me.SearchBingButton, "Search Bing")
        Me.SearchBingButton.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.ForeColor = System.Drawing.Color.Gray
        Me.SearchBox.Location = New System.Drawing.Point(141, 6)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(445, 23)
        Me.SearchBox.TabIndex = 4
        Me.SearchBox.Text = "Search or enter a URL"
        Me.SearchBox.WordWrap = False
        '
        'Navi
        '
        Me.Navi.AllowExternalDrop = True
        Me.Navi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navi.CreationProperties = Nothing
        Me.Navi.DefaultBackgroundColor = System.Drawing.Color.White
        Me.Navi.Location = New System.Drawing.Point(0, 35)
        Me.Navi.Name = "Navi"
        Me.Navi.Size = New System.Drawing.Size(727, 324)
        Me.Navi.Source = New System.Uri("https://tecartabible.com/home", System.UriKind.Absolute)
        Me.Navi.TabIndex = 8
        Me.Navi.ZoomFactor = 1.0R
        '
        'FaviconBox
        '
        Me.FaviconBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaviconBox.BackgroundImage = Global.Lightbrowse.My.Resources.Resources.Lightbrowse_Logo
        Me.FaviconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FaviconBox.Location = New System.Drawing.Point(565, 9)
        Me.FaviconBox.Name = "FaviconBox"
        Me.FaviconBox.Size = New System.Drawing.Size(15, 15)
        Me.FaviconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FaviconBox.TabIndex = 8
        Me.FaviconBox.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeButton.Enabled = False
        Me.HomeButton.Location = New System.Drawing.Point(592, 5)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(40, 23)
        Me.HomeButton.TabIndex = 5
        Me.HomeButton.Text = "⌂"
        Me.LightbrowseToolTip.SetToolTip(Me.HomeButton, "Go home (Tecarta)")
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadButton.Enabled = False
        Me.DownloadButton.Location = New System.Drawing.Point(684, 5)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(40, 23)
        Me.DownloadButton.TabIndex = 7
        Me.DownloadButton.Text = "🡣"
        Me.LightbrowseToolTip.SetToolTip(Me.DownloadButton, "See downloads")
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'LightbrowseStatusStrip
        '
        Me.LightbrowseStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperOptionsDropdownButtonSS})
        Me.LightbrowseStatusStrip.Location = New System.Drawing.Point(0, 360)
        Me.LightbrowseStatusStrip.Name = "LightbrowseStatusStrip"
        Me.LightbrowseStatusStrip.Size = New System.Drawing.Size(727, 22)
        Me.LightbrowseStatusStrip.SizingGrip = False
        Me.LightbrowseStatusStrip.TabIndex = 10
        Me.LightbrowseStatusStrip.Text = "StatusStrip1"
        '
        'DeveloperOptionsDropdownButtonSS
        '
        Me.DeveloperOptionsDropdownButtonSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeveloperOptionsDropdownButtonSS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperToosButtonSS, Me.TaskManagerButtonSS})
        Me.DeveloperOptionsDropdownButtonSS.Image = CType(resources.GetObject("DeveloperOptionsDropdownButtonSS.Image"), System.Drawing.Image)
        Me.DeveloperOptionsDropdownButtonSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeveloperOptionsDropdownButtonSS.Name = "DeveloperOptionsDropdownButtonSS"
        Me.DeveloperOptionsDropdownButtonSS.Size = New System.Drawing.Size(136, 20)
        Me.DeveloperOptionsDropdownButtonSS.Text = "⛭ Developer Options"
        '
        'DeveloperToosButtonSS
        '
        Me.DeveloperToosButtonSS.Name = "DeveloperToosButtonSS"
        Me.DeveloperToosButtonSS.Size = New System.Drawing.Size(187, 22)
        Me.DeveloperToosButtonSS.Text = "Open developer tools"
        '
        'TaskManagerButtonSS
        '
        Me.TaskManagerButtonSS.Name = "TaskManagerButtonSS"
        Me.TaskManagerButtonSS.Size = New System.Drawing.Size(187, 22)
        Me.TaskManagerButtonSS.Text = "Open task manager"
        '
        'LightbrowseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LightbrowseStatusStrip)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.FaviconBox)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.SearchBingButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Navi)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.StopButton)
        Me.Name = "LightbrowseControl"
        Me.Size = New System.Drawing.Size(727, 382)
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaviconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LightbrowseStatusStrip.ResumeLayout(False)
        Me.LightbrowseStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents SearchBingButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Navi As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents FaviconBox As PictureBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents DownloadButton As Button
    Friend WithEvents LightbrowseToolTip As ToolTip
    Friend WithEvents LightbrowseStatusStrip As StatusStrip
    Friend WithEvents DeveloperOptionsDropdownButtonSS As ToolStripSplitButton
    Friend WithEvents DeveloperToosButtonSS As ToolStripMenuItem
    Friend WithEvents TaskManagerButtonSS As ToolStripMenuItem
End Class
