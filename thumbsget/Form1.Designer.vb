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
        Me.flowlayoutpanelMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowlayoutpanelMainWindow
        '
        Me.flowlayoutpanelMainWindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutpanelMainWindow.BackColor = System.Drawing.SystemColors.Window
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.panelUrlAndButton)
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
        Me.panelUrlAndButton.Location = New System.Drawing.Point(3, 3)
        Me.panelUrlAndButton.Name = "panelUrlAndButton"
        Me.panelUrlAndButton.Size = New System.Drawing.Size(518, 197)
        Me.panelUrlAndButton.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowlayoutpanelMainWindow As FlowLayoutPanel
    Friend WithEvents panelUrlAndButton As Panel
End Class
