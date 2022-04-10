<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.BingButton = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Navi = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(23, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "🡠"
        Me.ToolTip1.SetToolTip(Me.BackButton, "Go back")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ForwardButton.Location = New System.Drawing.Point(32, 3)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(23, 23)
        Me.ForwardButton.TabIndex = 1
        Me.ForwardButton.Text = "🡢"
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Go forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshButton.Location = New System.Drawing.Point(61, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 23)
        Me.RefreshButton.TabIndex = 2
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
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "⨉"
        Me.ToolTip1.SetToolTip(Me.StopButton, "Stop")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'BingButton
        '
        Me.BingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BingButton.Location = New System.Drawing.Point(567, 3)
        Me.BingButton.Name = "BingButton"
        Me.BingButton.Size = New System.Drawing.Size(53, 23)
        Me.BingButton.TabIndex = 4
        Me.BingButton.Text = "Bing"
        Me.ToolTip1.SetToolTip(Me.BingButton, "Search Bing")
        Me.BingButton.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SearchBox.Location = New System.Drawing.Point(111, 5)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(450, 22)
        Me.SearchBox.TabIndex = 5
        Me.SearchBox.Text = "Welcome! What would you like to search for today?"
        Me.SearchBox.WordWrap = False
        '
        'Navi
        '
        Me.Navi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Navi.CreationProperties = Nothing
        Me.Navi.DefaultBackgroundColor = System.Drawing.Color.White
        Me.Navi.Location = New System.Drawing.Point(0, 32)
        Me.Navi.Name = "Navi"
        Me.Navi.Size = New System.Drawing.Size(623, 313)
        Me.Navi.Source = New System.Uri("https://tecartabible.com/home", System.UriKind.Absolute)
        Me.Navi.TabIndex = 6
        Me.Navi.ZoomFactor = 1.0R
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Lightbrowse.My.Resources.Resources.Lightbrowse_Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(90, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Navi)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.BingButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.StopButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(623, 345)
        CType(Me.Navi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents BingButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Navi As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
End Class
