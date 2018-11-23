<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformMainWindow
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
        Me.flowlayoutpanelMainWindow = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelUrlAndButton = New System.Windows.Forms.Panel()
        Me.buttonGetThumbnailInBrowser = New System.Windows.Forms.Button()
        Me.labelVideoUrl = New System.Windows.Forms.Label()
        Me.textboxVideoUrl = New System.Windows.Forms.TextBox()
        Me.linklabelAbout = New System.Windows.Forms.LinkLabel()
        Me.pictureboxPreview = New System.Windows.Forms.PictureBox()
        Me.buttonPreviewThumbnail = New System.Windows.Forms.Button()
        Me.buttonSaveThumbnail = New System.Windows.Forms.Button()
        Me.savefiledialogSaveThumbnail = New System.Windows.Forms.SaveFileDialog()
        Me.flowlayoutpanelMainWindow.SuspendLayout()
        Me.panelUrlAndButton.SuspendLayout()
        CType(Me.pictureboxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flowlayoutpanelMainWindow
        '
        Me.flowlayoutpanelMainWindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutpanelMainWindow.BackColor = System.Drawing.SystemColors.Window
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.panelUrlAndButton)
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.linklabelAbout)
        Me.flowlayoutpanelMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.flowlayoutpanelMainWindow.Name = "flowlayoutpanelMainWindow"
        Me.flowlayoutpanelMainWindow.Size = New System.Drawing.Size(525, 204)
        Me.flowlayoutpanelMainWindow.TabIndex = 0
        '
        'panelUrlAndButton
        '
        Me.panelUrlAndButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUrlAndButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelUrlAndButton.Controls.Add(Me.buttonSaveThumbnail)
        Me.panelUrlAndButton.Controls.Add(Me.buttonPreviewThumbnail)
        Me.panelUrlAndButton.Controls.Add(Me.pictureboxPreview)
        Me.panelUrlAndButton.Controls.Add(Me.buttonGetThumbnailInBrowser)
        Me.panelUrlAndButton.Controls.Add(Me.labelVideoUrl)
        Me.panelUrlAndButton.Controls.Add(Me.textboxVideoUrl)
        Me.panelUrlAndButton.Location = New System.Drawing.Point(3, 3)
        Me.panelUrlAndButton.Name = "panelUrlAndButton"
        Me.panelUrlAndButton.Size = New System.Drawing.Size(518, 178)
        Me.panelUrlAndButton.TabIndex = 0
        '
        'buttonGetThumbnailInBrowser
        '
        Me.buttonGetThumbnailInBrowser.Location = New System.Drawing.Point(8, 50)
        Me.buttonGetThumbnailInBrowser.Name = "buttonGetThumbnailInBrowser"
        Me.buttonGetThumbnailInBrowser.Size = New System.Drawing.Size(158, 29)
        Me.buttonGetThumbnailInBrowser.TabIndex = 2
        Me.buttonGetThumbnailInBrowser.Text = "View thumbnail in browser"
        Me.buttonGetThumbnailInBrowser.UseVisualStyleBackColor = True
        '
        'labelVideoUrl
        '
        Me.labelVideoUrl.AutoSize = True
        Me.labelVideoUrl.Location = New System.Drawing.Point(9, 4)
        Me.labelVideoUrl.Name = "labelVideoUrl"
        Me.labelVideoUrl.Size = New System.Drawing.Size(62, 13)
        Me.labelVideoUrl.TabIndex = 1
        Me.labelVideoUrl.Text = "Video URL:"
        '
        'textboxVideoUrl
        '
        Me.textboxVideoUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxVideoUrl.Location = New System.Drawing.Point(8, 23)
        Me.textboxVideoUrl.Name = "textboxVideoUrl"
        Me.textboxVideoUrl.Size = New System.Drawing.Size(501, 20)
        Me.textboxVideoUrl.TabIndex = 0
        '
        'linklabelAbout
        '
        Me.linklabelAbout.AutoSize = True
        Me.linklabelAbout.Location = New System.Drawing.Point(3, 184)
        Me.linklabelAbout.Name = "linklabelAbout"
        Me.linklabelAbout.Size = New System.Drawing.Size(35, 13)
        Me.linklabelAbout.TabIndex = 1
        Me.linklabelAbout.TabStop = True
        Me.linklabelAbout.Text = "About"
        '
        'pictureboxPreview
        '
        Me.pictureboxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxPreview.Location = New System.Drawing.Point(172, 50)
        Me.pictureboxPreview.Name = "pictureboxPreview"
        Me.pictureboxPreview.Size = New System.Drawing.Size(337, 123)
        Me.pictureboxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxPreview.TabIndex = 3
        Me.pictureboxPreview.TabStop = False
        '
        'buttonPreviewThumbnail
        '
        Me.buttonPreviewThumbnail.Location = New System.Drawing.Point(8, 85)
        Me.buttonPreviewThumbnail.Name = "buttonPreviewThumbnail"
        Me.buttonPreviewThumbnail.Size = New System.Drawing.Size(158, 29)
        Me.buttonPreviewThumbnail.TabIndex = 4
        Me.buttonPreviewThumbnail.Text = "Preview thumbnail"
        Me.buttonPreviewThumbnail.UseVisualStyleBackColor = True
        '
        'buttonSaveThumbnail
        '
        Me.buttonSaveThumbnail.Location = New System.Drawing.Point(8, 120)
        Me.buttonSaveThumbnail.Name = "buttonSaveThumbnail"
        Me.buttonSaveThumbnail.Size = New System.Drawing.Size(158, 29)
        Me.buttonSaveThumbnail.TabIndex = 5
        Me.buttonSaveThumbnail.Text = "Save thumbnail"
        Me.buttonSaveThumbnail.UseVisualStyleBackColor = True
        '
        'savefiledialogSaveThumbnail
        '
        Me.savefiledialogSaveThumbnail.Title = "Save thumbnail"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(525, 204)
        Me.Controls.Add(Me.flowlayoutpanelMainWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "aaformMainWindow"
        Me.Text = "thumbsget"
        Me.flowlayoutpanelMainWindow.ResumeLayout(False)
        Me.flowlayoutpanelMainWindow.PerformLayout()
        Me.panelUrlAndButton.ResumeLayout(False)
        Me.panelUrlAndButton.PerformLayout()
        CType(Me.pictureboxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowlayoutpanelMainWindow As FlowLayoutPanel
    Friend WithEvents panelUrlAndButton As Panel
    Friend WithEvents linklabelAbout As LinkLabel
    Friend WithEvents textboxVideoUrl As TextBox
    Friend WithEvents labelVideoUrl As Label
    Friend WithEvents buttonGetThumbnailInBrowser As Button
    Friend WithEvents pictureboxPreview As PictureBox
    Friend WithEvents buttonPreviewThumbnail As Button
    Friend WithEvents buttonSaveThumbnail As Button
    Friend WithEvents savefiledialogSaveThumbnail As SaveFileDialog
End Class
