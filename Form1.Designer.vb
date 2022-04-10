<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Navi = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.BingButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewTabButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveTabButton = New System.Windows.Forms.ToolStripButton()
        Me.NewWindowButton = New System.Windows.Forms.ToolStripButton()
        Me.DateTimeLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 420)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Navi)
        Me.TabPage2.Controls.Add(Me.SearchBox)
        Me.TabPage2.Controls.Add(Me.BingButton)
        Me.TabPage2.Controls.Add(Me.ForwardButton)
        Me.TabPage2.Controls.Add(Me.BackButton)
        Me.TabPage2.Controls.Add(Me.RefreshButton)
        Me.TabPage2.Controls.Add(Me.StopButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(791, 394)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "⭐ First page"
        '
        'Navi
        '
        Me.Navi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navi.CreationProperties = Nothing
        Me.Navi.DefaultBackgroundColor = System.Drawing.Color.White
        Me.Navi.Location = New System.Drawing.Point(-3, 30)
        Me.Navi.Name = "Navi"
        Me.Navi.Size = New System.Drawing.Size(797, 367)
        Me.Navi.Source = New System.Uri("https://tecartabible.com/home", System.UriKind.Absolute)
        Me.Navi.TabIndex = 13
        Me.Navi.ZoomFactor = 1.0R
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SearchBox.Location = New System.Drawing.Point(111, 5)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(617, 22)
        Me.SearchBox.TabIndex = 12
        Me.SearchBox.Text = "Welcome! What would you like to search for today?"
        Me.SearchBox.WordWrap = False
        '
        'BingButton
        '
        Me.BingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BingButton.Location = New System.Drawing.Point(734, 3)
        Me.BingButton.Name = "BingButton"
        Me.BingButton.Size = New System.Drawing.Size(53, 23)
        Me.BingButton.TabIndex = 11
        Me.BingButton.Text = "Bing"
        Me.ToolTip1.SetToolTip(Me.BingButton, "Search Bing")
        Me.BingButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ForwardButton.Location = New System.Drawing.Point(32, 3)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(23, 23)
        Me.ForwardButton.TabIndex = 8
        Me.ForwardButton.Text = "🡢"
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Go forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(23, 23)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "🡠"
        Me.ToolTip1.SetToolTip(Me.BackButton, "Go back")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshButton.Location = New System.Drawing.Point(61, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 23)
        Me.RefreshButton.TabIndex = 9
        Me.RefreshButton.Text = "⭯"
        Me.ToolTip1.SetToolTip(Me.RefreshButton, "Reload")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StopButton.Location = New System.Drawing.Point(61, 3)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(23, 23)
        Me.StopButton.TabIndex = 10
        Me.StopButton.Text = "⨉"
        Me.ToolTip1.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabButton, Me.RemoveTabButton, Me.NewWindowButton, Me.DateTimeLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewTabButton
        '
        Me.NewTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewTabButton.Image = CType(resources.GetObject("NewTabButton.Image"), System.Drawing.Image)
        Me.NewTabButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewTabButton.Name = "NewTabButton"
        Me.NewTabButton.Size = New System.Drawing.Size(44, 22)
        Me.NewTabButton.Text = "+ Add"
        Me.NewTabButton.ToolTipText = "Add a new tab"
        '
        'RemoveTabButton
        '
        Me.RemoveTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RemoveTabButton.Image = CType(resources.GetObject("RemoveTabButton.Image"), System.Drawing.Image)
        Me.RemoveTabButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveTabButton.Name = "RemoveTabButton"
        Me.RemoveTabButton.Size = New System.Drawing.Size(62, 22)
        Me.RemoveTabButton.Text = "- Remove"
        Me.RemoveTabButton.ToolTipText = "Remove the current tab"
        '
        'NewWindowButton
        '
        Me.NewWindowButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NewWindowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewWindowButton.Image = CType(resources.GetObject("NewWindowButton.Image"), System.Drawing.Image)
        Me.NewWindowButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWindowButton.Name = "NewWindowButton"
        Me.NewWindowButton.Size = New System.Drawing.Size(89, 22)
        Me.NewWindowButton.Text = "New window..."
        Me.NewWindowButton.ToolTipText = "New window"
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DateTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(182, 22)
        Me.DateTimeLabel.Text = "Saturday, December 25, 12:00 PM"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Lightbrowse.My.Resources.Resources.Lightbrowse_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(90, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Lightbrowse Browser"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewTabButton As ToolStripButton
    Friend WithEvents RemoveTabButton As ToolStripButton
    Friend WithEvents NewWindowButton As ToolStripButton
    Friend WithEvents DateTimeLabel As ToolStripLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Navi As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents BingButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ForwardButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
